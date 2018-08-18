using Atk.AtkExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AtkExpConditions<A> expa = new AtkExpConditions<A>();
            expa.AddAndWhere(s => s.Id == 123 && s.name.Contains("a"), AtkAlias.a2);
            expa.UpdateFields(s => new { s.Id, s.sex }, AtkAlias.a2);

            Console.WriteLine($"Where {expa.Where()}");

            Console.WriteLine($"UpdateFields { expa.UpdateFields()}");


            Console.ReadLine();
        }
    }


    class A
    {
        public Int16 Id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
    }
}
