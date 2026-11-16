using EduGrade._02aplication.entitidades;
using EduGrade._03data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade._02aplication.gestion_individual
{
    class GestionModulos : GestionIndividual<Modulo>
    {
        public GestionModulos() : base(
                    logArchivo: Globales._logModulo,
                    nombreTabla: "modulo",
                    columnaId: "codigo",
                    mapeadorObjeto: (tabla, fila) => new Modulo(
                        tabla.Rows[fila]["codigo"].ToString(),
                        tabla.Rows[fila]["nombre"].ToString(),
                        tabla.Rows[fila]["n_practicas"].ToString(),
                        tabla.Rows[fila]["n_examenes"].ToString()
                    ))
        { }
    }
}
