using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class Conductor
    {
        public int _Id { get; set; }
        public int _AnioNacimiento { get; set; }
        public int _Sexo { get; set; } // 1: Femenino, 2: Masculino
        public int _RegistroCarro { get; set; } // 1: Bogotá, 2: Otras ciudades

        public Conductor(int id, int anioNacimiento, int sexo, int registro)
        {
            _Id = id;
            _AnioNacimiento = anioNacimiento;
            _Sexo = sexo;
            _RegistroCarro = registro;
        }

        public class ConductorCrud
        {
            public List<Conductor> conductores = new List<Conductor>();
            public int siguienteId = 1;

            public void AgregarConductor(Conductor conductor)
            {
                Console.Write("Ingrese el año de nacimiento del conductor: ");
                int anioNacimiento = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el sexo (1: Femenino, 2: Masculino): ");
                int sexo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el registro del carro (1: Bogotá, 2: Otras ciudades): ");
                int registro = int.Parse(Console.ReadLine());

                conductor = new Conductor(siguienteId++, anioNacimiento, sexo, registro);
                conductores.Add(conductor);

                Console.WriteLine("Conductor registrado correctamente.\n");
            }

            public void MostrarEstadisticas()
            {
                if (conductores.Count == 0)
                {
                    Console.WriteLine("No hay datos registrados.\n");
                    return;
                }

                int anioActual = DateTime.Now.Year;
                int totalConductores = conductores.Count;

                int menores30 = conductores.Count(c => (anioActual - c._AnioNacimiento) < 30);
                int femeninos = conductores.Count(c => c._Sexo == 1);
                int masculinos = conductores.Count(c => c._Sexo == 2);
                int masculinosJovenes = conductores.Count(c => c._Sexo == 2 && (anioActual - c._AnioNacimiento) >= 12 && (anioActual - c._AnioNacimiento) <= 30);
                int fueraBogota = conductores.Count(c => c._RegistroCarro == 2);

                Console.WriteLine("===== ESTADÍSTICAS DE CONDUCTORES =====");
                Console.WriteLine($"Porcentaje de conductores menores de 30 años: {(menores30 * 100.0 / totalConductores):F2}%");
                Console.WriteLine($"Porcentaje de conductores femeninos: {(femeninos * 100.0 / totalConductores):F2}%");
                Console.WriteLine($"Porcentaje de conductores masculinos: {(masculinos * 100.0 / totalConductores):F2}%");
                Console.WriteLine($"Porcentaje de conductores masculinos entre 12 y 30 años: {(masculinosJovenes * 100.0 / totalConductores):F2}%");
                Console.WriteLine($"Porcentaje de conductores con carros registrados fuera de Bogotá: {(fueraBogota * 100.0 / totalConductores):F2}%");
                Console.WriteLine();
            }
        }
    }
}