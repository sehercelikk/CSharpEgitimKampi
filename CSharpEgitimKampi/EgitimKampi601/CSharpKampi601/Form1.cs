using CSharpKampi601.Entities;
using CSharpKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        CustomerOperation customerOperation = new CustomerOperation();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Balance = decimal.Parse(txtBakiye.Text),
                City = txtSehir.Text,
                ShoppingCount = int.Parse(txtTutar.Text)
            };
            customerOperation.AddCustomer(customer);
            MessageBox.Show("Ekleme işlemi başarılı");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Customer> customers=customerOperation.GetAllCustomer();
            DataGridView1.DataSource = customers;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string customerId = txtId.Text;
            customerOperation.DeleteCustomer(customerId);
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id= txtId.Text;
            var updateCustomer = new Customer
            {
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                City = txtSehir.Text,
                Balance = decimal.Parse(txtBakiye.Text),
                ShoppingCount = int.Parse(txtTutar.Text),
                CustomerId=int.Parse(id)
            };
            customerOperation.UpdateCustomer(updateCustomer);
            MessageBox.Show("Güncelleme işlemi başarılı");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Customer customer=customerOperation.GetCustomerById(id);
            DataGridView1.DataSource = new List<Customer> { customer };

        }
    }
}
