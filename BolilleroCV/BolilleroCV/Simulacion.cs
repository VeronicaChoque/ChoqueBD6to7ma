using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolilleroCV
{
    public class Simulacion
    {
        public Bolillero Bolillero { get; set; }
        public long CantidadSimulaciones { get; set; }
        public long CantidadAciertos { get; private set; }
        public List<int> jugada { get; set; }

        public double PorcentajeAciertos
        {
            get
            {
                return CantidadAciertos * 100 / CantidadSimulaciones;
            }
        }

        public long simularSinHilos()
        {
            return (long)Bolillero.jugar(jugada, CantidadSimulaciones); 
        }


        public void simularConHilos(int cantidadHilos)
        {
            List<Task<long>> hilos = new List<Task<long>>();
            //List<Bolillero> bolillero = new List<Bolillero>();

            long cantPorHilo = CantidadSimulaciones / cantidadHilos;

            for (int i = 0; i < cantidadHilos; i++)
            {
                Bolillero bolilleroClon = (Bolillero)Bolillero.Clone();
                Task<long> tarea = new Task<long>(() => bolilleroClon.jugar(jugada, CantidadSimulaciones));
                hilos.Add(tarea);
            }

            hilos.ForEach(hilo => hilo.Start());
            while (!hilos.TrueForAll(hilo => hilo.IsCompleted)) ;

            this.CantidadAciertos = 0;
            hilos.ForEach(hilo => CantidadAciertos += hilo.Result);
        }      
    }
}
