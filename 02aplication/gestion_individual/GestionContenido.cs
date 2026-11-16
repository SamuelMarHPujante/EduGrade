using EduGrade._02aplication.entitidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_individual
{
    internal class GestionContenido : GestionIndividual<Contenido>
    {
        public GestionContenido() : base(
                    logArchivo: Globales._logContenidos,
                    nombreTabla: "contiene",
                    columnaId: "id",
                    mapeadorObjeto: (tabla, fila) => new Contenido(
                        tabla.Rows[fila]["id"].ToString(),
                        tabla.Rows[fila]["codigo_modulo"].ToString(),
                        tabla.Rows[fila]["codigo_curso"].ToString()
                    ))
        { }
    }
}