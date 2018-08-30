using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// @author Yurdaer Dalkic 
    /// date : 12/10/2017
    /// This class handle of the fallowing processes
    /// (1) reading input (double) from console 
    /// (2) sum all input value
    /// (3) reading the name of foreig currency
    /// (4) reading the exchange value (double)
    /// (5) convert the sum to a value int the foreign currency
    /// (6) display result
    /// </summary>
    class CurrencyConverter
    {
        private double sum;
        private double result;
        private String currencyName;
        private double exchangeRate;
        internal void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ReadCurrencyInfo();
            CalculateResult();
            ShowResult();
        }

        /// <summary>
        /// This metod converts the sum to a value in the foreig currency.
        /// The result stores in instance variable.
        /// </summary>
        private void CalculateResult()
        {
            result = sum / exchangeRate;
        }

        /// <summary>
        /// This metod displeying the result of the program
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Thu sum is {0:C}", sum);
            Console.WriteLine("{0:C} converted to {1:f2} {2} at the exchange rate {3:C}/{2}",sum,result,currencyName,exchangeRate);
        }
        /// <summary>
        /// This metod reads double values and sum upp all input values.
        /// The results are stored in instance variable sum.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            bool done = false;
            sum = 0;
            double num;

            do
            {
                num = ReadInput();
                sum += num;
                if ((Math.Round(num, 7) == 0.0))
                {
                    done = true;
                }
            } while (!done);
        }

        /// <summary>
        /// This methor reads foreign currency nama and exchange rate.
        /// The inputs stores in instance variables.
        /// </summary>
      private void ReadCurrencyInfo()
        {
            Console.Write("Name of the forign currency: ");
            currencyName = Console.ReadLine();
            Console.Write("Exchange rate: ");
            exchangeRate = Input.ReadDoubleConsole();
        }

        /// <summary>
        /// This method reads user input from console
        /// </summary>
        private double ReadInput()
        {
            Console.Write("Write an amount or zero to finish: ");
            return Input.ReadDoubleConsole();
        }
        /// <summary>
        /// This metod displeying information about the program
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++++++++ The Currency Converter +++++++++++++\n");
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use correct decimal carracter\n");

        }
    }
}
