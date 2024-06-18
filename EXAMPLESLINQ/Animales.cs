namespace EXAMPLESLINQ
{
    public class Animal
    {
        public string Nombre { get; set; }
    }

    public class Perro : Animal
    {
        public string Raza { get; set; }
    }

    public class Gato : Animal
    {
        public bool Casa { get; set; }
    }

    public class Animaless
    {
        public static void Main(string[] args)
        {
            List<Animal> Animales = new List<Animal>
            {
                new Perro { Nombre = "Coquito", Raza = "Dalmata" },
                new Perro { Nombre = "Amaranta", Raza = "Golden Retriever" },
                new Animal { Nombre = "no tiene" },
                new Gato { Nombre = "Filomeno", Casa = true }
            };
             //Ejemplo 1 // filtrando Tipos
            // aqui filtramos solo los perros
            var perros = Animales.OfType<Perro>();

            // Aqui los gaots
            var gatos = Animales.OfType<Gato>();

            // y esta seria una condicion donde 
            var otrosAnimales = Animales.OfType<Animal>().Except(perros).Except(gatos);

            Console.WriteLine("Perros:");
            foreach (var perro in perros)
            {
                Console.WriteLine($"Nombre: {perro.Nombre}, Raza: {perro.Raza}");
            }

            Console.WriteLine("\nGatos:");
            foreach (var gato in gatos)
            {
                Console.WriteLine($"Nombre: {gato.Nombre}, Casa: {gato.Casa}");
            }

            Console.WriteLine("\nOtros Animales:");
            foreach (var animal in otrosAnimales)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}");
            }
        }
    }
}