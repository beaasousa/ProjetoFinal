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
Console.WriteLine("[&] Conversões");

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
    case "&":
        Calculadora.CacularConversões();

        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}