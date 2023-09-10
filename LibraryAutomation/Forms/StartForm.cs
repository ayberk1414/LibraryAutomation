using LibraryAutomation.Forms;

namespace LibraryAutomation
{

    public partial class StartForm : Form
    {
        public string selectedLibrary = ""; // Seçilen kütüphaneyi burada saklayacaðýz

        public StartForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtTitle.ForeColor = SystemColors.GrayText;
        }

        private void CloseApplication()
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseApplication();
        }

        private async void OpenStudentForm()
        {
            StudentLoginForm form = new StudentLoginForm(selectedLibrary);
            form.FormClosed += (s, args) => this.Close();
            selectedLibrary = "Öðrenci formu açýlýyor...";

            // 5 saniye beklet
            await Task.Delay(5000);

            // Formu göster ve mevcut formu gizle
            form.Show();
            this.Hide();
        }

        private async void OpenPersonelForm()
        {
            // Personel formunu oluþtur
            PersonelLoginForm form = new PersonelLoginForm(selectedLibrary);

            // Form kapatýldýðýnda bu formu kapat
            form.FormClosed += (s, args) => this.Close();

            // "Personel formu açýlýyor..." mesajýný göster
            selectedLibrary = "Personel formu açýlýyor...";

            // 5 saniye beklet
            await Task.Delay(5000);

            // Formu göster ve mevcut formu gizle
            form.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenStudentForm();
            if (!string.IsNullOrEmpty(selectedLibrary))
            {
                txtTitle.Text = selectedLibrary;
            }
            else
            {
                txtTitle.Text = "HATA.";
            }
        }

        private void btnPersonel_Click_1(object sender, EventArgs e)
        {
            OpenPersonelForm();

            if (!string.IsNullOrEmpty(selectedLibrary))
            {
                txtTitle.Text = selectedLibrary;
            }
            else
            {
                txtTitle.Text = "HATA.";
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
