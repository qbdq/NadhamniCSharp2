namespace NadhamniCSharp.UserControl_pages.Calandar
{
    partial class Year
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Year));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Year_Year = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Year_December = new System.Windows.Forms.Label();
            this.Year_August = new System.Windows.Forms.Label();
            this.Year_April = new System.Windows.Forms.Label();
            this.Year_November = new System.Windows.Forms.Label();
            this.Year_July = new System.Windows.Forms.Label();
            this.Year_March = new System.Windows.Forms.Label();
            this.Year_October = new System.Windows.Forms.Label();
            this.Year_June = new System.Windows.Forms.Label();
            this.Year_February = new System.Windows.Forms.Label();
            this.Year_September = new System.Windows.Forms.Label();
            this.Year_May = new System.Windows.Forms.Label();
            this.Year_January = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Year_Year);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 38);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::NadhamniCSharp.Properties.Resources.forward;
            this.pictureBox2.Location = new System.Drawing.Point(774, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NadhamniCSharp.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Year_Year
            // 
            this.Year_Year.AutoEllipsis = false;
            this.Year_Year.CursorType = null;
            this.Year_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Year_Year.ForeColor = System.Drawing.Color.White;
            this.Year_Year.Location = new System.Drawing.Point(384, 6);
            this.Year_Year.Name = "Year_Year";
            this.Year_Year.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Year_Year.Size = new System.Drawing.Size(79, 40);
            this.Year_Year.TabIndex = 0;
            this.Year_Year.Text = "2020";
            this.Year_Year.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Year_Year.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Year_Year.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.Year_December);
            this.panel2.Controls.Add(this.Year_August);
            this.panel2.Controls.Add(this.Year_April);
            this.panel2.Controls.Add(this.Year_November);
            this.panel2.Controls.Add(this.Year_July);
            this.panel2.Controls.Add(this.Year_March);
            this.panel2.Controls.Add(this.Year_October);
            this.panel2.Controls.Add(this.Year_June);
            this.panel2.Controls.Add(this.Year_February);
            this.panel2.Controls.Add(this.Year_September);
            this.panel2.Controls.Add(this.Year_May);
            this.panel2.Controls.Add(this.Year_January);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 442);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Year_December
            // 
            this.Year_December.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year_December.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_December.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_December.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_December.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_December.ForeColor = System.Drawing.Color.White;
            this.Year_December.Location = new System.Drawing.Point(603, 316);
            this.Year_December.Name = "Year_December";
            this.Year_December.Size = new System.Drawing.Size(152, 96);
            this.Year_December.TabIndex = 39;
            this.Year_December.Text = "December";
            this.Year_December.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_December.Click += new System.EventHandler(this._Label13_Click);
            // 
            // Year_August
            // 
            this.Year_August.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Year_August.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_August.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_August.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_August.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_August.ForeColor = System.Drawing.Color.White;
            this.Year_August.Location = new System.Drawing.Point(603, 177);
            this.Year_August.Name = "Year_August";
            this.Year_August.Size = new System.Drawing.Size(152, 96);
            this.Year_August.TabIndex = 38;
            this.Year_August.Text = "August";
            this.Year_August.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_August.Click += new System.EventHandler(this._Label9_Click);
            // 
            // Year_April
            // 
            this.Year_April.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Year_April.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_April.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_April.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_April.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_April.ForeColor = System.Drawing.Color.White;
            this.Year_April.Location = new System.Drawing.Point(603, 36);
            this.Year_April.Name = "Year_April";
            this.Year_April.Size = new System.Drawing.Size(152, 96);
            this.Year_April.TabIndex = 37;
            this.Year_April.Text = "April";
            this.Year_April.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_April.Click += new System.EventHandler(this._Label5_Click);
            // 
            // Year_November
            // 
            this.Year_November.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year_November.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_November.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_November.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_November.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_November.ForeColor = System.Drawing.Color.White;
            this.Year_November.Location = new System.Drawing.Point(419, 316);
            this.Year_November.Name = "Year_November";
            this.Year_November.Size = new System.Drawing.Size(152, 96);
            this.Year_November.TabIndex = 42;
            this.Year_November.Text = "November";
            this.Year_November.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_November.Click += new System.EventHandler(this._Label12_Click);
            // 
            // Year_July
            // 
            this.Year_July.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Year_July.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_July.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_July.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_July.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_July.ForeColor = System.Drawing.Color.White;
            this.Year_July.Location = new System.Drawing.Point(419, 177);
            this.Year_July.Name = "Year_July";
            this.Year_July.Size = new System.Drawing.Size(152, 96);
            this.Year_July.TabIndex = 41;
            this.Year_July.Text = "July";
            this.Year_July.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_July.Click += new System.EventHandler(this._Label8_Click);
            // 
            // Year_March
            // 
            this.Year_March.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Year_March.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_March.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_March.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_March.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_March.ForeColor = System.Drawing.Color.White;
            this.Year_March.Location = new System.Drawing.Point(419, 36);
            this.Year_March.Name = "Year_March";
            this.Year_March.Size = new System.Drawing.Size(152, 96);
            this.Year_March.TabIndex = 40;
            this.Year_March.Text = "March";
            this.Year_March.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_March.Click += new System.EventHandler(this._Label4_Click);
            // 
            // Year_October
            // 
            this.Year_October.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year_October.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_October.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_October.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_October.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_October.ForeColor = System.Drawing.Color.White;
            this.Year_October.Location = new System.Drawing.Point(235, 316);
            this.Year_October.Name = "Year_October";
            this.Year_October.Size = new System.Drawing.Size(152, 96);
            this.Year_October.TabIndex = 33;
            this.Year_October.Text = "October";
            this.Year_October.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_October.Click += new System.EventHandler(this._Label11_Click);
            // 
            // Year_June
            // 
            this.Year_June.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Year_June.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_June.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_June.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_June.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_June.ForeColor = System.Drawing.Color.White;
            this.Year_June.Location = new System.Drawing.Point(235, 177);
            this.Year_June.Name = "Year_June";
            this.Year_June.Size = new System.Drawing.Size(152, 96);
            this.Year_June.TabIndex = 32;
            this.Year_June.Text = "June";
            this.Year_June.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Year_June.Click += new System.EventHandler(this._Label7_Click);
            // 
            // Year_February
            // 
            this.Year_February.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Year_February.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_February.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_February.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_February.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_February.ForeColor = System.Drawing.Color.White;
            this.Year_February.Location = new System.Drawing.Point(235, 36);
            this.Year_February.Name = "Year_February";
            this.Year_February.Size = new System.Drawing.Size(152, 96);
            this.Year_February.TabIndex = 31;
            this.Year_February.Text = "February";
            this.Year_February.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Year_September
            // 
            this.Year_September.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Year_September.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_September.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_September.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_September.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_September.ForeColor = System.Drawing.Color.White;
            this.Year_September.Location = new System.Drawing.Point(53, 316);
            this.Year_September.Name = "Year_September";
            this.Year_September.Size = new System.Drawing.Size(152, 96);
            this.Year_September.TabIndex = 36;
            this.Year_September.Text = "September";
            this.Year_September.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Year_May
            // 
            this.Year_May.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Year_May.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_May.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_May.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_May.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_May.ForeColor = System.Drawing.Color.White;
            this.Year_May.Location = new System.Drawing.Point(53, 177);
            this.Year_May.Name = "Year_May";
            this.Year_May.Size = new System.Drawing.Size(152, 96);
            this.Year_May.TabIndex = 35;
            this.Year_May.Text = "May";
            this.Year_May.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Year_January
            // 
            this.Year_January.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Year_January.BackColor = System.Drawing.Color.LightSalmon;
            this.Year_January.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Year_January.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Year_January.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.Year_January.ForeColor = System.Drawing.Color.White;
            this.Year_January.Location = new System.Drawing.Point(53, 36);
            this.Year_January.Name = "Year_January";
            this.Year_January.Size = new System.Drawing.Size(152, 96);
            this.Year_January.TabIndex = 34;
            this.Year_January.Text = "January";
            this.Year_January.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Year
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Year";
            this.Size = new System.Drawing.Size(812, 480);
            this.Load += new System.EventHandler(this.Year_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Year_December;
        private System.Windows.Forms.Label Year_August;
        private System.Windows.Forms.Label Year_April;
        private System.Windows.Forms.Label Year_November;
        private System.Windows.Forms.Label Year_July;
        private System.Windows.Forms.Label Year_March;
        private System.Windows.Forms.Label Year_October;
        private System.Windows.Forms.Label Year_June;
        private System.Windows.Forms.Label Year_February;
        private System.Windows.Forms.Label Year_September;
        private System.Windows.Forms.Label Year_May;
        private System.Windows.Forms.Label Year_January;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel Year_Year;
    }
}
