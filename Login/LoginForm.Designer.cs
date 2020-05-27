using Bunifu.Framework.UI;

namespace NadhamniCSharp
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoginTwitter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LoginFacebook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LoginGmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LoginUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.LoginTwitter);
            this.bunifuGradientPanel1.Controls.Add(this.LoginFacebook);
            this.bunifuGradientPanel1.Controls.Add(this.LoginGmail);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Orange;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Salmon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(312, 458);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 164);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(243)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(44, 260);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(175, 20);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Sign in using Social Media";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoginTwitter
            // 
            this.LoginTwitter.Active = false;
            this.LoginTwitter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.LoginTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.LoginTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginTwitter.BorderRadius = 7;
            this.LoginTwitter.ButtonText = "                      Twitter";
            this.LoginTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginTwitter.DisabledColor = System.Drawing.Color.Gray;
            this.LoginTwitter.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginTwitter.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginTwitter.Iconimage")));
            this.LoginTwitter.Iconimage_right = null;
            this.LoginTwitter.Iconimage_right_Selected = null;
            this.LoginTwitter.Iconimage_Selected = null;
            this.LoginTwitter.IconMarginLeft = 0;
            this.LoginTwitter.IconMarginRight = 0;
            this.LoginTwitter.IconRightVisible = true;
            this.LoginTwitter.IconRightZoom = 0D;
            this.LoginTwitter.IconVisible = true;
            this.LoginTwitter.IconZoom = 90D;
            this.LoginTwitter.IsTab = false;
            this.LoginTwitter.Location = new System.Drawing.Point(29, 386);
            this.LoginTwitter.Name = "LoginTwitter";
            this.LoginTwitter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.LoginTwitter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.LoginTwitter.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginTwitter.selected = false;
            this.LoginTwitter.Size = new System.Drawing.Size(246, 41);
            this.LoginTwitter.TabIndex = 0;
            this.LoginTwitter.Text = "                      Twitter";
            this.LoginTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginTwitter.Textcolor = System.Drawing.Color.White;
            this.LoginTwitter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LoginFacebook
            // 
            this.LoginFacebook.Active = false;
            this.LoginFacebook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.LoginFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.LoginFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginFacebook.BorderRadius = 7;
            this.LoginFacebook.ButtonText = "                 Facebook";
            this.LoginFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFacebook.DisabledColor = System.Drawing.Color.Gray;
            this.LoginFacebook.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginFacebook.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginFacebook.Iconimage")));
            this.LoginFacebook.Iconimage_right = null;
            this.LoginFacebook.Iconimage_right_Selected = null;
            this.LoginFacebook.Iconimage_Selected = null;
            this.LoginFacebook.IconMarginLeft = 0;
            this.LoginFacebook.IconMarginRight = 0;
            this.LoginFacebook.IconRightVisible = true;
            this.LoginFacebook.IconRightZoom = 0D;
            this.LoginFacebook.IconVisible = true;
            this.LoginFacebook.IconZoom = 90D;
            this.LoginFacebook.IsTab = false;
            this.LoginFacebook.Location = new System.Drawing.Point(29, 292);
            this.LoginFacebook.Name = "LoginFacebook";
            this.LoginFacebook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.LoginFacebook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.LoginFacebook.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginFacebook.selected = false;
            this.LoginFacebook.Size = new System.Drawing.Size(246, 41);
            this.LoginFacebook.TabIndex = 0;
            this.LoginFacebook.Text = "                 Facebook";
            this.LoginFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginFacebook.Textcolor = System.Drawing.Color.White;
            this.LoginFacebook.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LoginGmail
            // 
            this.LoginGmail.Active = false;
            this.LoginGmail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.LoginGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.LoginGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginGmail.BorderRadius = 7;
            this.LoginGmail.ButtonText = "                      Gmail";
            this.LoginGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginGmail.DisabledColor = System.Drawing.Color.Gray;
            this.LoginGmail.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginGmail.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginGmail.Iconimage")));
            this.LoginGmail.Iconimage_right = null;
            this.LoginGmail.Iconimage_right_Selected = null;
            this.LoginGmail.Iconimage_Selected = null;
            this.LoginGmail.IconMarginLeft = 0;
            this.LoginGmail.IconMarginRight = 0;
            this.LoginGmail.IconRightVisible = true;
            this.LoginGmail.IconRightZoom = 0D;
            this.LoginGmail.IconVisible = true;
            this.LoginGmail.IconZoom = 90D;
            this.LoginGmail.IsTab = false;
            this.LoginGmail.Location = new System.Drawing.Point(29, 339);
            this.LoginGmail.Name = "LoginGmail";
            this.LoginGmail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.LoginGmail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(49)))), ((int)(((byte)(33)))));
            this.LoginGmail.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginGmail.selected = false;
            this.LoginGmail.Size = new System.Drawing.Size(246, 41);
            this.LoginGmail.TabIndex = 0;
            this.LoginGmail.Text = "                      Gmail";
            this.LoginGmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginGmail.Textcolor = System.Drawing.Color.White;
            this.LoginGmail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LoginUsername
            // 
            this.LoginUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LoginUsername.ForeColor = System.Drawing.Color.Black;
            this.LoginUsername.HintForeColor = System.Drawing.Color.Black;
            this.LoginUsername.HintText = "Username or Email";
            this.LoginUsername.isPassword = false;
            this.LoginUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginUsername.LineThickness = 1;
            this.LoginUsername.Location = new System.Drawing.Point(379, 185);
            this.LoginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.LoginUsername.MaxLength = 32767;
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(379, 33);
            this.LoginUsername.TabIndex = 2;
            this.LoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginUsername.OnValueChanged += new System.EventHandler(this.LoginUsername_OnValueChanged);
            // 
            // LoginPassword
            // 
            this.LoginPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LoginPassword.ForeColor = System.Drawing.Color.Black;
            this.LoginPassword.HintForeColor = System.Drawing.Color.Empty;
            this.LoginPassword.HintText = "Password";
            this.LoginPassword.isPassword = true;
            this.LoginPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.LoginPassword.LineThickness = 1;
            this.LoginPassword.Location = new System.Drawing.Point(379, 226);
            this.LoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPassword.MaxLength = 32767;
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(379, 33);
            this.LoginPassword.TabIndex = 2;
            this.LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginPassword.OnValueChanged += new System.EventHandler(this.LoginPassword_OnValueChanged);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(382, 276);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 3;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(408, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(107, 18);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Remember Me";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click_1);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(460, 393);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(171, 17);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "You don\'t have an account ?";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(629, 394);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(48, 15);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Sign Up";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(652, 265);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(106, 15);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Forget Password?";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(1)))), ((int)(((byte)(142)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Login";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(483, 320);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(159, 50);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Login";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(502, 82);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(96, 42);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Login";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(768, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(23, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(738, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(23, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUsername);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuGradientPanel bunifuGradientPanel1;
        private BunifuFlatButton LoginTwitter;
        private BunifuFlatButton LoginGmail;
        private BunifuFlatButton LoginFacebook;
        private BunifuMaterialTextbox LoginPassword;
        private BunifuMaterialTextbox LoginUsername;
        private BunifuCustomLabel bunifuCustomLabel3;
        private BunifuCheckbox bunifuCheckbox1;
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuCustomLabel bunifuCustomLabel6;
        private BunifuCustomLabel bunifuCustomLabel5;
        private BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private BunifuImageButton bunifuImageButton2;
        private BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

