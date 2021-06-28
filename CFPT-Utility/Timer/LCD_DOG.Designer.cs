namespace Dessin
{
    partial class LCD_DOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCD_DOG));
            this.DessinBox = new System.Windows.Forms.PictureBox();
            this.PixelX = new System.Windows.Forms.Label();
            this.PixelY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Generer_button = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.RichTextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Couleur = new System.Windows.Forms.ComboBox();
            this.CodeOpti = new System.Windows.Forms.RichTextBox();
            this.Copy_opti = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.progressCode = new System.Windows.Forms.ProgressBar();
            this.ChecknonOpti = new System.Windows.Forms.CheckBox();
            this.CheckOpti = new System.Windows.Forms.CheckBox();
            this.InvertColor = new System.Windows.Forms.CheckBox();
            this.listImage = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DessinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DessinBox
            // 
            this.DessinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DessinBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DessinBox.Image = ((System.Drawing.Image)(resources.GetObject("DessinBox.Image")));
            this.DessinBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DessinBox.InitialImage")));
            this.DessinBox.Location = new System.Drawing.Point(12, 12);
            this.DessinBox.Name = "DessinBox";
            this.DessinBox.Size = new System.Drawing.Size(640, 320);
            this.DessinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DessinBox.TabIndex = 0;
            this.DessinBox.TabStop = false;
            this.DessinBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DessinBox_DragEnter);
            this.DessinBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DessinBox_MouseDown);
            this.DessinBox.MouseLeave += new System.EventHandler(this.DessinBox_MouseLeave);
            this.DessinBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DessinBox_MouseMove);
            this.DessinBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DessinBox_MouseUp);
            // 
            // PixelX
            // 
            this.PixelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PixelX.AutoSize = true;
            this.PixelX.Location = new System.Drawing.Point(84, 388);
            this.PixelX.Name = "PixelX";
            this.PixelX.Size = new System.Drawing.Size(35, 13);
            this.PixelX.TabIndex = 1;
            this.PixelX.Text = "label1";
            // 
            // PixelY
            // 
            this.PixelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PixelY.AutoSize = true;
            this.PixelY.Location = new System.Drawing.Point(84, 405);
            this.PixelY.Name = "PixelY";
            this.PixelY.Size = new System.Drawing.Size(35, 13);
            this.PixelY.TabIndex = 2;
            this.PixelY.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordoné X :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coordoné Y :";
            // 
            // Generer_button
            // 
            this.Generer_button.Location = new System.Drawing.Point(573, 338);
            this.Generer_button.Name = "Generer_button";
            this.Generer_button.Size = new System.Drawing.Size(75, 23);
            this.Generer_button.TabIndex = 5;
            this.Generer_button.Text = "Generer";
            this.Generer_button.UseVisualStyleBackColor = true;
            this.Generer_button.Click += new System.EventHandler(this.Generer_button_Click);
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(654, 32);
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Size = new System.Drawing.Size(162, 300);
            this.Code.TabIndex = 6;
            this.Code.Text = "";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(654, 338);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(162, 23);
            this.Copy.TabIndex = 7;
            this.Copy.Text = "Copier";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(492, 339);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Couleur
            // 
            this.Couleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Couleur.FormattingEnabled = true;
            this.Couleur.Items.AddRange(new object[] {
            "Noir",
            "Blanc"});
            this.Couleur.Location = new System.Drawing.Point(391, 340);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(95, 21);
            this.Couleur.TabIndex = 9;
            this.Couleur.SelectedIndexChanged += new System.EventHandler(this.Couleur_SelectedIndexChanged);
            // 
            // CodeOpti
            // 
            this.CodeOpti.Location = new System.Drawing.Point(823, 32);
            this.CodeOpti.Name = "CodeOpti";
            this.CodeOpti.ReadOnly = true;
            this.CodeOpti.Size = new System.Drawing.Size(174, 300);
            this.CodeOpti.TabIndex = 10;
            this.CodeOpti.Text = "";
            // 
            // Copy_opti
            // 
            this.Copy_opti.Location = new System.Drawing.Point(823, 336);
            this.Copy_opti.Name = "Copy_opti";
            this.Copy_opti.Size = new System.Drawing.Size(174, 23);
            this.Copy_opti.TabIndex = 11;
            this.Copy_opti.Text = "Copier";
            this.Copy_opti.UseVisualStyleBackColor = true;
            this.Copy_opti.Click += new System.EventHandler(this.Copy_opti_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(145, 338);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(109, 23);
            this.OpenFileButton.TabIndex = 12;
            this.OpenFileButton.Text = "Ouvrir une image";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // progressCode
            // 
            this.progressCode.Location = new System.Drawing.Point(654, 368);
            this.progressCode.Name = "progressCode";
            this.progressCode.Size = new System.Drawing.Size(343, 23);
            this.progressCode.TabIndex = 13;
            // 
            // ChecknonOpti
            // 
            this.ChecknonOpti.AutoSize = true;
            this.ChecknonOpti.Location = new System.Drawing.Point(659, 13);
            this.ChecknonOpti.Name = "ChecknonOpti";
            this.ChecknonOpti.Size = new System.Drawing.Size(132, 17);
            this.ChecknonOpti.TabIndex = 14;
            this.ChecknonOpti.Text = "Generer code non opti";
            this.ChecknonOpti.UseVisualStyleBackColor = true;
            this.ChecknonOpti.CheckedChanged += new System.EventHandler(this.ChecknonOpti_CheckedChanged);
            // 
            // CheckOpti
            // 
            this.CheckOpti.AutoSize = true;
            this.CheckOpti.Location = new System.Drawing.Point(823, 13);
            this.CheckOpti.Name = "CheckOpti";
            this.CheckOpti.Size = new System.Drawing.Size(111, 17);
            this.CheckOpti.TabIndex = 15;
            this.CheckOpti.Text = "Generer code opti";
            this.CheckOpti.UseVisualStyleBackColor = true;
            this.CheckOpti.CheckedChanged += new System.EventHandler(this.CheckOpti_CheckedChanged);
            // 
            // InvertColor
            // 
            this.InvertColor.AutoSize = true;
            this.InvertColor.Location = new System.Drawing.Point(15, 339);
            this.InvertColor.Name = "InvertColor";
            this.InvertColor.Size = new System.Drawing.Size(118, 17);
            this.InvertColor.TabIndex = 17;
            this.InvertColor.Text = "Inverser les couleur";
            this.InvertColor.UseVisualStyleBackColor = true;
            this.InvertColor.CheckedChanged += new System.EventHandler(this.InvertColor_CheckedChanged);
            // 
            // listImage
            // 
            this.listImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listImage.FormattingEnabled = true;
            this.listImage.Location = new System.Drawing.Point(145, 367);
            this.listImage.Name = "listImage";
            this.listImage.Size = new System.Drawing.Size(503, 56);
            this.listImage.TabIndex = 18;
            this.listImage.SelectedValueChanged += new System.EventHandler(this.listImage_SelectedValueChanged);
            // 
            // LCD_DOG
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 433);
            this.Controls.Add(this.listImage);
            this.Controls.Add(this.InvertColor);
            this.Controls.Add(this.CheckOpti);
            this.Controls.Add(this.ChecknonOpti);
            this.Controls.Add(this.progressCode);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.Copy_opti);
            this.Controls.Add(this.CodeOpti);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Generer_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PixelY);
            this.Controls.Add(this.PixelX);
            this.Controls.Add(this.DessinBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCD_DOG";
            this.Text = "LCD DOG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.DessinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DessinBox;
        private System.Windows.Forms.Label PixelX;
        private System.Windows.Forms.Label PixelY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Generer_button;
        private System.Windows.Forms.RichTextBox Code;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox Couleur;
        private System.Windows.Forms.RichTextBox CodeOpti;
        private System.Windows.Forms.Button Copy_opti;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.ProgressBar progressCode;
        private System.Windows.Forms.CheckBox ChecknonOpti;
        private System.Windows.Forms.CheckBox CheckOpti;
        private System.Windows.Forms.CheckBox InvertColor;
        private System.Windows.Forms.ListBox listImage;
    }
}

