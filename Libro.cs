using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Estructura_Control
{
    internal class Libro
    {
        public int _Id { get; set; }
        public string _Titulo { get; set; }
        public string _Autor { get; set; }
        public string _Editorial { get; set; }
        public int _AnioPublicacion { get; set; }

        public Libro(int id, string titulo, string autor, string editorial, int anioPublicacion)
        {
            _Id = id;
            _Titulo = titulo;
            _Autor = autor;
            _Editorial = editorial;
            _AnioPublicacion = anioPublicacion;
        }

        public class BibliotecaCrud
        {
            public List<Libro> libros = new List<Libro>();
            public int siguienteId = 1;

            public void AgregarLibro(Libro libro)
            {
                Console.Write("Ingrese el título del libro: ");
                string titulo = Console.ReadLine();
                Console.Write("Ingrese el autor del libro: ");
                string autor = Console.ReadLine();
                Console.Write("Ingrese la editorial: ");
                string editorial = Console.ReadLine();
                Console.Write("Ingrese el año de publicación: ");
                int anioPublicacion = int.Parse(Console.ReadLine());

                libro = new Libro(siguienteId++, titulo, autor, editorial, anioPublicacion);
                libros.Add(libro);

                Console.WriteLine("Libro agregado correctamente.\n");
            }

            public void ListarLibros()
            {
                if (libros.Count == 0)
                {
                    Console.WriteLine("No hay libros registrados.\n");
                    return;
                }

                Console.WriteLine("Lista de libros:");
                foreach (var libro in libros)
                {
                    Console.WriteLine($"ID: {libro._Id}, Título: {libro._Titulo}, Autor: {libro._Autor}, Editorial: {libro._Editorial}, Año: {libro._AnioPublicacion}");
                }
                Console.WriteLine();
            }

            public void BuscarLibroPorTitulo()
            {
                Console.Write("Ingrese el título del libro a buscar: ");
                string tituloBusqueda = Console.ReadLine();

                var resultados = libros.Where(l => l._Titulo.ToLower().Contains(tituloBusqueda.ToLower())).ToList();

                if (resultados.Count > 0)
                {
                    Console.WriteLine("Libros encontrados:");
                    foreach (var libro in resultados)
                    {
                        Console.WriteLine($"ID: {libro._Id}, Título: {libro._Titulo}, Autor: {libro._Autor}, Editorial: {libro._Editorial}, Año: {libro._AnioPublicacion}");
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron libros con ese título.\n");
                }
            }
        }
    }
}