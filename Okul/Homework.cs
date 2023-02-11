using System;
using System.Collections.Generic;
using System.Text;

namespace Okul
{
    class Ödev
    {
        public string Ad { get; set; }
        public string Konu { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string ID { get; set; }
        public Öğretmen Öğretmen { get; set; }
        public int ÖğretmenId { get; set; }
    }
}
