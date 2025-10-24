using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores_de_acceso
{
    internal class Persona
    {
        public string _nombre { get; set; }
        private int _edad { get; set;}

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        private void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {_nombre}, Edad {_edad}");
        }

        public void accederMetodoPrivado()
        {
            MostrarInformacion();
        }



    }
}
