using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Customer
    {

        private Contact m_contact;
        private string m_id;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer()
        {
            m_contact = new Contact();
        }


        /// <summary>
        /// Contructot - has a parameter which is an object av same type class.
        /// </summary>
        /// <param name="contactIn"></param>
        public Customer( Contact contactIn)
        {
            this.m_contact = contactIn;
        }

        /// <summary>
        /// Contructot - has two parameter. An object of same class and ID.
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="id"></param>
        public Customer(Contact contactIn, string id)
        {
            m_contact = contactIn;
            this.m_id = id;
        }

        /// <summary>
        /// Property related to the field m_contact
        /// Read and get access
        /// </summary>
        public Contact ContactData
        {
            get
            {
                return m_contact;
            }
            set
            {
                if (value != null)
                    m_contact = value;
            }
        }


        /// <summary>
        /// Property related to the field m_id
        /// Read and get access
        /// </summary>
        public string ID
        {
            get
            {
                return m_id;
            }
            set
            {
                if (value != null)
                    m_id = value;
            }
        }

        public override string ToString()
        {
            return m_id + "                   " + m_contact.ToString();
        }


    }
}
