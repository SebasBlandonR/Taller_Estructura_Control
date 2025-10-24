using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class Empleado
    {
        public int _Id { get; set; }
        public string _Nombre { get; set; }
        public List<double> _Ventas { get; set; }
        public double _TotalVentas { get; set; }
        public double _Bonificacion { get; set; }
        public double _PagoTotal { get; set; }

        public Empleado(int id, string nombre, List<double> ventas, double totalVentas, double bonificacion, double pagoTotal)
        {
            _Id = id;
            _Nombre = nombre;
            _Ventas = ventas;
            _TotalVentas = totalVentas;
            _Bonificacion = bonificacion;
            _PagoTotal = pagoTotal;
        }

        public class EmpleadoCrud
        {
            public List<Empleado> empleados = new List<Empleado>();
            public int siguienteId = 1;
            public const double PAGO_BASICO = 500000;

            public void AgregarEmpleado(Empleado empleado)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad de ventas realizadas por el empleado: ");
                int cantidadVentas = int.Parse(Console.ReadLine());

                List<double> ventas = new List<double>();

                for (int i = 0; i < cantidadVentas; i++)
                {
                    double venta = 0;
                    bool entradaValida = false;

                    while (!entradaValida)
                    {
                        Console.Write($"Ingrese el valor de la venta #{i + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out venta) && venta > 0)
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Ingrese un número positivo.");
                        }
                    }

                    ventas.Add(venta);
                }

                double totalVentas = ventas.Sum();
                double bonificacion = CalcularBonificacion(totalVentas);
                double pagoTotal = PAGO_BASICO + bonificacion;

                empleado = new Empleado(siguienteId++, nombre, ventas, totalVentas, bonificacion, pagoTotal);
                empleados.Add(empleado);

                Console.WriteLine("Empleado registrado correctamente.\n");
            }

            private double CalcularBonificacion(double totalVentas)
            {
                if (totalVentas > 800000)
                    return totalVentas * 0.10;
                else if (totalVentas > 400000)
                    return totalVentas * 0.05;
                else if (totalVentas >= 400000)
                    return totalVentas * 0.03;
                else
                    return 0;
            }

            public void MostrarEmpleados()
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine("No hay empleados registrados.\n");
                    return;
                }

                Console.WriteLine("Lista de empleados y ventas realizadas:\n");

                foreach (var empleado in empleados)
                {
                    int menores300 = empleado._Ventas.Count(v => v <= 300000);
                    int entre300y800 = empleado._Ventas.Count(v => v > 300000 && v < 800000);
                    int mayores800 = empleado._Ventas.Count(v => v >= 800000);

                    Console.WriteLine($"ID: {empleado._Id}, Nombre: {empleado._Nombre}");
                    Console.WriteLine($"Ventas <= $300.000: {menores300}");
                    Console.WriteLine($"Ventas > $300.000 y < $800.000: {entre300y800}");
                    Console.WriteLine($"Ventas >= $800.000: {mayores800}");
                    Console.WriteLine($"Total ventas: ${empleado._TotalVentas:N0}");
                    Console.WriteLine($"Bonificación: ${empleado._Bonificacion:N0}");
                    Console.WriteLine($"Pago total (Básico + Bonificación): ${empleado._PagoTotal:N0}");
                    Console.WriteLine();
                }
            }

            public void MostrarResumenGeneral()
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine("No hay datos registrados.\n");
                    return;
                }

                double totalVentasEmpresa = empleados.Sum(e => e._TotalVentas);
                double totalBonificaciones = empleados.Sum(e => e._Bonificacion);
                double totalPagos = empleados.Sum(e => e._PagoTotal);

                Console.WriteLine("===== RESUMEN GENERAL DEL DÍA =====");
                Console.WriteLine($"Total de empleados registrados: {empleados.Count}");
                Console.WriteLine($"Monto total de ventas: ${totalVentasEmpresa:N0}");
                Console.WriteLine($"Total de bonificaciones pagadas: ${totalBonificaciones:N0}");
                Console.WriteLine($"Monto total a pagar (sueldos + bonificaciones): ${totalPagos:N0}");
                Console.WriteLine();
            }
        }
    }
}