using Feature.SimpleComponent.Controllers;
using Feature.SimpleComponent.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Feature.SimpleComponent.Pipelines
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISimpleComponentRepository, SimpleComponentRepository>();
            serviceCollection.AddTransient<SimpleComponentController>();
        }
    }
}
