using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceApp
{
    /// <summary>
    ///  This class use a List object for storing objects of type Income.
    /// </summary>
    public class IncomeManager
    {
        
        private List<Income> incomeList; 



        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeManager()
        {
            incomeList = new List<Income>();
        }



        /// <summary>
        /// This method retruns the numbers of total elements in the incomeList;
        /// </summary>
        public int Count
        {
            get
            {
                return incomeList.Count;
            }

        }



        /// <summary>
        /// This method returns an Income object from the incomeList at given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Income GetIncomeAt(int index)
        {
        
            if ((index <= -1) || (index >= incomeList.Count))
            {
          
                return null ;
            }
            
            else{
                return incomeList[index];
            }
        }



        /// <summary>
        /// This method changes the Income object with a new one.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newIncome"></param>
        public void Edit(int index, Income newIncome)
        {
            incomeList[index] = newIncome;
            incomeList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        ///  This method deletes a Income object at the given position.
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            incomeList.RemoveAt(index);
            incomeList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        /// This method adds the given Income object in the end of the List.
        /// </summary>
        /// <param name="task"></param>
        public void Add(Income income)
        {
            incomeList.Add(income);
            incomeList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        /// This method creat a new Incame obejct with given parameters and adds the new Income object in the end of the List.
        /// </summary>
        /// <param name="task"></param>
        public void Add(DateTime date, string description, IncomesEnum category, int amount)
        {
            incomeList.Add(new Income(date,description,category,amount));
            incomeList.Sort((x, y) => x.Date.CompareTo(y.Date));
        }



        /// <summary>
        /// This method returns an array of strings where each string is a formatted text line containing data for each Income object.
        /// </summary>
        /// <returns></returns>
        public string[] ListToStringArray()
        {
            string[] incomeArray = new string[Count];
            for (int i = 0; i < Count; i++) incomeArray[i] = incomeList[i].ToString();
            return incomeArray;
        }



        /// <summary>
        /// This method returns the total amount of the Incomes from the incomeList
        /// </summary>
        /// <returns></returns>
        public int totalIncomeAmount()
        {
            int total = 0;
            for (int i = 0; i < Count; i++) total += incomeList[i].Amount;
            return total;
        }

    }
}
