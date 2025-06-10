using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statico
{
    public class Contador
    {
        public static int TotalContadores = 0;

        public static readonly double Pi = 3.14;

        public int MenbroInstancia = 0;
        static Contador()
        {
            TotalContadores++;
        }
    }
}
