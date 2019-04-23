using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinSem2.Classes
{
    static class CaracteresInvalidos
    {
        public static int RevCaracteresInvalidos(string nombre, int checador)
        {
            string[] archivo = File.ReadAllLines(@"C:\Users\mtorr\source\repos\NewRepo4\ProyectoFinSem2\ProyectoFinSem2\CaracteresEspeciales.txt");

            List<char> caracteres = new List<char>();
            List<char> carNombre = new List<char>();

            foreach(string s in archivo)
            {
                caracteres.Add(char.Parse(s));
            }

            foreach (char c in nombre)
            {
                carNombre.Add(c);
            }

            for (int i = 0; i < carNombre.Count(); i++)
            {
                for (int k = 0; k < caracteres.Count(); k++)
                {
                    if (carNombre[i] == caracteres[k])
                    {
                        Console.WriteLine("No seguiste las instrucciones, vuelve a intentar. ");
                        Console.WriteLine();
                        checador++;
                        return checador;
                        break;
                    }
                }
            }

            return checador;

        }
    }
}
