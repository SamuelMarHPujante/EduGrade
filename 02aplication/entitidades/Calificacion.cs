using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.entitidades
{
    class Calificacion
    {
        public string Id { get; set; }
        public string Dni_alumno { get; set; }
        public string Codigo_modulo { get; set; }
        public string Codigo_trimestre { get; set; }
        public string Nota { get; set; }
        public string Tipo { get; set; }

        public Calificacion() { }

        public Calificacion(string id, string dni_alumno, string codigo_modulo, string codigo_trimestre, string nota, string tipo)
        {
            Id = id;
            Dni_alumno = dni_alumno;
            Codigo_modulo = codigo_modulo;
            Codigo_trimestre = codigo_trimestre;
            Nota = nota;
            Tipo = tipo;
        }

        public override string? ToString()
        {
            return $"[{this.Id}] - Alumno {this.Dni_alumno} & módulo {this.Codigo_modulo} - Trimestre {this.Codigo_trimestre} - {this.Tipo} - Nota: {this.Nota}";
        }
    }
}
