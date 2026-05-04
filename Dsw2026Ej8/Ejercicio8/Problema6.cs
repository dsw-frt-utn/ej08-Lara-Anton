using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8.Ejercicio8
{
    internal class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();
        }
    }
}
