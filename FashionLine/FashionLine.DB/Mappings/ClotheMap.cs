using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class ClotheMap:ClassMap<Clothe>
    {
        public ClotheMap()
        {
            Id(s => s.Id).GeneratedBy.Identity();
            Map(s => s.ClotheType).CustomType<ClotheType>();
            References(s=>s.Measurement).Unique();
            References(s => s.Order).Unique();
            References(s => s.FashionLine).Unique();
        }
    }
}
