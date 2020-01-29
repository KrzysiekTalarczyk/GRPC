using Product.Domain;
using System.Collections.Generic;

namespace Product.Application
{
    public interface IElementService
    {
            IList<Element> GetElements();
    }
}
