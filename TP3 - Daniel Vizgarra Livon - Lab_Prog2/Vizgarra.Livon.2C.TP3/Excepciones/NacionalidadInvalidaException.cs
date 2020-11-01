﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException() : this("Error de DNI/Nacionalidad...")
        {

        }

       
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }

    }
}
