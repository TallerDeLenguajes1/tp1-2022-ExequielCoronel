using System; 
namespace TPN1_Punto2
{
    class Program
    {
        static void Main (string[] args)
        {
            int num;
            
            try{
                System.Console.WriteLine("Ingrese un numero entero, para calcular su cuadrado: ");
                num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"El cuadrado de {num} es {num*num}");
            }catch(FormatException){
                System.Console.WriteLine("Error: se supero el tamaño que soporta el tipo de dato entero.");
            }catch(OverflowException){
                System.Console.WriteLine("Error: el numero ingresado supera el tamaño soportado por el tipo de dato entero.");
            }catch(Exception e){
                System.Console.WriteLine($"Error:{e.Message}");
            } 
        }
    }
    
}
