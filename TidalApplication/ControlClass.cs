using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class ControlClass
    {
        public static int GetNumberForChoice()
        {
            string choiceAsString = Console.ReadLine();
            int choiceAsInteger = 0;

            while(!(int.TryParse(choiceAsString, out choiceAsInteger) && choiceAsInteger >=1 && choiceAsInteger <=5))
            {
                Console.WriteLine("Dear user, you have not inputted a number" +
                    "\nbetween 1 and 5 inclusive. Please, try again");

                choiceAsString = Console.ReadLine();
            }

            return choiceAsInteger;
        }

    }
}
