using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_relaciones
{
    internal class GestionMatriculacion : GestionRelaciones<Matricula, Alumno, Curso>
    {
        public GestionMatriculacion() : base(
                logArchivo: Globales._logMatriculacion,
                nombreTablaConjunta: "cursa",
                fkColumnaDominante: "dni_alumno",
                fkColumnaSeguidora: "codigo_curso",
                gestionRelacional: new GestionMatricula(),
                gestionDominante: new GestionAlumnos(),
                gestionSeguidora: new GestionCursos())
        { }
    }
}
