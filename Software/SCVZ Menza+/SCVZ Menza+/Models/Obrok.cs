using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SCVZ_Menza_.Models
{
    public class Obrok
    {
        public int IdObroka { get; set; }

        public string NazivObroka { get; set;}

        public string OpisObroka { get; set;}

        public int Zaliha { get;set;}

        public float Cijena {  get;set;}

        public override string ToString()
        {
            return NazivObroka;
        }
    }
}
