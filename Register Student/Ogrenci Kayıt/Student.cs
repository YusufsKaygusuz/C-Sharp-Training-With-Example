using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Kayıt
{
    class Student
    {
        
        public string NameSurname { get; }
        public int Numara { get; }

        private double Average;
        public double average 
        {
            get
            {
                return Average;
            }

                set
            {
                if (value >= 0.0 && value <= 4.0)
                    Average = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Average), "0 ve 4.0 aralığında olmalı.");

            }
        }
        private string Email;
        public string email {
            get
            {
                return Email;
            }
            set
            {
                var mailAdress = new System.Net.Mail.MailAddress(value);
                if(mailAdress.Address == value)
                {
                    Email = value;
                }
                else
                {
                    throw new Exception("Geçerli bir email adresi girilmedi.");
                }
            }
  
           }

       
        #region Constructors

        public Student(string isimSoyi, int numara)
        {
            Numara = numara;
            NameSurname = isimSoyi;
            this.average = 0.0;
            this.Email = isimSoyi.Replace(" ", string.Empty) + "@hotmail.com";
        }
        public Student(string isimSoyisim,int numara, string EMAİL, double ortalama)
            :this(isimSoyisim,numara)
        {
            this.email = EMAİL;
            this.average = ortalama;
        }

        public string InfoStudent()
        {
            return $"İsim Soyisim: {NameSurname}\nNumara: {Numara}\nOrtalama: {Average}\nEmail: {email}"; 
        }
        
        #endregion




    }
}
