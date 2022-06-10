using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteri = new Musteri[3];
            musteri[0] = new Musteri();
            musteri[1] = new Musteri();
            musteri[2] = new Musteri();
            musteri[0].Name = "Ahmet";
            musteri[0].Surname = "Mantıksız";
            musteri[0].Id = 1;
            musteri[1].Name = "Murtaza";
            musteri[1].Surname = "Yumurta";
            musteri[1].Id = 2;
            musteri[2].Id = 3;
            musteri[2].Name = "Yeliz";
            musteri[2].Surname = "Yeşilmen";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri[0]);
            musteriManager.MusteriListele(musteri[1]);
            musteriManager.MusteriSil(musteri[2]);

        }
    }
}
