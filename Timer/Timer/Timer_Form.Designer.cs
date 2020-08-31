namespace Timer
{
    partial class Tempo_Timer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tempo_Timer));
            this.SelectPrediv = new System.Windows.Forms.ComboBox();
            this.label_Prediviseur = new System.Windows.Forms.Label();
            this.LabelClockFrequency = new System.Windows.Forms.Label();
            this.ModeTimer = new System.Windows.Forms.ComboBox();
            this.LabelModeTimer = new System.Windows.Forms.Label();
            this.LabelLoadValue = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.Calcul = new System.Windows.Forms.Button();
            this.ResultatLoadValue = new System.Windows.Forms.Label();
            this.Seconde = new System.Windows.Forms.Label();
            this.fmtTempo = new System.Windows.Forms.ComboBox();
            this.LabelErreur = new System.Windows.Forms.Label();
            this.Temporisation = new System.Windows.Forms.NumericUpDown();
            this.ClockFrequency = new System.Windows.Forms.NumericUpDown();
            this.Hz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextCode = new System.Windows.Forms.RichTextBox();
            this.Temporisation1 = new System.Windows.Forms.NumericUpDown();
            this.LabelErreur1 = new System.Windows.Forms.Label();
            this.fmtTempo1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultatLoadValue1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeTimer1 = new System.Windows.Forms.ComboBox();
            this.CheckBoxTimer1 = new System.Windows.Forms.CheckBox();
            this.Copy = new System.Windows.Forms.Button();
            this.CheckBoxTimer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Temporisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temporisation1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectPrediv
            // 
            this.SelectPrediv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectPrediv.FormattingEnabled = true;
            this.SelectPrediv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectPrediv.Items.AddRange(new object[] {
            "4",
            "12",
            "48"});
            this.SelectPrediv.Location = new System.Drawing.Point(11, 41);
            this.SelectPrediv.Name = "SelectPrediv";
            this.SelectPrediv.Size = new System.Drawing.Size(121, 21);
            this.SelectPrediv.TabIndex = 0;
            this.SelectPrediv.SelectedIndexChanged += new System.EventHandler(this.SelectPrediv_SelectedIndexChanged);
            // 
            // label_Prediviseur
            // 
            this.label_Prediviseur.AutoSize = true;
            this.label_Prediviseur.Location = new System.Drawing.Point(8, 25);
            this.label_Prediviseur.Name = "label_Prediviseur";
            this.label_Prediviseur.Size = new System.Drawing.Size(59, 13);
            this.label_Prediviseur.TabIndex = 1;
            this.label_Prediviseur.Text = "Prediviseur";
            // 
            // LabelClockFrequency
            // 
            this.LabelClockFrequency.AutoSize = true;
            this.LabelClockFrequency.Location = new System.Drawing.Point(13, 71);
            this.LabelClockFrequency.Name = "LabelClockFrequency";
            this.LabelClockFrequency.Size = new System.Drawing.Size(152, 13);
            this.LabelClockFrequency.TabIndex = 3;
            this.LabelClockFrequency.Text = "Frequence du Clock Systeme :";
            // 
            // ModeTimer
            // 
            this.ModeTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeTimer.FormattingEnabled = true;
            this.ModeTimer.Items.AddRange(new object[] {
            "8",
            "13",
            "16"});
            this.ModeTimer.Location = new System.Drawing.Point(160, 41);
            this.ModeTimer.Name = "ModeTimer";
            this.ModeTimer.Size = new System.Drawing.Size(121, 21);
            this.ModeTimer.TabIndex = 4;
            this.ModeTimer.SelectedIndexChanged += new System.EventHandler(this.ModeTimer_SelectedIndexChanged);
            // 
            // LabelModeTimer
            // 
            this.LabelModeTimer.AutoSize = true;
            this.LabelModeTimer.Location = new System.Drawing.Point(157, 25);
            this.LabelModeTimer.Name = "LabelModeTimer";
            this.LabelModeTimer.Size = new System.Drawing.Size(78, 13);
            this.LabelModeTimer.TabIndex = 5;
            this.LabelModeTimer.Text = "Mode du Timer";
            // 
            // LabelLoadValue
            // 
            this.LabelLoadValue.AutoSize = true;
            this.LabelLoadValue.Location = new System.Drawing.Point(8, 122);
            this.LabelLoadValue.Name = "LabelLoadValue";
            this.LabelLoadValue.Size = new System.Drawing.Size(64, 13);
            this.LabelLoadValue.TabIndex = 6;
            this.LabelLoadValue.Text = "LoadValue :";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(8, 97);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(82, 13);
            this.labelTempo.TabIndex = 7;
            this.labelTempo.Text = "Termporisation :";
            // 
            // Calcul
            // 
            this.Calcul.Location = new System.Drawing.Point(201, 313);
            this.Calcul.Name = "Calcul";
            this.Calcul.Size = new System.Drawing.Size(118, 23);
            this.Calcul.TabIndex = 9;
            this.Calcul.Text = "Calculer la LoadValue";
            this.Calcul.UseVisualStyleBackColor = true;
            this.Calcul.Click += new System.EventHandler(this.Calcul_Click);
            // 
            // ResultatLoadValue
            // 
            this.ResultatLoadValue.AutoSize = true;
            this.ResultatLoadValue.Location = new System.Drawing.Point(93, 122);
            this.ResultatLoadValue.Name = "ResultatLoadValue";
            this.ResultatLoadValue.Size = new System.Drawing.Size(100, 13);
            this.ResultatLoadValue.TabIndex = 10;
            this.ResultatLoadValue.Text = "Resultat LoadValue";
            // 
            // Seconde
            // 
            this.Seconde.AutoSize = true;
            this.Seconde.Location = new System.Drawing.Point(274, 101);
            this.Seconde.Name = "Seconde";
            this.Seconde.Size = new System.Drawing.Size(50, 13);
            this.Seconde.TabIndex = 11;
            this.Seconde.Text = "Seconde";
            // 
            // fmtTempo
            // 
            this.fmtTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fmtTempo.FormattingEnabled = true;
            this.fmtTempo.Items.AddRange(new object[] {
            "-",
            "milli",
            "micro",
            "nano"});
            this.fmtTempo.Location = new System.Drawing.Point(208, 93);
            this.fmtTempo.Name = "fmtTempo";
            this.fmtTempo.Size = new System.Drawing.Size(60, 21);
            this.fmtTempo.TabIndex = 12;
            this.fmtTempo.SelectedIndexChanged += new System.EventHandler(this.fmtTempo_SelectedIndexChanged);
            // 
            // LabelErreur
            // 
            this.LabelErreur.AutoSize = true;
            this.LabelErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErreur.Location = new System.Drawing.Point(136, 153);
            this.LabelErreur.Name = "LabelErreur";
            this.LabelErreur.Size = new System.Drawing.Size(19, 25);
            this.LabelErreur.TabIndex = 13;
            this.LabelErreur.Text = "-";
            // 
            // Temporisation
            // 
            this.Temporisation.DecimalPlaces = 2;
            this.Temporisation.Location = new System.Drawing.Point(96, 93);
            this.Temporisation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Temporisation.Name = "Temporisation";
            this.Temporisation.Size = new System.Drawing.Size(106, 20);
            this.Temporisation.TabIndex = 16;
            this.Temporisation.ValueChanged += new System.EventHandler(this.Temporisation_ValueChanged);
            // 
            // ClockFrequency
            // 
            this.ClockFrequency.Location = new System.Drawing.Point(172, 71);
            this.ClockFrequency.Maximum = new decimal(new int[] {
            48000000,
            0,
            0,
            0});
            this.ClockFrequency.Name = "ClockFrequency";
            this.ClockFrequency.Size = new System.Drawing.Size(96, 20);
            this.ClockFrequency.TabIndex = 17;
            this.ClockFrequency.Value = new decimal(new int[] {
            48000000,
            0,
            0,
            0});
            this.ClockFrequency.ValueChanged += new System.EventHandler(this.ClockFrequency_ValueChanged);
            // 
            // Hz
            // 
            this.Hz.AutoSize = true;
            this.Hz.Location = new System.Drawing.Point(274, 78);
            this.Hz.Name = "Hz";
            this.Hz.Size = new System.Drawing.Size(20, 13);
            this.Hz.TabIndex = 18;
            this.Hz.Text = "Hz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TextCode
            // 
            this.TextCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCode.Location = new System.Drawing.Point(331, 12);
            this.TextCode.Name = "TextCode";
            this.TextCode.ReadOnly = true;
            this.TextCode.Size = new System.Drawing.Size(393, 190);
            this.TextCode.TabIndex = 20;
            this.TextCode.Text = "";
            this.TextCode.TextChanged += new System.EventHandler(this.TextCode_TextChanged);
            // 
            // Temporisation1
            // 
            this.Temporisation1.DecimalPlaces = 2;
            this.Temporisation1.Location = new System.Drawing.Point(94, 239);
            this.Temporisation1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Temporisation1.Name = "Temporisation1";
            this.Temporisation1.Size = new System.Drawing.Size(106, 20);
            this.Temporisation1.TabIndex = 34;
            this.Temporisation1.ValueChanged += new System.EventHandler(this.Temporisation1_ValueChanged);
            // 
            // LabelErreur1
            // 
            this.LabelErreur1.AutoSize = true;
            this.LabelErreur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErreur1.Location = new System.Drawing.Point(64, 319);
            this.LabelErreur1.Name = "LabelErreur1";
            this.LabelErreur1.Size = new System.Drawing.Size(19, 25);
            this.LabelErreur1.TabIndex = 33;
            this.LabelErreur1.Text = "-";
            // 
            // fmtTempo1
            // 
            this.fmtTempo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fmtTempo1.FormattingEnabled = true;
            this.fmtTempo1.Items.AddRange(new object[] {
            "-",
            "milli",
            "micro",
            "nano"});
            this.fmtTempo1.Location = new System.Drawing.Point(206, 239);
            this.fmtTempo1.Name = "fmtTempo1";
            this.fmtTempo1.Size = new System.Drawing.Size(60, 21);
            this.fmtTempo1.TabIndex = 32;
            this.fmtTempo1.SelectedIndexChanged += new System.EventHandler(this.fmtTempo1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Seconde";
            // 
            // ResultatLoadValue1
            // 
            this.ResultatLoadValue1.AutoSize = true;
            this.ResultatLoadValue1.Location = new System.Drawing.Point(91, 262);
            this.ResultatLoadValue1.Name = "ResultatLoadValue1";
            this.ResultatLoadValue1.Size = new System.Drawing.Size(100, 13);
            this.ResultatLoadValue1.TabIndex = 30;
            this.ResultatLoadValue1.Text = "Resultat LoadValue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Termporisation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "LoadValue :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mode du Timer";
            // 
            // ModeTimer1
            // 
            this.ModeTimer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeTimer1.FormattingEnabled = true;
            this.ModeTimer1.Items.AddRange(new object[] {
            "8",
            "13",
            "16"});
            this.ModeTimer1.Location = new System.Drawing.Point(8, 208);
            this.ModeTimer1.Name = "ModeTimer1";
            this.ModeTimer1.Size = new System.Drawing.Size(121, 21);
            this.ModeTimer1.TabIndex = 25;
            this.ModeTimer1.SelectedIndexChanged += new System.EventHandler(this.ModeTimer1_SelectedIndexChanged);
            // 
            // CheckBoxTimer1
            // 
            this.CheckBoxTimer1.AutoSize = true;
            this.CheckBoxTimer1.Location = new System.Drawing.Point(8, 172);
            this.CheckBoxTimer1.Name = "CheckBoxTimer1";
            this.CheckBoxTimer1.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxTimer1.TabIndex = 38;
            this.CheckBoxTimer1.Text = "Timer1 :";
            this.CheckBoxTimer1.UseVisualStyleBackColor = true;
            this.CheckBoxTimer1.CheckedChanged += new System.EventHandler(this.CheckBoxTimer1_CheckedChanged);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(586, 206);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 39;
            this.Copy.Text = "Copier";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // CheckBoxTimer
            // 
            this.CheckBoxTimer.AutoSize = true;
            this.CheckBoxTimer.Location = new System.Drawing.Point(6, 5);
            this.CheckBoxTimer.Name = "CheckBoxTimer";
            this.CheckBoxTimer.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxTimer.TabIndex = 40;
            this.CheckBoxTimer.Text = "Timer0 :";
            this.CheckBoxTimer.UseVisualStyleBackColor = true;
            this.CheckBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer0_CheckedChanged);
            // 
            // Tempo_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 355);
            this.Controls.Add(this.CheckBoxTimer);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.CheckBoxTimer1);
            this.Controls.Add(this.Temporisation1);
            this.Controls.Add(this.LabelErreur1);
            this.Controls.Add(this.fmtTempo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultatLoadValue1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModeTimer1);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hz);
            this.Controls.Add(this.ClockFrequency);
            this.Controls.Add(this.Temporisation);
            this.Controls.Add(this.LabelErreur);
            this.Controls.Add(this.fmtTempo);
            this.Controls.Add(this.Seconde);
            this.Controls.Add(this.ResultatLoadValue);
            this.Controls.Add(this.Calcul);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.LabelLoadValue);
            this.Controls.Add(this.LabelModeTimer);
            this.Controls.Add(this.ModeTimer);
            this.Controls.Add(this.LabelClockFrequency);
            this.Controls.Add(this.label_Prediviseur);
            this.Controls.Add(this.SelectPrediv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tempo_Timer";
            this.Text = "Temporisation Timer";
            this.Load += new System.EventHandler(this.Tempo_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Temporisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Temporisation1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectPrediv;
        private System.Windows.Forms.Label label_Prediviseur;
        private System.Windows.Forms.Label LabelClockFrequency;
        private System.Windows.Forms.ComboBox ModeTimer;
        private System.Windows.Forms.Label LabelModeTimer;
        private System.Windows.Forms.Label LabelLoadValue;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Button Calcul;
        private System.Windows.Forms.Label ResultatLoadValue;
        private System.Windows.Forms.Label Seconde;
        private System.Windows.Forms.ComboBox fmtTempo;
        private System.Windows.Forms.Label LabelErreur;
        private System.Windows.Forms.NumericUpDown Temporisation;
        private System.Windows.Forms.NumericUpDown ClockFrequency;
        private System.Windows.Forms.Label Hz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox TextCode;
        private System.Windows.Forms.NumericUpDown Temporisation1;
        private System.Windows.Forms.Label LabelErreur1;
        private System.Windows.Forms.ComboBox fmtTempo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultatLoadValue1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ModeTimer1;
        private System.Windows.Forms.CheckBox CheckBoxTimer1;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.CheckBox CheckBoxTimer;
    }
}

