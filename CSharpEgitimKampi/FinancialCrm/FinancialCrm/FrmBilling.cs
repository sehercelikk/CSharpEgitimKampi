using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db=new FinancialCrmDbEntities();
        void BillList()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            BillList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            BillList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(TxtAmount.Text);
            string periot=txtPeriot.Text;
            Bills bills = new Bills();
            bills.Amount = amount;
            bills.Title = title;
            bills.Period = periot;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı bir şekilde eklendi");
            BillList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue= db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarıyla silindi");
            BillList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            decimal amount = decimal.Parse(TxtAmount.Text);
            string periot = txtPeriot.Text;
            int id = int.Parse(txtId.Text);

            var values = db.Bills.Find(id);
            values.Amount = amount;
            values.Title = title;
            values.Period = periot;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı bir şekilde eklendi");
            BillList();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();
        }
    }
}
