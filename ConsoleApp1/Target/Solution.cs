using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Target
{
    internal class Solution
    {
        public int Soma(int indice, int soma, int K)
        {
            while (K < indice)
            {
                K += 1;
                soma += K;

            }

            return soma;
        }

        public bool PertenceFibonacci(int nuemro)
        {
            int a = 0;
            int b = 1;
            int temp;

            while (a < nuemro)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return a == 0;
        }

        public double FaturamentoDiarioValoresValidosMin(List<double> faturamentos)
        {
            var valoresValidos = faturamentos.Where(x => x > 0).ToList();
            return valoresValidos.Min();
        }

        public double FaturamentoDiarioValoresValidosMax(List<double> faturamentos)
        {
            var valoresValidos = faturamentos.Where(x => x > 0).ToList();
            return valoresValidos.Max();
        }

        public double FaturamentoDiarioValoresValidosMedia(List<double> faturamentos)
        {
            var valoresValidos = faturamentos.Where(x => x > 0).ToList();
            double mediaMensal = valoresValidos.Average();
            int diasAcimaDaMedia = valoresValidos.Count(v => v > mediaMensal);
            return diasAcimaDaMedia;
        }

        public Dictionary<string, double> FaturamentoPorEstado(Dictionary<string, double> faturamentosPorEstado)
        {
            double faturamentoTotal = faturamentosPorEstado.Values.Sum();

            Dictionary<string, double> percentuaisPorEstado = new Dictionary<string, double>();

            foreach (var estado in faturamentosPorEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;

                percentuaisPorEstado.Add(estado.Key, percentual);
            }

            return percentuaisPorEstado;
        }


        public string InvertString(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            string invertida = "";

            for (int i = caracteres.Length - 1; i >= 0; i--)
            {
                invertida += caracteres[i];
            }

            return invertida;
        }
    }
}
