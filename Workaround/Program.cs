using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Degiskenler();

            //Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(3, 5);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "İlker";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); //Adana olur


            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //sayi2 =?;  //10 olur değer tipli

            
            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string>yeniSehirler1=new List<string> { "Ankara 1", " istanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach(var sehir in yeniSehirler1)
            { 
                Console.WriteLine(sehir); 
            }

            Console.ReadLine();
        }

        //resharper
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        //    private static void Degiskenler()
        //    {
        //        string mesaj = "Merhaba";
        //        double tutar = 100000;   //db den gelir
        //        int sayi = 100;
        //        bool girisYapmisMi = false;

        //        string ad = "Engin";
        //        string soyad = "Demiroğ";
        //        int dogumYili = 1985;
        //        long tcNo = 11111111111;

        //        Console.WriteLine(tutar * 1.18);

        //        Console.WriteLine(tutar * 1.18);
        //    }
        //}
        ////pascal casing
        //public class Vatandas
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set;}
        //    public int DogumYili { get; set;}
        //    public long TcNo { get; set;}
        //}
    }
}
