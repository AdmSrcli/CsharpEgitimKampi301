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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var listele=(from x in db.Location
                         select new
                         {
                             x.LocationId,
                             x.City,
                             x.Country,
                             x.Capacity,
                             x.Price,
                             x.DayNight,
                             GuidNameSurname=x.Guid.GuidName+" "+x.Guid.GuidSurname
                         }).ToList();
            dataGridView1.DataSource = listele;
              
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var rehber = (from x in db.Guid
                          select new
                          {
                              x.GuidId,
                              Ad = x.GuidName + " " + x.GuidSurname
                          }
                          ).ToList();
            cmbrehber.ValueMember = "GuidId";
            cmbrehber.DisplayMember = "Ad";
            cmbrehber.DataSource= rehber;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Location loc=new Location();
            loc.Capacity = byte.Parse(nmrkapasite.Value.ToString());
            loc.City = txtsehir.Text;
            loc.Country=txtulke.Text;
            loc.Price = decimal.Parse(txtfiyat.Text);
            loc.DayNight = txtgecegun.Text;
            loc.GuidId = int.Parse(cmbrehber.SelectedValue.ToString());
            db.Location.Add(loc);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı Şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtlocid.Text);
            var bul=db.Location.Find(id);
            db.Location.Remove(bul);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı Şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtlocid.Text);
            var bul = db.Location.Find(id);
            bul.City = txtsehir.Text;
            bul.Country = txtulke.Text;
            bul.Capacity=byte.Parse(nmrkapasite.Text);
            bul.Price=decimal.Parse(txtfiyat.Text);
            bul.DayNight=txtgecegun.Text;
            bul.GuidId=int.Parse(cmbrehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme  İşlemi Başarılı Şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

     
    }
}
