using EduGrade._02aplication.entitidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_individual
{
    class GestionCalificacion : GestionIndividual<Calificacion>
    {
        public GestionCalificacion() : base(
                    logArchivo: Globales._logCalificaciones,
                    nombreTabla: "califica",
                    columnaId: "id",
                    mapeadorObjeto: (tabla, fila) => new Calificacion(
                        tabla.Rows[fila]["id"].ToString(),
                        tabla.Rows[fila]["dni_alumno"].ToString(),
                        tabla.Rows[fila]["codigo_modulo"].ToString(),
                        tabla.Rows[fila]["codigo_trimestre"].ToString(),
                        tabla.Rows[fila]["nota"].ToString(),
                        tabla.Rows[fila]["tipo"].ToString()
                    ))
        { }
    }
}
