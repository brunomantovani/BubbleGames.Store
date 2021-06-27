using System;

namespace StockContext.DomainModels.Categories
{
    public struct CategoryId
    {
        public CategoryId(
            Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }
    }
}
