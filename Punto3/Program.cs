namespace TPN1_Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int control, cantidad=0;
            Random rnd = new Random();
            List<Empleado> ListadoE = new List<Empleado>();
            do
            {
                Empleado E = new Empleado();
                Console.WriteLine($"Carga Empleado N{cantidad+1}");
                try{
                    E.cargarEmpleadoA();
                    ListadoE.Add(E);
                }
                catch(IndexOutOfRangeException)
                {
                    System.Console.WriteLine("Error: el valor ingresado para un tipo de dato no corresponde con su rango.");
                }
                catch(FormatException)
                {
                    System.Console.WriteLine("Error: el valor ingresado no es del tipo esperado");
                }
                catch(Exception e)
                {
                    System.Console.WriteLine($"Error: {e.Message}");
                }
                cantidad++;
                System.Console.WriteLine("desea ingresar un nuevo empleado? 1=Sí, 0=No");
                control = Convert.ToInt32(Console.ReadLine());
            }while(control!=0);

            foreach (var Empleado in ListadoE)
            {
                Empleado.MostrarDatos();
            }
        }
    }
}