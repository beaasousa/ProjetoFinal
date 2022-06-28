public class Calculadora
{
    public static void CalcularSoma()
    {
        double a, b, resultado;

        Console.WriteLine("--- Soma A+B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Soma(a, b);

        Console.WriteLine($"{a} somado com {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularSubtracao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Subtração A-B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Subtracao(a, b);

        Console.WriteLine($"{a} subtraindo {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularMultiplicacao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Multiplicacao(a, b);

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularDivisao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero.");
        }
        else
        {
            resultado = Aritmetica.Divisao(a, b);

            Console.WriteLine($"{a} dividido por {b} é {resultado}");
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularExponenciação()
     {
         Console.Clear();
         double Exponenciação, a,b;

         Console.WriteLine("---Exponenciação---\n");
         Console.WriteLine("digite os valores:");

         Console.Write("Base: ");
         a = Convert.ToDouble(Console.ReadLine());
         Console.Write("Expoente: ");
         b = Convert.ToDouble(Console.ReadLine());

         Exponenciação = Math.Pow(a, b);

         Console.WriteLine($"O resultado é: {Exponenciação}");

         Console.Write("Pressione uma tecla para continuar");
         Console.ReadKey();
     }
     public static void CalcularRadiciação()
     {
         Console.Clear();
         double Radiciação, x;

         Console.WriteLine("---Radiciação---\n");
         Console.WriteLine("Digite os valores: ");
         Console.Write("Número: ");
         x = Convert.ToDouble(Console.ReadLine());

         Radiciação = Math.Sqrt(x);

         Console.WriteLine($"O resultado é {Radiciação}");

         Console.Write("Pressione uma tecla para continuar");
         Console.ReadKey();
         
     }

    public static void CalcularMédiaAritmética()
    {
        double n1, n2, n3, media;
 

    Console.WriteLine("Média Aritmética de 3 números\n");

    Console.Write("Digite o primeiro numero:");
    n1 = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite o segundo numero:");
    n2 = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite o terceiro numero:");
    n3 = Convert.ToDouble(Console.ReadLine()!);

    media = (n1 + n2 + n3) /3;

    Console.WriteLine($"Média: {media:N1} ");
    }


    public static void CacularConversões()
    {
        Console.Clear();
        string opcaoDesejada;

        Console.Clear();
        Console.WriteLine("---CONVERSÃO DE DISTÂNCIA---\n");
        Console.WriteLine("[A] Metro para Foot");
        Console.WriteLine("[B] Foot para Metro");
        Console.WriteLine("\n[0] Voltar");

        Console.Write("\nEscolha uma opção: ");
        opcaoDesejada = Console.ReadLine()!;

        switch (opcaoDesejada)
        {
            case "A":
                ConversoesVisuais.MetroParaFoot();
                break;

            case "B":
                ConversoesVisuais.FootParaMetro();
                break;

            case "0":
                return;
        }
    }
 public static string ExibeSair()
    {
        Console.Clear();
        string saida;

        Console.WriteLine("Deseja sair do programa?");
        Console.WriteLine("Y-Yes || N-No");
        Console.Write("Escolha uma opção: ");
        saida = Console.ReadLine()!;

        switch (saida.ToUpper())
        {
            case "S":

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nObrigado por usar meu programa!");
                Console.ResetColor();

                return saida;

            case "N" or "n":
                return saida;

                default:
                return "N";
        }
    }

     public static void ExibeMiniintroduçao()
    {
        Console.Clear();
        Console.WriteLine("-- Um pouco sobre mim e o motivo do projeto--\n");

        Console.WriteLine("Me chamo Ana Beatriz, tenho 16 anos e faço curso de Informática na Etec Adolpho Berezin, estou no 1° Módulo do Ensino Técnico.");

        Console.WriteLine("Este projeto foi realizado com a intenção de por em prática o que aprendi nesse módulo do curso\n");
        Console.WriteLine("Quero parabenizar e agradecer os professores, Ermogenes Palacio e Diego Neri, por serem ótimos profissionas e conseguirem ensinar tantas pessoas, a ponto de motivá-las a seguirem nessa área.");

        Console.WriteLine("Pressione uma tecla para continuar: ");
        Console.ReadKey();
    }

}
