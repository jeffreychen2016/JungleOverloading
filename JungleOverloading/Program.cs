using System.Collections.Generic;

namespace JungleOverloading
{

    class Program
    {
        static void Main(string[] args)
        {
            var Jeff = new Employee("Jeffrey", "Chen");
            var John = new Employee("John", "xxx");
            var Ed = new Employee("Ed","aaa");
            List<string> allCompanions = new List<string>();

            allCompanions.Add(John.FirstName);
            allCompanions.Add(Ed.FirstName);

            Jeff.eat();
            Jeff.eat("Tacobell");
            Jeff.eat(allCompanions);
            Jeff.eat("Tacobell",allCompanions);
        }
    }
}
