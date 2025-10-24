using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores_de_acceso
{
    internal class Animales
    {
        protected string _nombre { get; set; }
        protected string _especie { get; set; }
       

        public Animales(string nombre, string especie)
        {
            
            _nombre = nombre;
            _especie = especie;
        }

        protected void MostrarEspecie()
        {
            Console.WriteLine($"Nombre: {_especie}, Edad {_nombre}");
        }

        public class Perro : Animales
        {
            public string Raza {  get; set; }
            public Perro(string nombre) : base("Canino", nombre)
            {
            }

            public void MostrarEspeciePublico()
            {
                MostrarEspecie();
            }
        }

    }
}
