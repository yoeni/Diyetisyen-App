﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyetisyen_Application
{
    public class Hasta : User
    {
        private IDiyet Diyet { get; set; }
        private IHastalik Hastalik { get; set; }
        public Hasta(string tcNo, string isim, string soyisim) : base(tcNo, isim, soyisim, null)
        {
            Diyet = null;
            Hastalik = null;
        }
        public void DiyetYaz(IDiyet diyet)
        {
            this.Diyet = diyet;
        }
        public void HastalikAta(IHastalik hastalik)
        {
            this.Hastalik = hastalik;
        }
        public string DiyetBilgisi()
        {
            return (Diyet!=null? Diyet.Bilgi() : "Diyet Ataması Gerçekleşmedi!");
        }
        public string HastalikBilgisi()
        {
            return (Hastalik != null ? Hastalik.Bilgi() : "Hastalık Ataması Gerçekleşmedi!");
        }
    }
}
