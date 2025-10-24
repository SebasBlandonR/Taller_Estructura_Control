using System;
using System.Collections.Generic;

namespace Taller_Estructura_Control
{
    internal class CamionCarga
    {
        public class Camion
        {
            public int _Id { get; set; }
            public double _CapacidadMax { get; set; }
            public double _CargaActual { get; set; }

            public Camion(int id, double capacidadMax)
            {
                _Id = id;
                _CapacidadMax = capacidadMax;
                _CargaActual = 0;
            }

            public bool Cargar(double cantidad)
            {
                if (_CargaActual + cantidad <= _CapacidadMax)
                {
                    _CargaActual += cantidad;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Distribucion
        {
            public List<Camion> camiones = new List<Camion>();
            public int totalCamiones = 20;

            public void IniciarCarga()
            {
                for (int i = 1; i <= totalCamiones; i++)
                {
                    Console.WriteLine($"\n=== CAMIÓN #{i} ===");
                    Console.Write("Ingrese la capacidad del camión (18000 - 28000 litros): ");
                    double capacidad;
                    while (!double.TryParse(Console.ReadLine(), out capacidad) || capacidad < 18000 || capacidad > 28000)
                    {
                        Console.Write("Capacidad inválida. Ingrese entre 18000 y 28000: ");
                    }

                    Camion camion = new Camion(i, capacidad);
                    bool seguirCargando = true;

                    while (seguirCargando)
                    {
                        Console.Write("Ingrese el peso de la saca a cargar (3000 - 9000 litros): ");
                        double saca;
                        while (!double.TryParse(Console.ReadLine(), out saca) || saca < 3000 || saca > 9000)
                        {
                            Console.Write("Peso inválido. Ingrese entre 3000 y 9000 litros: ");
                        }

                        if (!camion.Cargar(saca))
                        {
                            Console.WriteLine("El camión alcanzó su límite. Despachando camión...\n");
                            seguirCargando = false;
                        }
                        else
                        {
                            Console.WriteLine($"Carga actual del camión: {camion._CargaActual} / {camion._CapacidadMax} litros");
                            Console.Write("¿Desea cargar otra saca? (s/n): ");
                            string respuesta = Console.ReadLine().ToLower();
                            if (respuesta != "s") seguirCargando = false;
                        }
                    }

                    camiones.Add(camion);
                }

                Console.WriteLine("\n===== FIN DE LA CARGA DIARIA =====\n");
            }
        }
    }
}