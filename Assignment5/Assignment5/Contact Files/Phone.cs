using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  This class represents a phone number and contains information of the phone number.
    /// </summary>
   public class Phone
    {

        private string m_home;
        private string m_work;
        private string m_other;


        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Phone():this(string.Empty)
        {

        }

        /// <summary>
        /// Constructor with one parameter - calls the constructor with
		/// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="workMail"></param>
        public Phone(string home):this(home,string.Empty)
        {

        }

        /// Constructor with two parameters.  calls another constructor in this class
        public Phone(string home, string work):this(home,work,string.Empty)
        {
    

        }
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters.
        public Phone(string home, string work,string other) 
        {
            this.m_home = home;
            this.m_work = work;
            this.m_other = other;

        }


        /// <summary>
        /// Property related to the field m_Personal
		/// Both read and write access
        /// </summary>
        public string Home
        {
            get
            {
                return m_home;
            }
            set
            {
                m_home = value;
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

        /// <summary>
        /// Property related to the field m_other
        /// Both read and write access
        /// </summary>
        public string Other
        {
            get
            {
                return m_other;
            }
            set
            {
                m_other = value;
            }
        }

        public override string ToString()
        {
            string strout = string.Format("{0,-20}{1,-20}", m_home, m_work, m_other);
            return strout;
        }
    }
}

