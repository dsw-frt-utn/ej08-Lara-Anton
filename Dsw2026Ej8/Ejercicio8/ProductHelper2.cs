using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dsw2026Ej8.Ejercicio8
{
    internal partial class ProductHelper
    {
        public string FormatearPrecio(decimal price)
        {
            return price.ToString("C", new CultureInfo("es-AR"));
        }
    }
}
