using System;
using System.IO;
using NHibernate;
using NHibernate.Cfg;

namespace Core
{
    public static class SessionFactory
    {
        //private static readonly string HbmFolderPath = @"..\..\..\..\Core\Hbm"; //- if don`t copy .hbm file to base directory

        private static readonly string HbmFolderPath = @"Hbm";  //- if copy .hbm file to base directory

        public static ISession OpenSession()
        {
            ;
            var config = new Configuration()
                .AddFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, HbmFolderPath, "PersonAdress.hbm.xml"))
                //.AddFile(Path.Combine(HbmFolderPath, "SalesTerritory.hbm.xml"))
                .AddFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, HbmFolderPath, "StateProvince.hbm.xml"))
                .AddFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, HbmFolderPath, "CountryRegion.hbm.xml"));
            var factory = config.Configure(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, HbmFolderPath, "Nhibernate.cfg.xml")).BuildSessionFactory();

            return factory.OpenSession();
        }
    }
}
