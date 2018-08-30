
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
    public class PetOwnerMain
    {

        static void Main(string[] args)
        {
            Pet pet = new Pet();
            pet.Start();
            //  Book book = new Book();
            //   book.start();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
