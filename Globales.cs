using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EduGrade
{
    public class Globales
    {
        public enum Formato
        {
            Vacio,
            Invalido,
            Semicompleto,
            Valido
        }

        public static readonly Regex _regexDni = new Regex("^\\d{8}[A-Z]$");
        public static readonly Regex _regexDniNumerico = new Regex("^\\d{8}$");
        public static readonly Regex _regexCodigos = new Regex(@"^\d{1,11}$");

        public static readonly Regex _regexAnio = new Regex("^\\d{4}-\\d{4}$");
        public static readonly Regex _regexNota = new Regex("^\\d{1,2}(\\,\\d+)?$");

        public const string _logUsuario = "..\\..\\..\\03data\\logs\\userLog.log";

        public const string _logAlumno = "..\\..\\..\\03data\\logs\\alumnoLog.log";
        public const string _logCurso = "..\\..\\..\\03data\\logs\\cursoLog.log";
        public const string _logModulo = "..\\..\\..\\03data\\logs\\moduloLog.log";
        
        public const string _logMatriculacion = "..\\..\\..\\03data\\logs\\matriculacionLog.log";
        public const string _logContenidos = "..\\..\\..\\03data\\logs\\contenidosLog.log";
        public const string _logCalificaciones = "..\\..\\..\\03data\\logs\\calificacionesLog.log";

        public static Color colorFondoCelda = Color.LightCyan;
        public static Color colorFuenteCelda = Color.DarkBlue;
        public static Color colorCeldaFlotante = Color.DimGray;

        public static Color colorBotonesBorrado = Color.DarkRed;
        public static Color colorBotonesCopiado = Color.LightCyan;
        public static Color colorBotonesGestion = Color.LightBlue;
        public static Color colorBotonesNavegacion = Color.LightSteelBlue;

        public static Color colorBotonesEnlazado = Color.LightBlue;
        public static Color colorBotonesRelacion = Color.LightSteelBlue;
    }
}
