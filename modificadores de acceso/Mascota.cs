using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores_de_acceso
{
    internal class Mascota
    {
        private string nombre;
        private int edad;
        private string tipo;
        private double peso;


        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }


        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public double GetPeso()
        {
            return peso;
        }


        public int CalcularEdadHumana()
        {
            if (tipo.ToLower() == "perro")
            {
                return edad * 7;
            }
            else if (tipo.ToLower() == "gato")
            {
                return edad * 6;
            }
            else
            {
                return edad;
            }
        }

 
        public void MostrarInformacion()
        {
            Console.WriteLine("=== Información de la Mascota ===");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Edad en años humanos: {CalcularEdadHumana()}");
            Console.WriteLine();
        }
        }
}
