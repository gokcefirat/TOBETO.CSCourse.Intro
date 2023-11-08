using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
