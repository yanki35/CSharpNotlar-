using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izsu
{
    public class Abone
    {
        public string AboneNo;
        public string AdSoyad;
        public int OncekiSayac;
        public int SonSayac;
        public string AboneTuru;

        public double OdemeHesapla(double onceki, double son, string aboneTuru)
        {
            double result = 0;
            if (aboneTuru == "Ev")
            {
                result = (son - onceki) * 0.3;
            }
            else
            {
                result = (son - onceki) * 0.5;
            }
            return result;
        }

        public override string ToString()
        {
            
               
                return this.AboneNo;
                }
        }
    }

