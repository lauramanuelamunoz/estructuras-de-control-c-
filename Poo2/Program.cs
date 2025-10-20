using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear los objetos

            //Auto coche = new Auto("Toyota", "Corolla", 2020);
            //Auto coche2 = new Auto("Kia", "Picanto", 2010);

            //coche.MostrarInfo();
            //coche2.MostrarInfo();
            //coche._fecha = 2027;
            //coche.MostrarInfo();

            Console.WriteLine("Ingrese el nombre del aprendiz");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese la edad del aprendiz:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la direccion del aprendiz:");
            string direccion = Console.ReadLine();

            Aprendiz estudiantes = new Aprendiz(nombre, edad, direccion);

            estudiantes.VereficarEdad(); //Llamar al metodo para verificar la edad
        }
    }
}
