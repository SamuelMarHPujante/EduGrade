using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EduGrade._02aplication.entitidades
{
    class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public Curso() { }
        public Curso(string codigo, string nombre) 
        { 
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        public override string? ToString()
        {
            return $"[{Codigo}] {Nombre}";
        }
    }
}
