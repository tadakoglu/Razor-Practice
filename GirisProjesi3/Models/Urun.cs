using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GirisProjesi3.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Kategori { set; get; }
    }
}
