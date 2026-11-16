using EduGrade._02aplication.entitidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_individual
{
    internal class GestionMatricula : GestionIndividual<Matricula>
    {
        public GestionMatricula() : base(
                    logArchivo: Globales._logMatriculacion,
                    nombreTabla: "cursa",
                    columnaId: "id",
                    mapeadorObjeto: (tabla, fila) => new Matricula(
                        tabla.Rows[fila]["id"].ToString(),
                        tabla.Rows[fila]["dni_alumno"].ToString(),
                        tabla.Rows[fila]["codigo_curso"].ToString(),
                        tabla.Rows[fila]["anio"].ToString(),
                        tabla.Rows[fila]["nota"].ToString()
                    ))
        { }
    }
}