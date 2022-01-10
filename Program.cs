using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_beliriteci geri_donustipi metot_adi(parametrelistesi/arguman)
            //{
                //Komutlar;
            //}

            int a= 2;
            int b= 3;
            System.Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            System.Console.WriteLine(sonuc);
            
            Metotlat ornek = new Metotlat();
            ornek.EkranaYazdir(sonuc.ToString());
            int sonuc2 = ornek.ArttirVeTopla(a,b);
            System.Console.WriteLine(sonuc2);

        }
        static int Topla(int deger1,int deger2)
        {
            return(deger1+deger2);
        }

    }

    class Metotlat
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public int ArttirVeTopla(int deger1,int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1 + deger2;
        }

    }


}
