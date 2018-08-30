using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  The GUI that user can add or change a Costumer info.
    /// </summary>
    public partial class MainForm : Form

    {
        CustomerManager customerMng = new CustomerManager();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method calls when user click on button btnClick and user adds a new costumer info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm("Add New Costumer");
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                frmContact.ContactData = customerMng.GetCustomer(index).ContactData;
            }
            if(frmContact.ShowDialog() == DialogResult.OK)
            {
                customerMng.AddCustomer(frmContact.ContactData);
                frmContact.ContactData = new Contact();
                UpdateGui();
            }
        }

        /// <summary>
        /// This method updates listbox for customers
        /// </summary>
        private void UpdateGui()
        {
            listBox.Items.Clear();
            string[] arr = customerMng.GetCustomerInfo();
            if(arr!= null)
            {
                listBox.Items.AddRange(arr);
            }
        }

        /// <summary>
        /// This method calls when user click on the button btnEdit and user changes information of a cunstomer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                ContactForm frmContact = new ContactForm("Change Costumer");
                frmContact.ContactData = customerMng.GetCustomer(index).ContactData;
                if (frmContact.ShowDialog() == DialogResult.OK)
                {
                    customerMng.ChangeCustomer(frmContact.ContactData, index);
                    UpdateGui();
                }
            }
         
        }

        /// <summary>
        /// This method calls when user click on the button btnDelete and user deletes information of a cunstomer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index != -1)
            {
                customerMng.DeleteCustomer(index);
            }
            UpdateGui();
        }

    }
}
