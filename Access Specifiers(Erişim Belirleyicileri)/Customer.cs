using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers_Erişim_Belirleyicileri_
{
    class Customer // We have set (adjusted) the access identifier to be "public".
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { 
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("name is not null");
                _name = value;
            }
        }

        public string Surname;
        public float Salary;
        public string Gender;
        public string DateofBirth;

        private double ID = 458741365; // The private specifier can only be used in the class in which it is defined. That is, it is closed
                           // to the outside world.

        public void DemonstrateCusInfo()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Surname: "+ Surname);
            Console.WriteLine("Salary: "+ Salary);
            Console.WriteLine("Gender: "+ Gender);
            Console.WriteLine("Date of Brith: "+ DateofBirth);
            Console.WriteLine("Identity: " +ID);
        }

        private void Name_Surname(string CustomerName, string CustomerSurname)
        {
            Console.WriteLine("Customer's name and surname: " +CustomerName +" " + CustomerSurname);
        }


    }
}
