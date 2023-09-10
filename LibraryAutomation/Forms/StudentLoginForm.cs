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
    public partial class StudentLoginForm : Form
    {
        public string SelectedLibrary { get; } // Özelliği burada tanımlıyoruz

        public StudentLoginForm(string selectedLibrary)
        {
            InitializeComponent();
            SelectedLibrary = selectedLibrary;
            label1.Text = SelectedLibrary;
            this.Text = selectedLibrary;
        }


    }

}