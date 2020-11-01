using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(archivo,false); 
                streamWriter.WriteLine(datos);
                
            }
            catch(Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }
            return true;
        }
            

        public bool Leer(string archivo, out string datos)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(archivo, false);
                string text = string.Empty;
                string newLine = streamReader.ReadLine();
                while (newLine != null)
                {
                    text += newLine + "\n";
                    newLine = streamReader.ReadLine();
                }
                datos = text;
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }
            return true;
        }
        
    }
}
