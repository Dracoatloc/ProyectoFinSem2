using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinSem2.Classes
{
    class Personajes
    {
        /*
        Davos Seaworth[0]
        Tormund Giantsbane[1]
        Melissandre of Asshai[2]
        Sansa Stark[3]
        Dolorous Edd[4]
        Robett Glover[5]
        Lyanna Mormont[6]
        Ramsay Bolton[7]
        */

        string[] personajes;
        protected string nombre;
        public Personajes()
        {
            personajes = File.ReadAllLines(@"C:\Users\mtorr\source\repos\ProyectoFinalS2\Personajes.txt");
        }

        public string SacaPersonaje(int i)
        {
            return personajes[i];
        }
    }
}
