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
    /// Main class of the project Assignment2
    /// </summary>
    class MainProgram
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();
        }
    }
}
