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
    /// This class calculates temperatures from 0 to 100
    /// degrees Cecius to corresponding Fahrenhaitvalues.
    /// The result show as a table in the console.
    /// </summary>
    class Temperatures
    {
        internal void Start()
        {
            WriteProgramInfo();
            ReadAndshowTable();

        }

        /// <summary>
        /// This metod reads user input and displays a list.
        /// </summary>
        private void ReadAndshowTable()
        {
            bool rule = false;
            int choise;

            while (!rule)
            {
                showChoieses();
                choise = ReadInput();
                switch (choise)
                {
                    case 1:
                        CelciusToFahrenheit();
                        break;
                    case 2:
                        FahrenheitToCelcius();
                        break;
                    case 0:
                        rule = true;
                        break;
                }
            }
        }
        /// <summary>
        ///This metod calculating displeying a result table of converting from Fahrenheit to Celcius
        /// </summary>
        private void FahrenheitToCelcius()
        {
            Console.WriteLine("     Temperature Table");
            Console.WriteLine("Fahrenheit (F) to Changing Celcius (C) ");
            Console.WriteLine("\n-------------------------------");
            for (int index = 0; index < 100; index += 4)
            {
                Console.Write("{0:f2} F = {1:f2} C", index, (5.0 / 9.0 * (index -32)));
                Console.WriteLine();
            }
            Console.WriteLine("\n-------------------------------\n");
        }

        /// <summary>
        /// This method reads user choise from console
        /// </summary>
        private int ReadInput()
        {
            Console.Write("Your choise: ");
            return Input.ReadIntegerConsole();
        }

        /// <summary>
        /// This metod displeys the choises for the user
        /// </summary>
        private void showChoieses()
        {
            Console.WriteLine("\n1 Celcius to Fahrenheit");
            Console.WriteLine("2 Farenheit to Celcius");
            Console.WriteLine("0 Return to Main Menu\n");

        }

        /// <summary>
        /// This metod displeying information about the program
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n               TEMPERATURE CONVERTER             ");
            Console.WriteLine("Select from the menu which table you would like to see.");
            Console.WriteLine("-----------------------------------------------------------------\n");
        }
        /// <summary>
        /// This metod calculating displeying a result table of converting from Celcius to Fahrenheit
        /// </summary>
        private void CelciusToFahrenheit()
        {
            Console.WriteLine("\n     Temperature Table");
            Console.WriteLine(" Changing Celcius (C) to Fahrenheit (F)");
            Console.WriteLine("\n-------------------------------");
            for (int index = 0; index <= 100; index += 4)
            {
                Console.Write("{0:f2} C = {1:f2} F",index,((9.0/5.0)*index+32));
                Console.WriteLine();
            }
            Console.WriteLine("\n-------------------------------\n");
        }
    }
}
