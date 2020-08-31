namespace CFPT_Utility
{
    partial class ADC
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
            this.TextCode = new System.Windows.Forms.RichTextBox();
            this.btnCopyText = new System.Windows.Forms.Button();
            this.nudClockFrequency = new System.Windows.Forms.NumericUpDown();
            this.LabelClockFrequency = new System.Windows.Forms.Label();
            this.lblSARFrequency = new System.Windows.Forms.Label();
            this.nudSARFrequency = new System.Windows.Forms.NumericUpDown();
            this.cmbEntreeP = new System.Windows.Forms.ComboBox();
            this.cmbEntreeN = new System.Windows.Forms.ComboBox();
            this.lblEntreeP = new System.Windows.Forms.Label();
            this.lblEntreeN = new System.Windows.Forms.Label();
            this.chkbLowPower = new System.Windows.Forms.CheckBox();
            this.btnCalcule = new System.Windows.Forms.Button();
            this.chkbGauche = new System.Windows.Forms.CheckBox();
            this.lblVref = new System.Windows.Forms.Label();
            this.cmbStartConv = new System.Windows.Forms.ComboBox();
            this.lblStartConv = new System.Windows.Forms.Label();
            this.chkbTempSensor = new System.Windows.Forms.CheckBox();
            this.chkbBiasGenerator = new System.Windows.Forms.CheckBox();
            this.chkbBuffer = new System.Windows.Forms.CheckBox();
            this.chkbInternalRegulator = new System.Windows.Forms.CheckBox();
            this.cmbGain = new System.Windows.Forms.ComboBox();
            this.cmbReference = new System.Windows.Forms.ComboBox();
            this.lblGain = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTensionVref = new System.Windows.Forms.Label();
            this.chkbInterruptADC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudClockFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSARFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCode
            // 
            this.TextCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCode.Location = new System.Drawing.Point(247, 12);
            this.TextCode.Name = "TextCode";
            this.TextCode.ReadOnly = true;
            this.TextCode.Size = new System.Drawing.Size(364, 562);
            this.TextCode.TabIndex = 0;
            this.TextCode.Text = "";
            // 
            // btnCopyText
            // 
            this.btnCopyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyText.Location = new System.Drawing.Point(536, 580);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(75, 23);
            this.btnCopyText.TabIndex = 1;
            this.btnCopyText.Text = "Copier";
            this.btnCopyText.UseVisualStyleBackColor = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // nudClockFrequency
            // 
            this.nudClockFrequency.Location = new System.Drawing.Point(166, 187);
            this.nudClockFrequency.Maximum = new decimal(new int[] {
            48000000,
            0,
            0,
            0});
            this.nudClockFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClockFrequency.Name = "nudClockFrequency";
            this.nudClockFrequency.Size = new System.Drawing.Size(74, 20);
            this.nudClockFrequency.TabIndex = 2;
            this.nudClockFrequency.Value = new decimal(new int[] {
            48000000,
            0,
            0,
            0});
            this.nudClockFrequency.ValueChanged += new System.EventHandler(this.nudClockFrequency_ValueChanged);
            // 
            // LabelClockFrequency
            // 
            this.LabelClockFrequency.AutoSize = true;
            this.LabelClockFrequency.Location = new System.Drawing.Point(8, 187);
            this.LabelClockFrequency.Name = "LabelClockFrequency";
            this.LabelClockFrequency.Size = new System.Drawing.Size(152, 13);
            this.LabelClockFrequency.TabIndex = 4;
            this.LabelClockFrequency.Text = "Frequence du Clock Systeme :";
            // 
            // lblSARFrequency
            // 
            this.lblSARFrequency.AutoSize = true;
            this.lblSARFrequency.Location = new System.Drawing.Point(8, 222);
            this.lblSARFrequency.Name = "lblSARFrequency";
            this.lblSARFrequency.Size = new System.Drawing.Size(134, 13);
            this.lblSARFrequency.TabIndex = 6;
            this.lblSARFrequency.Text = "Frequence du Clock SAR :";
            // 
            // nudSARFrequency
            // 
            this.nudSARFrequency.Location = new System.Drawing.Point(156, 220);
            this.nudSARFrequency.Maximum = new decimal(new int[] {
            48000000,
            0,
            0,
            0});
            this.nudSARFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSARFrequency.Name = "nudSARFrequency";
            this.nudSARFrequency.Size = new System.Drawing.Size(84, 20);
            this.nudSARFrequency.TabIndex = 5;
            this.nudSARFrequency.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSARFrequency.ValueChanged += new System.EventHandler(this.nudSARFrequency_ValueChanged);
            // 
            // cmbEntreeP
            // 
            this.cmbEntreeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntreeP.FormattingEnabled = true;
            this.cmbEntreeP.Items.AddRange(new object[] {
            "P1.0",
            "P1.1",
            "P1.2",
            "P1.3",
            "P1.4",
            "P1.5",
            "P1.6",
            "P1.7",
            "P2.0",
            "P2.1",
            "P2.2",
            "P2.3",
            "P2.4",
            "P2.5",
            "P2.6",
            "P2.7",
            "P3.0",
            "P0.0",
            "P0.1",
            "P0.4",
            "P0.5",
            "Temp Sensor",
            "VDD"});
            this.cmbEntreeP.Location = new System.Drawing.Point(15, 34);
            this.cmbEntreeP.Name = "cmbEntreeP";
            this.cmbEntreeP.Size = new System.Drawing.Size(90, 21);
            this.cmbEntreeP.TabIndex = 7;
            this.cmbEntreeP.SelectedIndexChanged += new System.EventHandler(this.cmbEntreeP_SelectedIndexChanged);
            // 
            // cmbEntreeN
            // 
            this.cmbEntreeN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntreeN.FormattingEnabled = true;
            this.cmbEntreeN.Items.AddRange(new object[] {
            "P1.0",
            "P1.1",
            "P1.2",
            "P1.3",
            "P1.4",
            "P1.5",
            "P1.6",
            "P1.7",
            "P2.0",
            "P2.1",
            "P2.2",
            "P2.3",
            "P2.4",
            "P2.5",
            "P2.6",
            "P2.7",
            "P3.0",
            "P0.0",
            "P0.1",
            "P0.4",
            "P0.5",
            "VREF",
            "GND"});
            this.cmbEntreeN.Location = new System.Drawing.Point(148, 34);
            this.cmbEntreeN.Name = "cmbEntreeN";
            this.cmbEntreeN.Size = new System.Drawing.Size(93, 21);
            this.cmbEntreeN.TabIndex = 8;
            this.cmbEntreeN.SelectedIndexChanged += new System.EventHandler(this.cmbEntreeN_SelectedIndexChanged);
            // 
            // lblEntreeP
            // 
            this.lblEntreeP.AutoSize = true;
            this.lblEntreeP.Location = new System.Drawing.Point(12, 15);
            this.lblEntreeP.Name = "lblEntreeP";
            this.lblEntreeP.Size = new System.Drawing.Size(47, 13);
            this.lblEntreeP.TabIndex = 9;
            this.lblEntreeP.Text = "Entree +";
            // 
            // lblEntreeN
            // 
            this.lblEntreeN.AutoSize = true;
            this.lblEntreeN.Location = new System.Drawing.Point(145, 12);
            this.lblEntreeN.Name = "lblEntreeN";
            this.lblEntreeN.Size = new System.Drawing.Size(44, 13);
            this.lblEntreeN.TabIndex = 10;
            this.lblEntreeN.Text = "Entree -";
            // 
            // chkbLowPower
            // 
            this.chkbLowPower.AutoSize = true;
            this.chkbLowPower.Location = new System.Drawing.Point(11, 131);
            this.chkbLowPower.Name = "chkbLowPower";
            this.chkbLowPower.Size = new System.Drawing.Size(176, 17);
            this.chkbLowPower.TabIndex = 19;
            this.chkbLowPower.Text = "Activer Low Power Track Mode";
            this.chkbLowPower.UseVisualStyleBackColor = true;
            this.chkbLowPower.CheckedChanged += new System.EventHandler(this.chkbLowPower_CheckedChanged);
            // 
            // btnCalcule
            // 
            this.btnCalcule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcule.Location = new System.Drawing.Point(455, 580);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(75, 23);
            this.btnCalcule.TabIndex = 20;
            this.btnCalcule.Text = "Calculer";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcule_Click);
            // 
            // chkbGauche
            // 
            this.chkbGauche.AutoSize = true;
            this.chkbGauche.Location = new System.Drawing.Point(11, 154);
            this.chkbGauche.Name = "chkbGauche";
            this.chkbGauche.Size = new System.Drawing.Size(106, 17);
            this.chkbGauche.TabIndex = 22;
            this.chkbGauche.Text = "Aligner a gauche";
            this.chkbGauche.UseVisualStyleBackColor = true;
            this.chkbGauche.CheckedChanged += new System.EventHandler(this.chkbGauche_CheckedChanged);
            // 
            // lblVref
            // 
            this.lblVref.AutoSize = true;
            this.lblVref.Location = new System.Drawing.Point(12, 253);
            this.lblVref.Name = "lblVref";
            this.lblVref.Size = new System.Drawing.Size(44, 13);
            this.lblVref.TabIndex = 24;
            this.lblVref.Text = "VREF : ";
            // 
            // cmbStartConv
            // 
            this.cmbStartConv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartConv.FormattingEnabled = true;
            this.cmbStartConv.Items.AddRange(new object[] {
            "AD0BUSY=1;",
            "Interruption Timer 0",
            "Interruption Timer 2",
            "Interruption Timer 1",
            "Flanc montant externe sur CNVSTR",
            "Interruption Timer 3",
            "Interruption Timer 4",
            "Interruption Timer 5"});
            this.cmbStartConv.Location = new System.Drawing.Point(11, 92);
            this.cmbStartConv.Name = "cmbStartConv";
            this.cmbStartConv.Size = new System.Drawing.Size(200, 21);
            this.cmbStartConv.TabIndex = 25;
            this.cmbStartConv.SelectedIndexChanged += new System.EventHandler(this.cmbStartConv_SelectedIndexChanged);
            // 
            // lblStartConv
            // 
            this.lblStartConv.AutoSize = true;
            this.lblStartConv.Location = new System.Drawing.Point(8, 76);
            this.lblStartConv.Name = "lblStartConv";
            this.lblStartConv.Size = new System.Drawing.Size(138, 13);
            this.lblStartConv.TabIndex = 26;
            this.lblStartConv.Text = "Demarrage de conversion : ";
            // 
            // chkbTempSensor
            // 
            this.chkbTempSensor.AutoSize = true;
            this.chkbTempSensor.Location = new System.Drawing.Point(15, 269);
            this.chkbTempSensor.Name = "chkbTempSensor";
            this.chkbTempSensor.Size = new System.Drawing.Size(183, 17);
            this.chkbTempSensor.TabIndex = 27;
            this.chkbTempSensor.Text = "Activer le capteur de temperature";
            this.chkbTempSensor.UseVisualStyleBackColor = true;
            this.chkbTempSensor.CheckedChanged += new System.EventHandler(this.chkbTempSensor_CheckedChanged);
            // 
            // chkbBiasGenerator
            // 
            this.chkbBiasGenerator.AutoSize = true;
            this.chkbBiasGenerator.Location = new System.Drawing.Point(15, 292);
            this.chkbBiasGenerator.Name = "chkbBiasGenerator";
            this.chkbBiasGenerator.Size = new System.Drawing.Size(170, 17);
            this.chkbBiasGenerator.TabIndex = 28;
            this.chkbBiasGenerator.Text = "Enable Internal Bias Generator";
            this.chkbBiasGenerator.UseVisualStyleBackColor = true;
            this.chkbBiasGenerator.CheckedChanged += new System.EventHandler(this.chkbBiasGenerator_CheckedChanged);
            // 
            // chkbBuffer
            // 
            this.chkbBuffer.AutoSize = true;
            this.chkbBuffer.Location = new System.Drawing.Point(15, 315);
            this.chkbBuffer.Name = "chkbBuffer";
            this.chkbBuffer.Size = new System.Drawing.Size(135, 17);
            this.chkbBuffer.TabIndex = 29;
            this.chkbBuffer.Text = "Activer le buffer interne";
            this.chkbBuffer.UseVisualStyleBackColor = true;
            this.chkbBuffer.CheckedChanged += new System.EventHandler(this.chkbBuffer_CheckedChanged);
            // 
            // chkbInternalRegulator
            // 
            this.chkbInternalRegulator.AutoSize = true;
            this.chkbInternalRegulator.Location = new System.Drawing.Point(15, 338);
            this.chkbInternalRegulator.Name = "chkbInternalRegulator";
            this.chkbInternalRegulator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkbInternalRegulator.Size = new System.Drawing.Size(229, 17);
            this.chkbInternalRegulator.TabIndex = 30;
            this.chkbInternalRegulator.Text = "Regulateur interne comme reference (1.2V)";
            this.chkbInternalRegulator.UseVisualStyleBackColor = true;
            this.chkbInternalRegulator.CheckedChanged += new System.EventHandler(this.chkbInternalRegulator_CheckedChanged);
            // 
            // cmbGain
            // 
            this.cmbGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGain.FormattingEnabled = true;
            this.cmbGain.Items.AddRange(new object[] {
            "1X",
            "2X"});
            this.cmbGain.Location = new System.Drawing.Point(80, 361);
            this.cmbGain.Name = "cmbGain";
            this.cmbGain.Size = new System.Drawing.Size(90, 21);
            this.cmbGain.TabIndex = 31;
            this.cmbGain.SelectedIndexChanged += new System.EventHandler(this.cmbGain_SelectedIndexChanged);
            // 
            // cmbReference
            // 
            this.cmbReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReference.FormattingEnabled = true;
            this.cmbReference.Items.AddRange(new object[] {
            "VDD",
            "VREF PIN"});
            this.cmbReference.Location = new System.Drawing.Point(80, 388);
            this.cmbReference.Name = "cmbReference";
            this.cmbReference.Size = new System.Drawing.Size(90, 21);
            this.cmbReference.TabIndex = 32;
            this.cmbReference.SelectedIndexChanged += new System.EventHandler(this.cmbReference_SelectedIndexChanged);
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(12, 364);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(38, 13);
            this.lblGain.TabIndex = 33;
            this.lblGain.Text = "Gain : ";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(8, 391);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(66, 13);
            this.lblReference.TabIndex = 34;
            this.lblReference.Text = "Reference : ";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(213, 585);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(236, 13);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.Text = "Rappel : Il faut configurer la Pin choisit en entree";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 36;
            // 
            // lblTensionVref
            // 
            this.lblTensionVref.AutoSize = true;
            this.lblTensionVref.Location = new System.Drawing.Point(62, 253);
            this.lblTensionVref.Name = "lblTensionVref";
            this.lblTensionVref.Size = new System.Drawing.Size(29, 13);
            this.lblTensionVref.TabIndex = 37;
            this.lblTensionVref.Text = "0.0V";
            // 
            // chkbInterruptADC
            // 
            this.chkbInterruptADC.AutoSize = true;
            this.chkbInterruptADC.Location = new System.Drawing.Point(15, 444);
            this.chkbInterruptADC.Name = "chkbInterruptADC";
            this.chkbInterruptADC.Size = new System.Drawing.Size(179, 17);
            this.chkbInterruptADC.TabIndex = 38;
            this.chkbInterruptADC.Text = "Generer la fonction d\'interruption";
            this.chkbInterruptADC.UseVisualStyleBackColor = true;
            this.chkbInterruptADC.CheckedChanged += new System.EventHandler(this.chkbInterruptADC_CheckedChanged);
            // 
            // ADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 615);
            this.Controls.Add(this.chkbInterruptADC);
            this.Controls.Add(this.lblTensionVref);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.cmbReference);
            this.Controls.Add(this.cmbGain);
            this.Controls.Add(this.chkbInternalRegulator);
            this.Controls.Add(this.chkbBuffer);
            this.Controls.Add(this.chkbBiasGenerator);
            this.Controls.Add(this.chkbTempSensor);
            this.Controls.Add(this.lblStartConv);
            this.Controls.Add(this.cmbStartConv);
            this.Controls.Add(this.lblVref);
            this.Controls.Add(this.chkbGauche);
            this.Controls.Add(this.btnCalcule);
            this.Controls.Add(this.chkbLowPower);
            this.Controls.Add(this.lblEntreeN);
            this.Controls.Add(this.lblEntreeP);
            this.Controls.Add(this.cmbEntreeN);
            this.Controls.Add(this.cmbEntreeP);
            this.Controls.Add(this.lblSARFrequency);
            this.Controls.Add(this.nudSARFrequency);
            this.Controls.Add(this.LabelClockFrequency);
            this.Controls.Add(this.nudClockFrequency);
            this.Controls.Add(this.btnCopyText);
            this.Controls.Add(this.TextCode);
            this.Name = "ADC";
            this.Text = "ADC";
            this.Load += new System.EventHandler(this.ADC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudClockFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSARFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextCode;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.NumericUpDown nudClockFrequency;
        private System.Windows.Forms.Label LabelClockFrequency;
        private System.Windows.Forms.Label lblSARFrequency;
        private System.Windows.Forms.NumericUpDown nudSARFrequency;
        private System.Windows.Forms.ComboBox cmbEntreeP;
        private System.Windows.Forms.ComboBox cmbEntreeN;
        private System.Windows.Forms.Label lblEntreeP;
        private System.Windows.Forms.Label lblEntreeN;
        private System.Windows.Forms.CheckBox chkbLowPower;
        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.CheckBox chkbGauche;
        private System.Windows.Forms.Label lblVref;
        private System.Windows.Forms.ComboBox cmbStartConv;
        private System.Windows.Forms.Label lblStartConv;
        private System.Windows.Forms.CheckBox chkbTempSensor;
        private System.Windows.Forms.CheckBox chkbBiasGenerator;
        private System.Windows.Forms.CheckBox chkbBuffer;
        private System.Windows.Forms.CheckBox chkbInternalRegulator;
        private System.Windows.Forms.ComboBox cmbGain;
        private System.Windows.Forms.ComboBox cmbReference;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTensionVref;
        private System.Windows.Forms.CheckBox chkbInterruptADC;
    }
}