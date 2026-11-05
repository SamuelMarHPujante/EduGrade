using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.entitidades
{
    class Modulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string N_practicas { get; set; }
        public string N_examenes { get; set; }

        public Modulo() { }

        public Modulo(string codigo, string nombre, string practicas, string examenes)
        {
            Codigo = codigo;
            Nombre = nombre;
            N_practicas = practicas;
            N_examenes = examenes;
        }

        public override string? ToString()
        {
            return $"[{this.Codigo}] - {this.Nombre} - Nº prácticas: {this.N_practicas} - Nº exámenes: {this.N_examenes}";
        }
    }
}
