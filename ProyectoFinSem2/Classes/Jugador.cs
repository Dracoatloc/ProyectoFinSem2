using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinSem2.Classes
{
    class Jugador:Personajes
    {
        //private string nombre;

        private int vida = 20;

        List<char> carNombre;

        int contador = 0; //Este rompe el ciclo si no se encuentran errores al momento de hacer el jugador
        int checador = 0; //Este solamente sirve para ciclar todo, en el caso de que hayan errores.


        //Este metodo es unicamente cuando inicie el juego; es el intro del personaje

        public void IniciarNombre()
        {
            Console.Write("Se sabe que tu apellido es Snow por ser bastardo, pero no se sabe tu primer nombre."); Console.ReadKey(); Console.WriteLine();

            while (contador != 1)
            {
                Console.Write("Ingresa en la siguiente linea un nombre sin caracteres especiales comunes (los que están en el teclado)."); Console.ReadKey(); Console.WriteLine();

                nombre = Console.ReadLine();
                carNombre = new List<char>();

                foreach (char c in nombre)
                {
                    carNombre.Add(c);
                }

                checador = CaracteresInvalidos.RevCaracteresInvalidos(nombre, contador);

                if (checador >= 1)
                {
                    checador = 0;
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Entonces tu nombre completo es {0} Snow.", nombre); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    Console.Write("Eres el electo señor comandante número 998 de la Guardia Nocturna, una orden militar situada en El Muro, al extremo norte de Westeros, que lleva más de 8000 años activa."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Sin embargo, situaciones graves comenzaron a emerger, eventualmente provocando tu asesinato por parte de algunos hermanos de la Guardia Nocturna."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Melissandre, una sacerdotisa, en conjunto con los esfuerzos de Tormund y Sir Davos, intentan revivirte con magia antigua del Dios Rojo."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Después de varias horas de rezar por parte de la sacerdotisa, la esperanza se va, y salen de la habitación sin intentar más."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Poco sabían ellos, que un milagro estaba por suceder."); Console.ReadKey(); Console.WriteLine();
                    contador++;
                }
            }
        }
    }
}
