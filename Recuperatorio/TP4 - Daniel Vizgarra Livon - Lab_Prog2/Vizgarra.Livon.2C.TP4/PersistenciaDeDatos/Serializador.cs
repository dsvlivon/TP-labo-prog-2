using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace PersistenciaDeDatos
{
    /// <summary>
    /// metodo que aplica generics para serializar un objeto segun la ruta y las restricciones de <T>
    /// </summary>
    /// <typeparam name="T"> sea de clase y tengo un constructor </typeparam>
    public static class Serializador<T> where T : class, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="ruta"></param>
        public static void SerializarAXml(T objeto, string ruta)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new ArchivosException("Error: Directorio no encontrado.", ex);
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Error inesperado", ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
        /// <summary>
        /// metodo que aplica generics para Deserializar un objeto en la ruta especificada
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns> retorana un objeto default <T> </returns>
        public static T DeserializarXml(string ruta)
        {
            XmlTextReader reader = null;
            T objeto = default(T);
            try
            {
                reader = new XmlTextReader(ruta);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Ocurrió un error al tratar de deserializar el archivo XML.", ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return objeto;
        }
    }
}