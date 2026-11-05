using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduGrade
{
    static class RegistroLogs
    {
        public static void BorrarLog(string ficheroLog = Globales._logUsuario)
        {
            if (File.Exists(ficheroLog))
            {
                File.Delete(ficheroLog);
            }
        }

        public static void AbrirLog(string ficheroLog = Globales._logUsuario)
        {
            if (File.Exists(ficheroLog))
            {
                try
                {
                    using (FileStream fs = File.Open(ficheroLog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) { }
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = ficheroLog,
                        UseShellExecute = true
                    };

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception error)
                {
                    RegistrarEnLog($"Error al abrior el log: {error.Message}", ficheroLog);
                }
            }
        }

        public static void RegistrarEnLog(string registro, string destino = Globales._logUsuario)
        {
            DateTime fechaYHora = DateTime.Now;
            using (StreamWriter registroLog = new StreamWriter(destino, true))
            {
                registroLog.WriteLine($"{fechaYHora} [Nota] \t{registro}");
            }
        }
    }
}
