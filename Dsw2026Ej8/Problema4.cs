using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            double Promedio;
            List<int> notasValidas = new List<int>();
            int?[] notas = { nota1, nota2, nota3 };

            foreach (int? nota in notas)
            {
                if (nota != null && nota.Value >= 0 && nota.Value <= 10)
                {
                    notasValidas.Add(nota.Value);
                }
            }
            if (notasValidas.Count == 0)
            {
                return 0;
            }

            foreach (int nota in notasValidas)
            {
                suma += nota;
            }
            Promedio = suma / notasValidas.Count;
            return Promedio;
        }
    }
}
