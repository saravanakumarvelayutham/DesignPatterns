using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Factories
    {
    }

    public class Person
    {
        internal Person(int id, string name)
        {
            this.Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Id {0} , Name :{1}", Id, Name);
        }

        public int Id { get; set; }
        public string Name { get; set; }



    }

    public class PersonFactory
    {
        private static int Id = 0;
        public Person CreatePerson(string name)
        {
            return new Person(Id++, name);
        }
    }
}
