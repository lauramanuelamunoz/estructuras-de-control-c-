using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2
{
    internal class Aprendiz
    {
        public string _nombre {  get; set; }
        public int _edad { get; set; }

        public string _direccion { get; set; }

        public Aprendiz(string nombre, int edad, string direccion)
        {
            _nombre = nombre;
            _edad = edad;
            _direccion = direccion;
        }

        //Crear metodo para saber si es mayor de edad

        public void VereficarEdad()
        {
            if (_edad >= 18)
            {
                Console.WriteLine($"{_nombre} Es mayor de edad");
            }
            else
            {
                Console.WriteLine($"{_nombre}Es menor de edad");
            }
        }
    }
}
