using System.IO;
using NHibernate;
using NHibernate.Cfg;

namespace Core
{
    public static class SessionFactory
    {
        private static readonly string CfgFolderPath = @"C:\Users\a.himbitski\source\repos\AdventureWorks\Core";

        public static ISession OpenSession()
        {
            ;
            var config = new Configuration()
                .AddFile(Path.Combine(CfgFolderPath, "PersonAdress.hbm.xml"))
                //.AddFile(Path.Combine(CfgFolderPath, "SalesTerritory.hbm.xml"))
                .AddFile(Path.Combine(CfgFolderPath, "StateProvince.hbm.xml"));
                //.AddFile(Path.Combine(CfgFolderPath, "CountryRegion.hbm.xml"));
            var factory = config.Configure(Path.Combine(CfgFolderPath, "Nhibernate.cfg.xml")).BuildSessionFactory();

            return factory.OpenSession();
        }
    }
}
