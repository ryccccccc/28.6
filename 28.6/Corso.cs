using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int NumEdizione{ get; set; }
        public List<Studente> StudentiPartecipanti { get; set; }
        public List<Lezione> LezioniCorso { get; set; }
    }
}
