using EduGrade._03data;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Reflection;
using System.Text;

namespace EduGrade._02aplication.gestion_individual
{
    public class GestionIndividual<T> where T : class, new()
    {
        public T Entidad { get; set; }
        public string NombreTabla { get; }
        public string ColumnaId { get; }

        protected readonly string _logArchivo;
        private readonly Func<DataTable, int, T> _mapeadorObjeto;

        public GestionIndividual(
            string logArchivo, 
            string nombreTabla, 
            string columnaId, 
            Func<DataTable, int, T> mapeadorObjeto)
        {
            Entidad = new T();
            NombreTabla = nombreTabla;
            ColumnaId = columnaId;
            _logArchivo = logArchivo;
            _mapeadorObjeto = mapeadorObjeto;
        }

        public string ErrorDeBD() => BaseDatos.ErrorBD;

        #region Operaciones de Lectura y Navegación

        public T GetPorClavePrimaria(string id)
        {
            string consultaSql = $"select * from {NombreTabla} where {ColumnaId} = '{id}'";
            return GetUnicoObjeto(consultaSql);
        }

        public T GetUnicoObjeto(string consultaSql)
        {
            RegistroLogs.RegistrarEnLog($"Petición de objeto único: \"{consultaSql}\"", _logArchivo);
            DataTable tablaDeDatos = BaseDatos.ConsultarBD(consultaSql);

            bool hayDatos = tablaDeDatos != null && tablaDeDatos.Rows.Count > 0;
            if (hayDatos)
            {
                T resultado = _mapeadorObjeto(tablaDeDatos, 0);
                RegistroLogs.RegistrarEnLog($"Objeto resultado: \"{resultado}\"", _logArchivo);
                return resultado;
            }

            RegistroLogs.RegistrarEnLog("El resultado dio \"null\"", _logArchivo);
            return null;
        }

        public List<T> GetListaDeObjetos(string consultaSql = null)
        {
            if (string.IsNullOrEmpty(consultaSql))
            {
                consultaSql = $"select * from {NombreTabla} order by {ColumnaId}";
            }

            RegistroLogs.RegistrarEnLog($"Petición de lista: \"{consultaSql}\"", _logArchivo);
            List<T> listaResultados = new List<T>();
            DataTable tablaDeDatos = BaseDatos.ConsultarBD(consultaSql);

            if (tablaDeDatos != null)
            {
                for (int i = 0; i < tablaDeDatos.Rows.Count; i++)
                {
                    T resultado = _mapeadorObjeto(tablaDeDatos, i);
                    RegistroLogs.RegistrarEnLog($"-- {resultado}", _logArchivo);
                    listaResultados.Add(resultado);
                }
            }
            return listaResultados;
        }

        public void CambiarDeFila(string emisor, string idActual)
        {
            string consultaSql = $"select * from {NombreTabla}";
            switch (emisor)
            {
                case "btnPrimero":
                    consultaSql += $" order by {ColumnaId} asc";
                    break;
                case "btnUltimo":
                    consultaSql += $" order by {ColumnaId} desc";
                    break;
                case "btnSiguiente":
                    consultaSql += $" where {ColumnaId} > '{idActual}' order by {ColumnaId} asc limit 1";
                    break;
                case "btnAnterior":
                    consultaSql += $" where {ColumnaId} < '{idActual}' order by {ColumnaId} desc limit 1";
                    break;
            }
            RegistroLogs.RegistrarEnLog($"Fila seleccionada por \"{emisor}\"", _logArchivo);

            T resultado = GetUnicoObjeto(consultaSql);
            if (resultado != null)
            {
                Entidad = resultado;
            }
        }

        #endregion

        #region Operaciones de Inserción, Edición y Borrado

        public int Insertar()
        {
            PropertyInfo[] propiedades = Entidad.GetType().GetProperties();
            StringBuilder columnasSql = new StringBuilder();
            StringBuilder valoresSql = new StringBuilder();
            string valorClavePrimaria = string.Empty;

            foreach (PropertyInfo prop in propiedades)
            {
                string nombreAtributo = prop.Name.ToLower();
                object valorAtributo = prop.GetValue(Entidad);

                if (valorAtributo == null) continue;

                if (nombreAtributo == ColumnaId.ToLower())
                {
                    valorClavePrimaria = valorAtributo.ToString();
                }

                columnasSql.Append($"{nombreAtributo}, ");
                valoresSql.Append($"'{valorAtributo}', ");
            }

            columnasSql.Remove(columnasSql.Length - 2, 2);
            valoresSql.Remove(valoresSql.Length - 2, 2);

            string consultaFinal = $"insert into {NombreTabla} ({columnasSql}) values ({valoresSql})";
            RegistroLogs.RegistrarEnLog($"Inserción Dinámica Generada: \"{consultaFinal}\"", _logArchivo);

            return EjecutarOperacionValida(valorClavePrimaria, consultaFinal, debeExistir: false);
        }

        public int Editar()
        {
            PropertyInfo[] propiedades = Entidad.GetType().GetProperties();
            StringBuilder consultaSql = new StringBuilder($"update {NombreTabla} set ");

            string valorClavePrimaria = string.Empty;
            foreach (PropertyInfo prop in propiedades)
            {
                string nombreAtributo = prop.Name.ToLower();
                object valorAtributo = prop.GetValue(Entidad);

                if (valorAtributo == null) continue;
                if (nombreAtributo == ColumnaId.ToLower())
                {
                    valorClavePrimaria = valorAtributo.ToString();
                    continue;
                }

                consultaSql.Append($"{nombreAtributo} = '{valorAtributo}', ");
            }

            consultaSql.Remove(consultaSql.Length - 2, 2);
            consultaSql.Append($" where {ColumnaId} = '{valorClavePrimaria}'");

            string consultaFinal = consultaSql.ToString();
            RegistroLogs.RegistrarEnLog($"Edición Dinámica Generada: \"{consultaFinal}\"", _logArchivo);
            return EjecutarOperacionValida(valorClavePrimaria, consultaFinal, debeExistir: true);
        }

        public int Borrar(string id)
        {
            string consultaSql = $"delete from {NombreTabla} where {ColumnaId} = '{id}'";
            return EjecutarOperacionValida(id, consultaSql, debeExistir: true);
        }

        protected int EjecutarOperacionValida(string id, string consultaSql, bool debeExistir)
        {
            bool existe = GetPorClavePrimaria(id) != null;
            bool condicionValida = debeExistir.Equals(existe);
            RegistroLogs.RegistrarEnLog($"Query solicitada: \"{consultaSql}\"", _logArchivo);

            int codigoDeEjecucion = condicionValida ? BaseDatos.OperarBD(consultaSql) : -1;
            RegistroLogs.RegistrarEnLog($"Código de error: {codigoDeEjecucion}", _logArchivo);
            return codigoDeEjecucion;
        }

        #endregion

        #region Operaciones de Búsqueda de entidad según propiedades

        /// <summary>
        /// Busca registros basándose en las propiedades que estén llenas en el objeto Entidad.
        /// Si la clave primaria está llena, busca por ID exacto. Si no, busca combinando el resto de campos con LIKE.
        /// </summary>
        public List<T> Buscar()
        {
            PropertyInfo[] propiedades = Entidad.GetType().GetProperties();
            string valorClavePrimaria = string.Empty;

            foreach (PropertyInfo prop in propiedades)
            {
                bool esClavePrimaria = prop.Name.ToLower() == ColumnaId.ToLower();
                if (esClavePrimaria)
                {
                    object valor = prop.GetValue(Entidad);

                    bool hayClavePrimaria = valor != null && !string.IsNullOrWhiteSpace(valor.ToString());
                    if (hayClavePrimaria)
                    {
                        valorClavePrimaria = valor.ToString();
                        
                        if (!string.IsNullOrEmpty(valorClavePrimaria))
                        {
                            return BuscarID(valorClavePrimaria);
                        }
                    }
                    break;
                }
            }
            return BuscarParametros(propiedades);
        }

        private List<T> BuscarID(string valorClavePrimaria)
        {
            RegistroLogs.RegistrarEnLog($"Búsqueda prioritaria por Clave Primaria ({ColumnaId} = {valorClavePrimaria})", _logArchivo);
            List<T> listaResultadoUnico = new List<T>();
            T objetoEncontrado = GetPorClavePrimaria(valorClavePrimaria);

            if (objetoEncontrado != null)
            {
                listaResultadoUnico.Add(objetoEncontrado);
            }
            return listaResultadoUnico;
        }

        private List<T> BuscarParametros(PropertyInfo[] propiedades)
        {
            StringBuilder clausulaWhere = new StringBuilder();
            foreach (PropertyInfo prop in propiedades)
            {
                object valorAtributo = prop.GetValue(Entidad);

                bool noHayPropiedad = valorAtributo == null || string.IsNullOrWhiteSpace(valorAtributo.ToString());
                if (noHayPropiedad) continue;

                string nombreAtributo = prop.Name.ToLower();
                clausulaWhere.Append($"{nombreAtributo} LIKE '%{valorAtributo}%' AND ");
            }

            string consultaSql = $"select * from {NombreTabla}";

            if (clausulaWhere.Length > 0)
            {
                clausulaWhere.Remove(clausulaWhere.Length - 5, 5);
                consultaSql += $" where {clausulaWhere}";
            }

            consultaSql += $" order by {ColumnaId}";
            RegistroLogs.RegistrarEnLog($"Búsqueda Multicriterio: \"{consultaSql}\"", _logArchivo);
            return GetListaDeObjetos(consultaSql);
        }

        #endregion
    }
}
