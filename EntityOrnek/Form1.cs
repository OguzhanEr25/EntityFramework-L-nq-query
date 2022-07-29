using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityOrnek.Entity;


namespace EntityOrnek
{
    public partial class Form1 : Form
    {

        SqlBaglantisi bgl = new SqlBaglantisi();
        DbSınavEntities2 db = new DbSınavEntities2(); // Model ile nesne oluşturma

        public Form1()
        {
            InitializeComponent();
        }

        // Öğrenci kaydetme butonu
        public string OgrKaydet()
        {
            TblOgrenci ogrekle = new TblOgrenci();
            ogrekle.Ad = txtOgrAd.Text;
            ogrekle.Soyad = txtOgrSoyad.Text;
            ogrekle.Cinsiyet = txtCinsiyet.Text;
            db.TblOgrenci.Add(ogrekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenci ekleme başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtCinsiyet.Text = "";
            return Convert.ToString(ogrekle);
        }

        // Ders kaydetme metodu
        public string DersKaydet()
        {
            TblDersler dersEkle = new TblDersler();
            dersEkle.DersAd = txtDersAd.Text;
            db.TblDersler.Add(dersEkle);
            db.SaveChanges();
            MessageBox.Show("Ders ekleme başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtDersAd.Text = "";
            return Convert.ToString(dersEkle);
        }
        void Dersler()
        {
            SqlCommand dersler = new SqlCommand("Select DersID From TblDersler", bgl.SqlBaglanti());
            SqlDataReader dr = dersler.ExecuteReader();
            while (dr.Read())
            {
                cmbDersAdi.Properties.Items.Add(dr[0]);
            }
            bgl.SqlBaglanti().Close();
        }

        void DersSec()
        {
            SqlCommand dersSec = new SqlCommand("Select DersAd From TblDersler", bgl.SqlBaglanti());
            SqlDataReader dr2 = dersSec.ExecuteReader();
            while (dr2.Read())
            {
                cmbDersSec.Properties.Items.Add(dr2[0]);
            }
            bgl.SqlBaglanti().Close();
        }

        public string NotKaydet()
        {
            TblNotlar notEkle = new TblNotlar();
            notEkle.OGR = Convert.ToInt32(txtOgrNo.Text);
            notEkle.Ders = Convert.ToInt32(cmbDersAdi.Text);
            notEkle.Vize = Convert.ToByte(txtVize.Text);
            if(txtFinal.Text == "")
            {
                txtFinal.Text = "";
            }
            else
            {
                notEkle.Final = Convert.ToByte(txtFinal.Text);
            }
            if(txtBut.Text == "")
            {
                txtBut.Text = "";
            }
            else
            {
                notEkle.But = Convert.ToByte(txtBut.Text);
            }

            db.TblNotlar.Add(notEkle);
            db.SaveChanges();
            MessageBox.Show("Not girildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Convert.ToString(notEkle);
        }

        // Öğrenci silme metodu
        public string OgrSil()
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TblOgrenci.Find(id);
            db.TblOgrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtOgrID.Text = "";
            return Convert.ToString(id);
        }

        // Ders silme metodu
        public string DersSil()
        {
            int idDers = Convert.ToInt32(txtDersID.Text);
            var y = db.TblDersler.Find(idDers);
            db.TblDersler.Remove(y);
            db.SaveChanges();
            MessageBox.Show("Ders silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDersID.Text = "";
            return Convert.ToString(idDers);
        }

        public string OgrGuncelle()
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TblOgrenci.Find(id);
            x.Ad = txtOgrAd.Text;
            x.Soyad = txtOgrSoyad.Text;
            x.Cinsiyet = txtCinsiyet.Text;
            x.Fotograf = txtOgrFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtOgrID.Text = "";
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtCinsiyet.Text = "";
            txtOgrFoto.Text = "";
            return Convert.ToString(id);
        }

        public string DersGuncelle()
        {
            int id = Convert.ToInt32(txtDersID.Text);
            var x = db.TblDersler.Find(id);
            x.DersAd = txtDersAd.Text;
            db.SaveChanges();
            MessageBox.Show("Ders Adı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDersID.Text = "";
            txtDersAd.Text = "";
            return Convert.ToString(id);
        }

        public string NotGuncelle()
        {
            int id = Convert.ToInt32(txtOgrNo.Text); //NotID ye göre güncelleme yapıyor, OgrNo olarak değiştirilecek
            var x = db.TblNotlar.Find(id);
            if(txtVize.Text != "")
            {
                x.Vize = Convert.ToByte(txtVize.Text);
            }
            if(txtFinal.Text != "")
            {
                x.Final = Convert.ToByte(txtFinal.Text);
            }
            if(txtBut.Text != "")
            {
                x.But = Convert.ToByte(txtBut.Text);
            }
            db.SaveChanges();
            MessageBox.Show("Not güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtOgrNo.Text = "";
            cmbDersAdi.Text = "";
            txtVize.Text = "";
            txtFinal.Text = "";
            txtBut.Text = "";
            return Convert.ToString(id);
        }

        // Ders listele butonu
        private void BtnDersListe_Click(object sender, EventArgs e)
        {
            // Normal SQL komutları ile veri çekme
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblDersler", bgl.SqlBaglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // Öğrenci listele butonu
        private void BtnOgrListele_Click(object sender, EventArgs e)
        {
            // Entity ile veri çekme
            dataGridView1.DataSource = db.TblOgrenci.ToList(); // Nesne ile tablodan veri çekme
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        // Not listeleme butonu
        private void BtnNotListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NotListesi(); // procedure çağırma

            //var query = from item in db.TblNotlar
            //            select new
            //            {
            //                item.NotID,
            //                item.OGR,
            //                item.Ders,
            //                item.Vize,
            //                item.Final,
            //                item.But,
            //                item.Ortalama,
            //                item.Durum
            //            };
            //dataGridView1.DataSource = query.ToList();

            // Join ile tablo birleştirme
            //var sorgu = from db1 in db.TblNotlar
            //            join db2 in db.TblOgrenci
            //            on db1.OGR equals db2.ID

            //            join db3 in db.TblDersler
            //            on db1.Ders equals db3.DersID
            //            select new
            //            {
            //                Öğrenci = db2.Ad + "" + db2.Soyad,
            //                Vize = db1.Vize,
            //                Ders = db3.DersAd
            //            };
            //dataGridView1.DataSource = sorgu.ToList();
        }

        // Öğrenci ve Ders kaydetme butonu
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(txtOgrAd.Text != "" & txtOgrSoyad.Text != "")
            {
                OgrKaydet();
            }
            if (txtDersAd.Text != "")
            {
                DersKaydet();
            }
            if(txtOgrNo.Text != "")
            {
                NotKaydet();
            }
        }
        
        // Öğrenci ve Ders silme butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(txtOgrID.Text != "")
            {
                OgrSil();
            }
            if(txtDersID.Text != "")
            {
                DersSil();
            }
        }

        // Öğrenci bilgi güncelleme butonu
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtOgrID.Text != "")
            {
                OgrGuncelle();
            }
            if(txtDersID.Text != "")
            {
                DersGuncelle();
            }
            if(txtOgrNo.Text != "")
            {
                NotGuncelle();
            }
        }

        // Linq sorgusu ile veri bulma 
        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TblOgrenci.Where(x => x.Ad == txtOgrAd.Text | x.Soyad == txtOgrSoyad.Text).ToList();
        }

        private void txtOgrAd_EditValueChanged(object sender, EventArgs e)
        {
            string arananAd = txtOgrAd.Text;
            var degerler = from item in db.TblOgrenci
                           where item.Ad.Contains(arananAd) // txtAd kısmına yazılan karakterlere sahip olan verileri seç
                           select item; 
            dataGridView1.DataSource = degerler.ToList();
        }
         
       // Linq sorguları ile sıralama yapma
        private void BtnSirala_Click(object sender, EventArgs e)    
        {   
            if(radioSirala.Checked == true)
            {
                // Öğrencilerin isimlerini A --> Z ye doğru listele
                List<TblOgrenci> liste1 = db.TblOgrenci.OrderBy(p => p.Ad).ToList();
                dataGridView1.DataSource = liste1;
            }
            if(radioSiralaTers.Checked == true)
            {
                // Öğrencilerin isimlerini Z --> A ya doğru listele
                List<TblOgrenci> liste2 = db.TblOgrenci.OrderByDescending(p => p.Ad).ToList();
                dataGridView1.DataSource = liste2;
            }
            if(radioID.Checked == true)
            {
                // Öğeencileri ID'lerine göre listele
                List<TblOgrenci> liste3 = db.TblOgrenci.OrderBy(p => p.ID).ToList();
                dataGridView1.DataSource = liste3;
            }
            if(radioErkek.Checked == true)
            {
                // Cinsiyeti erkek olanları başta listele
                List<TblOgrenci> liste4 = db.TblOgrenci.OrderByDescending(p => p.Cinsiyet == "Erkek").ToList(); 
                dataGridView1.DataSource = liste4;
            }
            if(radioKiz.Checked == true)
            {
                // Cinsiyeti kız olanları başta listele
                List<TblOgrenci> liste5 = db.TblOgrenci.OrderByDescending(p => p.Cinsiyet == "Kız").ToList();
                dataGridView1.DataSource = liste5;
            }
            if(radiVizeOrt.Checked == true)
            {
                var VizeOrt = db.TblNotlar.Average(P => P.Vize);
                MessageBox.Show("vize ortalama" + VizeOrt.ToString());
            }
            
            if (radioOrtUstu.Checked == true)
            {
                // Vizelerden ortalama üstünde alanları listeleme
                List<NotListesi_Result> liste6 = db.NotListesi().Where(p => p.Vize > db.TblNotlar.Average(x => x.Vize)).ToList();
                dataGridView1.DataSource = liste6;
            }
            if(radioVizeNotlarıMax.Checked == true)
            {
                // Vize notlarını Max --> Min listeleme
                List<NotListesi_Result> liste7 = db.NotListesi().OrderByDescending(p => p.Vize).ToList();
                dataGridView1.DataSource = liste7;
            }
            if(radioVizeNotlariMin.Checked == true)
            {
                // Vize notlarını Min --> Max listeleme
                List<NotListesi_Result> liste8 = db.NotListesi().OrderBy(p => p.Vize).ToList();
                dataGridView1.DataSource = liste8;  
            }
            if(cmbDersSec.Text != "")
            {
                // Ders adına  göre listeleme
                List<NotListesi_Result> liste9 = db.NotListesi().Where(p => p.DersAdi == cmbDersSec.Text).ToList();
                dataGridView1.DataSource = liste9;
                cmbDersSec.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dersler();
            DersSec();
        }

        private void cmbDersSec_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DersSec();
        }
    }
}
