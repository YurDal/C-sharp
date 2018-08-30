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
    /// (2) calculating the sum of inputs
    /// (3) displeying the sum
    /// </summary>
    class FloatingPointsNumberWhileAdd
    {

        private double sum;
        internal void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResult();
        }


        /// <summary>
        /// This metod reads double values and sum upp all input values.
        /// The results are stored in instance variable sum.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            bool done = false;
            double num;

            while (!done)
            {
                num = ReadInput();
                sum += num;
                if ((Math.Round(num, 7) == 0.0))
                {
                    done = true;
                }
            }
        }

        /// <summary>
        /// This metod displeying information about the program
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++++++++ Summation of real numbers +++++++++++++");
            Console.WriteLine("                     Using While-statement\n");
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use correct decimal character.");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This method reads user input from console
        /// </summary>
        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            double num = Input.ReadDoubleConsole();
            return num;
        }


        /// <summary>
        /// This metod displeying the result of the program
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Thu sum is \t{0}", sum);
            Console.WriteLine();
        }
    }
}
