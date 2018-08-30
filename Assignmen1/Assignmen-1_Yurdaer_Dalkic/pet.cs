using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen_1_Yurdaer_Dalkic
{
    /// <summary>
    ///  @author Yurdaer Dalkic 
    ///  date : 20/09/2017
    /// </summary>
    public class Pet
    {
        private string name; // name of the pet
        private int age;  // age of the pet
        private bool isFemale;  // female or male ?

        /// <summary>
        /// Start metod som anropar andra metoder för inmattning och utskrivning
        /// </summary>
        public void Start()
        {
            CostumConsole();
            ReadInput();
            WriteInfo();
        }
        /// <summary>
        /// Metod som konfigurerar konsolen
        /// </summary>
        private void CostumConsole()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "Assigment-1";
        }
        /// <summary>
        /// Metod som skriver ut information om pet objekt
        /// </summary>
        private void WriteInfo()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Name : " + name + ", Age : " + age);
            if (isFemale)
            {
                Console.WriteLine(name + " is a good girl");

            }
            else
            {
                Console.WriteLine(name + " is a good boy");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++");
        }
        /// <summary>
        /// Metod som anropar andra metoder för inmattning
        /// </summary>
        private void ReadInput()
        {
            ReadName();
            ReadAge();
            ReadGender();
        }
        /// <summary>
        /// Metod som läser in gender
        /// </summary>
        private void ReadGender()
        {
            Console.WriteLine("Is your pet a female (y/n) ?");
            char temp = Char.Parse(Console.ReadLine());
            if (temp == 'y' || temp == 'Y')
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }
        /// <summary>
        /// Metod som läser in age
        /// </summary>
        private void ReadAge()
        {
            Console.WriteLine("What is the age of the " + name + "?");
            age = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Metod som läser in name
        /// </summary>
        private void ReadName()
        {
            Console.WriteLine("Greetings from a pet object");
            Console.WriteLine("");
            Console.WriteLine("What is the name of your pet ?");
            name = Console.ReadLine();
        }
    }



}
