


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
    class Book
    {
        private string name; // name of the book
        private int year;  // publish year
        private string author;  // name of the author
        private double price; // price of the book

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
        /// Metod som anropar andra metoder för inmattning
        /// </summary>
        private void ReadInput()
        {
            ReadName();
            ReadYear();
            ReadAuthor();
            ReadPrice();
        }

        /// <summary>
        /// Metod som läser in name
        /// </summary>
        private void ReadName()
        {
            Console.WriteLine(" Please enter the name of the book");
            name = Console.ReadLine();
        }
        /// <summary>
        /// Metod som läser in year
        /// </summary>
        private void ReadYear()
        {
            Console.WriteLine("Enter the publish year");
            year = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Metod som läser in author
        /// </summary>
        private void ReadAuthor()
        {
            Console.WriteLine("What is the name of the author ?");
            author = Console.ReadLine();
        }
        /// <summary>
        /// Metod som läser in price
        /// </summary>
        private void ReadPrice()
        {
            Console.WriteLine("How much the book does cost ? (Euro)");
            price = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Metod som skriver ut information om bok objekt
        /// </summary>
        private void WriteInfo()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Name of the book is " + name + ".");
            Console.WriteLine(name + " was published in " + year + ".");
            Console.WriteLine("The book, " + name + " written by " + author + ", is a delight to read.");
            Console.WriteLine("The book costs " + price + " euro.");
            Console.WriteLine("+++++++++++++++++++++++++++++");
        }
    }
}
