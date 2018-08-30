using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceApp
{
    /// <summary>
    ///  This class use a List object for storing objects of type Expenditure.
    /// </summary>
    public class ExpenditureManager
    {
        private List<Expenditure> expenditureList;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpenditureManager()
        {
            expenditureList = new List<Expenditure>();
        }

        /// <summary>
        /// This method retruns the numbers of total elements in the expenditureList;
        /// </summary>
        public int Count
        {
            get
            {
                return expenditureList.Count;
            }

        }

        /// <summary>
        /// This method returns an Expenditure object from the expenditureList at given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Expenditure GetExpenditureAt(int index)
        {
            if ((index <= -1) || (index >= expenditureList.Count))
            {
                return null ;
            }
            else return expenditureList[index];
        }

        /// <summary>
        /// This method adds the given Expenditure object in the end of the List.
        /// </summary>
        /// <param name="task"></param>
        public void Add(Expenditure expenditure)
        {
            expenditureList.Add(expenditure);
            expenditureList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }




        /// <summary>
        /// This method changes the Expenditure object with a new one.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newIncome"></param>
        public void Edit(int index, Expenditure newExpend)
        {
            expenditureList[index] = newExpend;
            expenditureList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        ///  This method deletes a Expenditure object at the given position.
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            expenditureList.RemoveAt(index);
            expenditureList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        /// This method creat a new Expenditure object with given parameters and adds the new Expenditure object in the end of the List.
        /// </summary>
        /// <param name="task"></param>
        public void Add(DateTime date, string description, ExpencesEnum category, int amount)
        {
            expenditureList.Add(new Expenditure(date, description, category, amount));
            expenditureList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        /// This method returns an array of strings where each string is a formatted text line containing data for each Expenditure object.
        /// </summary>
        /// <returns></returns>
        public string[] ListToStringArray()
        {
            string[] expenditureArray = new string[Count];
            for (int i = 0; i < Count; i++) expenditureArray[i] = expenditureList[i].ToString();
            return expenditureArray;
        }


        /// <summary>
        /// This method returns the total amount of the Expences from the expenditureList
        /// </summary>
        /// <returns></returns>
        public int totalIncomeAmount()
        {
            int total = 0;
            for (int i = 0; i < Count; i++) total += expenditureList[i].Amount;
            return total;
        }
    }
}
