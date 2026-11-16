using EduGrade._02aplication.gestion_individual;
using EduGrade._03data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EduGrade._02aplication.gestion_relaciones
{
    public class GestionRelaciones<TEnlace, T, U> where TEnlace : class, new() where T : class, new() where U : class, new()
    {
        protected GestionIndividual<TEnlace> _gestionRelacional;
        protected GestionIndividual<T> _gestionDominante;
        protected GestionIndividual<U> _gestionSeguidora;

        protected readonly string _logArchivo;
        protected readonly string _nombreTablaConjunta;

        protected readonly string _fkColumnaDominante;
        protected readonly string _fkColumnaSeguidora;

        public GestionRelaciones(
            string logArchivo, 
            string nombreTablaConjunta,
            string fkColumnaDominante,
            string fkColumnaSeguidora,

            GestionIndividual<TEnlace> gestionRelacional,
            GestionIndividual<T> gestionDominante,
            GestionIndividual<U> gestionSeguidora)
        {
            _logArchivo = logArchivo;
            _nombreTablaConjunta = nombreTablaConjunta;
            _fkColumnaDominante = fkColumnaDominante;
            _fkColumnaSeguidora = fkColumnaSeguidora;

            _gestionRelacional = gestionRelacional;
            _gestionDominante = gestionDominante;
            _gestionSeguidora = gestionSeguidora;
        }

        public string ErrorDeBD() => BaseDatos.ErrorBD;
        public List<TEnlace> MostrarEnlaces() => _gestionRelacional.GetListaDeObjetos();
        public List<T> MostrarDominante() => _gestionDominante.GetListaDeObjetos();
        public List<U> MostrarSeguidora() => _gestionSeguidora.GetListaDeObjetos();


        #region Obtención de relaciones entre tablas

        /// <summary>
        /// Obtiene los elementos de la tabla dominante que están vinculados a un ID específico de la tabla seguidora.
        /// Ej Primera: "Dame el curso que está cursando el Alumno con DNI X"
        /// Ej Segunda: "Dame los alumnos que están cursando el Curso con ID X"
        /// <summary>
        public List<U> RelacionesDeDominante(string idPatron)
        {
            DataTable tablaDatos = ObtenerRelaciones(
                        nombreTablaSeguidora: _gestionSeguidora.NombreTabla,
                        idTablaSeguidora: _gestionSeguidora.ColumnaId,
                        fkDominante: _fkColumnaDominante,
                        fkSeguidora: _fkColumnaSeguidora,
                        idPatron: idPatron);

            return ConvertirDataTableALista<U>(tablaDatos);
        }

        public List<T> RelacionesDeSeguidora(string idPatron)
        {
            DataTable tablaDatos = ObtenerRelaciones(
                        nombreTablaSeguidora: _gestionDominante.NombreTabla,
                        idTablaSeguidora: _gestionDominante.ColumnaId,
                        fkDominante: _fkColumnaSeguidora,
                        fkSeguidora: _fkColumnaDominante,
                        idPatron: idPatron);

            return ConvertirDataTableALista<T>(tablaDatos);
        }

        public List<TEnlace> DetallesRelaciones(string idPatron, bool esDominante)
        {
            string columna = esDominante ? _fkColumnaDominante : _fkColumnaSeguidora;
            string consultaSql = $"select * from {_nombreTablaConjunta} where {columna} = '{idPatron}'";
            RegistroLogs.RegistrarEnLog($"Copiada tabla relaciones elementos: {idPatron}", _logArchivo);
            DataTable tablaDatos = BaseDatos.ConsultarBD(consultaSql);
            return ConvertirDataTableALista<TEnlace>(tablaDatos);
        }

        private DataTable ObtenerRelaciones(string nombreTablaSeguidora, string idTablaSeguidora, string fkDominante, string fkSeguidora, string idPatron)
        {
            string consultaSql = $"select * from {nombreTablaSeguidora} " +
                                     $"inner join {_nombreTablaConjunta} " +
                                     $"on {nombreTablaSeguidora}.{idTablaSeguidora} = {_nombreTablaConjunta}.{fkSeguidora} " +
                                     $"where {_nombreTablaConjunta}.{fkDominante} = '{idPatron}'";

            RegistroLogs.RegistrarEnLog($"Consultadas relaciones para la entidad con id: {idPatron}", _logArchivo);
            RegistroLogs.RegistrarEnLog($"Vinculos con {nombreTablaSeguidora}: {consultaSql}", _logArchivo);
            return BaseDatos.ConsultarBD(consultaSql);
        }

        /// <summary>
        /// Convierte dinámicamente un DataTable en una lista de objetos mapeando por nombres de columnas.
        /// </summary>
        private List<URegistro> ConvertirDataTableALista<URegistro>(DataTable tablaDatos) where URegistro : class, new()
        {
            List<URegistro> listaResultados = new List<URegistro>();
            if (tablaDatos == null || tablaDatos.Rows.Count == 0) return listaResultados;

            var propiedades = typeof(URegistro).GetProperties();
            foreach (DataRow fila in tablaDatos.Rows)
            {
                URegistro objetoInstancia = new URegistro();

                foreach (var prop in propiedades)
                {
                    if (tablaDatos.Columns.Contains(prop.Name))
                    {
                        object valorCelda = fila[prop.Name];
                        if (valorCelda != DBNull.Value)
                        {
                            prop.SetValue(objetoInstancia, Convert.ChangeType(valorCelda, prop.PropertyType));
                        }
                    }
                }
                listaResultados.Add(objetoInstancia);
            }
            return listaResultados;
        }

        #endregion

        #region Vinculado y desvinculado de tablas

        /// <summary>
        /// Vincula y desvincula dos registros en la tabla conjunta (Inserta y borra la relación).
        /// </summary>
        public int Vincular(string idDominante, string idSeguidor, bool esUnico, Dictionary<string, object> columnasAdicionales = null)
        {
            string sqlCheck = $"select count(*) from {_nombreTablaConjunta} " +
                                $"where {_fkColumnaDominante} = '{idDominante}' and {_fkColumnaSeguidora} = '{idSeguidor}'";

            if (esUnico)
            {
                DataTable comprobacion = BaseDatos.ConsultarBD(sqlCheck);
                bool hayRelacion = comprobacion != null && Convert.ToInt32(comprobacion.Rows[0][0]) > 0;
                if (hayRelacion)
                {
                    RegistroLogs.RegistrarEnLog($"Intento de vinculación duplicada rechazado para {idDominante} - {idSeguidor}", _logArchivo);
                    return -1;
                }
            }

            List<string> columnas = new List<string> { _fkColumnaDominante, _fkColumnaSeguidora };
            List<string> valores = new List<string> { $"'{idDominante}'", $"'{idSeguidor}'" };

            if (columnasAdicionales != null && columnasAdicionales.Count > 0)
            {
                foreach (var campo in columnasAdicionales)
                {
                    columnas.Add(campo.Key);

                    string valorFormateado = campo.Value is string
                        ? $"'{campo.Value}'"
                        : campo.Value.ToString().Replace(",", "."); // Reemplazo de coma decimal por punto en MySQL

                    valores.Add(valorFormateado);
                }
            }

            string consultaSql = $"insert into {_nombreTablaConjunta} ({string.Join(", ", columnas)}) " +
                                    $"values ({string.Join(", ", valores)})";

            RegistroLogs.RegistrarEnLog($"Vinculación solicitada: {consultaSql}", _logArchivo);
            return BaseDatos.OperarBD(consultaSql);
        }

        public int Desvincular(string idRelacion)
        {
            string consultaSql = $"delete from {_nombreTablaConjunta} where id = '{idRelacion}'";
            RegistroLogs.RegistrarEnLog($"Desvinculación solicitada: {consultaSql}", _logArchivo);
            return BaseDatos.OperarBD(consultaSql);
        }

        #endregion

    }
}
