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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        CSharpEgitimCampiEfTravelDbEntities2 context = new CSharpEgitimCampiEfTravelDbEntities2();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = context.Location.ToList();
            dataGridView1.DataSource= values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = context.Guide.Select(x => new
            {
                FullName = x.Name +" "+ x.Surname,
                x.GuideId
            }).ToList();
            cmbRehber.DisplayMember = "FullName";
            cmbRehber.ValueMember = "GuideId";
            cmbRehber.DataSource= values;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City= txtSehir.Text;
            location.Country = txtUlke.Text;
            location.Capacity = byte.Parse(nmrKapasite.Value.ToString());
            location.DayNight = txtGunGece.Text;
            location.Price =decimal.Parse(txtFiyat.Text);
            location.GuideId=int.Parse(cmbRehber.SelectedValue.ToString());
            context.Location.Add(location);
            context.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id=int.Parse(txtId.Text);
            var deletedValue = context.Location.Find(id);
            context.Location.Remove(deletedValue);
            context.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue= context.Location.Find(id);
            updatedValue.DayNight = txtGunGece.Text;
            updatedValue.Capacity = byte.Parse(nmrKapasite.Value.ToString());
            updatedValue.Price = decimal.Parse(txtFiyat.Text);
            updatedValue.City=txtSehir.Text;
            updatedValue.Country=txtUlke.Text;
            updatedValue.GuideId= int.Parse(cmbRehber.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
