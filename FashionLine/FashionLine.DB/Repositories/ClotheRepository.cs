using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class ClotheRepository : Repository<Clothe>
    {
        public ClotheRepository(ISession session) : base(session)
        {

        }
    }
}
