using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimCampi301.EFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        CSharpEgitimCampiEfTravelDbEntities2 db = new CSharpEgitimCampiEfTravelDbEntities2();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Location.Count().ToString();
            #endregion

            #region Toplam Kapasite Sayısı
            lblToplamKapasite.Text= db.Location.Sum(x=>x.Capacity).ToString();
            #endregion

            #region Toplam Rehber Sayısı
            lblRehberSayisi.Text = db.Guide.Count().ToString();
            #endregion

            #region Ortalama Kapasite Sayısı
            lblOrtalamaKapasite.Text= db.Location.Average(x=>x.Capacity).ToString();
            #endregion

            lblOrtTurFiyat.Text=db.Location.Average(x=>x.Price).ToString();

            int id= db.Location.Max(x=>x.LocationId);
            label.Text=db.Location.Where(x=>x.LocationId==id).Select(y=>y.Country).FirstOrDefault();

            lblKpdkyTrKpst.Text=db.Location.Where(x=>x.City== "Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeOrtKapasite.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romaGuideId= db.Location.Where(x=>x.City=="Roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomaRhb.Text = db.Guide.Where(x => x.GuideId == romaGuideId).Select(y=>y.Name + " " + y.Surname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLoc.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPriceLoc = db.Location.Max(x => x.Price); ;
            lblMaxPriceLoc.Text = db.Location.Where(x => x.Price == maxPriceLoc).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByName= db.Guide.Where(x=>x.Name=="Cem" && x.Surname=="Doğan").Select(x=>x.GuideId).FirstOrDefault();
            lblCmDgnLoc.Text = db.Location.Where(x => x.GuideId == guideIdByName).Count().ToString();
        }
    }
}
