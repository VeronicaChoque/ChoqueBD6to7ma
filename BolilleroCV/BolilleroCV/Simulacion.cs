using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolilleroCV
{
    class Simulacion
    {
        public Bolillero bolillero { get; set; }

        public long simularSinHilos(List<int> jugada,long cantSimu)
        {
            return (long)bolillero.jugar(jugada, cantSimu); 
        }
    }
}
