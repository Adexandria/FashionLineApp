using NHibernate;

namespace FashionLine.DB.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private ISession session;
        public Repository(ISession session)
        {
            this.session = session;
        }

        public void Add(T entity)
        {
            using var transaction = Transaction();
            session.Save(entity);
            transaction.Commit();
        }

        public T GetById(int id)
        {
            var entity = session.Get<T>(id);
            return entity;
        }

        public void Remove(T entity)
        {
            using var transaction = Transaction();
            session.Delete(entity);
            transaction.Commit();
        }

        public void Update(T entity)
        {
            using var transaction = Transaction();
            session.Update(entity);
            transaction.Commit();
        }

       private ITransaction Transaction()
       {
            return session.BeginTransaction();
       }

    }
}
