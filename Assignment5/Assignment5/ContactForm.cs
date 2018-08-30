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
    ///  The GUI that user can add or change a Contact.
    /// </summary>
    public partial class ContactForm : Form
    {

        private bool m_closeForm = false;
        private Contact contact = new Contact();


        /// <summary>
        /// Default contructor
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Contructor has a parameter for title
        /// </summary>
        public ContactForm(string title)
        {
            InitializeComponent();
            InitializeGUI();
            changeTitle(title);
        }

        /// <summary>
        /// This mothed initialize the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            FillCountryComboBox();
        }

        /// <summary>
        /// This method changes the main title of the this form
        /// </summary>
        /// <param name="title"></param>
        private void changeTitle(string title)
        {
            this.Text=title;
        }

        /// <summary>
        /// This method calls when user click on the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ReadInput())
            {
                m_closeForm = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a valid contact!!!");
            }

        }

        /// <summary>
        /// This method calls when user click on the Cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// This method calls when user click on the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
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

        /// <summary>
        /// This method fills the cbCountry with Countries
        /// </summary>
        private void FillCountryComboBox()
        {
            cbCountry.DataSource = Enum.GetNames(typeof(Countries));
            cbCountry.SelectedIndex = 10;
            m_closeForm = true;
        }
        
        /// <summary>
        /// This method reads all user input and puts in the class variable contact.
        /// </summary>
        /// <returns> Returns true if inputs are valid</returns>
        private bool ReadInput()
        {
            contact.AdressDate = ReadAdress();
            contact.EmailData = ReadEmails();
            contact.PhoneData = ReadPhones();
            contact.FirstName = tbFirstName.Text;
            contact.LastName = tbLastName.Text;
            return (contact.Validate() && contact.AdressDate.Validate());
        }

        /// <summary>
        /// This method reads the adress inputs and creates a new Adress with these data
        /// </summary>
        /// <returns>Adress object </returns>
        private Adress ReadAdress()

        {
            Adress adress = new Adress(tbStreet.Text, tbZipCode.Text, tbCity.Text, (Countries)Enum.Parse(typeof(Countries),  cbCountry.SelectedItem.ToString()));
            return adress;
        }

        /// <summary>
        /// This method reads the Email inputs and creates a new Email with these data
        /// </summary>
        /// <returns>Email object </returns>
        private Email ReadEmails()
        {
            return new Email(tbEmailBusiness.Text,tbEmailPrivate.Text);
        }

        /// <summary>
        /// This method reads the phone inputs and creates a new Phone with these data
        /// </summary>
        /// <returns>Phone object </returns>
        private Phone ReadPhones()
        {
            return new Phone(tbPhoneHome.Text,tbPhoneCell.Text);
        }

        /// <summary>
        /// Property related to the field contact
        /// Read and get access
        /// </summary>
        public Contact ContactData
        {
            get
            {
                return contact;
            }
            set
            {
                if (value != null)
                    contact = value;
                UpdateGui();
               
            }
        }

        private void UpdateGui()
        {
            tbFirstName.Text = contact.FirstName;
            tbLastName.Text = contact.LastName;
            tbPhoneHome.Text = contact.PhoneData.Home;
            tbPhoneCell.Text = contact.PhoneData.Work;
            tbEmailPrivate.Text = contact.EmailData.Personal;
            tbEmailBusiness.Text = contact.EmailData.Work;
            tbStreet.Text = contact.AdressDate.Street;
            tbCity.Text = contact.AdressDate.City;
            tbZipCode.Text = contact.AdressDate.ZipCode;
            cbCountry.SelectedItem = contact.AdressDate.Country.ToString();
            contact = new Contact();

        }



        /// <summary>
        /// This method returns the string presentation of the contact object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return contact.ToString();
        }
    }
}
