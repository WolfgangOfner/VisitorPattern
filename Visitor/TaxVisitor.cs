namespace Visitor
{
    public class TaxVisitor : IVisitor
    {
        public double Taxes { get; set; }

        public void Visit(Salary salary)
        {
            Taxes += salary.SalaryBeforeTax - salary.SalaryAfterTax;
        }

        public void Visit(Bonus bonus)
        {
            Taxes += bonus.BonusBeforeTax - bonus.BonusAfterTax;
        }

        public void Visit(Marketing marketing)
        {
            // no taxes
        }
    }
}