using System.Collections.Generic;

namespace Visitor
{
    public class Person : IAsset
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Assets = new List<IAsset>();
        }

        public string Name { get; }

        public int Age { get; }

        public List<IAsset> Assets { get; set; }

        public void Accept(IVisitor visitor)
        {
            foreach (var item in Assets)
            {
                item.Accept(visitor);
            }
        }
    }
}