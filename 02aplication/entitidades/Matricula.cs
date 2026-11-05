using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.entitidades
{
    class Matricula
    {
        public string Id { get; set; }
        public string Dni_alumno { get; set; }
        public string Codigo_curso { get; set; }
        public string Anio { get; set; }
        public string Nota { get; set; }

        public Matricula() { }

        public Matricula(string id, string dni_alumno, string codigo_curso, string anio, string nota)
        {
            Id = id;
            Dni_alumno = dni_alumno;
            Codigo_curso = codigo_curso;
            Anio = anio;
            Nota = nota;
        }

        public override string? ToString()
        {
            return $"[{this.Id}] - Alumno {this.Dni_alumno} & curso {this.Codigo_curso} - Años {this.Anio} - Nota: {this.Nota}";
        }
    }
}
