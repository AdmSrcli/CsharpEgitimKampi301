using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpEgitimKampi301EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        void listele()
        {
            var values = db.Guid.ToList();
            dataGridView1.DataSource = values;
        }
        
        #region listele Butonu
        private void btnlist_Click(object sender, EventArgs e)
        {
            listele();

        }

        #endregion

        #region Ekle Butonu
        private void btnekle_Click(object sender, EventArgs e)
        {
            Guid guide = new Guid();
            guide.GuidName = txtad.Text;
            guide.GuidSurname = txtsoyad.Text;
            db.Guid.Add(guide);
            db.SaveChanges();
            listele();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Sil Butonu
        private void btnsil_Click(object sender, EventArgs e)
        {
            int sil=int.Parse(txtId.Text);
            var bul = db.Guid.Find(sil);
            db.Guid.Remove(bul);
            db.SaveChanges() ;
            listele();
            MessageBox.Show("Kayıt Başarıyla Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        #endregion

        #region Güncelle Butonu
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
           var bul= db.Guid.Find(id);
            bul.GuidName=txtad.Text;
            bul.GuidSurname=txtsoyad.Text;
            db.SaveChanges();
            listele();
            MessageBox.Show("Kayıt Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

        #region Id ye Göre Getir Butonu

        private void btngetir_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var bul=db.Guid.Where(x=>x.GuidId==id).ToList();
            
            dataGridView1.DataSource= bul;
        }
        #endregion


    }
}
