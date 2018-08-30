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
    ///  The GUI that user can add or change a Expenditure.
    /// </summary>
    public partial class ExpenditureForm : Form
    {

        private Expenditure expenditure;
        private bool m_closeForm = false;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpenditureForm()
        {
            InitializeComponent();
          
            InitializeGUI();
        }

        /// <summary>
        /// This method initialize the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            string[] category = Enum.GetNames(typeof(ExpencesEnum));
            foreach (var item in category) cbExp.Items.Add(item);
            cbExp.SelectedIndex = 0;
            dateTimePickerExp.Format = DateTimePickerFormat.Custom;
            dateTimePickerExp.CustomFormat = "yyyy-MM-dd    HH:mm";
        }

        /// <summary>
        /// Property related to the field expenditure
        /// Both read and write access
        /// </summary>
        public Expenditure ExpenditureData
        {
            get
            {
                return
                    expenditure;
            }
            set
            {
                expenditure = value;
                UpdateGUI();
            }
        }


        /// <summary>
        /// This method updates the gui with expenditure data
        /// </summary>
        private void UpdateGUI()
        {
            if (expenditure != null)
            {
                dateTimePickerExp.Value = expenditure.Date;
                tbAmountExp.Text = expenditure.Amount.ToString();
                tbDescriptionExp.Text = expenditure.Description;
                cbExp.SelectedItem = expenditure.Category.ToString();
            }
        }
        /// <summary>
        /// This method calls when user click on the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkExp_Click(object sender, EventArgs e)
        {
            if (ReadInput())
            {
                m_closeForm = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a valid expenditure!!!");
            }

        }

         /// <summary>
        /// This method reads all user input and puts in the class variables of Expenditure.
        /// </summary>
        /// <returns> Returns true if inputs are valid</returns>
        private bool ReadInput()
        {
            int amount;
            if (!string.IsNullOrEmpty(tbDescriptionExp.Text) && cbExp.SelectedIndex != -1 && int.TryParse(tbAmountExp.Text, out amount))
            {
                expenditure = new Expenditure(dateTimePickerExp.Value, tbDescriptionExp.Text, (ExpencesEnum)Enum.Parse(typeof(ExpencesEnum), cbExp.SelectedItem.ToString()), amount);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// This method calls when user try close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpenditureForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCancelExp_Click(object sender, EventArgs e)
        {

        }
    }
}
