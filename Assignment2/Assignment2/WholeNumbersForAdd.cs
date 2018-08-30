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
    /// (1) reading input from console
    /// (2) calculating the sum of inputs
    /// (3) displeying the sum
    /// </summary>
    class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;
        internal void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumbers();
            ShowResult();
        }
        /// <summary>
        /// This metod displeying information about the program
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++++++++ Summation of hole numbers +++++++++++++");
            Console.WriteLine("                     Using a for-statement\n");
            Console.WriteLine();
        }

        /// <summary>
        /// This method reads user input from console
        /// </summary>
        private void ReadInput()
        {
            Console.Write("Number of values to sum? ");
            numOfInput = Input.ReadIntegerConsole();
        }

        /// <summary>
        /// This method sums upp the all user input and results
        /// are stored in the instance variable sum.
        /// </summary>
        private void SumNumbers()
        {
            int index;
            sum = 0;

            for (index = 0; index < numOfInput; index++)
            {
                Console.Write("Please give the value no " + (index + 1) + " <whole number>: ");
                sum += Input.ReadIntegerConsole();
            }
        }

        /// <summary>
        /// This metod displeying the result of the program
        /// </summary>
        private void ShowResult()
        {
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Thu sum is \t{0}", sum);
            Console.WriteLine();
        }
    }
}
