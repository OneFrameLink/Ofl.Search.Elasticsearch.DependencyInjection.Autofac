using Autofac;
using System;

namespace Ofl.Search.Elasticsearch.DependencyInjection.Autofac
{
    [Obsolete]
    public class DefaultModule : Module
    {
        #region Overrides of Module

        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<ElasticClientFactory>().As<IElasticClientFactory>();
        }

        #endregion
    }
}
