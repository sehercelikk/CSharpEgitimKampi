using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;
namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }



        FinancialCrmDbEntities context = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBalance = context.Banks.Where(x => x.Title == "Ziraat Bankası").Select(y=>y.Balance).FirstOrDefault();
            var vakifBalance = context.Banks.Where(x => x.Title == "VakıfBank").Select(y => y.Balance).FirstOrDefault();
            var isBalance = context.Banks.Where(x => x.Title == "İş Bankası").Select(y => y.Balance).FirstOrDefault();
            lblIsBalance.Text = isBalance.ToString()+" ₺";
            lblVakifBalance.Text = vakifBalance.ToString()+" ₺";
            lblZiraatBankBalance.Text = ziraatBalance.ToString()+" ₺";

            //Banka Hareketleri
            var bankProcess1= context.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProces1.Text=bankProcess1.Description + " "+ bankProcess1.Amount+ " " + bankProcess1.ProcessDate;

            var bankProcess2 = context.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProces2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcessDate;

            var bankProcess3 = context.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProces3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcessDate;

            var bankProcess4 = context.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProces4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcessDate;

            var bankProcess5 = context.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProces5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcessDate;

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }
    }
}
