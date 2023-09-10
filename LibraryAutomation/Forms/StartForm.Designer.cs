namespace LibraryAutomation
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnStudent = new Button();
            btnClose = new Button();
            btnPersonel = new Button();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(140, 88);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Yeni Nesil Kütüphane";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.BlanchedAlmond;
            btnStudent.FlatStyle = FlatStyle.Popup;
            btnStudent.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = SystemColors.HotTrack;
            btnStudent.Location = new Point(108, 335);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(75, 46);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Öğrenci";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.BlanchedAlmond;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.HotTrack;
            btnClose.Location = new Point(108, 387);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(174, 31);
            btnClose.TabIndex = 5;
            btnClose.Text = "Çikiş";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.BackColor = Color.BlanchedAlmond;
            btnPersonel.FlatStyle = FlatStyle.Popup;
            btnPersonel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonel.ForeColor = SystemColors.HotTrack;
            btnPersonel.Location = new Point(207, 335);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(75, 46);
            btnPersonel.TabIndex = 4;
            btnPersonel.Text = "Personel";
            btnPersonel.UseVisualStyleBackColor = false;
            btnPersonel.Click += btnPersonel_Click_1;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.BlanchedAlmond;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.CharacterCasing = CharacterCasing.Upper;
            txtTitle.Font = new Font("Segoe Script", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(12, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(389, 34);
            txtTitle.TabIndex = 6;
            txtTitle.Text = "YENİ NESİL KÜTÜPHANE";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 454);
            Controls.Add(txtTitle);
            Controls.Add(btnClose);
            Controls.Add(btnPersonel);
            Controls.Add(btnStudent);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            TopMost = true;
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnStudent;
        private Button btnClose;
        private Button btnPersonel;
        private TextBox txtTitle;
    }
}