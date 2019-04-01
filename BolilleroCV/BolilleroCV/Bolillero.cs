using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolilleroCV
{
    public class Bolillero
    {
        Random r;
        public List<int> bolillas { get; set; }
        public Bolillero()
        {
            var bolillas = new List<byte>();
            var r = new Random();
        }

        public byte sacarBolilla()
        {
            bolillas = r.Next(0,);

        }
        public void volverAponer()
        {

        }
    }
}
