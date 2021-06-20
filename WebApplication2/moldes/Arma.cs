using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.moldes
{
    public class Arma
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public Heroi Heroi{ get; set; }
        public int HeroiID { get; set; }
    }
}
