namespace Visitor
{
    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }
}