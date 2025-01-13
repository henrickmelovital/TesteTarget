using ConsoleApp1.Target;

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

        // Cálculo do faturamento diário
        List<double> faturamentos = new List<double> { 22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0, 42889.2258 };
        solution.FaturamentoDiarioValoresValidosMin(faturamentos);
        solution.FaturamentoDiarioValoresValidosMax(faturamentos);
        solution.FaturamentoDiarioValoresValidosMedia(faturamentos);
        Console.WriteLine($"\nMenor valor: {solution.FaturamentoDiarioValoresValidosMin(faturamentos)}");
        Console.WriteLine($"Maior valor: {solution.FaturamentoDiarioValoresValidosMax(faturamentos)}");
        Console.WriteLine($"Dias acima da média: {solution.FaturamentoDiarioValoresValidosMedia(faturamentos)}");

        // Cálculo do faturamento por estado
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        var percentuaisPorEstado = solution.FaturamentoPorEstado(faturamentoPorEstado);
        Console.WriteLine($"\nPercentual de faturamento por estado:");
        foreach (var estado in percentuaisPorEstado)
        {
            Console.WriteLine($"{estado.Key}: {estado.Value:F2}%");
        }

        //Invert String
        Console.WriteLine("\nInforme uma string: ");
        string str = Console.ReadLine();
        Console.WriteLine($"String invertida: {solution.InvertString(str)}");
    }
}

