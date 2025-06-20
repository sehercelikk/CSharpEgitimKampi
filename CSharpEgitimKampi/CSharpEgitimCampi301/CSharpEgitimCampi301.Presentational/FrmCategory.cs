using CSharpEgitimCampi301.Business.Abstract;
using CSharpEgitimCampi301.Business.Concrete;
using CSharpEgitimCampi301.DataAccess.EntityFramework;
using CSharpEgitimCampi301.Entity.Concrete;
using System;
using System.Windows.Forms;

namespace CSharpEgitimCampi301.Presentational
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtAd.Text;
            category.Status = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deletedValue = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValue);
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var values= _categoryService.TGetById(id);
            dataGridView1 .DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId= int.Parse(txtId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName= txtAd.Text;
            updatedValue.Status = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }   
}
