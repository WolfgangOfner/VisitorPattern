namespace Visitor
{
    public class Salary : IAsset
    {
        public double SalaryBeforeTax { get; set; }

        public double SalaryAfterTax => SalaryBeforeTax * 0.8;

        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}