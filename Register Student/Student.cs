using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Kayıt
{
    class Student
    {
        // İsim ve soyisim özelliği
        private string _nameSurname;
        public string NameSurname
        {
            get { return _nameSurname; }
            /*
             nameof operatörü, belirtilen bir değişkenin veya özellik adının, string bir ifade olarak geri döndürülmesini sağlar.
             Bu operatör, kodda yapılan değişikliklerin, kodun diğer kısımlarına etkisi olmadan güncellenmesine olanak tanır.
             */

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(NameSurname), "İsim ve soyisim alanı boş bırakılamaz");
                
                _nameSurname = value;
            }
        }

        // Numara özelliği
        private double _numara;

        public double Numara
        {
            get { return _numara; }
            set
            {
                if (value < 0)
                    throw new ArgumentNullException(nameof(Numara), "Numara sıfırdan büyük olmalı.");

                _numara = value;
            }
        }

        // Ortalama özelliği
        private double _average;
        public double Average
        {
            get { return _average; }

            set {
                if (value < 0.0 || value > 4.0)
                    throw new ArgumentNullException(nameof(Average), "Ortalama 0.0 ve 4.0 aralığında olmalı.");
                _average = value;
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
            this.Average = 0.0;
            this.Email = isimSoyi.Replace(" ", string.Empty) + "@hotmail.com";
        }
        public Student(string isimSoyisim,int numara, string EMAİL, double ortalama)
            :this(isimSoyisim,numara)
        {
            this.email = EMAİL;
            this.Average = ortalama;
        }

        public string InfoStudent()
        {
            return $"İsim Soyisim: {NameSurname}\nNumara: {Numara}\nOrtalama: {Average}\nEmail: {email}"; 
        }
        #endregion

    }
}
