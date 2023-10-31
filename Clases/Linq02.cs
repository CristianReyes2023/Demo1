using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Clases
{
    public class Linq02
    {
        List<Student> _student = new List<Student>()
        {
            new Student(){Id = 123,Name="Iroan Man",Age=18},
            new Student(){Id = 124,Name="Hulk",Age=43},
            new Student(){Id = 125,Name="Spider-man",Age=16},
            new Student(){Id = 125,Name="CaptainAmerica",Age=25},
            new Student(){Id = 125,Name="Groot",Age=13}


        };
        public void PrintData()
        {
            var teenPerson = _student.Where(s => s.Age > 12 && s.Age < 25).ToList<Student>();
            teenPerson.ForEach(tp => Console.WriteLine($"{tp.Name}"));
        }
        public void PrintDataIdName()
        {
            var expre = from s in _student
                        select new {
                            s.Id,s.Name
                        };

            foreach(var item in expre){
                Console.WriteLine($"{item.Id}-{item.Name}");
            }
        }
    }
}