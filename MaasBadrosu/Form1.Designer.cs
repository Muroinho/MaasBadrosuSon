namespace MaasBadrosu
{
    partial class frmMaasBordrosu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliKullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblbrutucret = new System.Windows.Forms.Label();
            this.lblMedeniDurum = new System.Windows.Forms.Label();
            this.lblEsCalismaDurum = new System.Windows.Forms.Label();
            this.lblCocuksayisi = new System.Windows.Forms.Label();
            this.txtBrütUcret = new System.Windows.Forms.TextBox();
            this.cbxMedeniDurum = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDönem = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliKullanıcıToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // yetkiliKullanıcıToolStripMenuItem
            // 
            this.yetkiliKullanıcıToolStripMenuItem.Name = "yetkiliKullanıcıToolStripMenuItem";
            this.yetkiliKullanıcıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yetkiliKullanıcıToolStripMenuItem.Text = "Yetkili Kullanıcı";
            this.yetkiliKullanıcıToolStripMenuItem.Click += new System.EventHandler(this.yetkiliKullanıcıToolStripMenuItem_Click);
            // 
            // lblbrutucret
            // 
            this.lblbrutucret.AutoSize = true;
            this.lblbrutucret.Location = new System.Drawing.Point(75, 33);
            this.lblbrutucret.Name = "lblbrutucret";
            this.lblbrutucret.Size = new System.Drawing.Size(55, 13);
            this.lblbrutucret.TabIndex = 1;
            this.lblbrutucret.Text = "Brüt Ücret";
            // 
            // lblMedeniDurum
            // 
            this.lblMedeniDurum.AutoSize = true;
            this.lblMedeniDurum.Location = new System.Drawing.Point(54, 64);
            this.lblMedeniDurum.Name = "lblMedeniDurum";
            this.lblMedeniDurum.Size = new System.Drawing.Size(76, 13);
            this.lblMedeniDurum.TabIndex = 2;
            this.lblMedeniDurum.Text = "Medeni Durum";
            // 
            // lblEsCalismaDurum
            // 
            this.lblEsCalismaDurum.AutoSize = true;
            this.lblEsCalismaDurum.Location = new System.Drawing.Point(32, 92);
            this.lblEsCalismaDurum.Name = "lblEsCalismaDurum";
            this.lblEsCalismaDurum.Size = new System.Drawing.Size(98, 13);
            this.lblEsCalismaDurum.TabIndex = 3;
            this.lblEsCalismaDurum.Text = "Eş Çalışma Durumu";
            // 
            // lblCocuksayisi
            // 
            this.lblCocuksayisi.AutoSize = true;
            this.lblCocuksayisi.Location = new System.Drawing.Point(62, 121);
            this.lblCocuksayisi.Name = "lblCocuksayisi";
            this.lblCocuksayisi.Size = new System.Drawing.Size(68, 13);
            this.lblCocuksayisi.TabIndex = 4;
            this.lblCocuksayisi.Text = "Çocuk Sayısı";
            // 
            // txtBrütUcret
            // 
            this.txtBrütUcret.Location = new System.Drawing.Point(153, 26);
            this.txtBrütUcret.Name = "txtBrütUcret";
            this.txtBrütUcret.Size = new System.Drawing.Size(100, 20);
            this.txtBrütUcret.TabIndex = 5;
            // 
            // cbxMedeniDurum
            // 
            this.cbxMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedeniDurum.FormattingEnabled = true;
            this.cbxMedeniDurum.Items.AddRange(new object[] {
            "Evli",
            "Bekar",
            "Dul",
            "Boşanmış"});
            this.cbxMedeniDurum.Location = new System.Drawing.Point(153, 56);
            this.cbxMedeniDurum.Name = "cbxMedeniDurum";
            this.cbxMedeniDurum.Size = new System.Drawing.Size(100, 21);
            this.cbxMedeniDurum.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Çalışıyor",
            "Çalışmıyor"});
            this.comboBox1.Location = new System.Drawing.Point(153, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5 ve Üzeri"});
            this.comboBox2.Location = new System.Drawing.Point(153, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(369, 139);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(83, 25);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 303);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblDönem
            // 
            this.lblDönem.AutoSize = true;
            this.lblDönem.Location = new System.Drawing.Point(89, 151);
            this.lblDönem.Name = "lblDönem";
            this.lblDönem.Size = new System.Drawing.Size(41, 13);
            this.lblDönem.TabIndex = 12;
            this.lblDönem.Text = "Dönem";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // frmMaasBordrosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 553);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDönem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxMedeniDurum);
            this.Controls.Add(this.txtBrütUcret);
            this.Controls.Add(this.lblCocuksayisi);
            this.Controls.Add(this.lblEsCalismaDurum);
            this.Controls.Add(this.lblMedeniDurum);
            this.Controls.Add(this.lblbrutucret);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMaasBordrosu";
            this.Text = "Maaş Bordrosu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliKullanıcıToolStripMenuItem;
        private System.Windows.Forms.Label lblbrutucret;
        private System.Windows.Forms.Label lblMedeniDurum;
        private System.Windows.Forms.Label lblEsCalismaDurum;
        private System.Windows.Forms.Label lblCocuksayisi;
        private System.Windows.Forms.TextBox txtBrütUcret;
        private System.Windows.Forms.ComboBox cbxMedeniDurum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDönem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

