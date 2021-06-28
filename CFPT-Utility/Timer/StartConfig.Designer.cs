namespace Timer
{
    partial class StartConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartConfig));
            this.lblName = new System.Windows.Forms.Label();
            this.chkbHorsLigne = new System.Windows.Forms.CheckBox();
            this.tebName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom : ";
            // 
            // chkbHorsLigne
            // 
            this.chkbHorsLigne.AutoSize = true;
            this.chkbHorsLigne.Location = new System.Drawing.Point(12, 32);
            this.chkbHorsLigne.Name = "chkbHorsLigne";
            this.chkbHorsLigne.Size = new System.Drawing.Size(107, 17);
            this.chkbHorsLigne.TabIndex = 1;
            this.chkbHorsLigne.Text = "Mode Hors Ligne";
            this.chkbHorsLigne.UseVisualStyleBackColor = true;
            // 
            // tebName
            // 
            this.tebName.Location = new System.Drawing.Point(56, 6);
            this.tebName.Name = "tebName";
            this.tebName.ReadOnly = true;
            this.tebName.Size = new System.Drawing.Size(122, 20);
            this.tebName.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 32);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // StartConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 60);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tebName);
            this.Controls.Add(this.chkbHorsLigne);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartConfig";
            this.Text = "StartConfig";
            this.Load += new System.EventHandler(this.StartConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkbHorsLigne;
        private System.Windows.Forms.TextBox tebName;
        private System.Windows.Forms.Button btnOK;
    }
}