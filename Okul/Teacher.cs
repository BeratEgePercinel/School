using System;
using System.Collections.Generic;
using System.Text;

namespace Okul
{
    class Öğretmen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Branş { get; set; }
        public string TelefonNumarası { get; set; }
        public string Ünvan { get; set; }
        public string ID { get; set; }
        public Sınıf Sınıf { get; set; }
        public int SınıfId { get; set; }
    }
}
