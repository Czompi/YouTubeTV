namespace YouTubeTV
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.applyBTN = new System.Windows.Forms.Button();
            this.selectScreenLBL = new System.Windows.Forms.Label();
            this.selectScreenCBX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // applyBTN
            // 
            this.applyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBTN.Location = new System.Drawing.Point(370, 102);
            this.applyBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(112, 35);
            this.applyBTN.TabIndex = 0;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // selectScreenLBL
            // 
            this.selectScreenLBL.AutoSize = true;
            this.selectScreenLBL.Location = new System.Drawing.Point(14, 14);
            this.selectScreenLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectScreenLBL.Name = "selectScreenLBL";
            this.selectScreenLBL.Size = new System.Drawing.Size(287, 20);
            this.selectScreenLBL.TabIndex = 1;
            this.selectScreenLBL.Text = "Select active screen for this application:";
            // 
            // selectScreenCBX
            // 
            this.selectScreenCBX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectScreenCBX.FormattingEnabled = true;
            this.selectScreenCBX.Location = new System.Drawing.Point(18, 38);
            this.selectScreenCBX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectScreenCBX.Name = "selectScreenCBX";
            this.selectScreenCBX.Size = new System.Drawing.Size(463, 28);
            this.selectScreenCBX.TabIndex = 2;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 129);
            this.Controls.Add(this.selectScreenCBX);
            this.Controls.Add(this.selectScreenLBL);
            this.Controls.Add(this.applyBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(514, 185);
            this.MinimumSize = new System.Drawing.Size(514, 185);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings | YouTubeTV {0}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Label selectScreenLBL;
        private System.Windows.Forms.ComboBox selectScreenCBX;
    }
}