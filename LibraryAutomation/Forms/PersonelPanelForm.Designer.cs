using System.Windows.Forms;

namespace LibraryAutomation.Forms
{
    partial class PersonelPanelForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            
            txtper = new TextBox();
            groupBox1 = new GroupBox();
            txtperturara = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpersonelperyazarara = new TextBox();
            txtperkitapara = new TextBox();
            groupBox2 = new GroupBox();
            btnkitapistatistikleri = new Button();
            btnSil = new Button();
            btnDüzenle = new Button();
            btnEkle = new Button();
            datetimepickerper = new DateTimePicker();
            cmbpertur = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtperyazaradi = new TextBox();
            txtperkitapadi = new TextBox();
            groupBox3 = new GroupBox();
            btnreddet = new Button();
            btnteslimzamanigecenkitaplar = new Button();
            btnoduncverilenkitaplar = new Button();
            btnonaybekleyen = new Button();
            btnonayla = new Button();
            groupBox4 = new GroupBox();
            btnogrenciistatistikleri = new Button();
            btnogrenciuzaklastir = new Button();
            btnuzaklastirilanogrenci = new Button();
            btnogrencilistesi = new Button();
            label8 = new Label();
            txtogrenciara = new TextBox();
          
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dtper
            // 
            
            // 
            // txtper
            // 
            txtper.BackColor = Color.RosyBrown;
            txtper.Location = new Point(12, 12);
            txtper.Name = "txtper";
            txtper.Size = new Size(199, 26);
            txtper.TabIndex = 2;
            txtper.Text = "Hoşgeldin + Personel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtperturara);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtpersonelperyazarara);
            groupBox1.Controls.Add(txtperkitapara);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Arama İşlemleri";
            // 
            // txtperturara
            // 
            txtperturara.FormattingEnabled = true;
            txtperturara.Location = new Point(113, 97);
            txtperturara.Name = "txtperturara";
            txtperturara.Size = new Size(264, 27);
            txtperturara.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 1;
            label1.Text = "Kitap Ara:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 1;
            label2.Text = "Yazar Ara:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 1;
            label3.Text = "Tür Ara:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtpersonelperyazarara
            // 
            txtpersonelperyazarara.Location = new Point(113, 67);
            txtpersonelperyazarara.Name = "txtpersonelperyazarara";
            txtpersonelperyazarara.Size = new Size(264, 26);
            txtpersonelperyazarara.TabIndex = 2;
            // 
            // txtperkitapara
            // 
            txtperkitapara.Location = new Point(113, 32);
            txtperkitapara.Name = "txtperkitapara";
            txtperkitapara.Size = new Size(264, 26);
            txtperkitapara.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnkitapistatistikleri);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnDüzenle);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(datetimepickerper);
            groupBox2.Controls.Add(cmbpertur);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtperyazaradi);
            groupBox2.Controls.Add(txtperkitapadi);
            groupBox2.Location = new Point(504, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 227);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kütüphane Düzenleme İşlemleri";
            // 
            // btnkitapistatistikleri
            // 
            btnkitapistatistikleri.Location = new Point(139, 164);
            btnkitapistatistikleri.Name = "btnkitapistatistikleri";
            btnkitapistatistikleri.Size = new Size(238, 57);
            btnkitapistatistikleri.TabIndex = 3;
            btnkitapistatistikleri.Text = "Kitap İstatistikleri";
            btnkitapistatistikleri.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(383, 160);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(97, 56);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDüzenle
            // 
            btnDüzenle.Location = new Point(383, 98);
            btnDüzenle.Name = "btnDüzenle";
            btnDüzenle.Size = new Size(97, 56);
            btnDüzenle.TabIndex = 7;
            btnDüzenle.Text = "Düzenle";
            btnDüzenle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(383, 29);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(97, 56);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // datetimepickerper
            // 
            datetimepickerper.Format = DateTimePickerFormat.Short;
            datetimepickerper.Location = new Point(192, 94);
            datetimepickerper.Name = "datetimepickerper";
            datetimepickerper.Size = new Size(185, 26);
            datetimepickerper.TabIndex = 6;
            // 
            // cmbpertur
            // 
            cmbpertur.FormattingEnabled = true;
            cmbpertur.Location = new Point(192, 127);
            cmbpertur.Name = "cmbpertur";
            cmbpertur.Size = new Size(185, 27);
            cmbpertur.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 34);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 1;
            label4.Text = "Kitap Adı:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 96);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(180, 19);
            label7.TabIndex = 1;
            label7.Text = "Yazar Doğum Tarihi:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 66);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 1;
            label5.Text = "Yazar Adı:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 130);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 1;
            label6.Text = "Tür:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtperyazaradi
            // 
            txtperyazaradi.Location = new Point(192, 63);
            txtperyazaradi.Name = "txtperyazaradi";
            txtperyazaradi.Size = new Size(185, 26);
            txtperyazaradi.TabIndex = 2;
            // 
            // txtperkitapadi
            // 
            txtperkitapadi.Location = new Point(192, 31);
            txtperkitapadi.Name = "txtperkitapadi";
            txtperkitapadi.Size = new Size(185, 26);
            txtperkitapadi.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnreddet);
            groupBox3.Controls.Add(btnteslimzamanigecenkitaplar);
            groupBox3.Controls.Add(btnoduncverilenkitaplar);
            groupBox3.Controls.Add(btnonaybekleyen);
            groupBox3.Controls.Add(btnonayla);
            groupBox3.Location = new Point(12, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(477, 150);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödünç Onay İşlemleri";
            // 
            // btnreddet
            // 
            btnreddet.Location = new Point(163, 85);
            btnreddet.Name = "btnreddet";
            btnreddet.Size = new Size(150, 50);
            btnreddet.TabIndex = 3;
            btnreddet.Text = "Reddet";
            btnreddet.UseVisualStyleBackColor = true;
            // 
            // btnteslimzamanigecenkitaplar
            // 
            btnteslimzamanigecenkitaplar.Location = new Point(319, 25);
            btnteslimzamanigecenkitaplar.Name = "btnteslimzamanigecenkitaplar";
            btnteslimzamanigecenkitaplar.Size = new Size(150, 50);
            btnteslimzamanigecenkitaplar.TabIndex = 3;
            btnteslimzamanigecenkitaplar.Text = "Teslim Zamanı Geçen Kitaplar";
            btnteslimzamanigecenkitaplar.UseVisualStyleBackColor = true;
            // 
            // btnoduncverilenkitaplar
            // 
            btnoduncverilenkitaplar.Location = new Point(163, 25);
            btnoduncverilenkitaplar.Name = "btnoduncverilenkitaplar";
            btnoduncverilenkitaplar.Size = new Size(150, 50);
            btnoduncverilenkitaplar.TabIndex = 3;
            btnoduncverilenkitaplar.Text = "Ödünç Verilen Kitaplar";
            btnoduncverilenkitaplar.UseVisualStyleBackColor = true;
            // 
            // btnonaybekleyen
            // 
            btnonaybekleyen.Location = new Point(7, 25);
            btnonaybekleyen.Name = "btnonaybekleyen";
            btnonaybekleyen.Size = new Size(150, 50);
            btnonaybekleyen.TabIndex = 3;
            btnonaybekleyen.Text = "Onay Bekleyen Kitaplar";
            btnonaybekleyen.UseVisualStyleBackColor = true;
            // 
            // btnonayla
            // 
            btnonayla.Location = new Point(7, 85);
            btnonayla.Name = "btnonayla";
            btnonayla.Size = new Size(150, 50);
            btnonayla.TabIndex = 3;
            btnonayla.Text = "Onayla";
            btnonayla.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnogrenciistatistikleri);
            groupBox4.Controls.Add(btnogrenciuzaklastir);
            groupBox4.Controls.Add(btnuzaklastirilanogrenci);
            groupBox4.Controls.Add(btnogrencilistesi);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtogrenciara);
            groupBox4.Location = new Point(509, 288);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(553, 150);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Öğrenci Takip İşlemleri";
            // 
            // btnogrenciistatistikleri
            // 
            btnogrenciistatistikleri.Location = new Point(309, 18);
            btnogrenciistatistikleri.Name = "btnogrenciistatistikleri";
            btnogrenciistatistikleri.Size = new Size(238, 57);
            btnogrenciistatistikleri.TabIndex = 3;
            btnogrenciistatistikleri.Text = "Öğrenci İstatistikleri";
            btnogrenciistatistikleri.UseVisualStyleBackColor = true;
            // 
            // btnogrenciuzaklastir
            // 
            btnogrenciuzaklastir.Location = new Point(437, 85);
            btnogrenciuzaklastir.Name = "btnogrenciuzaklastir";
            btnogrenciuzaklastir.Size = new Size(110, 50);
            btnogrenciuzaklastir.TabIndex = 3;
            btnogrenciuzaklastir.Text = "Öğrenciyi Uzaklaştır";
            btnogrenciuzaklastir.UseVisualStyleBackColor = true;
            // 
            // btnuzaklastirilanogrenci
            // 
            btnuzaklastirilanogrenci.Location = new Point(238, 85);
            btnuzaklastirilanogrenci.Name = "btnuzaklastirilanogrenci";
            btnuzaklastirilanogrenci.Size = new Size(193, 50);
            btnuzaklastirilanogrenci.TabIndex = 3;
            btnuzaklastirilanogrenci.Text = "Uzaklaştırılan Öğrenci Listesi";
            btnuzaklastirilanogrenci.UseVisualStyleBackColor = true;
            // 
            // btnogrencilistesi
            // 
            btnogrencilistesi.Location = new Point(104, 85);
            btnogrencilistesi.Name = "btnogrencilistesi";
            btnogrencilistesi.Size = new Size(128, 50);
            btnogrencilistesi.TabIndex = 3;
            btnogrencilistesi.Text = "Öğrenci Listesi";
            btnogrencilistesi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 1;
            label8.Text = "Öğrenci :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtogrenciara
            // 
            txtogrenciara.Location = new Point(104, 22);
            txtogrenciara.Name = "txtogrenciara";
            txtogrenciara.Size = new Size(185, 26);
            txtogrenciara.TabIndex = 2;
            // 
            // PersonelPanelForm
            // 
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1074, 893);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtper);
       
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "PersonelPanelForm";
         
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ContextMenuStrip contextMenuStrip1;
        
        private TextBox txtper;
        private GroupBox groupBox1;
        private ComboBox txtperturara;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtpersonelperyazarara;
        private TextBox txtperkitapara;
        private GroupBox groupBox2;
        private Button btnSil;
        private Button btnDüzenle;
        private Button btnEkle;
        private DateTimePicker datetimepickerper;
        private ComboBox cmbpertur;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox txtperyazaradi;
        private TextBox txtperkitapadi;
        private GroupBox groupBox3;
        private Button btnreddet;
        private Button btnonaybekleyen;
        private Button btnonayla;
        private Button btnteslimzamanigecenkitaplar;
        private Button btnoduncverilenkitaplar;
        private GroupBox groupBox4;
        private Button btnogrenciuzaklastir;
        private Button btnuzaklastirilanogrenci;
        private Button btnogrencilistesi;
        private Label label8;
        private TextBox txtogrenciara;
        private Button btnkitapistatistikleri;
        private Button btnogrenciistatistikleri;
    }
}
#endregion