using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class MeasurementRepository : Repository<Measurement>
    {
        public MeasurementRepository(ISession session) : base(session)
        {

        }
    }
}
