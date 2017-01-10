using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil
{
    class Tofas : Otomobil
    {

        public Tofas()
        {
            seri = "Serce";
            model = "Murat 131";
            motorGucu = 65;
            motorHacmi = 1400;
        }

        public override string Calistir()
        {
            return "tır tır tır";
        }
    }
}
