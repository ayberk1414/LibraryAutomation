namespace LibraryAutomation.Forms
{
    partial class StudentPanelForm
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
            txtkitapara = new Label();
            txtyazarara = new Label();
            txtturara = new Label();
            txtogrkitapara = new TextBox();
            txtogryazarara = new TextBox();
            btnokumatalebiolustur = new Button();
            groupBox1 = new GroupBox();
            cmbogrturara = new ComboBox();
            btnokumagecmisim = new Button();
            btnkitapiade = new Button();
            groupBox2 = new GroupBox();
            txtkitapadi = new Label();
            btnoduncgecmisim = new Button();
            btnodunctalebiolustur = new Button();
            txtyazaradi = new Label();
            textBox4 = new TextBox();
            txttur = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            txtogrenci = new TextBox();
            btnyenile = new Button();

            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtogr
           
            // 
            // txtkitapara
            // 
            txtkitapara.AutoSize = true;
            txtkitapara.Location = new Point(7, 35);
            txtkitapara.Margin = new Padding(4, 0, 4, 0);
            txtkitapara.Name = "txtkitapara";
            txtkitapara.Size = new Size(99, 19);
            txtkitapara.TabIndex = 1;
            txtkitapara.Text = "Kitap Ara:";
            txtkitapara.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtyazarara
            // 
            txtyazarara.AutoSize = true;
            txtyazarara.Location = new Point(5, 70);
            txtyazarara.Margin = new Padding(4, 0, 4, 0);
            txtyazarara.Name = "txtyazarara";
            txtyazarara.Size = new Size(99, 19);
            txtyazarara.TabIndex = 1;
            txtyazarara.Text = "Yazar Ara:";
            txtyazarara.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtturara
            // 
            txtturara.AutoSize = true;
            txtturara.Location = new Point(25, 105);
            txtturara.Margin = new Padding(4, 0, 4, 0);
            txtturara.Name = "txtturara";
            txtturara.Size = new Size(81, 19);
            txtturara.TabIndex = 1;
            txtturara.Text = "Tür Ara:";
            txtturara.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtogrkitapara
            // 
            txtogrkitapara.Location = new Point(113, 32);
            txtogrkitapara.Name = "txtogrkitapara";
            txtogrkitapara.Size = new Size(264, 26);
            txtogrkitapara.TabIndex = 2;
            // 
            // txtogryazarara
            // 
            txtogryazarara.Location = new Point(113, 67);
            txtogryazarara.Name = "txtogryazarara";
            txtogryazarara.Size = new Size(264, 26);
            txtogryazarara.TabIndex = 2;
            // 
            // btnokumatalebiolustur
            // 
            btnokumatalebiolustur.Location = new Point(113, 131);
            btnokumatalebiolustur.Name = "btnokumatalebiolustur";
            btnokumatalebiolustur.Size = new Size(129, 54);
            btnokumatalebiolustur.TabIndex = 3;
            btnokumatalebiolustur.Text = "Okuma Talebi Oluştur";
            btnokumatalebiolustur.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbogrturara);
            groupBox1.Controls.Add(txtkitapara);
            groupBox1.Controls.Add(btnokumagecmisim);
            groupBox1.Controls.Add(btnokumatalebiolustur);
            groupBox1.Controls.Add(txtyazarara);
            groupBox1.Controls.Add(txtturara);
            groupBox1.Controls.Add(txtogryazarara);
            groupBox1.Controls.Add(txtogrkitapara);
            groupBox1.Location = new Point(15, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 213);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Arama İşlemleri";
            // 
            // cmbogrturara
            // 
            cmbogrturara.FormattingEnabled = true;
            cmbogrturara.Location = new Point(113, 97);
            cmbogrturara.Name = "cmbogrturara";
            cmbogrturara.Size = new Size(264, 27);
            cmbogrturara.TabIndex = 5;
            // 
            // btnokumagecmisim
            // 
            btnokumagecmisim.Location = new Point(248, 131);
            btnokumagecmisim.Name = "btnokumagecmisim";
            btnokumagecmisim.Size = new Size(129, 54);
            btnokumagecmisim.TabIndex = 3;
            btnokumagecmisim.Text = "Okuma Geçmişim";
            btnokumagecmisim.UseVisualStyleBackColor = true;
            // 
            // btnkitapiade
            // 
            btnkitapiade.Location = new Point(667, 331);
            btnkitapiade.Name = "btnkitapiade";
            btnkitapiade.Size = new Size(264, 46);
            btnkitapiade.TabIndex = 4;
            btnkitapiade.Text = "Kitabı İade Et";
            btnkitapiade.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtkitapadi);
            groupBox2.Controls.Add(btnoduncgecmisim);
            groupBox2.Controls.Add(btnodunctalebiolustur);
            groupBox2.Controls.Add(txtyazaradi);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(txttur);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(554, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 213);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç İşlemleri";
            // 
            // txtkitapadi
            // 
            txtkitapadi.AutoSize = true;
            txtkitapadi.Location = new Point(7, 35);
            txtkitapadi.Margin = new Padding(4, 0, 4, 0);
            txtkitapadi.Name = "txtkitapadi";
            txtkitapadi.Size = new Size(99, 19);
            txtkitapadi.TabIndex = 1;
            txtkitapadi.Text = "Kitap Adı:";
            txtkitapadi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnoduncgecmisim
            // 
            btnoduncgecmisim.Location = new Point(248, 131);
            btnoduncgecmisim.Name = "btnoduncgecmisim";
            btnoduncgecmisim.Size = new Size(129, 54);
            btnoduncgecmisim.TabIndex = 3;
            btnoduncgecmisim.Text = "Ödünç Geçmişim";
            btnoduncgecmisim.UseVisualStyleBackColor = true;
            // 
            // btnodunctalebiolustur
            // 
            btnodunctalebiolustur.Location = new Point(113, 131);
            btnodunctalebiolustur.Name = "btnodunctalebiolustur";
            btnodunctalebiolustur.Size = new Size(129, 54);
            btnodunctalebiolustur.TabIndex = 3;
            btnodunctalebiolustur.Text = "Ödünç Talebi Oluştur";
            btnodunctalebiolustur.UseVisualStyleBackColor = true;
            // 
            // txtyazaradi
            // 
            txtyazaradi.AutoSize = true;
            txtyazaradi.Location = new Point(5, 70);
            txtyazaradi.Margin = new Padding(4, 0, 4, 0);
            txtyazaradi.Name = "txtyazaradi";
            txtyazaradi.Size = new Size(99, 19);
            txtyazaradi.TabIndex = 1;
            txtyazaradi.Text = "Yazar Adı:";
            txtyazaradi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 26);
            textBox4.TabIndex = 2;
            // 
            // txttur
            // 
            txttur.AutoSize = true;
            txttur.Location = new Point(59, 105);
            txttur.Margin = new Padding(4, 0, 4, 0);
            txttur.Name = "txttur";
            txttur.Size = new Size(45, 19);
            txttur.TabIndex = 1;
            txttur.Text = "Tür:";
            txttur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 26);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 32);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 26);
            textBox6.TabIndex = 2;
            // 
            // txtogrenci
            // 
            txtogrenci.BackColor = Color.RosyBrown;
            txtogrenci.Font = new Font("Segoe Script", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txtogrenci.Location = new Point(128, 12);
            txtogrenci.Name = "txtogrenci";
            txtogrenci.Size = new Size(803, 38);
            txtogrenci.TabIndex = 5;
            txtogrenci.Text = "Hoşgeldin + Öğrenci +! + Umarız harika vakit geçirirsin...";
            txtogrenci.TextAlign = HorizontalAlignment.Center;
            // 
            // btnyenile
            // 
            btnyenile.Location = new Point(128, 331);
            btnyenile.Name = "btnyenile";
            btnyenile.Size = new Size(264, 46);
            btnyenile.TabIndex = 4;
            btnyenile.Text = "Yenile";
            btnyenile.UseVisualStyleBackColor = true;
            // 
            // StudentPanelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1046, 855);
            Controls.Add(btnyenile);
            Controls.Add(btnkitapiade);
            Controls.Add(txtogrenci);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
         
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StudentPanelForm";
            Text = "StudentPanelForm";
         
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

       
        private Label txtkitapara;
        private Label txtyazarara;
        private Label txtturara;
        private TextBox txtogrkitapara;
        private TextBox txtogryazarara;
        private Button btnokumatalebiolustur;
        private GroupBox groupBox1;
        private Button btnkitapiade;
        private Button btnokumagecmisim;
        private GroupBox groupBox2;
        private Label txtkitapadi;
        private Button btnoduncgecmisim;
        private Button btnodunctalebiolustur;
        private Label txtyazaradi;
        private TextBox textBox4;
        private Label txttur;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox cmbogrturara;
        private TextBox txtogrenci;
        private Button btnyenile;
    }
}