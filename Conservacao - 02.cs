public class Conversao 
{
   public static double MetroParaFoot (double distanciaMetro)
   {
       return Math.Round(distanciaMetro *3.281);
   } 
   public static double FootParaMetro (double distanciaFoot)
   {
       return Math.Round(distanciaFoot /3.281);
   }
}