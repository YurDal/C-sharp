using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
  
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  This class represents the adress information of a location.
    /// </summary>
    public class Adress
    {
        private string m_city;
        private Countries m_country;
        private string m_street;
        private string m_zipCode;

        /// <summary>
        /// Default contructor calling another constructor in this class
        /// </summary>
        public Adress():this(string.Empty,string.Empty,"Malmö")
        {

        }

        /// <summary>
        /// Constructor - call the next constructor for reuse
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Adress (string street, string zip, string city):this(street,zip,city,Countries.Sverige)
        {

        }

        /// <summary>
        /// Constructor that has most number of parameters in this class
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Adress (string street, string zip, string city, Countries country)
        {
            this.m_street = street;
            this.m_country = country;
            this.m_zipCode = zip;
            this.m_city = city;
        }

        /// <summary>
        /// Contructot - has a parameter which is an object av same type class.
        /// </summary>
        /// <param name="theOther"></param>
        public Adress(Adress theOther)
        {
            this.m_street = theOther.Street;
            this.m_country = theOther.Country;
            this.m_zipCode = theOther.ZipCode;
            this.m_city = theOther.City;
        }

        /// <summary>
        /// Property for m_street
        /// </summary>
        public string Street
        {
            get
            {
                return m_street;
            }
            set
            {
                m_street = value;
            }
        }

        /// <summary>
        /// Property for m_zipCode
        /// </summary>
        public string ZipCode
        {
            get
            {
                return m_zipCode;
            }
            set
            {
                m_zipCode = value;
            }
        }

        /// <summary>
        /// Property for m_city
        /// </summary>
        public string City
        {
            get
            {
                return m_city;
            }
            set
            {
                m_city = value;
            }
        }

        /// <summary>
        /// Property for m_country
        /// </summary>
        public Countries Country
        {
            get
            {
                return m_country;
            }
            set
            {
                m_country = value;
            }
        }

        /// <summary>
        /// This method removes from the country names and return it as a string
        /// </summary>
        /// <returns> Country name </returns>
       public string GetCountryString()
        {
            string strCounty = m_country.ToString();
            strCounty = strCounty.Replace("_"," ");
            return strCounty;
        }


        /// <summary>
        /// This method checks the validity of adress information. If m_city eller m_country is empty or null, this method returns false otherwise returns true,
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (string.IsNullOrEmpty(m_city) || string.IsNullOrEmpty(m_country.ToString()))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Override the ToString method to return  a string  made of adress details
        /// </summary>
        /// <returns> adress details</returns>
        public override string ToString()
        {
            
            string strout = string.Format("{0,-15}{1,-8}{2,-10}{3}",m_street.Replace("_"," "),m_zipCode,m_city,m_country.ToString().Replace("_", " "));
            return strout;
        }
    }
}
