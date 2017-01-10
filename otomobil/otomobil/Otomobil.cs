using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil
{
    class Otomobil
    {
        public string seri { get; set; }

        public string model { get; set; }

        public int motorGucu { get; set; }

        public int motorHacmi { get; set; }


        public string Yazdir();
        {
        return string.Format("Seri: {0} Model: {1} Motor Gücü: {2} Motor Hacmi: {3}", seri, model, motorGucu, motorHacmi);
        }

    public virtual string Calistir()
    {
        return "Otomobil Çalıştı.";
    }

   }

 }

