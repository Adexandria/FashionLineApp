using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class OrderMap:ClassMap<Order>
    {
        public OrderMap()
        {
            Id(order=>order.Id).GeneratedBy.Identity();
            Map(order=>order.DeliveryAddress);
            Map(order => order.InitiationDate);
            Map(order=>order.DeliveryDate);
            References(order => order.Owner).Unique();
            References(order => order.PaymentInfo).Unique();
        }
    }
}
