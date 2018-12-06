using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06BSelector
{
    public class Data
    {
        public IList<Person> People
        {
            get
            {
                return new List<Person>()
                {
                    new Person(){ Age = 24, FullName = "Lucas Monteiro de Carvalho"},
                    new Person(){ Age = 29, FullName = "Adrianne Monteiro de Carvalho"},
                    new Person(){ Age = 55, FullName = "Ricardo Monteiro de Carvalho"},
                    new Person(){ Age = 60, FullName = "Lucia de Fatima Aires de Carvalho"},
                    new Person(){ Age = 22, FullName = "Natália Vitória Soares Francelino de Souza"}
                };
            }
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FullName { get; set; }
    }
}
