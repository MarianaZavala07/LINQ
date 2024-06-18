//ejemplo 1 /sintaxis de metodos / numeros impares/

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var numerosImpares = numeros.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Números impares:");
        foreach (var numero in numerosImpares)
        {
            Console.WriteLine(numero);
        }

        //Ejemplo 2/ sitaxis de queris / usaremos el de impares de nuevo

        int[] numeros2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Sintaxis de consultas (query syntax)
        var numerosImpares2 =
            from numero in numeros
            where numero % 2 != 0
            select numero;

        Console.WriteLine("Números impares:");
        foreach (var numero2 in numerosImpares2)
        {
            Console.WriteLine(numero2);
            }

            //Ejemplo de otra forma de poner un arreglo de numeros
            //CREAR UN LISTADO DE NUMEROS CON RANGO

            int[] numeros3 = Enumerable.Range(0, 9).ToArray();
            foreach (var numero in numerosImpares)
        {
            Console.WriteLine(numero);

        }
        //Ejemplo 3 // Ejecucion definida// numeros impares
        int[] numeros4 = Enumerable.Range(0, 9).ToArray();
        var numeros4Impares = numeros.Where(a =>
        {
            Console.WriteLine($"Evaluando si {a} es impar");
            return a%2 != 0;
        });
        foreach (var numero4 in numeros4Impares)
        {
          Console.WriteLine($"si, el {numero4} es impar");
        }
        //Ejemplo 4 // where con objetos // estudiantes mayores
        
