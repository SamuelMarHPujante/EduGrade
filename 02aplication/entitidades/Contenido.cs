using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.entitidades
{
    class Contenido
    {
        public string Id { get; set; }
        public string Codigo_modulo { get; set; }
        public string Codigo_curso { get; set; }

        public Contenido() { }

        public Contenido(string id, string codigo_modulo, string codigo_curso)
        {
            Id = id;
            Codigo_modulo = codigo_modulo;
            Codigo_curso = codigo_curso;
        }

        public override string? ToString()
        {
            return $"[{this.Id}] - Módulo {this.Codigo_modulo} & curso {this.Codigo_curso}";
        }

    }
}
