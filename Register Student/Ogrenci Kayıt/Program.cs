using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Kayıt
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Eslem Naz Yanik", 202015463);
            Console.WriteLine(stu.InfoStudent());

            Student stu2 = new Student("Aslıhan Çelik", 20210510, "aslihancelix@gmail.com", 2.69);
            Console.WriteLine("\n" + stu2.InfoStudent());

            Student stu3 = new Student("Rana Selin", 190106084);
            Console.WriteLine("\n" + stu3.InfoStudent());
        }
    }
}
