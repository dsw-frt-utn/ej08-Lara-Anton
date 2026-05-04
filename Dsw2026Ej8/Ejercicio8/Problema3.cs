using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Dsw2026Ej8.Ejercicio8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue;
            copyValue++;
            Product copyProduct = product;
            copyProduct.ModifyDescription("Descripcion Modificada");

            return $"{originalValue} - {copyValue} - {product.Description}, Producto Copia: {copyProduct.Name}";
        }
    }
}
