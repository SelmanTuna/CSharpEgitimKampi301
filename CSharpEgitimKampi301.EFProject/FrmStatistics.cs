using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiTravelDbEntities db = new EgitimKampiTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Location.Count().ToString();
            
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();

            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price)?.ToString("0.00") + " ₺ ";

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAverage.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuıdeName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault(); //.ToString();

            var maxCapacityTour = db.Location.Max(x => x.Capacity);
            lblMaxCapacityTour.Text = db.Location.Where(x => x.Capacity == maxCapacityTour).Select(y => y.City).FirstOrDefault().ToString();

            var maxPriceTour = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPriceTour).Select(y => y.City).FirstOrDefault().ToString();

            int customGuideId = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname=="Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == customGuideId).Count().ToString();
        }

    }
}
