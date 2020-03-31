using Feature.SimpleComponent.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.SimpleComponent.Controllers
{
    public class SimpleComponentController : StandardController
    {
        private readonly ISimpleComponentRepository _repository;

        public SimpleComponentController(ISimpleComponentRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}
