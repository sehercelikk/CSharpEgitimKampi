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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;password=6";

        void GetAllEmployee()
        {
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var commend= new NpgsqlCommand(query,connection);
            var adapter=new NpgsqlDataAdapter(commend);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource= dt;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection= new NpgsqlConnection(connectionString);
            var query = "Select * From Departments";
            var commend= new NpgsqlCommand(query,connection);
            var adapter = new NpgsqlDataAdapter(commend);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbDepartman.DisplayMember="Name";
            cmbDepartman.ValueMember = "DepartmentId";
            cmbDepartman.DataSource=dt;
            connection.Close();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
            DepartmentList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string surname = txtSoyad.Text;
            int maas=int.Parse(txtMaas.Text);
            int departmentId = int.Parse(cmbDepartman.SelectedValue.ToString());
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert into Employees (Name, Surname,Salary,DepartmentId) values(@name,@surname,@salary,@departmentId)";
            var commend = new NpgsqlCommand(query,connection);
            commend.Parameters.AddWithValue("@name", name);
            commend.Parameters.AddWithValue("@surname", surname);
            commend.Parameters.AddWithValue("@salary", maas);
            commend.Parameters.AddWithValue("@departmentId", departmentId);
            commend.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı");
            connection.Close();
            GetAllEmployee();


        }
    }
}
