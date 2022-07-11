using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class PaymentInformationMap:ClassMap<PaymentInformation>
    {
        public PaymentInformationMap()
        {
            Id(s => s.Id).GeneratedBy.Identity(); 
            Map(s => s.Price);
            Map(s => s.AmountPaid);
            
        }
    }
}
