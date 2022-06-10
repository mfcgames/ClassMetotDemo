using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {


        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" İsimli Müşteri Başarıyla Eklendi.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+musteri.Surname+" İsimli Müşteri Silindi.");
        }
        public void MusteriListele(Musteri musteri)
        {

            Console.WriteLine(musteri.Name+ " " + musteri.Surname);
        }
    }
}
