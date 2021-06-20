using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.moldes
{
    public class Heroi
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public IndentidadeSecreta indentidade { get; set; }
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> heroiBatalhas { get; set; }

    }
}
