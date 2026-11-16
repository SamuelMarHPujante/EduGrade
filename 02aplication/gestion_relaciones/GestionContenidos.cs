using EduGrade._02aplication.entitidades;
using EduGrade._02aplication.gestion_individual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_relaciones
{
    class GestionContenidos : GestionRelaciones<Contenido, Curso, Modulo>
    {
        public GestionContenidos() : base(
                logArchivo: Globales._logContenidos,
                nombreTablaConjunta: "contiene",
                fkColumnaDominante: "codigo_curso",
                fkColumnaSeguidora: "codigo_modulo",
                gestionRelacional: new GestionContenido(),
                gestionDominante: new GestionCursos(),
                gestionSeguidora: new GestionModulos())
        { }
    }
}
