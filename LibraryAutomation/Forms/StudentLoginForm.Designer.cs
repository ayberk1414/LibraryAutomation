namespace LibraryAutomation.Forms
{
    partial class StudentLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            mskLoginTCKN = new MaskedTextBox();
            label5 = new Label();
            cmbLoginLibrary = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentPassword = new TextBox();
            mskStudentTCKN = new MaskedTextBox();
            cmbStudentLibrary = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            txtStudentSurname = new TextBox();
            btnStudentRegister = new Button();
            label11 = new Label();
            cmbStudentGender = new ComboBox();
            txtStudentName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(770, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.FloralWhite;
            label1.Image = Properties.Resources.pxfuel;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 7;
            label1.Text = "Giriş Yap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FloralWhite;
            label2.Image = Properties.Resources.pxfuel;
            label2.Location = new Point(48, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 7;
            label2.Text = "TCKN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.FloralWhite;
            label3.Image = Properties.Resources.pxfuel;
            label3.Location = new Point(39, 90);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = Properties.Resources.pxfuel;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(134, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 38);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(134, 83);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(115, 26);
            txtLoginPassword.TabIndex = 9;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // mskLoginTCKN
            // 
            mskLoginTCKN.Location = new Point(134, 51);
            mskLoginTCKN.Mask = "00000000000";
            mskLoginTCKN.Name = "mskLoginTCKN";
            mskLoginTCKN.Size = new Size(115, 26);
            mskLoginTCKN.TabIndex = 10;
            mskLoginTCKN.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.FloralWhite;
            label5.Image = Properties.Resources.pxfuel;
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 7;
            label5.Text = "Kütüphane:";
            // 
            // cmbLoginLibrary
            // 
            cmbLoginLibrary.FormattingEnabled = true;
            cmbLoginLibrary.Location = new Point(134, 118);
            cmbLoginLibrary.Name = "cmbLoginLibrary";
            cmbLoginLibrary.Size = new Size(115, 27);
            cmbLoginLibrary.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.ForeColor = Color.FloralWhite;
            label6.Image = Properties.Resources.pxfuel;
            label6.Location = new Point(408, 9);
            label6.Name = "label6";
            label6.Size = new Size(117, 19);
            label6.TabIndex = 7;
            label6.Text = "Yeni Öğrenci";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.FloralWhite;
            label4.Image = Properties.Resources.pxfuel;
            label4.Location = new Point(340, 51);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 7;
            label4.Text = "TCKN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.ForeColor = Color.FloralWhite;
            label7.Image = Properties.Resources.pxfuel;
            label7.Location = new Point(552, 55);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 7;
            label7.Text = "Şifre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.ForeColor = Color.FloralWhite;
            label8.Image = Properties.Resources.pxfuel;
            label8.Location = new Point(295, 126);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 7;
            label8.Text = "Kütüphane:";
            // 
            // txtStudentPassword
            // 
            txtStudentPassword.Location = new Point(631, 48);
            txtStudentPassword.Name = "txtStudentPassword";
            txtStudentPassword.Size = new Size(115, 26);
            txtStudentPassword.TabIndex = 9;
            txtStudentPassword.UseSystemPasswordChar = true;
            // 
            // mskStudentTCKN
            // 
            mskStudentTCKN.Location = new Point(410, 48);
            mskStudentTCKN.Mask = "00000000000";
            mskStudentTCKN.Name = "mskStudentTCKN";
            mskStudentTCKN.Size = new Size(115, 26);
            mskStudentTCKN.TabIndex = 10;
            mskStudentTCKN.ValidatingType = typeof(int);
            // 
            // cmbStudentLibrary
            // 
            cmbStudentLibrary.FormattingEnabled = true;
            cmbStudentLibrary.Location = new Point(410, 118);
            cmbStudentLibrary.Name = "cmbStudentLibrary";
            cmbStudentLibrary.Size = new Size(115, 27);
            cmbStudentLibrary.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.ForeColor = Color.FloralWhite;
            label9.Image = Properties.Resources.pxfuel;
            label9.Location = new Point(358, 86);
            label9.Name = "label9";
            label9.Size = new Size(36, 19);
            label9.TabIndex = 7;
            label9.Text = "Ad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.ForeColor = Color.FloralWhite;
            label10.Image = Properties.Resources.pxfuel;
            label10.Location = new Point(552, 88);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 7;
            label10.Text = "Soyad:";
            // 
            // txtStudentSurname
            // 
            txtStudentSurname.Location = new Point(631, 83);
            txtStudentSurname.Name = "txtStudentSurname";
            txtStudentSurname.Size = new Size(115, 26);
            txtStudentSurname.TabIndex = 12;
            // 
            // btnStudentRegister
            // 
            btnStudentRegister.BackgroundImage = Properties.Resources.pxfuel;
            btnStudentRegister.FlatStyle = FlatStyle.Popup;
            btnStudentRegister.ForeColor = SystemColors.ButtonFace;
            btnStudentRegister.Location = new Point(410, 160);
            btnStudentRegister.Name = "btnStudentRegister";
            btnStudentRegister.Size = new Size(115, 38);
            btnStudentRegister.TabIndex = 8;
            btnStudentRegister.Text = "Kayıt Ol";
            btnStudentRegister.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.ForeColor = Color.FloralWhite;
            label11.Image = Properties.Resources.pxfuel;
            label11.Location = new Point(535, 121);
            label11.Name = "label11";
            label11.Size = new Size(90, 19);
            label11.TabIndex = 7;
            label11.Text = "Cinsiyet:";
            // 
            // cmbStudentGender
            // 
            cmbStudentGender.FormattingEnabled = true;
            cmbStudentGender.Location = new Point(631, 118);
            cmbStudentGender.Name = "cmbStudentGender";
            cmbStudentGender.Size = new Size(115, 27);
            cmbStudentGender.TabIndex = 11;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(410, 83);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(115, 26);
            txtStudentName.TabIndex = 12;
            // 
            // StudentLoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(770, 369);
            Controls.Add(txtStudentSurname);
            Controls.Add(txtStudentName);
            Controls.Add(cmbStudentGender);
            Controls.Add(cmbStudentLibrary);
            Controls.Add(cmbLoginLibrary);
            Controls.Add(mskStudentTCKN);
            Controls.Add(mskLoginTCKN);
            Controls.Add(txtStudentPassword);
            Controls.Add(txtLoginPassword);
            Controls.Add(btnStudentRegister);
            Controls.Add(btnLogin);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "StudentLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private MaskedTextBox mskLoginTCKN;
        private Label label5;
        private ComboBox cmbLoginLibrary;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtStudentPassword;
        private MaskedTextBox mskStudentTCKN;
        private ComboBox cmbStudentLibrary;
        private Label label9;
        private Label label10;
        private TextBox txtStudentSurname;
        private Button btnStudentRegister;
        private Label label11;
        private ComboBox cmbStudentGender;
        private TextBox txtStudentName;
    }
}