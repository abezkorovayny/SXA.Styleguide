using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;

namespace Sitecore.XA.Foundation.SharedContent
{
    public static class Templates
    {
        public struct SharedDatasourceConfiguration
        {
            public static readonly ID ID;
            static SharedDatasourceConfiguration()
            {
                ID = ID.Parse("{B291F15D-674F-4036-9B6A-976DEAAB587D}");
            }

            public struct Fields
            {
                public static ID DatasourceLocation => new ID("{3B02FC13-2695-4EA5-A0C6-621CDA79DBEB}");
                public static ID AllowPageRelativeLocation => new ID("{0866C068-0F4E-40F7-A469-EB1A6754330E}");
                public static ID DatasourceTemplate => new ID("{E38F6435-6644-42E0-8E93-2C18FF0547D5}");
                public static ID CompatibleRenderings => new ID("{CF488616-964C-4898-BB4E-C468D9BCBA1E}");
                
            }
        }
    }
}
