using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinSem2.Classes
{
    class MasterControl
    {
        Jugador jugador;
        Personajes prsnjs;
        public MasterControl()
        {
            jugador = new Jugador();
            prsnjs = new Personajes();
        }

        public void Jugar()
        {
            Console.WriteLine("-------LA BATALLA DE LOS BASTARDOS-------");
            Console.WriteLine();

            jugador.IniciarNombre();
        }
    }
}
