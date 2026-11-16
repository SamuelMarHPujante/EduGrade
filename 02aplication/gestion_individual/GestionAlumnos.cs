using EduGrade._02aplication.entitidades;
using EduGrade._03data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EduGrade._02aplication.gestion_individual
{
    class GestionAlumnos : GestionIndividual<Alumno>
    {
        public GestionAlumnos() : base(
                    logArchivo: Globales._logAlumno,
                    nombreTabla: "alumno",
                    columnaId: "dni",
                    mapeadorObjeto: (tabla, fila) => new Alumno(
                        tabla.Rows[fila]["dni"].ToString(),
                        tabla.Rows[fila]["nombre"].ToString(),
                        tabla.Rows[fila]["apellidos"].ToString(),
                        tabla.Rows[fila]["telefono"].ToString(),
                        tabla.Rows[fila]["poblacion"].ToString()
                    ))
        { }
    }
}
