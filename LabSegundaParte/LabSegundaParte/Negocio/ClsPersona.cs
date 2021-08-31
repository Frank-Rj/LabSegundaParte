using LabSegundaParte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Negocio
{
    class ClsPersona
    {
        public String CalculoIMC(Persona persona)
        {
            double resultado;
            resultado = persona.Peso / Math.Pow(persona.Altura, 2);
            Console.WriteLine("\nIndice de masa corporal: " + resultado);

            if (resultado > 25)
            {
                return ("Tiene sobre peso.");
            }
            else
            {
                return ("Peso ideal.");
            }
        }

        public String esMayorDeEdad(Persona persona)
        {
            if (persona.Edad > 17)
            {
                return ("Eres mayor de edad.");
            }
            else
            {
                return ("Eres menor de edad.");
            }
        }
    }
}
