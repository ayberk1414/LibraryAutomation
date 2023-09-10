namespace LibraryAutomation.Forms
{
    partial class PersonelLoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelLoginForm));
            groupBoxPersonelBilgileri = new GroupBox();
            labelIsim = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelSoyad = new Label();
            dtpDate = new DateTimePicker();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            txtLastName = new TextBox();
            labelDogumTarihi = new Label();
            label3 = new Label();
            labelCinsiyet = new Label();
            cmbLibrary = new ComboBox();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            groupBoxTCKN = new GroupBox();
            labelTCKN = new Label();
            txtLoginUser = new TextBox();
            labelSifre = new Label();
            txtLoginPassword = new TextBox();
            btnEntry = new Button();
            pictureBox1 = new PictureBox();
            groupBoxPersonelBilgileri.SuspendLayout();
            groupBoxTCKN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPersonelBilgileri
            // 
            groupBoxPersonelBilgileri.Controls.Add(labelIsim);
            groupBoxPersonelBilgileri.Controls.Add(txtName);
            groupBoxPersonelBilgileri.Controls.Add(label1);
            groupBoxPersonelBilgileri.Controls.Add(label2);
            groupBoxPersonelBilgileri.Controls.Add(labelSoyad);
            groupBoxPersonelBilgileri.Controls.Add(dtpDate);
            groupBoxPersonelBilgileri.Controls.Add(txtPassword);
            groupBoxPersonelBilgileri.Controls.Add(txtUser);
            groupBoxPersonelBilgileri.Controls.Add(txtLastName);
            groupBoxPersonelBilgileri.Controls.Add(labelDogumTarihi);
            groupBoxPersonelBilgileri.Controls.Add(label3);
            groupBoxPersonelBilgileri.Controls.Add(labelCinsiyet);
            groupBoxPersonelBilgileri.Controls.Add(cmbLibrary);
            groupBoxPersonelBilgileri.Controls.Add(cmbGender);
            groupBoxPersonelBilgileri.Controls.Add(btnAdd);
            groupBoxPersonelBilgileri.Location = new Point(36, 254);
            groupBoxPersonelBilgileri.Name = "groupBoxPersonelBilgileri";
            groupBoxPersonelBilgileri.Size = new Size(282, 322);
            groupBoxPersonelBilgileri.TabIndex = 0;
            groupBoxPersonelBilgileri.TabStop = false;
            groupBoxPersonelBilgileri.Text = "Yeni Personel Bilgileri";
            groupBoxPersonelBilgileri.Enter += groupBoxPersonelBilgileri_Enter;
            // 
            // labelIsim
            // 
            labelIsim.Location = new Point(20, 33);
            labelIsim.Name = "labelIsim";
            labelIsim.Size = new Size(100, 20);
            labelIsim.TabIndex = 0;
            labelIsim.Text = "İsim:";
            labelIsim.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(20, 240);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Şifre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(20, 111);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSoyad
            // 
            labelSoyad.Location = new Point(20, 73);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(100, 20);
            labelSoyad.TabIndex = 2;
            labelSoyad.Text = "Soyad:";
            labelSoyad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(142, 208);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(125, 23);
            dtpDate.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(142, 108);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 23);
            txtUser.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(142, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 23);
            txtLastName.TabIndex = 3;
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.Location = new Point(20, 208);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(100, 20);
            labelDogumTarihi.TabIndex = 4;
            labelDogumTarihi.Text = "Doğum Tarihi:";
            labelDogumTarihi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(20, 177);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 6;
            label3.Text = "Kütüphane:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.Location = new Point(20, 145);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(100, 20);
            labelCinsiyet.TabIndex = 6;
            labelCinsiyet.Text = "Cinsiyet:";
            labelCinsiyet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbLibrary
            // 
            cmbLibrary.Location = new Point(142, 174);
            cmbLibrary.Name = "cmbLibrary";
            cmbLibrary.Size = new Size(125, 23);
            cmbLibrary.TabIndex = 7;
            cmbLibrary.SelectedIndexChanged += cmbLibrary_SelectedIndexChanged;
            // 
            // cmbGender
            // 
            cmbGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbGender.Location = new Point(142, 142);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(125, 23);
            cmbGender.TabIndex = 7;
         
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 45);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Kaydet";
            btnAdd.Click += buttonKaydet_Click;
            btnAdd.MouseEnter += buttonKaydet_MouseEnter;
            btnAdd.MouseLeave += buttonKaydet_MouseLeave;
            // 
            // groupBoxTCKN
            // 
            groupBoxTCKN.Controls.Add(labelTCKN);
            groupBoxTCKN.Controls.Add(txtLoginUser);
            groupBoxTCKN.Controls.Add(labelSifre);
            groupBoxTCKN.Controls.Add(txtLoginPassword);
            groupBoxTCKN.Controls.Add(btnEntry);
            groupBoxTCKN.Location = new Point(401, 254);
            groupBoxTCKN.Name = "groupBoxTCKN";
            groupBoxTCKN.Size = new Size(249, 153);
            groupBoxTCKN.TabIndex = 1;
            groupBoxTCKN.TabStop = false;
            groupBoxTCKN.Text = "Personel Giriş";
            // 
            // labelTCKN
            // 
            labelTCKN.Location = new Point(11, 23);
            labelTCKN.Name = "labelTCKN";
            labelTCKN.Size = new Size(82, 20);
            labelTCKN.TabIndex = 0;
            labelTCKN.Text = "Kullanıcı Adı:";
            labelTCKN.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(93, 23);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(125, 23);
            txtLoginUser.TabIndex = 1;
            // 
            // labelSifre
            // 
            labelSifre.Location = new Point(11, 63);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(82, 20);
            labelSifre.TabIndex = 2;
            labelSifre.Text = "Şifre:";
            labelSifre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(93, 63);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(125, 23);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnEntry
            // 
            btnEntry.Location = new Point(93, 92);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(75, 45);
            btnEntry.TabIndex = 4;
            btnEntry.Text = "Giriş Yap";
            btnEntry.Click += buttonGirisYap_Click;
            btnEntry.MouseEnter += buttonGirisYap_MouseEnter;
            btnEntry.MouseLeave += buttonGirisYap_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(693, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PersonelLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(718, 591);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxPersonelBilgileri);
            Controls.Add(groupBoxTCKN);
            Name = "PersonelLoginForm";
            Text = "Personel Girişi";
            Load += PersonelLoginForm_Load;
            groupBoxPersonelBilgileri.ResumeLayout(false);
            groupBoxPersonelBilgileri.PerformLayout();
            groupBoxTCKN.ResumeLayout(false);
            groupBoxTCKN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private GroupBox groupBoxPersonelBilgileri;
        private Label labelIsim;
        private TextBox txtName;
        private Label labelSoyad;
        private TextBox txtLastName;
        private Label labelDogumTarihi;
        private DateTimePicker dtpDate;
        private Label labelCinsiyet;
        private ComboBox cmbGender;
        private Button btnAdd;

        private GroupBox groupBoxTCKN;
        private Label labelTCKN;
        private TextBox txtLoginUser;
        private Label labelSifre;
        private TextBox txtLoginPassword;
        private Button btnEntry;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label3;
        private ComboBox cmbLibrary;
    }
}
