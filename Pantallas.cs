using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class Pantallas
    {
        public static int[] edades = new int[1000];
        public static bool[] vacunados = new bool[1000];
        public static int contadorEncuestas = 0;

        public static int menu()
        {
            Console.Clear();
            string texto = "================================\r\n" +
                "Encuesta Covid-19\r\n" +
                "================================\r\n" +
                "1: Realizar Encuesta\r\n" +
                "2: Mostrar Datos de la encuesta\r\n" +
                "3: Mostrar Resultados\r\n" +
                "4: Buscar Personas por edad\r\n" +
                "5: Salir\r\n" +
                "================================\r\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opción: ", texto);
        }
        public static int encuesta()
        {
            string texto = "===================================\r\n" +
                "Encuesta de vacunación\r\n" +
                "===================================\r\n";
            Console.Write(texto);

            int edad = Operaciones.getEntero("¿Qué edad tienes?: ", "");
            bool seVacuno = Operaciones.getEntero("¿Te has vacunado?\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n" +
                "===================================\r\n" +
                "Ingrese una opcion: ", "") == 1;

            edades[contadorEncuestas] = edad;
            vacunados[contadorEncuestas] = seVacuno;
            contadorEncuestas++;

            Console.Clear();
            Console.WriteLine("===================================\r\n" +
                              "Encuesta de vacunación\r\n" +
                              "===================================\r\n" +
                              "¡Gracias por participar!\r\n" +
                              "===================================\r\n");

            Console.WriteLine("Presione una tecla para volver al menú...");
            Console.ReadKey();
            return menu();
        }

        public static int mostrarDatos()
        {
            Console.Write("===================================\r\n" +
                "Datos de la encuesta\r\n" +
                "===================================\r\n" +
                "ID    | Edad | Vacunado\r\n" +
                "=======================\r\n");

            for (int i = 0; i < contadorEncuestas; i++)
            {
                Console.WriteLine($"{i:D4}  |  {edades[i]:D2}  |   {(vacunados[i] ? "Si" : "No")}");
            }

            Console.WriteLine("===================================\r\n" +
                "Presione una tecla para regresar ...\r\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }
        public static int mostrarResultado()
        {
            Console.WriteLine("===================================\r\n" +
            "Resultados de la encuesta\r\n" +
            "===================================");

            int personasVacunadas = 0;
            int personasNoVacunadas = 0;

            
            int[] distribucionEdades = new int[6]; 

            for (int i = 0; i < contadorEncuestas; i++)
            {
                if (vacunados[i])
                {
                    personasVacunadas++;
                }
                else
                {
                    personasNoVacunadas++;
                }

                if (edades[i] >= 1 && edades[i] <= 20)
                {
                    distribucionEdades[0]++;
                }
                else if (edades[i] >= 21 && edades[i] <= 30)
                {
                    distribucionEdades[1]++;
                }
                else if (edades[i] >= 31 && edades[i] <= 40)
                {
                    distribucionEdades[2]++;
                }
                else if (edades[i] >= 41 && edades[i] <= 50)
                {
                    distribucionEdades[3]++;
                }
                else if (edades[i] >= 51 && edades[i] <= 60)
                {
                    distribucionEdades[4]++;
                }
                else
                {
                    distribucionEdades[5]++;
                }
            }

            Console.WriteLine($"{personasVacunadas:D2} personas se han vacunado");
            Console.WriteLine($"{personasNoVacunadas:D2} personas no se han vacunado\n");

            Console.WriteLine("Existen:");
            Console.WriteLine($"{distribucionEdades[0]:D2} personas entre 01 y 20 años");
            Console.WriteLine($"{distribucionEdades[1]:D2} personas entre 21 y 30 años");
            Console.WriteLine($"{distribucionEdades[2]:D2} personas entre 31 y 40 años");
            Console.WriteLine($"{distribucionEdades[3]:D2} personas entre 41 y 50 años");
            Console.WriteLine($"{distribucionEdades[4]:D2} personas entre 51 y 60 años");
            Console.WriteLine($"{distribucionEdades[5]:D2} personas de más de 61 años");

            Console.WriteLine("===================================\r\n" +
                "Presione una tecla para regresar ...\r\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }
        public static int buscarXEdad()
        {
            Console.Write("================================\r\n" +
       "Busca a personas por edad\r\n" +
       "================================\r\n");

            int edadBuscada = Operaciones.getEntero("¿Qué edad quieres buscar?: ", "");

            int personasVacunadas = 0;
            int personasNoVacunadas = 0;

            for (int i = 0; i < contadorEncuestas; i++)
            {
                if (edades[i] == edadBuscada)
                {
                    if (vacunados[i])
                    {
                        personasVacunadas++;
                    }
                    else
                    {
                        personasNoVacunadas++;
                    }
                }
            }

            Console.WriteLine($"{personasVacunadas:D2} se vacunaron");
            Console.WriteLine($"{personasNoVacunadas:D2} no se vacunaron");

            Console.WriteLine("================================\r\n" +
                "Presione una tecla para regresar ...\r\n");
            Console.ReadKey();
            Console.Clear();
            return menu();
        }

    }
}
