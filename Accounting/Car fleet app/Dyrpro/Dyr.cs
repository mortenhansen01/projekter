using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrpro
{
    public class Dyr
    {
        public Dyr(string navn, int ojne, int ben)
        {
            this.Navn = navn;
            this.Ben = ben;
            this.ojne = ojne;
        }
        private string navn;
        public string Navn;

        public int nul = 0;
        private int ojne;
        public int Ojne { get; set; }
        public int Ben { get; set; }
        private int ben;
    }

}


