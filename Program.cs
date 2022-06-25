string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[^] Exponenciação");
Console.WriteLine("[~] Radiciação");
Console.WriteLine("[=] MédiaAritmética");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Calculadora.CalcularSoma();

        break;
    case "-":
        Calculadora.CalcularSubtracao();
    
        break;
    case "*":
       Calculadora.CalcularMultiplicacao();

        break;
    case "/":
      Calculadora.CalcularDivisao();

        break;
    case "^":
        Calculadora.CalcularExponenciação();

        break;
    case "~":
        Calculadora.CalcularRadiciação();
      
        break;
    case "=":
        Calculadora.CalcularMédiaAritmética();

        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine("\nObrigado por utilizar nosso programa.");

    return;