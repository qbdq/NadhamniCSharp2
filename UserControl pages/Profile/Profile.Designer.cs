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
            this.Profile_GotoPrivacy = new System.Windows.Forms.Button();
            this.Profile_GotoProfile = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Profile_GotoPrivacy
            // 
            this.Profile_GotoPrivacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Profile_GotoPrivacy.FlatAppearance.BorderSize = 0;
            this.Profile_GotoPrivacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_GotoPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Profile_GotoPrivacy.ForeColor = System.Drawing.Color.Salmon;
            this.Profile_GotoPrivacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_GotoPrivacy.Location = new System.Drawing.Point(168, 25);
            this.Profile_GotoPrivacy.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.Profile_GotoPrivacy.Name = "Profile_GotoPrivacy";
            this.Profile_GotoPrivacy.Size = new System.Drawing.Size(243, 42);
            this.Profile_GotoPrivacy.TabIndex = 24;
            this.Profile_GotoPrivacy.Text = "PRIVACY SETTINGS";
            this.Profile_GotoPrivacy.UseVisualStyleBackColor = true;
            this.Profile_GotoPrivacy.Click += new System.EventHandler(this.PrivacyLabel_Click_2);
            // 
            // Profile_GotoProfile
            // 
            this.Profile_GotoProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Profile_GotoProfile.FlatAppearance.BorderSize = 0;
            this.Profile_GotoProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_GotoProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.Profile_GotoProfile.ForeColor = System.Drawing.Color.Salmon;
            this.Profile_GotoProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_GotoProfile.Location = new System.Drawing.Point(20, 31);
            this.Profile_GotoProfile.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.Profile_GotoProfile.Name = "Profile_GotoProfile";
            this.Profile_GotoProfile.Size = new System.Drawing.Size(124, 31);
            this.Profile_GotoProfile.TabIndex = 24;
            this.Profile_GotoProfile.Text = "PROFILE";
            this.Profile_GotoProfile.UseVisualStyleBackColor = true;
            this.Profile_GotoProfile.Click += new System.EventHandler(this.ProfileLabel_Click_1);
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
            this.Controls.Add(this.Profile_GotoProfile);
            this.Controls.Add(this.Profile_GotoPrivacy);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(812, 480);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Profile_GotoPrivacy;
        private System.Windows.Forms.Button Profile_GotoProfile;
        private System.Windows.Forms.Panel ProfilePanel;
    }
}
