using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Demo1.Clases
{
    public class Linq02
    {
        List<Student> _student = new List<Student>()
        {
            new Student(){Id = 123,Name="Iroan Man",Age=18,StandardId = 1},
            new Student(){Id = 124,Name="Hulk",Age=43,StandardId = 1},
            new Student(){Id = 125,Name="Spider-man",Age=16,StandardId = 2},
            new Student(){Id = 125,Name="CaptainAmerica",Age=25,StandardId = 2},
            new Student(){Id = 125,Name="Groot",Age=13,StandardId = 3}
        };
        List<Standard> _standardList = new List<Standard>(){
            new Standard(){Id = 1,StandardName="Standard 1"},
            new Standard(){Id = 2,StandardName="Standard 2"},
            new Standard(){Id = 3,StandardName="Standard 3"}
        };
        public void PrintData()
        {
            var teenPerson = _student.Where(s => s.Age > 12 && s.Age < 25).ToList<Student>();
            teenPerson.ForEach(tp => Console.WriteLine($"{tp.Name}"));
        }
        public void PrintDataIdName()
        {
            var expre = from s in _student
                        select new
                        {
                            s.Id,
                            s.Name
                        };

            foreach (var item in expre)
            {
                Console.WriteLine($"{item.Id}-{item.Name}");
            }
        }
        public void PrintDataV3()
        {
            var result = _student.Where((s, i) =>
            {
                if (i % 2 == 0)
                    return true;
                return false;
            }).ToList();
            result.ForEach(rs => Console.WriteLine($"{rs.Name}"));
        }
        public List<Student> Ordenamiento()
        {
            List<Student> result;
            Console.WriteLine($"Ingresa una opcion A asc o D des");
            string option = Console.ReadLine().ToUpper();
            char typeOder = Char.Parse(option);
            switch (typeOder)
            {
                case 'A':
                    result = _student.OrderBy(s => s.Name).ToList();
                    result.ForEach(rs => Console.WriteLine($"{rs.Name}"));
                    break;
                case 'D':
                    result = _student.OrderByDescending(s => s.Name).ToList();
                    result.ForEach(rs => Console.WriteLine($"{rs.Name}"));
                    break;
                default:
                    Console.WriteLine($"No se especifico tipo de ordenamiento valido");
                    return result = new List<Student>();
            }
            return result;
        }
        public void JoinEntities()
        {
            var innerJoin = _student.Join(
               _standardList,
               student => student.StandardId,
               standard => standard.Id,
               (student, standard) => new
               {
                   Name = student.Name,
                   StandardName = standard.StandardName
               }).ToList();
            innerJoin.ForEach(x => Console.WriteLine($"{x.Name}-{x.StandardName}"));
        }
        // public void Orderby(){
        //     Console.WriteLine("Seleccione el metodo de ordenamiento: ");
        //     Console.WriteLine("1.Ascendente");
        //     Console.WriteLine("2.Desendente");
        //     string order = Console.ReadLine();
        //     int option = Int32.Parse(order);

        //     if (option == 1)
        //     {
        //         var result = _student.OrderBy(x=>x.Name); 
        //     }
        //     else 
        //     {
        //         var result = _student.OrderByDescending(x=>x.Name);
        //     }
        // }
    }
}