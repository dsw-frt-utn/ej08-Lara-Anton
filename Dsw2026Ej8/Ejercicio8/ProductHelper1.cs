using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio8
{
    internal partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string formattedPrice = FormatearPrecio(price);
            return $"[{code}] {description} - {formattedPrice:C}";
        }
    }
}
