using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db= new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.Balance);
            lblTotalBalance.Text = totalBalance.ToString()+" ₺";

            // Chart 1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.Title,
                x.Balance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.Title, item.Balance);
            }

            //Chart2 Kodları
            var billData = db.Bills.Select(x => new
            {
                x.Title,
                x.Amount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            foreach(var item in billData)
            {
                series2.Points.AddXY(item.Title, item.Amount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count%4==1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.Title == "Elektrik").Select(y => y.Amount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblAmount.Text=elektrikFaturasi.ToString();
            }
            if (count % 4 == 2)
            {
                var su = db.Bills.Where(x => x.Title == "Su Faturası").Select(y => y.Amount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblAmount.Text = su.ToString();
            }
            if (count % 4 == 3)
            {
                var dogalgaz = db.Bills.Where(x => x.Title == "Doğalgaz").Select(y => y.Amount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblAmount.Text = dogalgaz.ToString();
            }
            

            var lastBankProcessAmount= db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amount).FirstOrDefault();
            lblLastProcessAmount.Text = lastBankProcessAmount.ToString()+" ₺";
        }

       
    }
}
