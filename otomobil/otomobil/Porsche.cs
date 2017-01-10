using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil
{
    class Porsche : Otomobil
    {
        public Porsche()
        {
            seri = "Gt";
            model = "911";
            motorGucu = 400;
            motorHacmi = 3000;
        }

        public override Calistir()
        {
            return "Vrom Vrom";
        }
    }
}
