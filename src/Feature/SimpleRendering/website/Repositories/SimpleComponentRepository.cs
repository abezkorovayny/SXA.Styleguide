using Feature.SimpleComponent.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.SimpleComponent.Repositories
{
    public class SimpleComponentRepository : ModelRepository, ISimpleComponentRepository
    {
        public override IRenderingModelBase GetModel()
        {
            SimpleComponentModel model = new SimpleComponentModel();

            FillBaseProperties(model);
            model.Title = GetTitle();

            return model;
        }

        private string GetTitle()
        {
            return PageContext.Current[Sitecore.TemplateFieldIDs.Title];
        }
    }

}
