using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiTravelDbEntities db = new EgitimKampiTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuideId.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme başarıyla yapıldı.");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new 
            {
                FullName=x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
             
            cmbGuideId.DisplayMember = "FullName";
            cmbGuideId.ValueMember = "GuideId";
            cmbGuideId.DataSource = values; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedvalue=db.Location.Find(id);
            db.Location.Remove(deletedvalue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarıyla yapıldı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.GuideId = int.Parse(cmbGuideId.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarıyla yapıldı.");                
        }
    }
}
