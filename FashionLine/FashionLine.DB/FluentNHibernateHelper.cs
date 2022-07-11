using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace FashionLine.DB
{
    public class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory => _sessionFactory ??
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (_connectionString))
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
               .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                 .Execute(false, true))
            .BuildSessionFactory();

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
            

        private static string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Database=FashionLine;Integrated Security=True";

    }
}
