﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public class Universidad
    {

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get 
            {
                return this.alumnos;
            }
            set 
            {
                this.alumnos = value;
            }
        }
        public List<Profesor> Instructores
        {
            get 
            {
                return this.profesores;
            }
            set 
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas 
        {
            get 
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i] 
        { 
            get 
            { 
                return this.jornada[i]; 
            } 
            set 
            { 
                this.jornada[i] = value; 
            } 
        }
        #endregion

        #region Constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Metodos
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(string.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), uni);
        }

        //public Universidad Leer()
        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad universidad = new Universidad();

            xml.Leer(String.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), out universidad);
            return universidad;
        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<------------------------------------->");
            }
            return sb.ToString();
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g==a);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.profesores)
            {
                if (profesor == i)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            
            throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = g == clase; //esto no lo entiendo
            Jornada jornada = new Jornada(clase, profesor);
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                {
                    jornada += alumno;
                }
            }
            g.Jornadas.Add(jornada);
            return g;

        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            throw new AlumnoRepetidoException();
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)//gracias a la sobrecarga del ==0
            {
                u.Instructores.Add(i);
            }
            return u;
        }
        #endregion
    }
}
