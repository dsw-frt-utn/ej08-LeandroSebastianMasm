using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = 0;
            if (quantity > 0)
            {
                total = quantity * unitPrice;
            }
            else
            {
                total = 0;
            }

            var resumenVenta = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };
            return $"{resumenVenta.Code}-{resumenVenta.Description}-{resumenVenta.Total:C}";
        }
    }
}

