using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class Persona
    {
        public int _id { get; set; }
        public string _Nombre { get; set; }
        public int _Edad { get; set; }
        public string _Genero { get; set; }
        public string _Telefono { get; set; }
        

        public Persona (int id, string nombre, int edad, string genero, string telefono )
        {
            _id = id;
            _Nombre = nombre;
            _Edad = edad;
            _Genero = genero;
            _Telefono = telefono;
            
        }
        
        public class PersonaCRUD
        {
            public List<Persona> personas = new List<Persona>();
            public int siguienteId = 1;

            public void AgregarPersona(Persona persona)
            {
                Console.WriteLine("Ingrese su nombre:");
                string _Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad:");
                int _Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su género (F o M):");
                string _Genero = Console.ReadLine();

                Console.WriteLine("Ingrese su teléfono:");
                string _Telefono = Console.ReadLine();
                
                persona = new Persona(siguienteId++, _Nombre, _Edad, _Genero, _Telefono);

                personas.Add(persona);
            }

            public void EditarInformacion()
            {
                Console.WriteLine("Ingrese el ID de la persona a editar:");
                int id = int.Parse(Console.ReadLine());
                Persona persona = personas.FirstOrDefault(p => p._id == id);
                if (persona != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre:");
                    persona._Nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese la nueva edad:");
                    persona._Edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nuevo género (F o M):");
                    persona._Genero = Console.ReadLine();

                    Console.WriteLine("Ingrese el nuevo teléfono:");
                    persona._Telefono = Console.ReadLine();

                    Console.WriteLine("Información actualizada correctamente.");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada.");
                }
            }

            public void MostrarPersonas() 
            {
                Console.WriteLine("Lista de Personas:");
                foreach (var persona in personas)
                {
                    Console.WriteLine($"ID: {persona._id}, Nombre: {persona._Nombre}, Edad: {persona._Edad}, Género: {persona._Genero}, Teléfono: {persona._Telefono}");
                }
            }

            public void CalcularEdadEnDias()
            {
                Console.WriteLine("Ingrese el ID de la persona: ");
                int id = int.Parse(Console.ReadLine());

                Persona persona = personas.FirstOrDefault(p => p._id == id);
                if (persona != null)
                {
                    int edadEnDias = persona._Edad * 365;
                    Console.WriteLine($"La edad de {persona._Nombre} en días es: {edadEnDias} días.");
                }
                else
                {
                    Console.WriteLine("Persona no encontrada.");
                }
            }
        }
    }
}
