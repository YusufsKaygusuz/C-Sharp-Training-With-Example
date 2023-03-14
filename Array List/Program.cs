using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arraylist Kullanımı
            /*
             ArrayList formumuzu kullanabilmemiz için *using System.Collections* kütüphanemizi eklememiz gerekmektedir.  
             ArrayList ¨class¨ yapıda olduğu için bizim bir tanımlama yaparak kulanmamız gerekir.
            */

            ArrayList SınıfListesi = new ArrayList();
            ArrayList Numaralar = new ArrayList();

            SınıfListesi.Add("Selin");
            SınıfListesi.Add("Beyza");
            SınıfListesi.Add("Yusuf");
            SınıfListesi.Add("Dilara");
            SınıfListesi.Add("Ismail");
            SınıfListesi.Add("Rümeysa");
            SınıfListesi.Add("Gökberk");

            Numaralar.Add(415);
            Numaralar.Add(874);
            Numaralar.Add(695);
            Numaralar.Add(582);
            Numaralar.Add(465);
            Numaralar.Add(815);
            Numaralar.Add(849);

            // Diziye kenddi belirlediğimiz sırada olması şartıyla yeni bir eleman daha ekleme.
            SınıfListesi.Insert(3, "*Begüm*");
            Numaralar.Insert(3, 1);

            for (int i=0; i<SınıfListesi.Count; i++)
            {
                Console.WriteLine(SınıfListesi[i] + "\t" + Numaralar[i]);
            }

            Console.WriteLine("\n\n**Foreach Kullanımı**\n");

            // Foreach ile elemanlara ulaşalım ve ayrıca .Remove ile bir elamanı kaldıralım.
            //Numaralar.Remove(849);

            // Belirlediğimiz elemanın dizideki kaçıncı elemana denk geldiğini bulmak için  kullanmalıyız.
            int InWhatOrder = SınıfListesi.IndexOf("Yusuf");
            Console.WriteLine("Yusuf {0}. sırada yer almaktadır.", (InWhatOrder + 1));
        
            // Diziyi tamamen sıfırlamak için .Clear kullanmalıyız.
            // Numaralar.Clear();

            // Sorgulamak amaçlı oluşturduğumuz elemanın arrayın içine olup olmadığı öğrenmek için .contain kullanmalıyız.
            bool WhetherIsThere = Numaralar.Contains(849);
            Console.WriteLine("Seçtiğiniz eleman true ise var false ise yok anlamına gelmektedir." + WhetherIsThere );

            // Dizideki toplam elemanan sayısını bulmak için .count kullanmalıyız.  
            int TotalValueInArray  = Numaralar.Count;

            // Diziye kenddi belirlediğimiz sırada olması şartıyla yeni bir eleman daha ekleme.
            //Numaralar.Insert(4, 1);

            // Dizideki tüm sıralamayı ters çevirmek için .reverse kullanılır.
            //Numaralar.Reverse();

            // Diziyi Sıralamak için .sort kullanabiliriz.
            Numaralar.Sort();

            foreach (var a in Numaralar)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Toplam eleman sayısı: " + TotalValueInArray);


            Console.ReadLine();
        }
    }
}
