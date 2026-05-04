using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio8
{
    internal class Problema5
    {
        public decimal ObtenerImporte(Sale sale) {

            sale.CalculateTotal();
            return sale.Total;
        }


        class RetailSale: Sale
        {
            public long ProductCode { get; set; }
            public string ProductDescription { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }

            public override void CalculateTotal()
            {
                Total = Quantity * UnitPrice;
            }
        }

        class WholesaleSale: Sale
        {
            public long ProductCode { get; set; }
            public string ProductDescription { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Discount { get; set; } = 0.10m;

            public override void CalculateTotal()
            {
                decimal subtotal = Quantity * UnitPrice;
                Total = subtotal - (subtotal * Discount);
            }

        }

        public class Sale
        {
            public decimal Total { get; protected set; }
            public virtual void CalculateTotal()
            {
                // Implementación base, puede ser vacía o lanzar una excepción si se espera que las subclases la implementen.
            }

        }
    }
