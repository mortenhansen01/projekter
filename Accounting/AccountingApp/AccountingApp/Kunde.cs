using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    public class Kunde

    {
        public int Saldo { get; set; }
        public void Pengeud(int penge)
        {
            Saldo -= penge;
        }
        public void Pengeind(int penge)
        {
            Saldo += penge;
        }
    }
}
