﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Practice6
{
    public class Araba
    {
        public DateTime UretimTarihi { get; set; }
        public string SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
    }
}
