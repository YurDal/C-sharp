using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
  public class Contact
    {

        private Adress m_adress;
        private Email m_email;
        private string m_firstName;
        private string m_lastName;
        private Phone m_phone;


        /// <summary>
        /// Default constructor- Creates a new contact with unknown name anda lastname
        /// </summary>
        public Contact():this("Unknown", "Unknown", new Adress(), new Phone(), new Email())
        {
        }

        /// <summary>
        /// Construktor - Can be usefull for copy a Contact object.
        /// </summary>
        /// <param name="theOther"></param>
        public Contact(Contact theOther)
        {
            this.m_firstName = theOther.m_firstName;
            this.m_lastName = theOther.m_lastName;
            this.m_adress = new Adress(theOther.m_adress);
        }

        /// <summary>
        /// Constructor - Creates a new contact with given parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastname"></param>
        /// <param name="adress"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Contact(string firstName, string lastname, Adress adress, Phone phone, Email email)
        {
            m_firstName = firstName;
            m_lastName = lastname;
            m_adress = adress;
            m_phone = phone;
            m_email = email;
        }

        /// <summary>
        /// Property related to the field m_adress
        /// Both read and write access
        /// </summary>
        public Adress AdressDate
        {
            get
            {
                return m_adress;
            }
            set
            {
                m_adress = value;
            }
        }


        /// <summary>
        /// Property related to the field m_email
        /// Both read and write access
        /// </summary>
        public Email EmailData
        {
            get
            {
                return m_email;
            }
            set
            {
                m_email = value;
            }

        }

        /// <summary>
        /// Property related to the field m_firstName
        /// Both read and write access
        /// </summary>
        public string FirstName
        {
            get
            {
                return m_firstName;
            }
            set
            {
                m_firstName = value;
            }
        }

        /// <summary>
        /// Property related to the field m_lastName
        /// Both read and write access
        /// </summary>
        public string LastName
        {
            get
            {
                return m_lastName;
            }
            set
            {
                m_lastName = value;
            }
        }

        /// <summary>
        /// Property related to the field m_phone
        /// Both read and write access
        /// </summary>
        public Phone PhoneData
        {
            get
            {
                return m_phone;
            }
            set
            {
                m_phone = value;
            }
        }

        /// <summary>
        /// This method checks if m_firstName and m_lastName is null or empty
        /// </summary>
        /// <returns> true id its not null or empty </returns>
        public bool Validate()
        {
           return !string.IsNullOrEmpty(FullName);
        }

        /// <summary>
        /// Get groperty related to the fields m_firstName and m_lastName. Returns a string which contains m_firstName and m_lastName
        /// </summary>
        public string FullName
        {
            get
            {
               return m_firstName + " " + m_lastName;
            }
        }

        /// <summary>
        /// This method returns a string that contains all information about the contact object
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            string str = string.Format("      {0,-20}                             {1,-20}                       {2,-10}                  {3,-20}", FullName, AdressDate.ToString(), PhoneData.ToString(), EmailData.ToString());
            return str;
        }
    
    }
}
