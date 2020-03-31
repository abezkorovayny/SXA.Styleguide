using Sitecore.XA.Foundation.Mvc.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.SimpleComponent.Models
{
    public class SimpleComponentModel : RenderingModelBase
    {
        public string Title { get; internal set; }
    }
}
