using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  The GUI that user can add or change a Income.
    /// </summary>
    public partial class IncomeForm : Form
    {
        private Income currentIncome;
        private bool m_closeForm = false;

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeForm()
        {
            InitializeComponent();
          
            InitializeGUI();
        
        }



        /// <summary>
        /// This method initialize the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            string[] category = Enum.GetNames(typeof(IncomesEnum));
            foreach (var item in category) cbIncome.Items.Add(item);
            cbIncome.SelectedIndex = 0;
            dateTimePickerIncome.Format = DateTimePickerFormat.Custom;
            dateTimePickerIncome.CustomFormat = "yyyy-MM-dd    HH:mm";
           
        

        }

        /// <summary>
        /// This method reads all user input and puts in the class variables of Income.
        /// </summary>
        /// <returns> Returns true if inputs are valid</returns>
        private bool ReadInput()
        {
            int amount;
            if (!string.IsNullOrEmpty(tbDescriptionIncome.Text) && cbIncome.SelectedIndex != -1 && int.TryParse(tbAmountIncome.Text, out amount) )
            {
                Income newIncome = new Income(dateTimePickerIncome.Value, tbDescriptionIncome.Text, (IncomesEnum)Enum.Parse(typeof(IncomesEnum), cbIncome.SelectedItem.ToString()), amount);
                currentIncome = newIncome;
                return true;
            }
            else
            {
                return false;
            }

        }

    

        /// <summary>
        /// Property related to the field currentIncome
        /// Both read and write access
        /// </summary>
        public Income IncomeData
        {
            get
            {
                return
                    currentIncome;
            }
            set
            {
                currentIncome = value;
                UpdateGUI();
            }
        }

        /// <summary>
        /// This method updates the gui with currentIncome data
        /// </summary>
        private void UpdateGUI()
        {
            if (currentIncome != null)
            {
                dateTimePickerIncome.Value = currentIncome.Date;
                tbAmountIncome.Text = currentIncome.Amount.ToString();
                tbDescriptionIncome.Text = currentIncome.Description;
                cbIncome.SelectedItem = currentIncome.Category.ToString();
            }
        }

        /// <summary>
        /// This method calls when user click on the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkIncome_Click(object sender, EventArgs e)
        {

            if (ReadInput())
            {
                m_closeForm = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a valid income!!!");
            }

        }


        /// <summary>
        /// This method calls when user try close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            if (DialogResult == DialogResult.OK)
            {
                e.Cancel = !ReadInput();
            }
            else
            {
                DialogResult result = MessageBox.Show("Discard all data?", "Think twice!", MessageBoxButtons.OKCancel);
                e.Cancel = result != DialogResult.OK;
            }
        }

        private void btnOkCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
