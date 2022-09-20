using NLog;
namespace TPN1_Punto3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
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
                catch(IndexOutOfRangeException e)
                {
                    System.Console.WriteLine("Error: el valor ingresado para un tipo de dato no corresponde con su rango.");
                    logger.Info(e,"Error: "+e.Message);
                }
                catch(FormatException e)
                {
                    System.Console.WriteLine("Error: el valor ingresado no es del tipo esperado");
                    logger.Debug(e,"Error"+e.Message);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine($"Error: {e.Message}");
                    logger.Info(e,"Error: "+e.Message);
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