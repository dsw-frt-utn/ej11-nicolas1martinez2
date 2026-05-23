using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;







internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        
        Alumno a1 = new Alumno(1, "Ana García", 8.5);
        Alumno a2 = new Alumno(2, "Carlos López", 7.0);
        Alumno a3 = new Alumno(3, "María Pérez", 9.2);
        lista.Agregar(a1);
        lista.Agregar(a2);
        lista.Agregar(a3);

        
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var a in lista.GetLista())
            Console.WriteLine(a);

        
        var encontrado = lista.BuscarPorNombre("Carlos López");
        Console.WriteLine($"\nBúsqueda 'Carlos López': {encontrado}");

        
        var noExiste = lista.BuscarPorNombre("Pedro Ramírez");
        Console.WriteLine($"Búsqueda 'Pedro Ramírez': {(noExiste == null ? "No existe" : noExiste.ToString())}");

        
        lista.Eliminar(a2);
        Console.WriteLine("\n=== Lista tras eliminar Carlos López ===");
        foreach (var a in lista.GetLista())
            Console.WriteLine(a);

      
        lista.EliminarEnPosicion(0);
        Console.WriteLine("\n=== Lista tras eliminar posición 0 ===");
        foreach (var a in lista.GetLista())
            Console.WriteLine(a);
    }

    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        
        Alumno a1 = new Alumno(101, "Ana García", 8.5);
        Alumno a2 = new Alumno(102, "Carlos López", 7.0);
        Alumno a3 = new Alumno(103, "María Pérez", 9.2);
        diccionario.Agregar(a1);
        diccionario.Agregar(a2);
        diccionario.Agregar(a3);

        
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in diccionario.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

        
        var encontrado = diccionario.Buscar(102);
        Console.WriteLine($"\nBúsqueda legajo 102: {encontrado}");

        
        var noExiste = diccionario.Buscar(999);
        Console.WriteLine($"Búsqueda legajo 999: {(noExiste == null ? "No existe" : noExiste.ToString())}");

        
        diccionario.Eliminar(101);
        Console.WriteLine("\n=== Diccionario tras eliminar legajo 101 ===");
        foreach (var par in diccionario.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }

    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("=== LINQ - Primer libro ===");
        Console.WriteLine(linq.GetPrimero());

        Console.WriteLine("\n=== LINQ - Último libro ===");
        Console.WriteLine(linq.GetUltimo());

        Console.WriteLine($"\n=== LINQ - Total precios ===");
        Console.WriteLine($"{linq.GetTotalPrecios():C}");

        Console.WriteLine($"\n=== LINQ - Promedio precios ===");
        Console.WriteLine($"{linq.GetPromedioPrecios():C}");

        Console.WriteLine("\n=== LINQ - Libros con Id > 15 ===");
        foreach (var l in linq.GetListById())
            Console.WriteLine(l);

        Console.WriteLine("\n=== LINQ - Libros (título y precio) ===");
        foreach (var s in linq.GetLibros())
            Console.WriteLine(s);

        Console.WriteLine("\n=== LINQ - Libro más caro ===");
        Console.WriteLine(linq.GetMayorPrecio());

        Console.WriteLine("\n=== LINQ - Libro más barato ===");
        Console.WriteLine(linq.GetMenorPrecio());

        Console.WriteLine("\n=== LINQ - Libros sobre el promedio ===");
        foreach (var l in linq.GetMayorPromedio())
            Console.WriteLine(l);

        Console.WriteLine("\n=== LINQ - Libros ordenados descendente por título ===");
        foreach (var l in linq.GetOrdenadosDescendente())
            Console.WriteLine(l);
    }
}

