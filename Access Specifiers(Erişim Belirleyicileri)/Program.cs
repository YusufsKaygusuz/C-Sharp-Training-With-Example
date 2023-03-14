using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers_Erişim_Belirleyicileri_
{
    class Program
    {
        static void Main(string[] args)
        {
            //*public --- *private --- protected --- internal

            Customer client = new Customer();

            client.Name = "Begüm";
            client.Surname = "Yıldırımer";
            client.Gender = "Woman";
            client.DateofBirth = "12/6/2000";
            client.Salary = 2146.01f;
            client.DemonstrateCusInfo();

            Customer client2 = new Customer();
            client2.Name = "NULL"; // If client2.Name is null or empty, system throw error.
            client2.Surname = "mike";
            client2.DemonstrateCusInfo();

            Console.ReadLine();

        }
    }
}
