using FashionLine.Domain;
using NHibernate;


namespace FashionLine.DB.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(ISession session) : base(session)
        {

        }
    }
}
