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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CSharpEgitimCampiEfTravelDbEntities2 context = new CSharpEgitimCampiEfTravelDbEntities2();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = context.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtRehberAd.Text;
            guide.Surname = txtRehberSoyad.Text;
            context.Guide.Add(guide);
            context.SaveChanges();
            MessageBox.Show("Rehber ekleme işlemi başarılı");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtRehberId.Text);
            var updatedValue = context.Guide.Find(id);
            updatedValue.Name= txtRehberAd.Text;
            updatedValue.Surname= txtRehberSoyad.Text;
            context.SaveChanges();
            MessageBox.Show("Rehber güncelleme işlemi başarılı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtRehberId.Text);
            var removeValue= context.Guide.Find(id);
            context.Guide.Remove(removeValue);
            context.SaveChanges();
            MessageBox.Show("Rehber silme işlemi başarılı");

        }

        private void btnIdAra_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtRehberId.Text);
            var value = context.Guide.Where(x=>x.GuideId==id).ToList();
            dataGridView1.DataSource = value;
        }
    }
}
