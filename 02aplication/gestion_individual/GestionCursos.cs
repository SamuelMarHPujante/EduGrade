using EduGrade._02aplication.entitidades;
using EduGrade._03data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_individual
{
    class GestionCursos : GestionIndividual<Curso>
    {
        public GestionCursos() : base(
                    logArchivo: Globales._logCurso,
                    nombreTabla: "curso",
                    columnaId: "codigo",
                    mapeadorObjeto: (tabla, fila) => new Curso(
                        tabla.Rows[fila]["codigo"].ToString(),
                        tabla.Rows[fila]["nombre"].ToString()
                    ))
        { }
    }
}
