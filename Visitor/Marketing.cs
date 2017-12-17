namespace Visitor
{
    public class Marketing : IAsset
    {
        public double MarketingCosts { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}