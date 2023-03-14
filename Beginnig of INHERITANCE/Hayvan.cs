using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginnig_of_INHERITANCE
{
    public class Hayvan
    {
        public string AnimalName;
        public string AnimalGender;
        public string AnimalColor;
        public int AnimalAge;


        public void ShowAnimalInfo()
        {
            Console.WriteLine("Animal's name is "+ "[" + AnimalName + "]") ;
            Console.WriteLine("Animal's gender is "+ "[" + AnimalGender + "]");
            Console.WriteLine("Animal's color is " + "[" + AnimalColor + "]");
            Console.WriteLine("Animal's Age is " + "[" + AnimalAge + "]");
        }

    }
}
