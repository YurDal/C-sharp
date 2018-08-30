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
    /// Menu
    /// This class handles all about displeying a menu to the user.
    /// The user is given a number of choises. For each choise, an action is taken by the objekt of the class
    /// The Menu repeats itself until the user choise the option zero.
    /// </summary>
    class Menu
    {
        public void Start()
        {
            CostumConsole();
            int choise = -1;

            while (choise != 0)
            {
                WriteMenuText();

                //Read the user input
                choise = Input.ReadIntegerConsole();
                //Depending on the users input, creats an instance of the class displayed on the menu.
                switch (choise)
                {

                    case 1: //Menu item 1
                        WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                        sumObj.Start();
                        break;
                    case 2: //Menu item 2
                        FloatingPointsNumberWhileAdd sumFload = new FloatingPointsNumberWhileAdd();
                        sumFload.Start();
                        break;
                    case 3: //Menu item 3
                        CurrencyConverter converter = new CurrencyConverter();
                        converter.Start();
                        break;
                    case 4: //Menu item 4
                        WorkingSchedule workingSchedule = new WorkingSchedule();
                        workingSchedule.Start();
                        break;
                    case 5: //Menu item 5
                        Temperatures temperatures = new Temperatures();
                        temperatures.Start();
                        break;
                }
            }

        }

        /// <summary>
        /// This metod displeying information about the choises that user can choise
        /// </summary>
        private void WriteMenuText()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("                     MAIN MENU");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("      Whole Numbers with For                  :1");
            Console.WriteLine("      Floationg Point Numbers with While      :2");
            Console.WriteLine("      Currency Converter with Do While loop   :3");
            Console.WriteLine("      Work schedule                           :4");
            Console.WriteLine("      Temperatur Converter                    :5");
            Console.WriteLine("      Exit the program                        :0");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Your choise : ");
        }

        /// <summary>
        /// This method configures the console
        /// </summary>
        private void CostumConsole()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Selection and iteration algorithms";
        }
    }
}
