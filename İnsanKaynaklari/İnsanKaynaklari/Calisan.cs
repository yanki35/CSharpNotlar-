using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
    class Calisan
    {
        public int sskNo { get; set; }
        public double maas { get; set; }
        public string elemanTuru { get; set; }

        public override string ToString()
        {
            return string.Format("SSK NO\t : {0}\nMaas\t : {1}", sskNo, maas);
        }

        public virtual double ZamYap(int satis)
        {
            double ekMaas = satis * 10;
            return maas + ekMaas;
        }
    }
}
