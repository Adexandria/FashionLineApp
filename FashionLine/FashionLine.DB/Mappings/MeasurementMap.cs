using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class MeasurementMap:ClassMap<Measurement>
    {
        public MeasurementMap()
        {
            Id(s => s.Id).GeneratedBy.Identity();
            Map(s => s.Waist);
            Map(s => s.Hip);
            Map(s => s.Neck);
            Map(s => s.Shoulder);
            
        }
    }
}
