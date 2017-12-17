namespace Visitor
{
    public class Bonus : IAsset
    {
        public double Revenue { get; set; }

        public double BonusBeforeTax => Revenue * 0.05;

        public double BonusAfterTax => BonusBeforeTax + 0.8;
       
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}