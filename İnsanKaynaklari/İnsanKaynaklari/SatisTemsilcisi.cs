using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanKaynaklari
{
    class SatisTemsilcisi : Calisan
    {
        public int satisMiktari { get; set; }

        public override double ZamYap(int satis)
        {
            if(satis <= 10)
            {
                maas += satis * 10;
            }
            else if (satis <= 20)
            {
                maas += satis * 20;
            }
            else
            {
                maas += satis * 30;
            }

            return maas;
          
        }
    }
}
