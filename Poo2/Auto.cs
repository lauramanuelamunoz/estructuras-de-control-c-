using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2
{
    internal class Auto
    {
        public string _marca { get; set; }
        public string _modelo { get; set; } 
        public int _fecha { get; set;}

        //constructor
        public Auto(string marca, string modelo, int fecha)
        {
            _marca = marca;
            _modelo = modelo;
            _fecha = fecha;
        }
        //crear metodos
        public void MostrarInfo() //metodo para mostrar la informacion del auto
        {
            Console.WriteLine($"Marca {_marca} su modelo es: {_modelo} y el año es: {_fecha}");
        }
    }
}
