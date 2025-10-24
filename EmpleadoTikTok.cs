using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_Estructura_Control
{
    internal class EmpleadoTikTok
    {
        public int _Id { get; set; }
        public string _Nombre { get; set; }
        public DateTime _FechaNacimiento { get; set; }
        public int _Edad { get; set; }
        public bool _RecibeBono { get; set; }

        public EmpleadoTikTok(int id, string nombre, DateTime fechaNacimiento)
        {
            _Id = id;
            _Nombre = nombre;
            _FechaNacimiento = fechaNacimiento;
            _Edad = CalcularEdad(fechaNacimiento);
            _RecibeBono = _Edad > 18 && _Edad < 50;
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        public class TikTokCrud
        {
            public List<EmpleadoTikTok> empleados = new List<EmpleadoTikTok>();
            public const double BONO = 150000;

            public void AgregarEmpleado()
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
                DateTime fecha;
                while (!DateTime.TryParse(Console.ReadLine(), out fecha))
                {
                    Console.Write("Fecha inválida. Intente nuevamente (YYYY-MM-DD): ");
                }

                empleados.Add(new EmpleadoTikTok(empleados.Count + 1, nombre, fecha));
                Console.WriteLine("Empleado registrado correctamente.\n");
            }

            public void MostrarEstadisticas()
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine("No hay empleados registrados.\n");
                    return;
                }

                var empleadosConBono = empleados.Where(e => e._RecibeBono).ToList();
                double promedioEdad = empleadosConBono.Average(e => e._Edad);

                Console.WriteLine($"Promedio de edad de empleados que reciben bono: {promedioEdad:F2} años");

                Console.WriteLine("\n===== BONOS POR MES =====");
                for (int mes = 1; mes <= 12; mes++)
                {
                    var empleadosMes = empleadosConBono.Where(e => e._FechaNacimiento.Month == mes).ToList();
                    int cantidad = empleadosMes.Count;
                    double dinero = cantidad * BONO;

                    if (cantidad > 0)
                    {
                        Console.WriteLine($"{new DateTime(2020, mes, 1).ToString("MMMM")}: {cantidad} empleados, Dinero en Bonos: ${dinero:N0}");
                    }
                }

                double totalBonos = empleadosConBono.Count * BONO;
                Console.WriteLine($"\nTotal de dinero en bonos a pagar: ${totalBonos:N0}\n");
            }
        }
    }
}