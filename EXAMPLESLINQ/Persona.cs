namespace EXAMPLESLINQ
{
public class Persona
{
    public string Nombre { get; set; }
}

public class Personas
{
    public static void Main()
    {
        List<Persona> personas = new List<Persona>
        {
            new Persona { Nombre = "Carlos" },
            new Persona { Nombre = "Mariana" },
            new Persona { Nombre = "Ricardo" }
        };

        var personasOrdenadas = personas.OrderBy(p => p.Nombre);

        foreach (var persona in personasOrdenadas)
        {
            Console.WriteLine(persona.Nombre);
        }
    }
}
}
