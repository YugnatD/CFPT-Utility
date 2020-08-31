namespace CFPT_Utility
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.tabSelector = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbClockInit = new System.Windows.Forms.RichTextBox();
            this.rtbUart0 = new System.Windows.Forms.RichTextBox();
            this.tabSelector.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelector.Controls.Add(this.tabPage1);
            this.tabSelector.Controls.Add(this.tabPage2);
            this.tabSelector.Location = new System.Drawing.Point(12, 12);
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.SelectedIndex = 0;
            this.tabSelector.Size = new System.Drawing.Size(622, 525);
            this.tabSelector.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbClockInit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ClockInit()";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbUart0);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UART0";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbClockInit
            // 
            this.rtbClockInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbClockInit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbClockInit.Location = new System.Drawing.Point(0, 0);
            this.rtbClockInit.Name = "rtbClockInit";
            this.rtbClockInit.Size = new System.Drawing.Size(618, 499);
            this.rtbClockInit.TabIndex = 0;
            this.rtbClockInit.Text = resources.GetString("rtbClockInit.Text");
            this.rtbClockInit.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtbUart0
            // 
            this.rtbUart0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbUart0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbUart0.Location = new System.Drawing.Point(-2, 0);
            this.rtbUart0.Name = "rtbUart0";
            this.rtbUart0.Size = new System.Drawing.Size(618, 499);
            this.rtbUart0.TabIndex = 1;
            this.rtbUart0.Text = resources.GetString("rtbUart0.Text");
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 549);
            this.Controls.Add(this.tabSelector);
            this.Name = "Model";
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Model_Load);
            this.tabSelector.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSelector;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbClockInit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbUart0;
    }
}