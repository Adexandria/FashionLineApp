using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(cust => cust.Id).GeneratedBy.Identity();
            Map(cust => cust.Address);
            References(s => s.FashionLine).Unique();
        }
    }
}
