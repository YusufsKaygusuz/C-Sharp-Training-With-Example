using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginnig_of_INHERITANCE
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kedi = new Cat();

            kedi.AnimalName = "Boncuk";
            kedi.AnimalGender = "Female";
            kedi.AnimalColor = "White";
            kedi.AnimalAge = 2; 
            kedi.ShowAnimalInfo();


            Console.ReadLine();
        }
    }
}
