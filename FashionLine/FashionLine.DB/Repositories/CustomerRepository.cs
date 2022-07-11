using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(ISession session) : base(session)
        {

        }
    }
}
