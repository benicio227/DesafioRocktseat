using System.Globalization;

class Program
{
    static void Main()
    {
        //1Aº
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

        //2Aº
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;

        Console.WriteLine("Nome completo: " + nomeCompleto);

        Console.WriteLine("Pressine qualquer tecla para sair...");
        Console.ReadKey();

        //3Aº
        double valor1 = 11.5;
        double valor2 = 4.5;

        double soma = valor1 + valor2;
        double subtracao = valor1 - valor2;
        double multiplicacao = valor1 * valor2;
        double divisao = valor2 != 0 ? valor1 / valor2 : double.NaN;
        double media = (valor1 + valor2) / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        if (valor2 != 0)
        {
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine($"Divisão: Não foi possível dividir por zero!");
        }
        Console.WriteLine($"Média: {media}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

        //4Aº
        Console.WriteLine("Digite uma ou mais palavras");
        string input = Console.ReadLine();

        int contadorCaracteres = 0;

        foreach (char c in input)
        {
            contadorCaracteres++;
        }

        Console.WriteLine($"Quantidade de caracteres: {contadorCaracteres}");
        Console.ReadKey();

        //5Aº
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine().ToUpper();

        bool placaValida = placa.Length == 7 &&
        char.IsLetter(placa[0]) &&
        char.IsLetter(placa[1]) &&
        char.IsLetter(placa[2]) &&
        char.IsDigit(placa[3]) &&
        char.IsDigit(placa[4]) &&
        char.IsDigit(placa[5]) &&
        char.IsDigit(placa[6]);

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();

        //6Aº
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2. Apenas a data no formato \"01/03/2024");
        Console.WriteLine("3. Apenas a hora no formato de 24 horas");
        Console.WriteLine("4. A data com o mês por extenso");

        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine(dataAtual.ToString("dddd, dd MMMM yyyy, HH:mm:ss"));
        }
        else if (escolha == "2")
        {
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        }
        else if (escolha == "3")
        {
            Console.WriteLine(dataAtual.ToString("HH:mm"));
        }
        else if (escolha == "4")
        {
            Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
