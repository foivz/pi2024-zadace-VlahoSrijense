using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ_Menza_.Models
{
    public class Narudzba
    {
        public int idNarudzbe {  get; set; }
        public int idObroka { get; set; }
        public int kolicina { get;set; }
        public float ukupnaCijena {  get; set; }
        public string statusNarudzbe { get; set; }
        public string vrijemeNarudzbe { get; set; }

    }
}
