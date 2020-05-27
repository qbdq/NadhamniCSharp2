namespace NadhamniCSharp
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrivacyLabel = new System.Windows.Forms.Button();
            this.ProfileLabel = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PrivacyLabel
            // 
            this.PrivacyLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrivacyLabel.FlatAppearance.BorderSize = 0;
            this.PrivacyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrivacyLabel.Font = new System.Drawing.Font("Google Sans Medium", 16F, System.Drawing.FontStyle.Bold);
            this.PrivacyLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PrivacyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrivacyLabel.Location = new System.Drawing.Point(168, 25);
            this.PrivacyLabel.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.PrivacyLabel.Name = "PrivacyLabel";
            this.PrivacyLabel.Size = new System.Drawing.Size(243, 42);
            this.PrivacyLabel.TabIndex = 24;
            this.PrivacyLabel.Text = "PRIVACY SETTINGS";
            this.PrivacyLabel.UseVisualStyleBackColor = true;
            this.PrivacyLabel.Click += new System.EventHandler(this.PrivacyLabel_Click_2);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfileLabel.FlatAppearance.BorderSize = 0;
            this.ProfileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileLabel.Font = new System.Drawing.Font("Google Sans Medium", 16F, System.Drawing.FontStyle.Bold);
            this.ProfileLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ProfileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileLabel.Location = new System.Drawing.Point(20, 31);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(124, 31);
            this.ProfileLabel.TabIndex = 24;
            this.ProfileLabel.Text = "PROFILE";
            this.ProfileLabel.UseVisualStyleBackColor = true;
            this.ProfileLabel.Click += new System.EventHandler(this.ProfileLabel_Click_1);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.Location = new System.Drawing.Point(30, 68);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(766, 397);
            this.ProfilePanel.TabIndex = 25;
            this.ProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfilePanel_Paint_1);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.PrivacyLabel);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(812, 480);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PrivacyLabel;
        private System.Windows.Forms.Button ProfileLabel;
        private System.Windows.Forms.Panel ProfilePanel;
    }
}
