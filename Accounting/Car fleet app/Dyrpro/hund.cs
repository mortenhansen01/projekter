using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrpro
{
    public class Hund : Dyr
    {
        
        public Hund(string navn,int ojne, int ben, string morsnavn) : base(navn, ojne, ben)
        {
            this.morsnavn = morsnavn;
        }

        public string Morsnavn { get; set; }
        private string morsnavn;
    }
};

