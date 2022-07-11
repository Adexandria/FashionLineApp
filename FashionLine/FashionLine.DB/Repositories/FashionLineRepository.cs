using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class FashionLineRepository : Repository<FashionLine.Domain.FashionLine>
    {
        public FashionLineRepository(ISession session) : base(session)
        {

        }
    }
}
