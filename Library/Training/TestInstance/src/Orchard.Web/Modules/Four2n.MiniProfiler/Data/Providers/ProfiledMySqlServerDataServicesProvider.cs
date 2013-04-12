// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProfiledMySqlServerDataServicesProvider.cs" company="Daniel Dabrowski - rod.42n.pl">
//   Copyright (c) 2008 Daniel Dabrowski - 42n. All rights reserved.
// </copyright>
// <summary>
//   Defines the ProfiledMySqlServerDataServicesProvider type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Four2n.Orchard.MiniProfiler.Data.Providers
{
    using System.Diagnostics;
    using FluentNHibernate.Cfg.Db;
    using global::Orchard.Environment.Extensions;

    [OrchardSuppressDependency("Orchard.Data.Providers.MySqklDataServicesProvider")]
    public class ProfiledMySqlServerDataServicesProvider : global::Orchard.Data.Providers.MySqklDataServicesProvider
    {
        public ProfiledMySqlServerDataServicesProvider(string dataFolder, string connectionString)
            : base(dataFolder, connectionString)
        {
        }

        public static string ProviderName
        {
            get { return global::Orchard.Data.Providers.MySqklDataServicesProvider.ProviderName; }
        }

        public override IPersistenceConfigurer GetPersistenceConfigurer(bool createDatabase)
        {
            var persistence = (MySQLConfiguration)base.GetPersistenceConfigurer(createDatabase);
            Debug.WriteLine("[Four2n.MiniProfiler] - ProfiledMySqlDataServicesProvider - GetPersistenceConfigurer ");
            return persistence.Driver(typeof(ProfiledMySqlClientDriver).AssemblyQualifiedName);
        }
    }
}