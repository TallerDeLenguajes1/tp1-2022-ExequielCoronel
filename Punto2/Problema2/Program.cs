namespace TPN1_Punto2
{
    using System;
    class Program
    {
        static void Main (string[] args)
        {
            int num1, num2;
            try
            {
                System.Console.WriteLine("Ingrese el dividendo: ");
                num1=Convert.ToInt32(Console.ReadLine()); 
                System.Console.WriteLine("Ingrese el divisor: ");
                num2=Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"El cociente entero {num1}/{num2} es igual a {num1/num2}");
            }
            catch(DivideByZeroException)
            {
                System.Console.WriteLine("Error: No esta definida la division por 0");
            }
            catch(OverflowException)
            {
                System.Console.WriteLine("Error: Se supero el tamaño soportado por el tipo de dato entero");
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Error: No se ingreso el tipo de dato esperado");
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}