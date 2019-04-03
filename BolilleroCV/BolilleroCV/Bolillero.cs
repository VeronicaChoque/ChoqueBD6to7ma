using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolilleroCV
{
    public class Bolillero:ICloneable
    {
        Random r;
        public List<int> bolillasAdentro { get; set; }
        public List<int> bolillasAfuera { get; set; }
        public Bolillero()
        {
            var bolillasAdentro = new List<int>();
            var bolillasAfuera = new List<int>();
            var r = new Random(DateTime.Now.Millisecond);
        }

        private int indiceAlAzar()
        {     
            return r.Next(0, bolillasAdentro.Count);
        }
        public int sacarBolilla()
        {
            int bolilla = bolillasAdentro[indiceAlAzar()];
            sacarBolilla(bolilla);
            return bolilla;

        }

        private void sacarBolilla(int bolilla)
        {
            bolillasAdentro.Remove(bolilla);
            bolillasAfuera.Add(bolilla);
        }
        public void reingresarBolillas()
        {
            bolillasAdentro.AddRange(bolillasAfuera);
            bolillasAfuera.Clear();
        }

        public bool jugar(List<int> jugada)
        {
            for(byte i=0;i<jugada.Count;i++)
            {
                if(jugada[i]!=this.sacarBolilla())
                {
                    return false;
                }
            } return true;
        }

        public long jugar(List<int> jugada , long cantSimu)
        {
            long cont = 0;
            for (long i=0;i<cantSimu;i++)
            {
                if (jugar(jugada))
                {
                    cont++;
                }
                reingresarBolillas();

            }
            return cont;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
