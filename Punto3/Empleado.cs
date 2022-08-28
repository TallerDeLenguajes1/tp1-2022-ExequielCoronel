namespace TPN1_Punto3
{
    public enum EstadoCivil
        {
            soltero = 0,
            casado = 1,
            divorciado = 2
        }

    public enum EstudiosMax
        {
            primario = 1,
            secundario = 2,
            terciario = 3,
            universitario = 4
        }
    class Empleado
    {
        private EstadoCivil estadocivil;
        private EstudiosMax estudiosmax;
        private string nombre;
        private string apellido;
        private string Dni;
        private string direccion;
        private DateTime fechaNacimiento;

        private DateTime fechaIngreso;

        private string titulo;

        private string establecimientoEstudio;
        private double sueldoBasico;

        private int cantidadHijos;

        private DateTime fechaDivorcio;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DNI { get => Dni; set => Dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int CantidadHijos { get => cantidadHijos; set => cantidadHijos = value; }
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }

        public int antiguedad()
        {
            DateTime FechaActual;
            FechaActual=DateTime.Now;
            if(FechaIngreso.Year == FechaActual.Year && FechaIngreso.Month < FechaActual.Month)
            {
                return 1;
            }
            return (FechaActual.Year-FechaIngreso.Year);    
        }

        

        public int edad()
        {
            DateTime FechaActual = DateTime.Now;
            if(FechaActual.Year-FechaNacimiento.Year>=18 && FechaNacimiento.Month<=FechaActual.Month)
            {
                return(FechaActual.Year-FechaNacimiento.Year);
            } else if(FechaActual.Year-FechaNacimiento.Year>18 && FechaNacimiento.Month>FechaActual.Month)
                   {
                        return(FechaActual.Year-FechaNacimiento.Year-1);
                   }
            return 0;
        }

        public double salario()
        {
            const double DESCUENTO = 0.15;
            const double ADICIONAL = 0.01; 
            if(antiguedad()<20)
            {
                return (sueldoBasico + ADICIONAL*antiguedad()*sueldoBasico - DESCUENTO*sueldoBasico);
            }
            return (sueldoBasico + ADICIONAL*25*sueldoBasico - DESCUENTO*sueldoBasico); 
        }

        public void cargarEmpleadoA()
        {
            Random rnd = new Random();
            Console.WriteLine("Ingrese el apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            Nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese la direccion: ");
            Direccion = Console.ReadLine();
            System.Console.WriteLine("Ingrese el DNI: ");
            DNI = Console.ReadLine();
            int anio, mes, dia;
            anio = rnd.Next(1965,1983);
            mes = rnd.Next(1,13);
            dia = rnd.Next(1,28);
            FechaNacimiento = new DateTime(anio,mes,dia);
            FechaIngreso = new DateTime(rnd.Next(2001,2023),rnd.Next(1,13),rnd.Next(1,28));
            System.Console.WriteLine("Ingrese el Sueldo basico: ");
            SueldoBasico = Convert.ToDouble(Console.ReadLine());
            CantidadHijos = rnd.Next(1,6);
            switch (rnd.Next(1,4))
            {
                case 1:
                    estadocivil = EstadoCivil.casado;
                    break;
                case 2:
                    estadocivil = EstadoCivil.divorciado;
                    break;
                case 3: 
                    estadocivil = EstadoCivil.soltero;
                    break;
                default:
                    break;
            }
            if(estadocivil == EstadoCivil.divorciado)
            {
                fechaDivorcio = new DateTime(rnd.Next(2000,2023));
            }
            cantidadHijos = rnd.Next(1,7);
            switch (rnd.Next(1,10))
            {
                case 1:
                    estudiosmax = EstudiosMax.primario;
                    break;
                case 2:
                    estudiosmax = EstudiosMax.secundario;
                    break;
                case 3: 
                    estudiosmax = EstudiosMax.terciario;
                    break;
                default:
                    estudiosmax = EstudiosMax.universitario;
                    break;
            }
            System.Console.WriteLine("Ingrese el nombre del establecimiento de estudio: ");
            establecimientoEstudio=Console.ReadLine();
        }

        public void MostrarDatos()
        {
            System.Console.WriteLine($"Nombre: {Nombre} \n Apellido {Apellido} \n Edad: {edad()} \n Antiguedad: {antiguedad()} \n Salario: {salario()}");
        }
    }
}