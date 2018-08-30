using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  This class represents an email adress and contains information of the email.
    /// </summary>
    public class Email
    {
        private string m_personal;
        private string m_work;


        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Email():this(string.Empty)
        {

        }

        /// <summary>
        /// Constructor with one parameter - calls the constructor with
		/// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="workMail"></param>
        public Email(string workMail):this(workMail,string.Empty)
        {

        }

        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters.
        public Email(string workMail, string personalMail)
        {
            this.m_personal = personalMail;
            this.m_work = workMail;
        }


        /// <summary>
        /// Property related to the field m_Personal
		/// Both read and write access
        /// </summary>
        public string Personal
        {
            get
            {
                return m_personal;
            }
            set
            {
                m_personal = value;
            }
        }

        /// <summary>
        /// Property related to the field m_work
        /// Both read and write access
        /// </summary>
        public string Work
        {
            get
            {
                return m_work;
            }
            set
            {
                m_work = value;
            }
        }

        public override string ToString()
        {
            string strout = string.Format("{0,-20}{1,-20}",m_work,m_personal);
            return strout;
        }
    }
}
