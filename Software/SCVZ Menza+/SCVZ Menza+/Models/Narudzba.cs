using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ_Menza_.Models
{
    public class Narudzba
    {
        public int IdNarudzbe {  get; set; }
        public int IdObroka { get; set; }
        public int Kolicina { get;set; }
        public float UkupnaCijena {  get; set; }
        public string StatusNarudzbe { get; set; }
        public string VrijemeNarudzbe { get; set; }

    }
}
