using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace EduGrade._03data
{
    static class BaseDatos
    {
        static public string ErrorBD { get; set; }
        static public int RegistrosModificados { set; get; }

        static private MySqlConnection ConectarConBD()
        {
            string ipDeConexion = "datasource=127.0.0.1; port=3306; username=root; password=; database=edugrade;";
            MySqlConnection conexionConBD = new MySqlConnection(ipDeConexion);
            return conexionConBD;
        }

        #region Manejo de Consulta y Modificación de datos

        static public DataTable ConsultarBD(string selectSQL)
        {
            MySqlConnection conexionConBD = ConectarConBD();
            MySqlDataAdapter adaptadorDeDatos = new MySqlDataAdapter(selectSQL, conexionConBD);
            RegistroLogs.RegistrarEnLog($"Query en \"ConsultarBD\": \"{selectSQL}\" para \"{conexionConBD}\"");
            try
            {
                DataSet tablaDeDatos = new DataSet();
                adaptadorDeDatos.Fill(tablaDeDatos);
                RegistrosModificados = 0;
                ErrorBD = "";
                return tablaDeDatos.Tables[0];
            }
            catch (Exception error)
            {
                ErrorBD = error.Message;
                RegistrosModificados = -1;
                return null;
            }
            finally
            {
                CerrarYRegistrar(conexionConBD);
            }
        }

        static public int OperarBD(string consultaDML)
        {
            MySqlConnection conexionConBD = ConectarConBD();
            RegistroLogs.RegistrarEnLog($"Query en \"OperarBD\": \"{consultaDML}\" para \"{conexionConBD}\"");
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand(consultaDML, conexionConBD);
                conexionConBD.Open();
                RegistrosModificados = comandoSQL.ExecuteNonQuery();
                ErrorBD = "";
                return RegistrosModificados;
            }
            catch (MySqlException error)
            {
                ErrorBD = error.Message;
                RegistrosModificados = -1;
                return RegistrosModificados;
            }
            finally
            {
                CerrarYRegistrar(conexionConBD);
            }
        }

        static private void CerrarYRegistrar(MySqlConnection conexionConBD)
        {
            conexionConBD.Close();
            string stringError = ErrorBD == "" ? null : ErrorBD;
            RegistroLogs.RegistrarEnLog($"Mensaje \"ErrorBD\": {stringError}");
            RegistroLogs.RegistrarEnLog($"Registros Modificados: {RegistrosModificados}");
        }

        #endregion
    }
}
