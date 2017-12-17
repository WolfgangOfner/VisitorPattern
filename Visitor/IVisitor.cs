namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Salary salary);

        void Visit(Bonus bonus);

        void Visit(Marketing marketing);
    }
}