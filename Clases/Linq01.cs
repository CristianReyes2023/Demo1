using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Demo1.Clases;
public class Linq01
{
    List<string> libros = new List<string>()
    {
        "Vb.Net Tutorial",
        "C# Tutorial",
        "TypeScript e-book",
    };

    public IEnumerable<string> ListaLibrosByNombre(string criterio)
    {

        return libros.Where(x => x.Contains(criterio));
    }

    public void PrintData()
    {
        Linq01 demoLinq01 = new Linq01();
        Console.WriteLine("Ingrese el criterio de busquedad");
        string criterio = Console.ReadLine();
        IEnumerable<string> data = demoLinq01.ListaLibrosByNombre(criterio);
        Console.Clear();
        foreach (string item in data)
        {
            Console.WriteLine($"Se encontro: {item}");
        }
        Console.ReadKey();
    }
    public void Query()
    {
        Console.WriteLine("Ingrese Criterio de busqueda");
        var criterio = Console.ReadLine();
        var query = (from x in libros 
                    where x.Contains(criterio) 
                    select x).ToList<string>();
        query.ForEach(x=> Console.WriteLine($"Se encontro el libro {x}"));

        //Segundo formato 
        // Console.WriteLine("Ingrese Criterio de busqueda");
        // var criterio = Console.ReadLine();
        // var query = from x in libros 
        //             where x.Contains(criterio) 
        //             select x;
        // List<string> result = query.ToList();
        // result.ForEach(x=> Console.WriteLine($"Se encontro el libro {x}"));


        //Diferentes formas de recorrer y imprimir la respuesta 
        // foreach (string item in query)
        // {
        //     Console.WriteLine($"Se encontro: {item}");
        // }
        // Console.ReadKey();
    }
}
