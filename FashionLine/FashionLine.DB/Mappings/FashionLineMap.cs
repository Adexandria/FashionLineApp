using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class FashionLineMap:ClassMap<Domain.FashionLine>
    {
        public FashionLineMap()
        {
            Id(s => s.Id).GeneratedBy.Identity();
            Map(s => s.Name);
            Map(s => s.Location);
        }
    }
}
