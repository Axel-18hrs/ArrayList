using System;
using System.Collections;

namespace Array_List
{
    class Program
    {

        static void Main()
        {
            ArrayList numeros = new ArrayList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Elije una opción:");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Eliminar número");
                Console.WriteLine("3. Mostrar números");
                Console.WriteLine("4. Buscar número");
                Console.WriteLine("5. Ordenar elementos");
                Console.WriteLine("6. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa un número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            numeros.Add(numero);
                            Console.WriteLine("Número agregado.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                        }
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Write("Ingresa el número a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int numeroEliminar))
                        {
                            if (numeros.Contains(numeroEliminar))
                            {
                                numeros.Remove(numeroEliminar);
                                Console.WriteLine("Número eliminado.");
                            }
                            else
                            {
                                Console.WriteLine("El número no se encuentra en la lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                        }
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Números en la lista:");
                        foreach (int n in numeros)
                        {
                            Console.WriteLine(n);
                        }
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Write("Ingresa el número a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int numeroBuscar))
                        {
                            if (numeros.Contains(numeroBuscar))
                            {
                                Console.WriteLine("El número se encuentra en la lista.");
                            }
                            else
                            {
                                Console.WriteLine("El número no se encuentra en la lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                        }
                        Console.ReadKey();
                        break;

                    case "5":
                        numeros.Sort();
                        Console.WriteLine("La lista se a ordenado");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Saliste del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }
            }
        }

    }
}