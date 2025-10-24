using Taller_Estructura_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1   
            //Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es 
            //del 5 % anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente
            //información.
            //• Cuanto dinero se ha pagado de intereses en un año.  
            //• Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            //• Cuanto dinero se ha pagado de intereses en el primer mes.
            //• Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses.

            //Console.WriteLine("Ingrese el monto del préstamo:");
            //double monto = Convert.ToDouble(Console.ReadLine());


            //double tasaAnual = 0.05;
            //int plazoAños = 5;

            //double interesAnual = monto * tasaAnual;
            //double interesTrimestre = interesAnual / 4;
            //double interesMensual = interesAnual / 12;
            //double totalIntereses = interesAnual * plazoAños;
            //double totalPago = monto + totalIntereses;

            //Console.WriteLine("\n===== RESULTADOS =====");
            //Console.WriteLine($"Monto del préstamo: ${monto:N2}");
            //Console.WriteLine($"Interés anual: ${interesAnual:N2}");
            //Console.WriteLine($"Interés en el tercer trimestre: ${interesTrimestre:N2}");
            //Console.WriteLine($"Interés en el primer mes: ${interesMensual:N2}");
            //Console.WriteLine($"Total de intereses pagados en {plazoAños} años: ${totalIntereses:N2}");
            //Console.WriteLine($"Total a pagar al final del préstamo: ${totalPago:N2}");

            //Console.WriteLine("\nPresione una tecla para salir...");
            //Console.ReadKey();


            //Ejercicio 2
            //Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una 
            //empresa.La colilla debe mostrar: 
            //● El Salario del Empleado  
            //● El Valor de Ahorro mensual programado. 
            //● La suma a deducir por aporte a la Salud(EPS) 12,5 %
            //● La suma a deducir por aporte al Fondo de Pensiones  16 %
            //● Total a Recibir
            //● Toda la información que debe proveer el usuario del programa es el  Salario del
            //Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y
            //devolver el resto de los datos.4

            //Console.WriteLine("====FACTURA DE PAGO EMPLEADO====");
            //Console.WriteLine("Ingrese el salario del empleado:");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrse el valor del ahorro mensual programado: ");
            //double ahorroMensual = Convert.ToDouble(Console.ReadLine());

            //double deduccionSalud = salario * 0.125;
            //double deduccionPension = salario * 0.16;
            //double totalDeducciones = deduccionSalud + deduccionPension + ahorroMensual;
            //double totalRecibir = salario - totalDeducciones;

            //Console.WriteLine("\n===== FACTURA DE PAGO =====");
            //Console.WriteLine($"Salario del Empleado: ${salario:N2}");
            //Console.WriteLine($"Valor de Ahorro Mensual Programado: ${ahorroMensual:N2}");
            //Console.WriteLine($"Deducción por Aporte a la Salud (EPS) 12.5%: ${deduccionSalud:N2}");
            //Console.WriteLine($"Deducción por Aporte al Fondo de Pensiones 16%: ${deduccionPension:N2}");
            //Console.WriteLine($"Total a Recibir: ${totalRecibir:N2}");


            //Ejercicio 3

            //Persona.PersonaCRUD personaCRUD = new Persona.PersonaCRUD();
            //bool continuar = true;

            //while (continuar)
            //{
            //    Console.WriteLine("\n=== Menú de Gestión de Personas ===");
            //    Console.WriteLine("1. Agregar Persona");
            //    Console.WriteLine("2. Editar Información de Persona");
            //    Console.WriteLine("3. Mostrar Personas");
            //    Console.WriteLine("4. Calcular Edad en Días");
            //    Console.WriteLine("5. Salir");
            //    string opcion = Console.ReadLine();
            //    switch (opcion)
            //    {
            //        case "1":
            //            personaCRUD.AgregarPersona(null);
            //            break;
            //        case "2":
            //            personaCRUD.EditarInformacion();
            //            break;
            //        case "3":
            //            personaCRUD.MostrarPersonas();
            //            break;
            //        case "4":
            //            personaCRUD.CalcularEdadEnDias();
            //            break;
            //        case "5":
            //            continuar = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            //            break;
            //    }
            //}


            //Ejercicio 4


            //Libro.BibliotecaCrud bibliotecaCrud = new Libro.BibliotecaCrud();
            //bool continuarBiblioteca = true;

            //while (continuarBiblioteca)
            //{
            //    Console.WriteLine("===== ADMINISTRACIÓN DE BIBLIOTECA =====");
            //    Console.WriteLine("1. Agregar Libro");
            //    Console.WriteLine("2. Listar Libros");
            //    Console.WriteLine("3. Buscar Libro por Título");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    int opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            bibliotecaCrud.AgregarLibro(null);
            //            break;
            //        case 2:
            //            bibliotecaCrud.ListarLibros();
            //            break;
            //        case 3:
            //            bibliotecaCrud.BuscarLibroPorTitulo();
            //            break;
            //        case 4:
            //            continuarBiblioteca = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            //            break;
            //    }
            //}

            //Ejercicio 5

            //MatriculaUniversitaria.MatriculaCrud matriculaCrud = new MatriculaUniversitaria.MatriculaCrud();
            //bool continuarMatricula = true;

            //while (continuarMatricula)
            //{
            //    Console.WriteLine("===== PROCESO DE MATRÍCULA UNIVERSITARIA 2020-3 =====");
            //    Console.WriteLine("1. Agregar Estudiante");
            //    Console.WriteLine("2. Mostrar Estudiantes");
            //    Console.WriteLine("3. Mostrar Resumen General");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    int opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            matriculaCrud.AgregarEstudiante(null);
            //            break;
            //        case 2:
            //            matriculaCrud.MostrarEstudiantes();
            //            break;
            //        case 3:
            //            matriculaCrud.MostrarResumen();
            //            break;
            //        case 4:
            //            continuarMatricula = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            //            break;
            //    }
            //}

            //Ejercicio 6

            //Empleado.EmpleadoCrud empleadoCrud = new Empleado.EmpleadoCrud();
            //bool continuar = true;

            //while (continuar)
            //{
            //    Console.WriteLine("===== EMPRESA COMPUTRONIC - CONTROL DE VENTAS =====");
            //    Console.WriteLine("1. Agregar Empleado");
            //    Console.WriteLine("2. Mostrar Ventas y Bonificaciones por Empleado");
            //    Console.WriteLine("3. Mostrar Resumen General del Día");
            //    Console.WriteLine("4. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    int opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            empleadoCrud.AgregarEmpleado(null);
            //            break;
            //        case 2:
            //            empleadoCrud.MostrarEmpleados();
            //            break;
            //        case 3:
            //            empleadoCrud.MostrarResumenGeneral();
            //            break;
            //        case 4:
            //            continuar = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            //            break;
            //    }
            //}

            //Ejercicio 7


            //Conductor.ConductorCrud conductorCrud = new Conductor.ConductorCrud();
            //bool continuarSeguros = true;

            //while (continuarSeguros)
            //{
            //    Console.WriteLine("===== OFICINA DE SEGUROS - ACCIDENTES DE TRÁNSITO =====");
            //    Console.WriteLine("1. Agregar Conductor");
            //    Console.WriteLine("2. Mostrar Estadísticas");
            //    Console.WriteLine("3. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    int opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            conductorCrud.AgregarConductor(null);
            //            break;
            //        case 2:
            //            conductorCrud.MostrarEstadisticas();
            //            break;
            //        case 3:
            //            continuarSeguros = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            //            break;
            //    }
            //}


            //Ejercicio 8

            //EmpleadoTikTok.TikTokCrud tiktokCrud = new EmpleadoTikTok.TikTokCrud();
            //bool continuarTikTok = true;

            //while (continuarTikTok)
            //{
            //    Console.WriteLine("===== TIKTOK - BONIFICACIONES =====");
            //    Console.WriteLine("1. Agregar empleado");
            //    Console.WriteLine("2. Mostrar estadisticas de bonos");
            //    Console.WriteLine("3. Salir");
            //    Console.Write("Seleccione una opción: ");
            //    int opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            tiktokCrud.AgregarEmpleado();
            //            break;
            //        case 2:
            //            tiktokCrud.MostrarEstadisticas();
            //            break;
            //        case 3:
            //            continuarTikTok = false;
            //            break;
            //        default:
            //            Console.WriteLine("Opción no válida. Intente de nuevo.\n");
            //            break;
            //    }
            //}

            //Ejercicio 9

            //DistribucionQuimicos.Distribucion distribucion = new DistribucionQuimicos.Distribucion();
            //distribucion.IniciarCarga();



        }
    }   
}
