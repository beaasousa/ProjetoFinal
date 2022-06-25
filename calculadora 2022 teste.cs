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

}