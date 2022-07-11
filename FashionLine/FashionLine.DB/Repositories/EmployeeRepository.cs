using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(ISession session) : base(session)
        {

        }
 
    }
}
