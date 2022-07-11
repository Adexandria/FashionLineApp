using FashionLine.Domain;
using NHibernate;

namespace FashionLine.DB.Repositories
{
    public class PaymentInformationRepository : Repository<PaymentInformation>
    {
        public PaymentInformationRepository(ISession session): base(session)
        {

        }
    }
}
