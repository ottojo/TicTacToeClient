namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSpielfeld = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button0_2 = new System.Windows.Forms.Button();
            this.button1_2 = new System.Windows.Forms.Button();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button0_1 = new System.Windows.Forms.Button();
            this.button1_1 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.button0_0 = new System.Windows.Forms.Button();
            this.button1_0 = new System.Windows.Forms.Button();
            this.button2_0 = new System.Windows.Forms.Button();
            this.groupBoxVerbindung = new System.Windows.Forms.GroupBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonVerbinden = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSpielfeld.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxVerbindung.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSpielfeld
            // 
            this.groupBoxSpielfeld.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSpielfeld.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSpielfeld.Name = "groupBoxSpielfeld";
            this.groupBoxSpielfeld.Size = new System.Drawing.Size(300, 300);
            this.groupBoxSpielfeld.TabIndex = 0;
            this.groupBoxSpielfeld.TabStop = false;
            this.groupBoxSpielfeld.Text = "Spielfeld";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button0_2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2_2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button0_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2_1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button0_0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1_0, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2_0, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button0_2
            // 
            this.button0_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0_2.Location = new System.Drawing.Point(3, 3);
            this.button0_2.Name = "button0_2";
            this.button0_2.Size = new System.Drawing.Size(91, 87);
            this.button0_2.TabIndex = 0;
            this.button0_2.UseVisualStyleBackColor = true;
            this.button0_2.Click += new System.EventHandler(this.fieldClick);
            // 
            // button1_2
            // 
            this.button1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_2.Location = new System.Drawing.Point(100, 3);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(92, 87);
            this.button1_2.TabIndex = 1;
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.fieldClick);
            // 
            // button2_2
            // 
            this.button2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_2.Location = new System.Drawing.Point(198, 3);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(93, 87);
            this.button2_2.TabIndex = 2;
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.fieldClick);
            // 
            // button0_1
            // 
            this.button0_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0_1.Location = new System.Drawing.Point(3, 96);
            this.button0_1.Name = "button0_1";
            this.button0_1.Size = new System.Drawing.Size(91, 87);
            this.button0_1.TabIndex = 3;
            this.button0_1.UseVisualStyleBackColor = true;
            this.button0_1.Click += new System.EventHandler(this.fieldClick);
            // 
            // button1_1
            // 
            this.button1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_1.Location = new System.Drawing.Point(100, 96);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(92, 87);
            this.button1_1.TabIndex = 4;
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.fieldClick);
            // 
            // button2_1
            // 
            this.button2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_1.Location = new System.Drawing.Point(198, 96);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(93, 87);
            this.button2_1.TabIndex = 5;
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.fieldClick);
            // 
            // button0_0
            // 
            this.button0_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0_0.Location = new System.Drawing.Point(3, 189);
            this.button0_0.Name = "button0_0";
            this.button0_0.Size = new System.Drawing.Size(91, 89);
            this.button0_0.TabIndex = 6;
            this.button0_0.UseVisualStyleBackColor = true;
            this.button0_0.Click += new System.EventHandler(this.fieldClick);
            // 
            // button1_0
            // 
            this.button1_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_0.Location = new System.Drawing.Point(100, 189);
            this.button1_0.Name = "button1_0";
            this.button1_0.Size = new System.Drawing.Size(92, 89);
            this.button1_0.TabIndex = 7;
            this.button1_0.UseVisualStyleBackColor = true;
            this.button1_0.Click += new System.EventHandler(this.fieldClick);
            // 
            // button2_0
            // 
            this.button2_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_0.Location = new System.Drawing.Point(198, 189);
            this.button2_0.Name = "button2_0";
            this.button2_0.Size = new System.Drawing.Size(93, 89);
            this.button2_0.TabIndex = 8;
            this.button2_0.UseVisualStyleBackColor = true;
            this.button2_0.Click += new System.EventHandler(this.fieldClick);
            // 
            // groupBoxVerbindung
            // 
            this.groupBoxVerbindung.Controls.Add(this.textBoxPort);
            this.groupBoxVerbindung.Controls.Add(this.buttonVerbinden);
            this.groupBoxVerbindung.Controls.Add(this.textBoxName);
            this.groupBoxVerbindung.Controls.Add(this.textBoxIp);
            this.groupBoxVerbindung.Location = new System.Drawing.Point(13, 319);
            this.groupBoxVerbindung.Name = "groupBoxVerbindung";
            this.groupBoxVerbindung.Size = new System.Drawing.Size(300, 71);
            this.groupBoxVerbindung.TabIndex = 1;
            this.groupBoxVerbindung.TabStop = false;
            this.groupBoxVerbindung.Text = "Verbindung";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(137, 17);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(76, 20);
            this.textBoxPort.TabIndex = 2;
            this.textBoxPort.Text = "Port";
            this.textBoxPort.Enter += new System.EventHandler(this.textBoxPort_Enter);
            this.textBoxPort.Leave += new System.EventHandler(this.textBoxPort_Leave);
            // 
            // buttonVerbinden
            // 
            this.buttonVerbinden.Location = new System.Drawing.Point(219, 15);
            this.buttonVerbinden.Name = "buttonVerbinden";
            this.buttonVerbinden.Size = new System.Drawing.Size(75, 23);
            this.buttonVerbinden.TabIndex = 0;
            this.buttonVerbinden.Text = "Verbinden";
            this.buttonVerbinden.UseVisualStyleBackColor = true;
            this.buttonVerbinden.Click += new System.EventHandler(this.buttonVerbinden_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Text = "Name";
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(6, 17);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(124, 20);
            this.textBoxIp.TabIndex = 1;
            this.textBoxIp.Text = "IP";
            this.textBoxIp.Enter += new System.EventHandler(this.textBoxIp_Enter);
            this.textBoxIp.Leave += new System.EventHandler(this.textBoxIp_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel.Text = "Nicht verbunden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 430);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxVerbindung);
            this.Controls.Add(this.groupBoxSpielfeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSpielfeld.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxVerbindung.ResumeLayout(false);
            this.groupBoxVerbindung.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSpielfeld;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button0_2;
        private System.Windows.Forms.Button button1_2;
        private System.Windows.Forms.Button button2_2;
        private System.Windows.Forms.Button button0_1;
        private System.Windows.Forms.Button button1_1;
        private System.Windows.Forms.Button button2_1;
        private System.Windows.Forms.Button button0_0;
        private System.Windows.Forms.Button button1_0;
        private System.Windows.Forms.Button button2_0;
        private System.Windows.Forms.GroupBox groupBoxVerbindung;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonVerbinden;
        private System.Windows.Forms.TextBox textBoxPort;
    }
}

