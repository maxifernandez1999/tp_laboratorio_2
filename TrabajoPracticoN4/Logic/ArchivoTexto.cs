using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
namespace Logic
{
    public class ArchivoTexto
    {

        /// <summary>
        /// metodo que guarda infomacion en un archivo de texto
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos a guardar</param>
        /// <returns>retorta true, todo ok. Lanza una excepcion si ocurrio un error</returns>
        public bool GuardarArchivoTexto(string archivo, string datos,bool append)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(archivo, append);
                streamWriter.WriteLine(datos);

            }
            catch (Exception)
            {
                throw new ArchivosException("Se a producido un error al guardar informacion en el archivo de texto");
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }
            return true;
        }


        /// <summary>
        /// metodo que lee infomacion de un archivo de texto
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">parametro para retornar los datos</param>
        /// <returns>retorta true, todo ok. Lanza una excepcion si ocurrio un error</returns>
        public bool LeerArchivoTexto(string archivo, out string datos)
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
            catch (Exception)
            {
                throw new ArchivosException("Se a producido un error al leer informacion en el archivo de texto");
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
