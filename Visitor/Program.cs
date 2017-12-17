using System;

namespace Visitor
{
   public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Wolfgang", 28);
            person.Assets.Add(new Salary { SalaryBeforeTax = 10000 });
            person.Assets.Add(new Salary { SalaryBeforeTax = 300 });
            person.Assets.Add(new Bonus { Revenue = 30000 });
            person.Assets.Add(new Marketing { MarketingCosts = 5000 });

            var totalSalaryVisitor = new TotalSalaryVisitor();
            var taxVisitor = new TaxVisitor();

            person.Accept(totalSalaryVisitor);
            person.Accept(taxVisitor);

            Console.WriteLine($"The total salary of {person.Name} is {totalSalaryVisitor.TotalSalary}");
            Console.WriteLine($"{person.Name} pays {taxVisitor.Taxes} taxes");

            Console.ReadLine();
        }
    }
}