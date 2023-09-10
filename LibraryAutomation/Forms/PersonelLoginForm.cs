using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.Forms
{
    public partial class PersonelLoginForm : Form
    {
        public string SelectedLibrary { get; }

        public PersonelLoginForm(string selectedLibrary)
        {
            InitializeComponent();
            SelectedLibrary = selectedLibrary;
            // Diğer işlemleriniz
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void buttonKaydet_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LightGray; // Üzerine gelindiğinde rengi değiştir
        }

        private void buttonKaydet_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = DefaultBackColor; // Fare çıkınca orijinal rengine döndür
        }

        private void buttonGirisYap_MouseEnter(object sender, EventArgs e)
        {
            btnEntry.BackColor = Color.LightGray; // Üzerine gelindiğinde rengi değiştir
        }

        private void buttonGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnEntry.BackColor = DefaultBackColor; // Fare çıkınca orijinal rengine döndür
        }

        private void groupBoxPersonelBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void PersonelLoginForm_Load(object sender, EventArgs e)
        {

        }

        

        private void cmbLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibrary.SelectedItem ==null)
            {
                
            }
        }

        // Diğer butonlar için aynı şekilde işlemleri yapabilirsiniz

    }
}