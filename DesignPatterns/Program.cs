using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Builder Invoke : piecewise oject construction
            //var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            //Console.WriteLine(cb);
            //Console.ReadKey();


            //Factories Invoke : whole object constructions
            //var personFactory = new PersonFactory();
            //var person1 = personFactory.CreatePerson("Sarav");
            //Console.WriteLine(person1);
            //Console.ReadKey();

            //var person2 = personFactory.CreatePerson("Shilpa");
            //Console.WriteLine(person2);
            //Console.ReadKey();

            //Chain of resp
            //var game = new Game();
            //var goblin = new Goblin(game);
            //game.Creatures.Add(goblin);
            //Console.WriteLine($"Attack:{goblin.Attack} , Defense:{goblin.Defense}");
            //var goblin2 = new GoblinKing(game);
            //game.Creatures.Add(goblin2);
            //Console.WriteLine($"Attack:{goblin2.Attack} , Defense:{goblin2.Defense}");
            //Console.Read();

            //Interpreter
            var parser = new ExpressionProcessor();
            Console.WriteLine(parser.Calculate("10-2-3"));
            Console.Read();
        }
    }
}
