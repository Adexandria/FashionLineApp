namespace FashionLine.DB.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        void Remove(T entity);
    }
}
