﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Entidades
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public Persona() { }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;

        }

        public Persona(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        Persona persona = new Persona();
        public override string ToString()
        {
            return "El nombre:" + persona.nombre +
                "\n edad: " + persona.edad +
                "\n sexo: " + persona.sexo +
                "\npeso: " + persona.sexo +
                "\naltura: " + persona.altura;
        }
    }
}