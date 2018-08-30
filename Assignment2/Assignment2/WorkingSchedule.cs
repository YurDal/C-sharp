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
    /// This class handles an action that the user can display a list
    /// of the week numbers that user has to work the weekends and the
    /// the user should work nights. 
    /// (I choised a while statement because number of itterations
    /// is not known. I prefered a switch case statement because it is a usefull statement
    /// when the user hava several choises.)
    /// </summary>
    class WorkingSchedule
    {
        internal void Start()
        {
            WriteProgramInfo();
            ReadAndshowSchedule();
        }

        /// <summary>
        /// This metod reads user input and displays a list.
        /// The methor contains a while loop which will repaet itself untill the
        /// user coise value 0.
        /// </summary>
        private void ReadAndshowSchedule()
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
                        ShowWeekends();
                        break;
                    case 2:
                        ShowNights();
                        break;
                    case 0:
                        rule = true;
                        break;
                }
            }
        }

        /// <summary>
        /// This method displeying a list of the nights to work.
        /// </summary>
        private void ShowNights()
        {
            Console.WriteLine("Your schedule of the above option as fallows: \n");
            for (int index = 6; index <= 52; index += 5)
            {
                Console.Write("          Week " + index);
                Console.WriteLine();

            }
            Console.WriteLine("\n-------------------------------");


        }

        /// <summary>
        /// This metod displeying a list of the weekends to work.
        /// </summary>
        private void ShowWeekends()
        {
            Console.WriteLine("Your schedule of the above option as fallows: \n");
            for (int index = 1; index <= 52; index += 3)
            {
                Console.Write("          Week " + index);
                    Console.WriteLine();
            }
            Console.WriteLine("\n-------------------------------");
        }

        /// <summary>
        /// This metod displeying information about the program
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n               YOUR SCHEDULE PROGRAM             ");
            Console.WriteLine("Select from the menu which type of scheule you would like to see.");
            Console.WriteLine("-----------------------------------------------------------------\n");
        }

        /// <summary>
        /// This metod displeys the choises for the user
        /// </summary>
        private void showChoieses()
        {
            Console.WriteLine("\n1 Show a list of the weekends to work");
            Console.WriteLine("2 Show a list of the nights to work");
            Console.WriteLine("0 Return to Main Menu\n");

        }
        /// <summary>
        /// This method reads user choise from console
        /// </summary>
        private int ReadInput()
        {
            Console.Write("Your choise: ");
            return Input.ReadIntegerConsole();
        }
    }
}
