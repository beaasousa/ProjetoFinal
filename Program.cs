string opcaoDesejada;

do
{
    Console.Clear();

    Console.WriteLine("--- Operações ---\n");

    Console.WriteLine("[+] Soma");
    Console.WriteLine("[-] Subtração");
    Console.WriteLine("[*] Multiplicação");
    Console.WriteLine("[/] Divisão");
    Console.WriteLine("[^] Exponenciação");
    Console.WriteLine("[~] Radiciação");
    Console.WriteLine("[=] MédiaAritmética");
    Console.WriteLine("[&] Conversões");
    Console.WriteLine("[0] Sair");
    Console.WriteLine("[#] Sobre");

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
        case "0":
            string confirmou = Calculadora.ExibeSair();

            if (confirmou == "N" || confirmou == "n")
            {
                opcaoDesejada = "X";
            }
            else
            {
                return;
            }
            break;

        case "#":
            Calculadora.ExibeMiniintroduçao();
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (opcaoDesejada != "0");