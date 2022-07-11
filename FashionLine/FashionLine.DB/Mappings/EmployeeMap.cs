using FashionLine.Domain;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(s => s.Id).GeneratedBy.Identity();
            Map(s => s.EmployeeRole).CustomType<Role>();
            Map(s => s.FirstName);
            Map(s => s.LastName);
            Map(s => s.Address);
            References(s => s.FashionLine).Unique();
        }
    }
}
