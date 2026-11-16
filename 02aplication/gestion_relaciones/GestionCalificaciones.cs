using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_relaciones
{
    internal class GestionCalificaciones : GestionRelaciones<Calificacion, Alumno, Modulo>
    {
        public GestionCalificaciones() : base(
                logArchivo: Globales._logCalificaciones,
                nombreTablaConjunta: "califica",
                fkColumnaDominante: "dni_alumno",
                fkColumnaSeguidora: "codigo_modulo",
                gestionRelacional: new GestionCalificacion(), 
                gestionDominante: new GestionAlumnos(),
                gestionSeguidora: new GestionModulos())
        { }
    }
}
