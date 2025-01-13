using ConsoleApp1.Target;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Cálculo do valor da variável soma
        Console.WriteLine("Soma: " + solution.Soma(indice: 13, soma: 0, K: 0));

        // Verificação se o número pertence à sequência de Fibonacci
        Console.WriteLine("\nInforme um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (solution.PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

        // JSON do faturamento diário
        string faturamentoJson = @"
        [
            { ""dia"": 1, ""valor"": 22174.1664 },
            { ""dia"": 2, ""valor"": 24537.6698 },
            { ""dia"": 3, ""valor"": 26139.6134 },
            { ""dia"": 4, ""valor"": 0.0 },
            { ""dia"": 5, ""valor"": 0.0 },
            { ""dia"": 6, ""valor"": 26742.6612 },
            { ""dia"": 7, ""valor"": 0.0 },
            { ""dia"": 8, ""valor"": 42889.2258 }
        ]";

        var faturamentoDiario = JsonConvert.DeserializeObject<List<Faturamento>>(faturamentoJson);
        var valoresFaturamento = faturamentoDiario.Select(f => f.Valor).ToList();

        Console.WriteLine($"\nMenor valor: {solution.FaturamentoDiarioValoresValidosMin(valoresFaturamento):F2}");
        Console.WriteLine($"Maior valor: {solution.FaturamentoDiarioValoresValidosMax(valoresFaturamento):F2}");
        Console.WriteLine($"Dias acima da média: {solution.FaturamentoDiarioValoresValidosMedia(valoresFaturamento)}");

        // JSON do faturamento por estado
        string faturamentoPorEstadoJson = @"
        {
            ""SP"": 67836.43,
            ""RJ"": 36678.66,
            ""MG"": 29229.88,
            ""ES"": 27165.48,
            ""Outros"": 19849.53
        }";

        var faturamentoPorEstado = JsonConvert.DeserializeObject<Dictionary<string, double>>(faturamentoPorEstadoJson);
        var percentuaisPorEstado = solution.FaturamentoPorEstado(faturamentoPorEstado);

        Console.WriteLine($"\nPercentual de faturamento por estado:");
        foreach (var estado in percentuaisPorEstado)
        {
            Console.WriteLine($"{estado.Key}: {estado.Value:F2}%");
        }

        // Inversão de string
        Console.WriteLine("\nInforme uma string: ");
        string str = Console.ReadLine();
        Console.WriteLine($"String invertida: {solution.InvertString(str)}");
    }
}


class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

