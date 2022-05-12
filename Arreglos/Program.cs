using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
		static void Main(string[] args)
		{
			int[] LeerDatos()
			{
				int totalArreglo;
				Console.Write("Ingrese el total de valores del arreglo: ");
				totalArreglo = int.Parse(Console.ReadLine());
				int[] arreglo = new int[totalArreglo];
				for (int i = 0; i < totalArreglo; i++)
				{
					Console.Write("Ingrese el valor " + (i + 1)+": ");
					arreglo[i] = int.Parse(Console.ReadLine());
				}
				return arreglo;

			}
			int opcionMenu;
			do {
				Console.Clear();
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("------------- Ejercicios con Arreglos ------------");
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("Menú de opciones:");
				Console.WriteLine("1. Encontrar el valor máximo");
				Console.WriteLine("2. Encontrar el valor mínimo");
				Console.WriteLine("3. Calcular el promedio");
				Console.WriteLine("4. Salir");
				// ingresar una opcion
				Console.Write("Elija una opción (1-4): ");
				opcionMenu = int.Parse(Console.ReadLine());
				int[] arregloDatos;
				// procesar esa opción
				switch (opcionMenu)
				{
					case 1:
						int max;
						arregloDatos = LeerDatos();
						max = arregloDatos[0];
                        for (int i = 1; i < arregloDatos.Length; i++)
                        {
                            if (arregloDatos[i] > max)
                                max = arregloDatos[i];
                        }
                        Console.WriteLine("El número máximo en el arreglo ingresado es: " + max);
                        //Console.WriteLine("El número máximo en el arreglo ingresado es: " + arregloDatos.Max());
                        break;
					case 2:
						int min;
						arregloDatos = LeerDatos();
						min = arregloDatos[0];
						for (int i = 1; i < arregloDatos.Length; i++)
						{
							if (arregloDatos[i] <min)
								min = arregloDatos[i];
						}
						Console.WriteLine("El número mínimo en el arreglo ingresado es: " + min);
                        //Console.WriteLine("El número mínimo en el arreglo ingresado es: " + arregloDatos.Min());
                        break;
					case 3:
						int suma = 0;
						double promedio;
						arregloDatos = LeerDatos();
						for (int i = 0; i < arregloDatos.Length; i++)
						{
							suma += arregloDatos[i];
						}
						promedio = Convert.ToDouble(suma) / arregloDatos.Length;
						Console.WriteLine("El promedio del arreglo ingresado es: " + promedio);
                        //Console.WriteLine("El promedio del arreglo ingresado es: " + arregloDatos.Average());
                        break;
					case 4:
						Console.WriteLine();
						Console.WriteLine("Gracias, vuelva pronto!");
						break;
					default:
						Console.WriteLine();
						Console.WriteLine("Opción no válida!");
						break;
				}
				Console.WriteLine();
				Console.Write("Presione enter para continuar ");
				Console.ReadKey();
			} while (opcionMenu != 4);
		}
    }
}
