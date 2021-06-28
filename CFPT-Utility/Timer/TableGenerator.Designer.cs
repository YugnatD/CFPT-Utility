namespace Timer
{
    partial class TableGenerator
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
            this.rtbValeur = new System.Windows.Forms.RichTextBox();
            this.rtbResultat = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCopier = new System.Windows.Forms.Button();
            this.tebNom = new System.Windows.Forms.TextBox();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbValeur
            // 
            this.rtbValeur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbValeur.Location = new System.Drawing.Point(12, 32);
            this.rtbValeur.Name = "rtbValeur";
            this.rtbValeur.Size = new System.Drawing.Size(135, 248);
            this.rtbValeur.TabIndex = 0;
            this.rtbValeur.Text = "";
            // 
            // rtbResultat
            // 
            this.rtbResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResultat.Location = new System.Drawing.Point(153, 32);
            this.rtbResultat.Name = "rtbResultat";
            this.rtbResultat.ReadOnly = true;
            this.rtbResultat.Size = new System.Drawing.Size(162, 248);
            this.rtbResultat.TabIndex = 1;
            this.rtbResultat.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nom :";
            // 
            // btnCopier
            // 
            this.btnCopier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopier.Location = new System.Drawing.Point(240, 286);
            this.btnCopier.Name = "btnCopier";
            this.btnCopier.Size = new System.Drawing.Size(75, 23);
            this.btnCopier.TabIndex = 3;
            this.btnCopier.Text = "Copier";
            this.btnCopier.UseVisualStyleBackColor = true;
            this.btnCopier.Click += new System.EventHandler(this.btnCopier_Click);
            // 
            // tebNom
            // 
            this.tebNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tebNom.Location = new System.Drawing.Point(54, 6);
            this.tebNom.Name = "tebNom";
            this.tebNom.Size = new System.Drawing.Size(180, 20);
            this.tebNom.TabIndex = 4;
            // 
            // btnGenerer
            // 
            this.btnGenerer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerer.Location = new System.Drawing.Point(240, 6);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 23);
            this.btnGenerer.TabIndex = 5;
            this.btnGenerer.Text = "Generer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Utiliser CTRL+V pour coller";
            // 
            // TableGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.tebNom);
            this.Controls.Add(this.btnCopier);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rtbResultat);
            this.Controls.Add(this.rtbValeur);
            this.Name = "TableGenerator";
            this.Text = "TableGenerator";
            this.Load += new System.EventHandler(this.TableGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbValeur;
        private System.Windows.Forms.RichTextBox rtbResultat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCopier;
        private System.Windows.Forms.TextBox tebNom;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Label label1;
    }
}