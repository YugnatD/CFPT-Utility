namespace Timer
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interruptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateurDeTableauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ValPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WindowMessage = new System.Windows.Forms.RichTextBox();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValPort)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem,
            this.interruptionToolStripMenuItem,
            this.aDCToolStripMenuItem,
            this.lCDToolStripMenuItem,
            this.generateurDeTableauToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click_1);
            // 
            // interruptionToolStripMenuItem
            // 
            this.interruptionToolStripMenuItem.Name = "interruptionToolStripMenuItem";
            this.interruptionToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.interruptionToolStripMenuItem.Text = "Interruption";
            this.interruptionToolStripMenuItem.Click += new System.EventHandler(this.interruptionToolStripMenuItem_Click_1);
            // 
            // aDCToolStripMenuItem
            // 
            this.aDCToolStripMenuItem.Name = "aDCToolStripMenuItem";
            this.aDCToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aDCToolStripMenuItem.Text = "ADC";
            this.aDCToolStripMenuItem.Click += new System.EventHandler(this.aDCToolStripMenuItem_Click);
            // 
            // lCDToolStripMenuItem
            // 
            this.lCDToolStripMenuItem.Name = "lCDToolStripMenuItem";
            this.lCDToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lCDToolStripMenuItem.Text = "LCD";
            this.lCDToolStripMenuItem.Click += new System.EventHandler(this.lCDToolStripMenuItem_Click);
            // 
            // generateurDeTableauToolStripMenuItem
            // 
            this.generateurDeTableauToolStripMenuItem.Name = "generateurDeTableauToolStripMenuItem";
            this.generateurDeTableauToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.generateurDeTableauToolStripMenuItem.Text = "Generateur de tableau";
            this.generateurDeTableauToolStripMenuItem.Click += new System.EventHandler(this.generateurDeTableauToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click_1);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(53, 27);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(117, 20);
            this.UserName.TabIndex = 43;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nom :";
            // 
            // MessageText
            // 
            this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageText.Location = new System.Drawing.Point(15, 301);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(567, 20);
            this.MessageText.TabIndex = 46;
            this.MessageText.TextChanged += new System.EventHandler(this.MessageText_TextChanged);
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send.AutoSize = true;
            this.Send.Location = new System.Drawing.Point(588, 301);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 47;
            this.Send.Text = "Envoyer";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Port :";
            // 
            // ValPort
            // 
            this.ValPort.Location = new System.Drawing.Point(214, 25);
            this.ValPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ValPort.Name = "ValPort";
            this.ValPort.Size = new System.Drawing.Size(119, 20);
            this.ValPort.TabIndex = 49;
            this.ValPort.Value = new decimal(new int[] {
            54545,
            0,
            0,
            0});
            this.ValPort.ValueChanged += new System.EventHandler(this.ValPort_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "V12.0";
            // 
            // WindowMessage
            // 
            this.WindowMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowMessage.Location = new System.Drawing.Point(12, 60);
            this.WindowMessage.Name = "WindowMessage";
            this.WindowMessage.ReadOnly = true;
            this.WindowMessage.Size = new System.Drawing.Size(651, 235);
            this.WindowMessage.TabIndex = 53;
            this.WindowMessage.Text = "";
            this.WindowMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.WindowMessage_LinkClicked);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.WindowMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Utilitaire CFPT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interruptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ValPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem lCDToolStripMenuItem;
        private System.Windows.Forms.RichTextBox WindowMessage;
        private System.Windows.Forms.ToolStripMenuItem generateurDeTableauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
    }
}