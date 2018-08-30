using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalFinanceApp
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  The GUI that user can add, change and delete an Income and an Expenditure.
    /// </summary>
    public partial class MainForm : Form
    {
        private IncomeManager incomeManager;
        private ExpenditureManager expenditureManager;

        /// <summary>
        /// Default cosntructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            incomeManager = new IncomeManager();
            expenditureManager = new ExpenditureManager();
            InitializeGUI();
         
        }

        /// <summary>
        /// This method initializeGUI
        /// </summary>
        private void InitializeGUI()
        {
            chart.Legends.Add("MyLegend");
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].BorderColor = Color.Black;
        }

        /// <summary>
        /// This method calls when user click on button btnAddIncome and user adds a new Income.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
           
            IncomeForm frmIncome = new IncomeForm();
            if (frmIncome.ShowDialog() == DialogResult.OK)
            {
                Income newIncome = frmIncome.IncomeData;
                System.Diagnostics.Debug.WriteLine(newIncome.Description);
                incomeManager.Add(newIncome);
                UpdateGui();
            }

        }

        /// <summary>
        /// This method updates the GUI
        /// </summary>
        private void UpdateGui()
        {
            lbExp.Items.Clear();
            lbIncome.Items.Clear();
            string[] arrIncome = incomeManager.ListToStringArray();
            string[] arrExp = expenditureManager.ListToStringArray();

            if (arrIncome != null )
            {
                lbIncome.Items.AddRange(arrIncome);
            }
            if (arrExp != null)
            {
                lbExp.Items.AddRange(arrExp);
            }
            UpdatePieChart();
        }

        /// <summary>
        /// This method updates the pie chart (chart) with total income amound and total expenditure amount
        /// </summary>
        private void UpdatePieChart()
        {
            chart.Series.Clear();
            string seriesname = "Balance";
            chart.Series.Add(seriesname);
            chart.Series[seriesname].ChartType = SeriesChartType.Pie;
   
            chart.Series[seriesname].Points.Add(incomeManager.totalIncomeAmount());
            chart.Series[seriesname].Points.Add(expenditureManager.totalIncomeAmount());
         
            chart.Series[0].Points[0].Color = Color.Green;
            chart.Series[0].Points[1].Color = Color.Red;
            var p1 = chart.Series[0].Points[0];
            var p2 = chart.Series[0].Points[1];
            p1.LegendText = "Incomes "+ incomeManager.totalIncomeAmount().ToString() +" SEK";
            p2.LegendText = "Expences " +expenditureManager.totalIncomeAmount().ToString() +" SEK";
            chart.Invalidate();



        }


        /// <summary>
        /// This method calls when user click on button btnEditIncome and user edits the selected income object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditIncome_Click(object sender, EventArgs e)
        {
            int index = lbIncome.SelectedIndex;
          
            if (index != -1) { 
              Income newIncome = incomeManager.GetIncomeAt(index);
                System.Diagnostics.Debug.WriteLine(newIncome.Description);
                IncomeForm frmIncome = new IncomeForm();

              frmIncome.IncomeData=newIncome;
              if (frmIncome.ShowDialog() == DialogResult.OK)
              {
                newIncome = frmIncome.IncomeData;
                incomeManager.Edit(index,newIncome);
                UpdateGui();
              }
            }
        }

        /// <summary>
        /// This method calls when user click on btnDeleteIncome and users delete the selected income object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            int index = lbIncome.SelectedIndex;
            if (index != -1)
            {
                incomeManager.Delete(index);
                UpdateGui();
            }
        }


        /// <summary>
        /// This method calls when user click on button btnAddExp and user adds a new Expenditure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddExp_Click(object sender, EventArgs e)
        {

            ExpenditureForm expenditureForm = new ExpenditureForm();
            if (expenditureForm.ShowDialog() == DialogResult.OK)
            {
                Expenditure expenditure = expenditureForm.ExpenditureData;
                expenditureManager.Add(expenditure);
                UpdateGui();
            }

        }

        /// <summary>
        /// This method calls when user click on button btnEditExp and user edits the selected Expenditure object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditExp_Click(object sender, EventArgs e)
        {
            int index = lbExp.SelectedIndex;

            if (index != -1)
            {
                Expenditure expenditure = expenditureManager.GetExpenditureAt(index);
                ExpenditureForm expenditureForm = new ExpenditureForm();

                expenditureForm.ExpenditureData = expenditure;
                if (expenditureForm.ShowDialog() == DialogResult.OK)
                {
                    expenditure = expenditureForm.ExpenditureData;
                    expenditureManager.Edit(index, expenditure);
                    UpdateGui();
                }
            }

        }

        /// <summary>
        /// This method calls when user click on btnDeleteExp and users delete the selected Expenditure object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteExp_Click(object sender, EventArgs e)
        {
            int index = lbExp.SelectedIndex;
            if (index != -1)
            {
                expenditureManager.Delete(index);
                UpdateGui();
            }
        }
    }
}
