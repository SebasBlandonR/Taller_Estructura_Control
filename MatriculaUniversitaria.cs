using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class MatriculaUniversitaria
    {
        public int _Id { get; set; }
        public string _Nombre { get; set; }
        public string _Programa { get; set; }
        public int _Creditos { get; set; }
        public string _FormaPago { get; set; }
        public double _ValorMatricula { get; set; }
        public double _DescuentoAplicado { get; set; }
        public double _ValorFinal { get; set; }

        public MatriculaUniversitaria(int id, string nombre, string programa, int creditos, string formaPago, double valorMatricula, double descuentoAplicado, double valorFinal)
        {
            _Id = id;
            _Nombre = nombre;
            _Programa = programa;
            _Creditos = creditos;
            _FormaPago = formaPago;
            _ValorMatricula = valorMatricula;
            _DescuentoAplicado = descuentoAplicado;
            _ValorFinal = valorFinal;
        }

        public class MatriculaCrud
        {
            public List<MatriculaUniversitaria> estudiantes = new List<MatriculaUniversitaria>();
            public int siguienteId = 1;
            public const double VALOR_CREDITO = 200000;

            public void AgregarEstudiante(MatriculaUniversitaria estudiante)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Seleccione el programa académico:");
                Console.WriteLine("1. Ingeniería de Sistemas (20 créditos, 18% descuento en efectivo)");
                Console.WriteLine("2. Psicología (16 créditos, 12% descuento en efectivo)");
                Console.WriteLine("3. Economía (18 créditos, 10% descuento en efectivo)");
                Console.WriteLine("4. Comunicación Social (18 créditos, 5% descuento en efectivo)");
                Console.WriteLine("5. Administración de Empresas (20 créditos, 15% descuento en efectivo)");
                Console.Write("Opción: ");
                int opcionPrograma = int.Parse(Console.ReadLine());

                string programa = "";
                int creditos = 0;
                double descuentoPorcentaje = 0;

                switch (opcionPrograma)
                {
                    case 1:
                        programa = "Ingeniería de Sistemas";
                        creditos = 20;
                        descuentoPorcentaje = 0.18;
                        break;
                    case 2:
                        programa = "Psicología";
                        creditos = 16;
                        descuentoPorcentaje = 0.12;
                        break;
                    case 3:
                        programa = "Economía";
                        creditos = 18;
                        descuentoPorcentaje = 0.10;
                        break;
                    case 4:
                        programa = "Comunicación Social";
                        creditos = 18;
                        descuentoPorcentaje = 0.05;
                        break;
                    case 5:
                        programa = "Administración de Empresas";
                        creditos = 20;
                        descuentoPorcentaje = 0.15;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. No se registró el estudiante.\n");
                        return;
                }

                Console.Write("Ingrese la forma de pago (Efectivo / Linea): ");
                string formaPago = Console.ReadLine().Trim().ToLower();

                double valorMatricula = creditos * VALOR_CREDITO;
                double descuentoAplicado = 0;

                if (formaPago == "efectivo")
                {
                    descuentoAplicado = valorMatricula * descuentoPorcentaje;
                }

                double valorFinal = valorMatricula - descuentoAplicado;

                estudiante = new MatriculaUniversitaria(siguienteId++, nombre, programa, creditos, formaPago, valorMatricula, descuentoAplicado, valorFinal);
                estudiantes.Add(estudiante);

                Console.WriteLine("Estudiante matriculado correctamente.\n");
            }

            public void MostrarEstudiantes()
            {
                if (estudiantes.Count == 0)
                {
                    Console.WriteLine("No hay estudiantes registrados.\n");
                    return;
                }

                Console.WriteLine("Lista de estudiantes matriculados:");
                foreach (var estudiante in estudiantes)
                {
                    Console.WriteLine($"ID: {estudiante._Id}, Nombre: {estudiante._Nombre}, Programa: {estudiante._Programa}, Créditos: {estudiante._Creditos}, Forma de pago: {estudiante._FormaPago}, Valor matrícula: ${estudiante._ValorMatricula:N0}, Descuento: ${estudiante._DescuentoAplicado:N0}, Valor final: ${estudiante._ValorFinal:N0}");
                }
                Console.WriteLine();
            }

            public void MostrarResumen()
            {
                if (estudiantes.Count == 0)
                {
                    Console.WriteLine("No hay datos registrados.\n");
                    return;
                }

                Console.WriteLine("===== RESUMEN DEL PERÍODO ACADÉMICO 2020-3 =====");

                var conteoPorPrograma = estudiantes
                    .GroupBy(e => e._Programa)
                    .Select(g => new { Programa = g.Key, Cantidad = g.Count() });

                Console.WriteLine("\na. Cantidad de estudiantes inscritos por programa académico:");
                foreach (var item in conteoPorPrograma)
                {
                    Console.WriteLine($"   {item.Programa}: {item.Cantidad}");
                }

                int totalCreditos = estudiantes.Sum(e => e._Creditos);
                double totalSinDescuento = estudiantes.Sum(e => e._ValorMatricula);
                double totalDescuentos = estudiantes.Sum(e => e._DescuentoAplicado);
                double totalFinal = estudiantes.Sum(e => e._ValorFinal);

                Console.WriteLine($"\nb. Total de créditos inscritos: {totalCreditos}");
                Console.WriteLine($"c. Valor total sin descuento: ${totalSinDescuento:N0}");
                Console.WriteLine($"d. Total descuentos aplicados: ${totalDescuentos:N0}");
                Console.WriteLine($"e. Valor neto recaudado: ${totalFinal:N0}\n");
            }
        }
    }
}