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
    /// This class contains methods which can handle the user input.
    /// </summary>
    class Input
    {

        /// <summary>
        /// Reads an integer from console untill a correct integer is recived.
        /// </summary>
        /// <returns>An integer</returns>
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadIntegerConsole();
        }

        /// <summary>
        /// Reads an double from console untill a correct double is recived.
        /// </summary>
        /// <returns>An double</returns>
        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.WriteLine("Wrong input. Please try again: ");
            return ReadDoubleConsole();
        }
    }
}
