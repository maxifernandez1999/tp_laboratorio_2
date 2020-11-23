using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;
namespace Logic
{
    public class ArchivosXml<T>
        where T : new()
    {

        /// <summary>
        /// metodo que se encarga de serializar en archivo xml los datos
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos a serializar</param>
        /// <returns>true, todo ok. lanza una excepcio si ocurrio un error</returns>
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
            }
            catch (Exception)
            {
                throw new ArchivosException("Se ha producido un error al Guardar un archivo en formato XML");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// metodo que se encarga de deserializar en archivo xml los datos
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        /// <param name="datos">datos  deserializados</param>
        /// <returns>true, todo ok. lanza una excepcio si ocurrio un error</returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("Se ha producido un error al Guardar un archivo en formato XML");
            }


        }
    }
}
