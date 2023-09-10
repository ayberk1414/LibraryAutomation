using LibraryAutomation.Forms;

namespace LibraryAutomation
{

    public partial class StartForm : Form
    {
        public string selectedLibrary = ""; // Se�ilen k�t�phaneyi burada saklayaca��z

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
            selectedLibrary = "��renci formu a��l�yor...";

            // 5 saniye beklet
            await Task.Delay(5000);

            // Formu g�ster ve mevcut formu gizle
            form.Show();
            this.Hide();
        }

        private async void OpenPersonelForm()
        {
            // Personel formunu olu�tur
            PersonelLoginForm form = new PersonelLoginForm(selectedLibrary);

            // Form kapat�ld���nda bu formu kapat
            form.FormClosed += (s, args) => this.Close();

            // "Personel formu a��l�yor..." mesaj�n� g�ster
            selectedLibrary = "Personel formu a��l�yor...";

            // 5 saniye beklet
            await Task.Delay(5000);

            // Formu g�ster ve mevcut formu gizle
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
