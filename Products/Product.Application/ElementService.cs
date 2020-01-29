using Product.Domain;
using System.Collections.Generic;

namespace Product.Application
{
    class ElementService : IElementService
    {
        public IList<Element> GetElements()
        {
            return new List<Element>() {new  Element() {  Name = "Pepsi", Amount = 100},
                                        new  Element() {  Name = "CocaCola", Amount = 50} };
        }
    }
}
