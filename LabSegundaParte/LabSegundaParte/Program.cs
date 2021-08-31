using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba sus datos ");
            Console.WriteLine("Escriba su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba la edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el sexo");
            string sexo = Console.ReadLine();
            Console.WriteLine("Escribe el peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la altura");
            double altura = double.Parse(Console.ReadLine());

            Persona persona = new Persona(nombre, edad, sexo, peso, altura);
            ClsPersona clspersona = new ClsPersona();
            Console.WriteLine(clspersona.CalculoIMC(persona));
            Console.WriteLine(clspersona.esMayorDeEdad(persona));
            Console.WriteLine(persona.ToString());


            Console.ReadLine();
        }
    }

    internal class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
    }

    internal class ClsPersona
    {
        public ClsPersona()
        {
        }

        internal bool CalculoIMC(Persona persona)
        {
            throw new NotImplementedException();
        }

        internal bool esMayorDeEdad(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
