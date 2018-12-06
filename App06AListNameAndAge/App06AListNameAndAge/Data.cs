using System.Collections.Generic;

namespace App06AListNameAndAge
{
    public class Data
    {
        public IList<Person> People
        {
            get
            {
                return new List<Person>()
                {
                    new Person(){ FullName = "Lucas Monteiro de Carvalho", Age = 24},
                    new Person(){ FullName = "Natália Vitória Soares Francelino de Souza", Age = 22},
                    new Person(){ FullName = "Adrianne Monteiro de Carvalho", Age = 29},
                };
            }
        }
    }

    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }

    }
}
