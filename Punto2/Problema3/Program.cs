namespace TPN1_Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Km, Litros;
            try
            {
                System.Console.WriteLine("Ingrese los kilómetros conducidos: ");
                Km = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Ingrese los litros consumidos: ");
                Litros = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"Los kilómetros recoridos por litro son: {Km/Litros} Km/L");
            } 
            catch(FormatException)
            {
                System.Console.WriteLine("Error: Tipo de dato no soportado");
            }
            catch(DivideByZeroException)
            {
                System.Console.WriteLine("Error: Los litros consumidos no pueden ser 0");
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}