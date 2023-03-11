using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Yusuf", "Bora", 154);
            Console.WriteLine(student1.GetFullName());
            Console.ReadLine();
            
        }
        /*
         C# programlama dilinde, abstract anahtar kelimesi ile tanımlanan sınıflar,
         somutlaştırılamayan (instantiate edilemeyen) sınıflardır. Bu sınıflar, genellikle bir arayüz gibi davranarak,
         türetilen sınıfların belirli bir davranışı uygulamalarını zorunlu kılmak için kullanılır.

        Bu kod bloğunda, Person sınıfı abstract anahtar kelimesi ile tanımlanmıştır.
        Bu sınıfın içinde, FirstName ve LastName adında iki özellik ve GetFullName adında bir soyut metot bulunmaktadır.

        GetFullName metodu soyut (abstract) olduğu için, bu sınıf doğrudan somutlaştırılamaz.
        Ancak, GetFullName metodu, bu sınıftan türetilen sınıflar tarafından uygulanması gereken bir davranışı tanımlar.
         */

        public abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public abstract string GetFullName();
        }

        public class Student : Person
        {
            private int _studentNumber;
            public int StudentNumber { 
                get
                {
                    return _studentNumber;
                }
                set
                {
                    if(value<0 || value == 0)
                        throw new ArgumentNullException(nameof(StudentNumber), "0' dan büyük olmalı");
                    _studentNumber = value;
                }
            }

            public override string GetFullName()
            {
                return $"{FirstName} {LastName} ({StudentNumber})";
            }
            public Student ()
            { }

            public Student(string first_name, string _lastname) {
                FirstName = first_name;
                LastName = _lastname;
            }
            public Student(string first_name, string _lastname, int _number)
            {
                FirstName = first_name;
                LastName = _lastname;
                StudentNumber = _number;
            }
        }




    }
}
