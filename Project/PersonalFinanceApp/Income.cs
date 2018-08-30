using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceApp
{
    /// <summary>
    /// @ author Yurdaer Dalkic
    ///  This class represents an income and contains information of it.
    /// </summary>
    public class Income
    {
        // Instance variables
        private DateTime date;
        private string description;
        private IncomesEnum category;
        private int amount;


        /// <summary>
        /// Constructor with tre parameter
        /// </summary>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        public Income(DateTime date, string description, IncomesEnum category, int amount)
        {
            this.date = date;
            this.description = description;
            this.category = category;
            this.amount = amount;
        }

        /// <summary>
        /// Property related to the field date
        /// Both read and write access
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        /// <summary>
        /// Property related to the field description
        /// Both read and write access
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>
        /// Property related to the field category
        /// Both read and write access
        /// </summary>
        public IncomesEnum Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        /// <summary>
        /// Property related to the field amount
        /// Both read and write access
        /// </summary>
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        /// <summary>
        /// This method returns a string which contains all information of the Income object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return
                   $"{date.ToShortDateString(),-12}  " +
                   $"{category.ToString(),-12}        " +
                   $"{amount.ToString(),-6}         " +
                   $"{description}";
        }

    }
}
