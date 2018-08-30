using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    ///  This class use a List object for storing objects of type Customer.
    /// </summary>
    class CustomerManager
    {
        private List<Customer> costumers;
        private int id;

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerManager()
        {
            costumers = new List<Customer>();
            id = 100;
        }

        /// <summary>
        /// This method creates a new Customer object with given Contact object and adds the new Customer onject in the end of the list.
        /// </summary>
        /// <param name="contactIn"></param>
        /// <returns></returns>
        public bool AddCustomer(Contact contactIn)
        {
            if (contactIn != null)
            {
                Contact con = new Contact();
                con.FirstName = contactIn.FirstName;
                con.LastName = contactIn.LastName;
                con.AdressDate = contactIn.AdressDate;
                con.EmailData = contactIn.EmailData;
                con.PhoneData = contactIn.PhoneData;
                costumers.Add(new Customer(con, (id.ToString())));
                id++;
                con = new Contact();
                contactIn = new Contact();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method adds the given Customer object in the end of the List.
        /// </summary>
        /// <param name="customerIn"></param>
        /// <returns></returns>
        public bool AddCustomer(Customer customerIn)
        {
            if (customerIn != null)
            {
                costumers.Add(customerIn);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method creates a new Customer object with given Contact object and insert the new Customer object at the given index in the List
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeCustomer(Contact contactIn, int index)
        {
            if (contactIn != null)
            {
                costumers[index] = new Customer(contactIn, id.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method deletes the Costumer object from the list at the given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int index)
        {
            costumers.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// This method returns a Costumer object at the given idex from the List.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Customer GetCustomer(int index)
        {
            if (index >= 0 && index < costumers.Count())
            {
                return costumers[index];
            }
            else return null;
        }


        /// <summary>
        /// This method returns an array of strings where each string is a formatted text line containing data for each customer.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string[] GetCustomerInfo()
        {
   
            string[] arr = new string[costumers.Count];
        
            for(int i =0; i< costumers.Count; i++)
            {
                arr[i] = costumers[i].ToString();
               
            }
            return arr;
        }
    
        /// <summary>
        /// Get property returns the number of registered items in the List.
        /// </summary>
        public int Count
        {
            get
            {
             return costumers.Count();
            }
        }

        /// <summary>
        /// Get property returns a new id.
        /// </summary>
        public int GetNewId
        {
            get
            {
                return id++;
            }
        }

    }  
}
