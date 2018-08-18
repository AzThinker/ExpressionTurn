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
            // 1
            AtkExpConditions<A> expa = new AtkExpConditions<A>();
            expa.AddAndWhere(s => s.Id == 123 && s.name.Contains("a"), AtkAlias.a2);
            expa.UpdateFields(s => new { s.Id, s.sex }, AtkAlias.a2);

            Console.WriteLine($"Where clasuse : {expa.Where()}");

            Console.WriteLine($"UpdateFields clasuse: { expa.UpdateFields()}");


            // 2
            // 当需要多子句拼接时，自动合并成合适的子句，如 Where ，不会出现多个“where”关键词。
            // When multiple clauses are required to be spliced, they are automatically merged into appropriate clauses, 
            // such as Where, without multiple "Where" keywords.
            AtkExpConditions<A> expa2 = new AtkExpConditions<A>();

            if (1==1)
            {
                expa2.AddAndWhere(s => s.Id == 123);
            }

            if (2==2)
            {
                expa2.AddAndWhere(s => s.name.Contains("a"));
            }

            Console.WriteLine($"Where clasuse : {expa2.Where()}");

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
