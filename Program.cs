using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.menu();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.encuesta();
                        break;
                    case 2:
                        opcion = Pantallas.mostrarDatos();
                        break;
                    case 3:
                        opcion = Pantallas.mostrarResultado();
                        break;
                    case 4:
                        opcion = Pantallas.buscarXEdad();
                        break;
                }

            } while (opcion !=5);
        }
    }
}
