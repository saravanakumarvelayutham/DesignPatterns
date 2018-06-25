namespace DesignPatterns
{
    public class Decorator
    {
        
    }

    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        private readonly Bird _bird = new Bird();
        private readonly Lizard _lizard = new Lizard();

        public Dragon()
        {
        }

        public int Age
        {
            get
            {
                return this._bird.Age;
            }
            set { this._bird.Age = value;
                this._lizard.Age = value;
            }
        }

        public string Fly()
        {
            return this._bird.Fly();
        }

        public string Crawl()
        {
            return this._lizard.Crawl();
        }
    }
}