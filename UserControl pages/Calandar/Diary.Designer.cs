namespace NadhamniCSharp.UserControl_pages.Calandar
{
    partial class Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Diary_delete = new System.Windows.Forms.Button();
            this.Diary_edit = new System.Windows.Forms.Button();
            this.Diary_read = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.LabelDate);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 30);
            this.panel1.TabIndex = 0;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoEllipsis = false;
            this.LabelDate.CursorType = null;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDate.Location = new System.Drawing.Point(359, 3);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDate.Size = new System.Drawing.Size(75, 17);
            this.LabelDate.TabIndex = 0;
            this.LabelDate.Text = "Today Date";
            this.LabelDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.LabelDate.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.Diary_delete);
            this.panel2.Controls.Add(this.Diary_edit);
            this.panel2.Controls.Add(this.Diary_read);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 54);
            this.panel2.TabIndex = 1;
            // 
            // Diary_delete
            // 
            this.Diary_delete.BackColor = System.Drawing.Color.LightCoral;
            this.Diary_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diary_delete.Image = global::NadhamniCSharp.Properties.Resources.bin;
            this.Diary_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Diary_delete.Location = new System.Drawing.Point(422, 4);
            this.Diary_delete.Name = "Diary_delete";
            this.Diary_delete.Size = new System.Drawing.Size(105, 47);
            this.Diary_delete.TabIndex = 5;
            this.Diary_delete.Text = "         Delete";
            this.Diary_delete.UseVisualStyleBackColor = false;
            this.Diary_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // Diary_edit
            // 
            this.Diary_edit.BackColor = System.Drawing.Color.LightCoral;
            this.Diary_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diary_edit.Image = global::NadhamniCSharp.Properties.Resources.pencil;
            this.Diary_edit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Diary_edit.Location = new System.Drawing.Point(531, 4);
            this.Diary_edit.Name = "Diary_edit";
            this.Diary_edit.Size = new System.Drawing.Size(105, 47);
            this.Diary_edit.TabIndex = 5;
            this.Diary_edit.Text = "           Edit";
            this.Diary_edit.UseVisualStyleBackColor = false;
            // 
            // Diary_read
            // 
            this.Diary_read.BackColor = System.Drawing.Color.LightCoral;
            this.Diary_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diary_read.Image = global::NadhamniCSharp.Properties.Resources.podcast;
            this.Diary_read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Diary_read.Location = new System.Drawing.Point(640, 3);
            this.Diary_read.Name = "Diary_read";
            this.Diary_read.Size = new System.Drawing.Size(169, 47);
            this.Diary_read.TabIndex = 5;
            this.Diary_read.Text = "Read for me ";
            this.Diary_read.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 396);
            this.panel3.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(806, 390);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Diary";
            this.Size = new System.Drawing.Size(812, 480);
            this.Load += new System.EventHandler(this.Diary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuLabel LabelDate;
        private System.Windows.Forms.Button Diary_read;
        private System.Windows.Forms.Button Diary_delete;
        private System.Windows.Forms.Button Diary_edit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
