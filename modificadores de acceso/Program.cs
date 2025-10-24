using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores_de_acceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------EjercicioPersona-----------------------------------------------------------
            //    Persona persona1 = new Persona("Juan", 30);
            //    persona1._nombre = "Pedro";
            //    persona1.accederMetodoPrivado();
            //}


            //Animales.Perro animal1 = new Animales.Perro("Canino");
            //animal1.MostrarEspeciePublico();


      
            Mascota mascota1 = new Mascota();
            mascota1.SetNombre("Firulais");
            mascota1.SetTipo("Perro");
            mascota1.SetEdad(5);
            mascota1.SetPeso(12.5);

            Mascota mascota2 = new Mascota();
            mascota2.SetNombre("Misu");
            mascota2.SetTipo("Gato");
            mascota2.SetEdad(3);
            mascota2.SetPeso(4.2);

            mascota1.MostrarInformacion();
            mascota2.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
