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
        DbSınavEntities_ db = new DbSınavEntities_(); // Model ile nesne oluşturma

        public Form1()
        {
            InitializeComponent();
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
        }

        // Öğrenci kaydetme butonu
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblOgrenci ogrekle = new TblOgrenci();
            ogrekle.Ad = txtOgrAd.Text;
            ogrekle.Soyad = txtOgrSoyad.Text;
            db.TblOgrenci.Add(ogrekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenci ekleme başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";

        }

        // Öğrenci sil butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TblOgrenci.Find(id);
            db.TblOgrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtOgrID.Text = "";
            
        }

        // Ders kaydetme butonu
        private void BtnDersKaydet_Click(object sender, EventArgs e)
        {
            TblDersler dersEkle = new TblDersler();
            dersEkle.DersAd = txtDersAd.Text;
            db.TblDersler.Add(dersEkle);
            db.SaveChanges();
            MessageBox.Show("Ders ekleme başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtDersAd.Text = "";
        }
        // Ders silme butonu
        private void BtnDersSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDersID.Text);
            var x = db.TblDersler.Find(id);
            db.TblDersler.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ders silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDersID.Text ="";
            
        }

        // Öğrenci bilgi güncelleme butonu
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TblOgrenci.Find(id);
            x.Ad = txtOgrAd.Text;
            x.Soyad = txtOgrSoyad.Text;
            x.Fotograf = txtOgrFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtOgrFoto.Text = "";

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
                List<TblOgrenci> liste1 = db.TblOgrenci.OrderBy(p => p.Ad).ToList();
                dataGridView1.DataSource = liste1;
            }
            if(radioSiralaTers.Checked == true)
            {
                List<TblOgrenci> liste2 = db.TblOgrenci.OrderByDescending(p => p.Ad).ToList();
                dataGridView1.DataSource = liste2;
            }
            if(radioID.Checked == true)
            {
                List<TblOgrenci> liste3 = db.TblOgrenci.OrderBy(p => p.ID).ToList();
                dataGridView1.DataSource = liste3;
            }
            if(radioErkek.Checked == true)
            {
                List<TblOgrenci> liste4 = db.TblOgrenci.OrderByDescending(p => p.Cinsiyet == "Erkek").ToList();
                dataGridView1.DataSource = liste4;
            }
            if(radioKiz.Checked == true)
            {
                List<TblOgrenci> liste5 = db.TblOgrenci.OrderByDescending(p => p.Cinsiyet == "Kız").ToList();
                dataGridView1.DataSource = liste5;
            }
            if(radiVizeOrt.Checked == true)
            {
                var VizeOrt = db.TblNotlar.Average(P => P.Vize);
                MessageBox.Show("vize ortalama" + VizeOrt.ToString());
            }
            //var vizeToplam = db.TblNotlar.Sum(P => P.Vize);
            //var VizeOrt = db.TblNotlar.Average(P => P.Vize);
            //var vizeFinalToplam = db.TblNotlar.Sum(p => p.Vize + p.Final);
            if (radioOrtUstu.Checked == true)
            {
                var ogrBilgi = db.TblOgrenci.GroupBy(x => x.ID + "" + x.Ad + "" + x.Soyad).Select(s => s.Key).FirstOrDefault();
                List<TblNotlar> liste6 = db.TblNotlar.Where(p => p.Vize > db.TblNotlar.Average(x => x.Vize)).ToList();
                dataGridView1.DataSource = liste6;
            }
            if(radiOrtalama.Checked == true)
            {
                
            }
        }
    }
}
