namespace DesignPatterns
{
    public class Proxy
    {
        
    }

    public class PrPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson
    {
        public int Age
        {
            get
            {
             return Person.Age;
            }
            set { Person.Age = value; }
        }

        private PrPerson Person { get; set; }
        public ResponsiblePerson(PrPerson person)
        {
            this.Person = person;
        }

        public string Drink()
        {
            return Age < 18 ? "too young" : Person.Drink();
        }

        public string Drive()
        {
            return Age < 16 ? "too young" : Person.Drive();
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}