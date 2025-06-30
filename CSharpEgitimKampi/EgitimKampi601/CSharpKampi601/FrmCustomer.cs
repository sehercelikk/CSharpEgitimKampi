using Npgsql;
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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        string connectionString = "Server =localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=6";

        void GetAllCustomer()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            connection.Close();
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllCustomer();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string surname = txtSoyad.Text;
            string city = txtSehir.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into Customers (CustomerName,CustomerSurname,City) values (@name,@surname,@city)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@city", city);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı");
            connection.Close();
            GetAllCustomer();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Customers Where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılı");
            connection.Close();
            GetAllCustomer();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string surname = txtSoyad.Text;
            string city = txtSehir.Text;  
            int id= int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customers Set CustomerName=@name,CustomerSurname=@surname,City=@city Where CustomerId=@customerId"; 
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı");
            connection.Close();
            GetAllCustomer();

        }
    }
}
