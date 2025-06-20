using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("YourConnection String");


        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * From Product";
            var values=await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            string query = "Insert into Product(Name,Stock,Price,Category) values (@name, @stock,@price,@category)";
            var parameters= new DynamicParameters();
            parameters.Add("@name",txtAd.Text);
            parameters.Add("@stock", txtStok.Text);
            parameters.Add("@price", txtFiyat.Text);
            parameters.Add("@category", txtKategori.Text);
            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            string query = "Delete From Product Where ProductId=@productId";
            var parameters= new DynamicParameters();
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query,parameters);
            MessageBox.Show("Silme işlemi başarılı");

        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string quer = "Update Product Set Name=@name, Price=@price, Stock=@stock, Category=@category Where ProductId=@productId";
            var parameters= new DynamicParameters();
            parameters.Add("@name", txtAd.Text);
            parameters.Add("@price", txtFiyat.Text);
            parameters.Add("@stock", txtStok.Text);
            parameters.Add("@category", txtKategori.Text);
            parameters.Add("@productId",txtId.Text); 
            await connection.ExecuteAsync(quer,parameters);
            MessageBox.Show("Güncelleme işlemi başarılı");

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From Product";
            var productCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblToplamProduct.Text = productCount.ToString();

            string query2 = "Select Name From Product Where Price=(Select Max(Price) From Product)";
            var maxPrice= await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProduct.Text= maxPrice.ToString();

            string query3 = "Select Count(Distinct(category)) From Product";
            var distinctProductCount=await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctCategory.Text= distinctProductCount.ToString();
        }

       

     
    }
}
