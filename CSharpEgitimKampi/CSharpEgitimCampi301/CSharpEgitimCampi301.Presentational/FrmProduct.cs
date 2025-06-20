using CSharpEgitimCampi301.Business.Abstract;
using CSharpEgitimCampi301.Business.Concrete;
using CSharpEgitimCampi301.DataAccess.EntityFramework;
using CSharpEgitimCampi301.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimCampi301.Presentational
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
       
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbKategori.DataSource = values;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var value= _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName=txtAd.Text;
            product.Description=txtAciklama.Text;
            product.Price=decimal.Parse(txtFiyat.Text);
            product.Stock=int.Parse(txtStok.Text);
            product.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            _productService.TInsert(product);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var value= _productService.TGetById(id);
            dataGridView1.DataSource = value;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var value = _productService.TGetById(id);
            value.Description=txtAciklama.Text;
            value.Stock=int.Parse(txtStok.Text);
            value.ProductName=txtAd.Text;
            value.Price=decimal.Parse(txtFiyat.Text);
            value.CategoryId=int.Parse(cmbKategori.SelectedValue.ToString());  
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme işlemi başarıyla yapıldı");
        }
    }
}
