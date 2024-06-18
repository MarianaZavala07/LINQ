using System;
using System.Linq;
using System.Collections.Generic;

namespace EXAMPLESLINQ
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var estudiantes = new List<Estudiante>()
            {
                new Estudiante { Nombre = "Juan", Edad = 20, Curso = "Matemáticas" },
                new Estudiante { Nombre = "Ana", Edad = 22, Curso = "Historia" },
                new Estudiante { Nombre = "Luis", Edad = 21, Curso = "Inglés" }
            };

            var menoresDe18 = estudiantes.Where(e => e.Edad <= 18).ToList();

            foreach (var estudiante in menoresDe18)
            {
                Console.WriteLine($"{estudiante.Nombre} tiene {estudiante.Edad} años");
            }

            // Ejemplo 2 //Consulta First o FirstOrDefault // usando el ejemplo anterior
            var PrimerEstudiante = estudiantes.First();
            var PrimerEstudiante2 = estudiantes.FirstOrDefault();

            // Ejemplo 3 //Consulta de último usando el ejemplo anterior
            var ultimoEstudiante = estudiantes.Last();
            var ultimoEstudiante2 = estudiantes.LastOrDefault();

            // Ejemplo 4 // usando ejemplo anterior
            // Recordando que se inicia en 0 que sería la posición 1
            var segundoEstudiante = estudiantes.ElementAt(1);
            var primeroEstudiante = estudiantes.ElementAtOrDefault(0);
        }
    }
}