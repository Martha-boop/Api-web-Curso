using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.moldes
{
    public class Batalha
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DTinicio { get; set; }
        public DateTime DTfim { get; set; }
        public List<HeroiBatalha> heroiBatalhas { get; set; }
    }
}
