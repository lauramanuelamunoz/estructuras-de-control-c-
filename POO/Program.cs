using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------Ejercicios de array------------------
            //int[] numeros = new int[3];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese un número: " + (i+1)+ ": ");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}
            ////imprimir los números ingresados 
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Numero" + (i + 1) + ": "+ numeros [i]);
            //}

            //--------------------Ejercicio list--------------------------

            //List<int> numeros = new List<int>();

            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);

            //Console.WriteLine("Lsita despues de añadir elementos");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            ////Accerder a un elemento por su indice 
            //int primerElemento = numeros[1];
            //Console.WriteLine("Primer Elemento: " + primerElemento);

            ////modificar un elemento 
            //numeros[1] = 25;
            //Console.WriteLine("Lista despues de modificar el segundo elemento: ");
            //foreach(int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            ////insetar elementos en una posicion especifica
            //numeros.Insert(1, 15);//Insertar 15 en la posicion 1
            //Console.WriteLine("Listas despues de insertar 15 en la posicion 1:");
            //foreach (int i in numeros)
            //{ Console.WriteLine(i);}

            ////Eliminar un elemento especifico
            //numeros.Remove(30);
            //Console.WriteLine("Lista despues de eliminar el elemento 30:");
            //foreach(int i in numeros)
            //{ Console.WriteLine(i);}

            ////Eliminar un elemento por posicion
            //numeros.RemoveAt(0);
            //Console.WriteLine("Listas despues de eliminar el elemento en la posicion 0");
            //foreach (int i in numeros)
            //{ Console.WriteLine(i); }

            ////ordenar la lista desendente y ascendente
            //numeros.Sort();
            //Console.WriteLine("Listas despues de ordenar:");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            
                List<string> nombres = new List<string>();
                List<double> precios = new List<double>();
                int opcion;

                do
                {
                Console.WriteLine("\n--Menú--");
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Mostrar productos");
                    Console.WriteLine("3. Actualizar producto");
                    Console.WriteLine("4. Eliminar producto");
                    Console.WriteLine("5. Salir");
                    Console.Write("Opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.Write("Nombre del producto: ");
                        nombres.Add(Console.ReadLine());
                        Console.Write("Precio: ");
                        precios.Add(double.Parse(Console.ReadLine()));
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("\nLista de productos:");
                        for (int i = 0; i < nombres.Count; i++)
                            Console.WriteLine($"{i + 1}. {nombres[i]} - ${precios[i]}");
                    }
                    else if (opcion == 3)
                    {
                        Console.Write("Número del producto a actualizar: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;
                        if (pos >= 0 && pos < nombres.Count)
                        {
                            Console.Write("Nuevo nombre: ");
                            nombres[pos] = Console.ReadLine();
                            Console.Write("Nuevo precio: ");
                            precios[pos] = double.Parse(Console.ReadLine());
                        }
                    }
                    else if (opcion == 4)
                    {
                        Console.Write("Número del producto a eliminar: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;
                        if (pos >= 0 && pos < nombres.Count)
                        {
                            nombres.RemoveAt(pos);
                            precios.RemoveAt(pos);
                        }
                    }

                } while (opcion != 5);

                Console.WriteLine("Programa terminado.");
            }
        }

    }