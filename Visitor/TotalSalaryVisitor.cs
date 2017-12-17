namespace Visitor
{
    public class TotalSalaryVisitor : IVisitor
    {
        public double TotalSalary { get; set; }

        public void Visit(Salary salary)
        {
            TotalSalary += salary.SalaryAfterTax;
        }

        public void Visit(Bonus bonus)
        {
            TotalSalary += bonus.BonusBeforeTax;
        }

        public void Visit(Marketing marketing)
        {
            TotalSalary -= marketing.MarketingCosts;
        }
    }
}