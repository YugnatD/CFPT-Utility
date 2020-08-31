namespace Timer
{
    partial class Interruption_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interruption_Form));
            this.Port_Select = new System.Windows.Forms.ComboBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_Flanc = new System.Windows.Forms.Label();
            this.Flanc_Select = new System.Windows.Forms.ComboBox();
            this.checkBox_INT0 = new System.Windows.Forms.CheckBox();
            this.checkBox_INT1 = new System.Windows.Forms.CheckBox();
            this.Flanc_Select1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Port_Select1 = new System.Windows.Forms.ComboBox();
            this.TextCode = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Port_Select
            // 
            this.Port_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port_Select.FormattingEnabled = true;
            this.Port_Select.Items.AddRange(new object[] {
            "P0.0",
            "P0.1",
            "P0.2",
            "P0.3",
            "P0.4",
            "P0.5",
            "P0.6",
            "P0.7"});
            this.Port_Select.Location = new System.Drawing.Point(12, 44);
            this.Port_Select.Name = "Port_Select";
            this.Port_Select.Size = new System.Drawing.Size(121, 21);
            this.Port_Select.TabIndex = 0;
            this.Port_Select.SelectedIndexChanged += new System.EventHandler(this.Port_Select_SelectedIndexChanged);
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(13, 25);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(26, 13);
            this.label_Port.TabIndex = 1;
            this.label_Port.Text = "Port";
            // 
            // label_Flanc
            // 
            this.label_Flanc.AutoSize = true;
            this.label_Flanc.Location = new System.Drawing.Point(9, 68);
            this.label_Flanc.Name = "label_Flanc";
            this.label_Flanc.Size = new System.Drawing.Size(33, 13);
            this.label_Flanc.TabIndex = 2;
            this.label_Flanc.Text = "Flanc";
            // 
            // Flanc_Select
            // 
            this.Flanc_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Flanc_Select.FormattingEnabled = true;
            this.Flanc_Select.Items.AddRange(new object[] {
            "Montant",
            "Descendant",
            "Etat Haut",
            "Etat Bas"});
            this.Flanc_Select.Location = new System.Drawing.Point(12, 84);
            this.Flanc_Select.Name = "Flanc_Select";
            this.Flanc_Select.Size = new System.Drawing.Size(121, 21);
            this.Flanc_Select.TabIndex = 3;
            this.Flanc_Select.SelectedIndexChanged += new System.EventHandler(this.Flanc_Select_SelectedIndexChanged);
            // 
            // checkBox_INT0
            // 
            this.checkBox_INT0.AutoSize = true;
            this.checkBox_INT0.Location = new System.Drawing.Point(13, 5);
            this.checkBox_INT0.Name = "checkBox_INT0";
            this.checkBox_INT0.Size = new System.Drawing.Size(82, 17);
            this.checkBox_INT0.TabIndex = 4;
            this.checkBox_INT0.Text = "Interuption0";
            this.checkBox_INT0.UseVisualStyleBackColor = true;
            this.checkBox_INT0.CheckedChanged += new System.EventHandler(this.checkBox_INT0_CheckedChanged);
            // 
            // checkBox_INT1
            // 
            this.checkBox_INT1.AutoSize = true;
            this.checkBox_INT1.Location = new System.Drawing.Point(16, 128);
            this.checkBox_INT1.Name = "checkBox_INT1";
            this.checkBox_INT1.Size = new System.Drawing.Size(82, 17);
            this.checkBox_INT1.TabIndex = 9;
            this.checkBox_INT1.Text = "Interuption1";
            this.checkBox_INT1.UseVisualStyleBackColor = true;
            this.checkBox_INT1.CheckedChanged += new System.EventHandler(this.checkBox_INT1_CheckedChanged);
            // 
            // Flanc_Select1
            // 
            this.Flanc_Select1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Flanc_Select1.FormattingEnabled = true;
            this.Flanc_Select1.Items.AddRange(new object[] {
            "Montant",
            "Descendant",
            "Etat Haut",
            "Etat Bas"});
            this.Flanc_Select1.Location = new System.Drawing.Point(15, 207);
            this.Flanc_Select1.Name = "Flanc_Select1";
            this.Flanc_Select1.Size = new System.Drawing.Size(121, 21);
            this.Flanc_Select1.TabIndex = 8;
            this.Flanc_Select1.SelectedIndexChanged += new System.EventHandler(this.Flanc_Select1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Flanc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // Port_Select1
            // 
            this.Port_Select1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port_Select1.FormattingEnabled = true;
            this.Port_Select1.Items.AddRange(new object[] {
            "P0.0",
            "P0.1",
            "P0.2",
            "P0.3",
            "P0.4",
            "P0.5",
            "P0.6",
            "P0.7"});
            this.Port_Select1.Location = new System.Drawing.Point(15, 167);
            this.Port_Select1.Name = "Port_Select1";
            this.Port_Select1.Size = new System.Drawing.Size(121, 21);
            this.Port_Select1.TabIndex = 5;
            this.Port_Select1.SelectedIndexChanged += new System.EventHandler(this.Port_Select1_SelectedIndexChanged);
            // 
            // TextCode
            // 
            this.TextCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCode.Location = new System.Drawing.Point(150, 9);
            this.TextCode.Name = "TextCode";
            this.TextCode.ReadOnly = true;
            this.TextCode.Size = new System.Drawing.Size(391, 363);
            this.TextCode.TabIndex = 10;
            this.TextCode.Text = "";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(58, 282);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 11;
            this.Copy.Text = "Copier";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Interruption_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 380);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.checkBox_INT1);
            this.Controls.Add(this.Flanc_Select1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Port_Select1);
            this.Controls.Add(this.checkBox_INT0);
            this.Controls.Add(this.Flanc_Select);
            this.Controls.Add(this.label_Flanc);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.Port_Select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interruption_Form";
            this.Text = "Interruption";
            this.Load += new System.EventHandler(this.Interruption_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Port_Select;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_Flanc;
        private System.Windows.Forms.ComboBox Flanc_Select;
        private System.Windows.Forms.CheckBox checkBox_INT0;
        private System.Windows.Forms.CheckBox checkBox_INT1;
        private System.Windows.Forms.ComboBox Flanc_Select1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Port_Select1;
        private System.Windows.Forms.RichTextBox TextCode;
        private System.Windows.Forms.Button Copy;
    }
}