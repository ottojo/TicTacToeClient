using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Concurrent;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        int port = 12345;   //Port des Servers
        const int localPort = 12346;
        Socket socket;
        EndPoint remoteEP;
        IPAddress myIp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setButtonsEnabled(false);
            
        }

        /// <summary>
        /// Funktion zum Verarbeiten einer Server-Anfrage
        /// </summary>
        /// <param name="message">Nachricht des Servers</param>
        private void handleMessage(string message)
        {
            NonBlockingConsole.WriteLine("Starting Handling");
            switch (message.Substring(0, 1))
            {
                case "c":
                    int x = int.Parse(message.Substring(1, 1));
                    int y = int.Parse(message.Substring(2, 1));
                    Button currentField = field(x, y);
                    this.Invoke((MethodInvoker)delegate
                    {
                        currentField.Text = message.Substring(3, 1);
                    });
                    break;
                case "p":
                    setButtonsEnabled(true);
                    this.Invoke((MethodInvoker)delegate
                    {
                        toolStripStatusLabel.Text = "Bereit";
                    });
                    break;
                case "e":
                    setButtonsEnabled(false);
                    this.Invoke((MethodInvoker)delegate
                    {
                        toolStripStatusLabel.Text = "Spiel beendet";
                    });
                    endGame(message.Substring(1, 1));
                    break;
                default:
                    this.Invoke((MethodInvoker)delegate
                    {
                        toolStripStatusLabel.Text = "Kommunikationsfehler";
                    });
                    break;
            }
            NonBlockingConsole.WriteLine("Finished Handling");
        }

        private void endGame(string status)
        {
            String message = "";
            switch (status)
            {
                case "0":
                    message = "Verloren!";
                    break;
                case "1":
                    message = "Gewonnen!";
                    break;
                case "2":
                    message = "Gleichstand";
                    break;
            }


            DialogResult result = MessageBox.Show(message, "Spiel zu Ende!", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Retry)
            {
                setButtonsText("");
                setButtonsEnabled(false);
                toolStripStatusLabel.Text = "Nicht verbunden";
                NonBlockingConsole.WriteLine("Executing buttonVerbinden_Click");
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                buttonVerbinden_Click(null, null);
            }
        }

        private void buttonVerbinden_Click(object sender, EventArgs e)
        {
            initSocket(ref socket);
            if (myIp == null)
            {
                using (var form = new IpChooserDialog(getLocalIPs()))
                {
                    var result = form.ShowDialog();
                    myIp = form.chosenAddress;
                    port = int.Parse(textBoxPort.Text.ToString());
                    IPEndPoint epLocal = new IPEndPoint(myIp, localPort);
                    socket.Bind(epLocal);
                }
            }
            try
            {

                string remoteIp = textBoxIp.Text.ToString();
                IPAddress ipAddressremote = IPAddress.Parse(remoteIp);
                remoteEP = new IPEndPoint(ipAddressremote, port);
                socket.Connect(remoteEP);
                NonBlockingConsole.WriteLine("Connected to remote EP " + remoteEP.ToString());
                byte[] buffer = new byte[1024];
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(MessageCallBack), buffer);
                SendPlayerName(textBoxName.Text.ToString(), ref socket);
                buttonVerbinden.Enabled = false;
                toolStripStatusLabel.Text = "Warten";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nVerbindung fehlgeschlagen.");
                this.Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabel.Text = "Fehler";
                });
            }
        }

        /// <summary>
        /// Initialisiert einen UDP Socket
        /// </summary>
        /// <param name="s">Referenz zum zu initialisierenden Socket</param>
        private void initSocket(ref Socket s)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            NonBlockingConsole.WriteLine("[NET]Socket initialisiert");
            s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            NonBlockingConsole.WriteLine("[NET]Socket Optionen gesetzt");
        }

        /// <summary>
        /// Erkennt lokale IP Adressen und filtert sie nach IPv4
        /// </summary>
        /// <returns>Liste aller verfügbaren lokalen IPv4 Adressen</returns>
        private List<IPAddress> getLocalIPs()
        {
            List<IPAddress> result = new List<IPAddress>();
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress a in localIPs)
            {
                if (a.AddressFamily == AddressFamily.InterNetwork)
                    result.Add(a);
            }
            return result;
        }

        private void MessageCallBack(IAsyncResult iAsyncResult)
        {
            try {
                NonBlockingConsole.WriteLine("Got something");
                int size = socket.EndReceive(iAsyncResult);
                if (size > 0)
                {
                    byte[] receivedData = (byte[])iAsyncResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receievedMessage = eEncoding.GetString(receivedData);
                    receievedMessage.Trim('\r', '\n', '\0', ' ');
                    NonBlockingConsole.WriteLine(receievedMessage);
                    Thread handlingThread = new Thread(() => handleMessage(receievedMessage));
                    handlingThread.Start();
                }

                byte[] buffer = new byte[1024];
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(MessageCallBack), buffer);
                NonBlockingConsole.WriteLine("Listening Again");
            }
            catch (System.ObjectDisposedException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void fieldClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                var location = GetLocationFromName(button.Name);
                int x = location.Item1;
                int y = location.Item2;
                sendFieldClick(x, y, ref socket);
                toolStripStatusLabel.Text = "Warten";
            }
            else
            {
                toolStripStatusLabel.Text = "Feld belegt";
            }
        }

        /// <summary>
        /// Schickt die Information zum Server, dass ein Feld angeklickt wurde
        /// </summary>
        /// <param name="x">X Koordinate des Feldes</param>
        /// <param name="y">Y Koordinate des Feldes</param>
        /// <param name="sock">Zu benutzender Socket</param>
        private void sendFieldClick(int x, int y, ref Socket sock)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] message = new byte[3];
            message[0] = enc.GetBytes("c")[0];
            message[1] = enc.GetBytes(x.ToString())[0];
            message[2] = enc.GetBytes(y.ToString())[0];
            NonBlockingConsole.WriteLine("Sending " + enc.GetString(message) + " to " + sock.RemoteEndPoint.ToString() + " from " + sock.LocalEndPoint.ToString());
            sock.Send(message);
        }

        /// <summary>
        /// Schickt den Spielernamen zzum Server um ein Spiel zu starten
        /// </summary>
        /// <param name="name">Spielername</param>
        /// <param name="sock">Zu benutzender Socket</param>
        private void SendPlayerName(string name, ref Socket sock)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] message = new byte[enc.GetByteCount(name) + 1];
            enc.GetBytes(name, 0, name.Length, message, 1);
            message[0] = enc.GetBytes("n")[0];
            NonBlockingConsole.WriteLine("Sending " + enc.GetString(message) + " to " + sock.RemoteEndPoint.ToString() + " from " + sock.LocalEndPoint.ToString());
            sock.Send(message);
        }

        /// <summary>
        /// Gibt X und Y Wert des angeklickten Buttons zurück
        /// </summary>
        /// <param name="name">Name des Buttons im Format "buttonx_y"</param>
        /// <returns>Item1: byte X, Item2: byte Y</returns>
        private Tuple<int, int> GetLocationFromName(string name)
        {
            //Name is like button1_1
            string xString = name.Substring(6, 1);
            string yString = name.Substring(8, 1);
            int x = int.Parse(xString);
            int y = int.Parse(yString);
            return Tuple.Create(x, y);
        }

        //Hilfsfunktionen für TextBox Beschriftungen 
        private void textBoxIp_Enter(object sender, EventArgs e)
        {
            if (textBoxIp.Text == "IP")
                textBoxIp.Text = "";
        }

        private void textBoxPort_Enter(object sender, EventArgs e)
        {
            if (textBoxPort.Text == "Port")
                textBoxPort.Text = "";
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Name")
                textBoxName.Text = "";
        }

        private void textBoxIp_Leave(object sender, EventArgs e)
        {
            if (textBoxIp.Text == "")
                textBoxIp.Text = "IP";
        }

        private void textBoxPort_Leave(object sender, EventArgs e)
        {
            if (textBoxPort.Text == "")
                textBoxPort.Text = "Port";
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
                textBoxName.Text = "Name";
        }

        /// <summary>
        /// Aktiviert oder Deaktiviert alle Felder
        /// </summary>
        /// <param name="enabled">Status der Felder</param>
        private void setButtonsEnabled(bool enabled)
        {
            this.Invoke((MethodInvoker)delegate
            {
                NonBlockingConsole.WriteLine("setButtonsEnabled");
                var buttons = tableLayoutPanel1.Controls;
                foreach (Button button in buttons)
                {
                    NonBlockingConsole.WriteLine("Type: " + button.GetType().ToString() + " Name: " + button.Name);
                    if (Regex.IsMatch(button.Name, "button\\d_\\d"))
                    {

                        button.Enabled = enabled; // runs on UI thread

                    }
                }
            });
        }

        private void setButtonsText(string text)
        {
            var buttons = tableLayoutPanel1.Controls;
            foreach (Button button in buttons)
            {
                NonBlockingConsole.WriteLine("Type: " + button.GetType().ToString() + " Name: " + button.Name);
                if (Regex.IsMatch(button.Name, "button\\d_\\d"))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        button.Text = text; // runs on UI thread
                    });
                }
            }
        }

        /// <summary>
        /// Sucht den Button an der angegebenen Stelle
        /// </summary>
        /// <param name="x">X Koordinate</param>
        /// <param name="y">Y Koordinate</param>
        /// <returns>Button Objekt des angegebenen Feldes</returns>
        private Button field(int x, int y)
        {
            var buttons = tableLayoutPanel1.Controls;
            foreach (Button button in buttons)
            {
                if (button.Name == "button" + x + "_" + y)
                    return button;
            }
            return null;
        }
    }

    /// <summary>
    /// Hilfsklasse um auf die Konsole zugreifen zu könne ohne Threads zu blockieren
    /// </summary>
    public static class NonBlockingConsole
    {
        private static BlockingCollection<string> m_Queue = new BlockingCollection<string>();

        static NonBlockingConsole()
        {
            var thread = new Thread(
              () =>
              {
                  while (true) Console.WriteLine(m_Queue.Take());
              });
            thread.IsBackground = true;
            thread.Start();
        }

        public static void WriteLine(string value)
        {
            m_Queue.Add(value);
        }
    }
}