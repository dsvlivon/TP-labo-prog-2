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
        #region Xml
        /// <summary>
        /// Metodo estático para serializar un objeto tipo T genérico en la ruta especifícada
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="ruta"></param>
        public static void SerializarAXml(T objeto, string ruta, string nombre)
        {
            XmlTextWriter writer = null;
            string rutaAbsoluta = ruta + @"\" + nombre + ".xml";
            try
            {
                writer = new XmlTextWriter(rutaAbsoluta, Encoding.UTF8);
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
        #endregion


        #region Txt
        /// <summary>
        /// Metodo para LEER un string en formato txt de la ruta especificada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="nombre"></param>
        /// <returns> retorna el texto leído formateado con salots de linea. </returns>
        public static string LeerTxt(string ruta, string nombre)
        {
            StreamReader streamRead = null;
            try
            {
                streamRead = new StreamReader(ruta);
                string text = string.Empty;
                string newLine = streamRead.ReadLine();
                while (newLine != null)
                {
                    text += newLine + "\n";
                    newLine = streamRead.ReadLine();
                }
                return text;
            }
            finally
            {
                if (streamRead != null)
                {
                    streamRead.Close();
                }
            }
        }

        /// <summary>
        /// Método estático para guardar un archivo txt en la ruta especificada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="texto"></param>
        /// <param name="nombre"></param>
        public static void GuardarTxt(string ruta, string texto, string nombre)
        {
            StreamWriter streamWriter = null;
            string rutaAbsoluta = ruta + @"\" + nombre + ".txt";
            try
            {
                streamWriter = new StreamWriter(rutaAbsoluta, false);
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
        #endregion
    }
}