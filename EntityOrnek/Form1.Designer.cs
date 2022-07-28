
namespace EntityOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnOgrListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBul = new DevExpress.XtraEditors.SimpleButton();
            this.grpOgrenci = new DevExpress.XtraEditors.GroupControl();
            this.txtOgrFoto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtOgrID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpSınavlar = new DevExpress.XtraEditors.GroupControl();
            this.btnNotGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnHesapla = new DevExpress.XtraEditors.SimpleButton();
            this.txtDurum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrtalama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBut = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFinal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtVize = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grpDers = new DevExpress.XtraEditors.GroupControl();
            this.BtnDersGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDersSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDersKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtDersAd = new DevExpress.XtraEditors.TextEdit();
            this.BtnDersListe = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDersID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.BtnNotListe = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioSirala = new System.Windows.Forms.RadioButton();
            this.BtnSirala = new DevExpress.XtraEditors.SimpleButton();
            this.radioSiralaTers = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.radioKiz = new System.Windows.Forms.RadioButton();
            this.radiVizeOrt = new System.Windows.Forms.RadioButton();
            this.radioOrtUstu = new System.Windows.Forms.RadioButton();
            this.radiOrtalama = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenci)).BeginInit();
            this.grpOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSınavlar)).BeginInit();
            this.grpSınavlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtalama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDers)).BeginInit();
            this.grpDers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDersAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDersID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOgrListele
            // 
            this.BtnOgrListele.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnOgrListele.Appearance.Options.UseBackColor = true;
            this.BtnOgrListele.Location = new System.Drawing.Point(87, 229);
            this.BtnOgrListele.Name = "BtnOgrListele";
            this.BtnOgrListele.Size = new System.Drawing.Size(129, 32);
            this.BtnOgrListele.TabIndex = 1;
            this.BtnOgrListele.Text = "Öğrenci Listele";
            this.BtnOgrListele.Click += new System.EventHandler(this.BtnOgrListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Location = new System.Drawing.Point(87, 278);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(129, 32);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Location = new System.Drawing.Point(87, 321);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(129, 32);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Location = new System.Drawing.Point(87, 372);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 32);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnBul.Appearance.Options.UseBackColor = true;
            this.BtnBul.Location = new System.Drawing.Point(1091, 339);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(104, 32);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpOgrenci.CaptionImageOptions.Image")));
            this.grpOgrenci.Controls.Add(this.txtOgrFoto);
            this.grpOgrenci.Controls.Add(this.labelControl3);
            this.grpOgrenci.Controls.Add(this.txtOgrSoyad);
            this.grpOgrenci.Controls.Add(this.labelControl4);
            this.grpOgrenci.Controls.Add(this.txtOgrAd);
            this.grpOgrenci.Controls.Add(this.labelControl2);
            this.grpOgrenci.Controls.Add(this.BtnGuncelle);
            this.grpOgrenci.Controls.Add(this.txtOgrID);
            this.grpOgrenci.Controls.Add(this.BtnSil);
            this.grpOgrenci.Controls.Add(this.labelControl1);
            this.grpOgrenci.Controls.Add(this.BtnKaydet);
            this.grpOgrenci.Controls.Add(this.BtnOgrListele);
            this.grpOgrenci.Location = new System.Drawing.Point(21, 285);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(333, 445);
            this.grpOgrenci.TabIndex = 6;
            this.grpOgrenci.Text = "Öğrenci";
            // 
            // txtOgrFoto
            // 
            this.txtOgrFoto.Location = new System.Drawing.Point(154, 168);
            this.txtOgrFoto.Name = "txtOgrFoto";
            this.txtOgrFoto.Size = new System.Drawing.Size(129, 20);
            this.txtOgrFoto.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 15);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "FOTOĞRAF :";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(154, 130);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtOgrSoyad.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(50, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 15);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "SOYAD :";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(154, 85);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(129, 20);
            this.txtOgrAd.TabIndex = 17;
            this.txtOgrAd.EditValueChanged += new System.EventHandler(this.txtOgrAd_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 15);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "AD :";
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(154, 47);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(129, 20);
            this.txtOgrID.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 15);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "ID :";
            // 
            // grpSınavlar
            // 
            this.grpSınavlar.Appearance.BackColor = System.Drawing.Color.Azure;
            this.grpSınavlar.Appearance.Options.UseBackColor = true;
            this.grpSınavlar.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.grpSınavlar.AppearanceCaption.Options.UseBackColor = true;
            this.grpSınavlar.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpSınavlar.CaptionImageOptions.Image")));
            this.grpSınavlar.Controls.Add(this.btnNotGuncelle);
            this.grpSınavlar.Controls.Add(this.btnHesapla);
            this.grpSınavlar.Controls.Add(this.txtDurum);
            this.grpSınavlar.Controls.Add(this.labelControl9);
            this.grpSınavlar.Controls.Add(this.txtOrtalama);
            this.grpSınavlar.Controls.Add(this.labelControl5);
            this.grpSınavlar.Controls.Add(this.txtBut);
            this.grpSınavlar.Controls.Add(this.labelControl6);
            this.grpSınavlar.Controls.Add(this.txtFinal);
            this.grpSınavlar.Controls.Add(this.labelControl7);
            this.grpSınavlar.Controls.Add(this.txtVize);
            this.grpSınavlar.Controls.Add(this.labelControl8);
            this.grpSınavlar.Location = new System.Drawing.Point(741, 285);
            this.grpSınavlar.Name = "grpSınavlar";
            this.grpSınavlar.Size = new System.Drawing.Size(333, 445);
            this.grpSınavlar.TabIndex = 7;
            this.grpSınavlar.Text = "Sınav";
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnNotGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGuncelle.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotGuncelle.Appearance.Options.UseBackColor = true;
            this.btnNotGuncelle.Appearance.Options.UseFont = true;
            this.btnNotGuncelle.Appearance.Options.UseForeColor = true;
            this.btnNotGuncelle.Appearance.Options.UseTextOptions = true;
            this.btnNotGuncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnNotGuncelle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNotGuncelle.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnNotGuncelle.AppearanceDisabled.Options.UseBackColor = true;
            this.btnNotGuncelle.Location = new System.Drawing.Point(105, 350);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(129, 32);
            this.btnNotGuncelle.TabIndex = 25;
            this.btnNotGuncelle.Text = "Sınav Notu Güncelle";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnHesapla.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnHesapla.Appearance.Options.UseBackColor = true;
            this.btnHesapla.Appearance.Options.UseForeColor = true;
            this.btnHesapla.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapla.AppearancePressed.Options.UseBackColor = true;
            this.btnHesapla.Location = new System.Drawing.Point(105, 288);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(129, 32);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "Hesapla";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(154, 224);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(129, 20);
            this.txtDurum.TabIndex = 23;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(50, 229);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 15);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "DURUM :";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(154, 178);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(129, 20);
            this.txtOrtalama.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(50, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 15);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "ORTALAMA :";
            // 
            // txtBut
            // 
            this.txtBut.Location = new System.Drawing.Point(154, 137);
            this.txtBut.Name = "txtBut";
            this.txtBut.Size = new System.Drawing.Size(129, 20);
            this.txtBut.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(50, 142);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 15);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "BÜT :";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(154, 93);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(129, 20);
            this.txtFinal.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(50, 98);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 15);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "FİNAL :";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(154, 55);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(129, 20);
            this.txtVize.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(50, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 15);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Vize :";
            // 
            // grpDers
            // 
            this.grpDers.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpDers.Appearance.Options.UseBackColor = true;
            this.grpDers.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpDers.CaptionImageOptions.Image")));
            this.grpDers.Controls.Add(this.BtnDersGuncelle);
            this.grpDers.Controls.Add(this.BtnDersSil);
            this.grpDers.Controls.Add(this.BtnDersKaydet);
            this.grpDers.Controls.Add(this.txtDersAd);
            this.grpDers.Controls.Add(this.BtnDersListe);
            this.grpDers.Controls.Add(this.labelControl11);
            this.grpDers.Controls.Add(this.txtDersID);
            this.grpDers.Controls.Add(this.labelControl12);
            this.grpDers.Location = new System.Drawing.Point(383, 285);
            this.grpDers.Name = "grpDers";
            this.grpDers.Size = new System.Drawing.Size(333, 321);
            this.grpDers.TabIndex = 8;
            this.grpDers.Text = "Ders";
            // 
            // BtnDersGuncelle
            // 
            this.BtnDersGuncelle.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnDersGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnDersGuncelle.Location = new System.Drawing.Point(107, 274);
            this.BtnDersGuncelle.Name = "BtnDersGuncelle";
            this.BtnDersGuncelle.Size = new System.Drawing.Size(129, 32);
            this.BtnDersGuncelle.TabIndex = 20;
            this.BtnDersGuncelle.Text = "Ders Güncelle";
            // 
            // BtnDersSil
            // 
            this.BtnDersSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnDersSil.Appearance.Options.UseBackColor = true;
            this.BtnDersSil.Location = new System.Drawing.Point(107, 226);
            this.BtnDersSil.Name = "BtnDersSil";
            this.BtnDersSil.Size = new System.Drawing.Size(129, 32);
            this.BtnDersSil.TabIndex = 19;
            this.BtnDersSil.Text = "Ders Sil";
            this.BtnDersSil.Click += new System.EventHandler(this.BtnDersSil_Click);
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnDersKaydet.Appearance.Options.UseBackColor = true;
            this.BtnDersKaydet.Location = new System.Drawing.Point(107, 176);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(129, 32);
            this.BtnDersKaydet.TabIndex = 18;
            this.BtnDersKaydet.Text = "Ders Kaydet";
            this.BtnDersKaydet.Click += new System.EventHandler(this.BtnDersKaydet_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(154, 85);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(129, 20);
            this.txtDersAd.TabIndex = 17;
            // 
            // BtnDersListe
            // 
            this.BtnDersListe.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnDersListe.Appearance.Options.UseBackColor = true;
            this.BtnDersListe.Location = new System.Drawing.Point(107, 133);
            this.BtnDersListe.Name = "BtnDersListe";
            this.BtnDersListe.Size = new System.Drawing.Size(129, 32);
            this.BtnDersListe.TabIndex = 9;
            this.BtnDersListe.Text = "Ders Listesi";
            this.BtnDersListe.Click += new System.EventHandler(this.BtnDersListe_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(50, 88);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 15);
            this.labelControl11.TabIndex = 16;
            this.labelControl11.Text = "AD :";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(154, 47);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(129, 20);
            this.txtDersID.TabIndex = 15;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(50, 50);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 15);
            this.labelControl12.TabIndex = 14;
            this.labelControl12.Text = "ID :";
            // 
            // BtnNotListe
            // 
            this.BtnNotListe.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnNotListe.Appearance.Options.UseBackColor = true;
            this.BtnNotListe.Location = new System.Drawing.Point(1091, 285);
            this.BtnNotListe.Name = "BtnNotListe";
            this.BtnNotListe.Size = new System.Drawing.Size(104, 32);
            this.BtnNotListe.TabIndex = 10;
            this.BtnNotListe.Text = "Not Listesi";
            this.BtnNotListe.Click += new System.EventHandler(this.BtnNotListe_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1230, 269);
            this.dataGridView1.TabIndex = 11;
            // 
            // radioSirala
            // 
            this.radioSirala.AutoSize = true;
            this.radioSirala.Location = new System.Drawing.Point(383, 624);
            this.radioSirala.Name = "radioSirala";
            this.radioSirala.Size = new System.Drawing.Size(140, 17);
            this.radioSirala.TabIndex = 12;
            this.radioSirala.TabStop = true;
            this.radioSirala.Text = "Ada Göre Sırala (A --> Z)";
            this.radioSirala.UseVisualStyleBackColor = true;
            // 
            // BtnSirala
            // 
            this.BtnSirala.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.BtnSirala.Appearance.Options.UseBackColor = true;
            this.BtnSirala.Location = new System.Drawing.Point(383, 683);
            this.BtnSirala.Name = "BtnSirala";
            this.BtnSirala.Size = new System.Drawing.Size(104, 32);
            this.BtnSirala.TabIndex = 13;
            this.BtnSirala.Text = "Sırala";
            this.BtnSirala.Click += new System.EventHandler(this.BtnSirala_Click);
            // 
            // radioSiralaTers
            // 
            this.radioSiralaTers.AutoSize = true;
            this.radioSiralaTers.Location = new System.Drawing.Point(383, 647);
            this.radioSiralaTers.Name = "radioSiralaTers";
            this.radioSiralaTers.Size = new System.Drawing.Size(140, 17);
            this.radioSiralaTers.TabIndex = 14;
            this.radioSiralaTers.TabStop = true;
            this.radioSiralaTers.Text = "Ada Göre Sırala (Z --> A)";
            this.radioSiralaTers.UseVisualStyleBackColor = true;
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Location = new System.Drawing.Point(551, 624);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(107, 17);
            this.radioID.TabIndex = 15;
            this.radioID.TabStop = true;
            this.radioID.Text = "ID\' ye Göre Sırala";
            this.radioID.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(551, 647);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(53, 17);
            this.radioErkek.TabIndex = 16;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // radioKiz
            // 
            this.radioKiz.AutoSize = true;
            this.radioKiz.Location = new System.Drawing.Point(633, 647);
            this.radioKiz.Name = "radioKiz";
            this.radioKiz.Size = new System.Drawing.Size(39, 17);
            this.radioKiz.TabIndex = 17;
            this.radioKiz.TabStop = true;
            this.radioKiz.Text = "Kız";
            this.radioKiz.UseVisualStyleBackColor = true;
            // 
            // radiVizeOrt
            // 
            this.radiVizeOrt.AutoSize = true;
            this.radiVizeOrt.Location = new System.Drawing.Point(551, 672);
            this.radiVizeOrt.Name = "radiVizeOrt";
            this.radiVizeOrt.Size = new System.Drawing.Size(97, 17);
            this.radiVizeOrt.TabIndex = 18;
            this.radiVizeOrt.TabStop = true;
            this.radiVizeOrt.Text = "Vize Ortalaması";
            this.radiVizeOrt.UseVisualStyleBackColor = true;
            // 
            // radioOrtUstu
            // 
            this.radioOrtUstu.AutoSize = true;
            this.radioOrtUstu.Location = new System.Drawing.Point(551, 698);
            this.radioOrtUstu.Name = "radioOrtUstu";
            this.radioOrtUstu.Size = new System.Drawing.Size(150, 17);
            this.radioOrtUstu.TabIndex = 19;
            this.radioOrtUstu.TabStop = true;
            this.radioOrtUstu.Text = "Vize Ortalama Üstü Alanlar";
            this.radioOrtUstu.UseVisualStyleBackColor = true;
            // 
            // radiOrtalama
            // 
            this.radiOrtalama.AutoSize = true;
            this.radiOrtalama.Location = new System.Drawing.Point(551, 721);
            this.radiOrtalama.Name = "radiOrtalama";
            this.radiOrtalama.Size = new System.Drawing.Size(109, 17);
            this.radiOrtalama.TabIndex = 20;
            this.radiOrtalama.TabStop = true;
            this.radiOrtalama.Text = "Yıl Sonu Ortalama";
            this.radiOrtalama.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 769);
            this.Controls.Add(this.radiOrtalama);
            this.Controls.Add(this.radioOrtUstu);
            this.Controls.Add(this.radiVizeOrt);
            this.Controls.Add(this.radioKiz);
            this.Controls.Add(this.radioErkek);
            this.Controls.Add(this.radioID);
            this.Controls.Add(this.radioSiralaTers);
            this.Controls.Add(this.BtnSirala);
            this.Controls.Add(this.radioSirala);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnNotListe);
            this.Controls.Add(this.grpDers);
            this.Controls.Add(this.grpSınavlar);
            this.Controls.Add(this.grpOgrenci);
            this.Controls.Add(this.BtnBul);
            this.Name = "Form1";
            this.Text = "Sınav Bilgi Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenci)).EndInit();
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSınavlar)).EndInit();
            this.grpSınavlar.ResumeLayout(false);
            this.grpSınavlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtalama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDers)).EndInit();
            this.grpDers.ResumeLayout(false);
            this.grpDers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDersAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDersID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnOgrListele;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnBul;
        private DevExpress.XtraEditors.GroupControl grpOgrenci;
        private DevExpress.XtraEditors.TextEdit txtOgrFoto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOgrSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOgrAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOgrID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grpSınavlar;
        private DevExpress.XtraEditors.TextEdit txtOrtalama;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBut;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtFinal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtVize;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl grpDers;
        private DevExpress.XtraEditors.TextEdit txtDersAd;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDersID;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton BtnDersListe;
        private DevExpress.XtraEditors.SimpleButton BtnNotListe;
        private DevExpress.XtraEditors.SimpleButton btnNotGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnHesapla;
        private DevExpress.XtraEditors.TextEdit txtDurum;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton BtnDersGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnDersSil;
        private DevExpress.XtraEditors.SimpleButton BtnDersKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioSirala;
        private DevExpress.XtraEditors.SimpleButton BtnSirala;
        private System.Windows.Forms.RadioButton radioSiralaTers;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.RadioButton radioKiz;
        private System.Windows.Forms.RadioButton radiVizeOrt;
        private System.Windows.Forms.RadioButton radioOrtUstu;
        private System.Windows.Forms.RadioButton radiOrtalama;
    }
}

