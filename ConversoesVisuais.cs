
public class ConversoesVisuais
{
    public static void MetroParaFoot()
    {
        double distanciaMetro, distanciaFoot;

        Console.WriteLine("---METROS PARA FOOT---\n");

        Console.Write("Distância em metros: ");

        distanciaMetro = Convert.ToDouble(Console.ReadLine());
        distanciaFoot = Conversao.MetroParaFoot(distanciaMetro);

        Console.WriteLine($"\nO equivalente em foot é aproximadamente {distanciaFoot} foot(s)");

        Console.WriteLine("Pressione uma tecla para continuar  ");
        Console.ReadKey();

        return;
    }

     public static void FootParaMetro()
     {
         double distanciaFoot, distanciaMetro;

         Console.WriteLine("---FOOT PARA METRO---\n");

         Console.Write("Distância em foot: ");

         distanciaFoot = Convert.ToDouble(Console.ReadLine());
         distanciaMetro = Conversao.FootParaMetro(distanciaFoot);

         Console.WriteLine($"\nO equivalente em metro é aproximadamente {distanciaMetro} metro(s)");

         Console.WriteLine("Pressione uma tecla para continuar ");
         Console.ReadKey();

         return;
     }
}
