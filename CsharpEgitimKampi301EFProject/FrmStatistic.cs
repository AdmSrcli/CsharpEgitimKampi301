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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities();

       
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            lbllocasyonSayısı.Text=db.Location.Count().ToString()+" Adet";
            lblkapasitetoplam.Text=db.Location.Sum(x=>x.Capacity).ToString()+" Kişi";
            lblrehbersayısı.Text=db.Guid.Count().ToString()+" Kişi";
            lblortalamakapasite.Text= db.Location.Average(x=>(decimal)x.Capacity).ToString("0.")+" Kişi";
            lblortfiyat.Text = db.Location.Average(x =>(decimal) x.Price).ToString("0.00")+" ₺";

            int lastcountryId = db.Location.Max(x => x.LocationId);
            lblsonulke.Text=db.Location.Where(x=>x.LocationId==lastcountryId).Select(y=>y.Country).FirstOrDefault();

            lblkapturkap.Text=db.Location.Where(x=>x.City=="Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString()+" Kişi";
            lblturortkap.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString()+" Kişi";

            var rehber=db.Location.Where(x=>x.City=="Roma").Select(y=>y.GuidId).FirstOrDefault();
            lblromgezrehber.Text=db.Guid.Where(x=>x.GuidId==rehber).Select(y=>y.GuidName+" "+y.GuidSurname).FirstOrDefault().ToString();

            var maxcap=db.Location.Max(x=>x.Capacity);
            lblyukkap.Text = db.Location.Where(x => x.Capacity == maxcap).Select(y => y.City).FirstOrDefault().ToString();

            var maxprice=db.Location.Max(x=>x.Price);
            lblenpahtur.Text=db.Location.Where(x=>x.Price==maxprice).Select(y=>y.City).FirstOrDefault().ToString();

            var ayse = db.Guid.Where(x => x.GuidName == "Ayşegül" && x.GuidSurname == "Çınar").Select(y => y.GuidId).FirstOrDefault();
            lblayse.Text=db.Location.Where(z=>z.GuidId==ayse).Count().ToString();
        }
       

        
    }
}
