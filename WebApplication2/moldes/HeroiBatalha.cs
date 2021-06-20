using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.moldes
{
    public class HeroiBatalha
    {
        public int HeroiId { get; set; }
        public Heroi Heroi  { get; set; }
        public int BatalhaID { get; set; }
        public Batalha Batalha { get; set; }
    }
}
