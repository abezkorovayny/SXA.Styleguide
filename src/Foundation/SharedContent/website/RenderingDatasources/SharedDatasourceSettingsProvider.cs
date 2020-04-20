using Microsoft.Extensions.DependencyInjection;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.DependencyInjection;
using Sitecore.XA.Foundation.Multisite;
//using Sitecore.Data.Fields.MultilistField;
using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.XA.Foundation.SharedContent.RenderingDatasources
{
    public class SharedDatasourceSettingsProvider : Sitecore.XA.Foundation.LocalDatasources.RenderingDatasources.DatasourceSettingsProvider
    {
        public override IEnumerable<Item> GetDatasourceRoots(Item contextItem, ID renderingId)
        {
            Item settingsItem = GetSettingsItem(contextItem, renderingId);
            
            if (settingsItem != null)
            {
                IEnumerable<Item> originalDatasources = (from id in ((MultilistField)settingsItem.Fields[Sitecore.XA.Foundation.LocalDatasources.Templates.DatasourceConfiguration.Fields.DatasourceLocation]).TargetIDs select contextItem.Database.GetItem(id));

                IEnumerable<Item> sharedDatasources = (from id in ((MultilistField)settingsItem.Fields[Templates.SharedDatasourceConfiguration.Fields.DatasourceLocation]).TargetIDs select contextItem.Database.GetItem(id));
                
                if (sharedDatasources.Any())
                {
                    if (originalDatasources.Any())
                    {
                        originalDatasources.Concat(sharedDatasources);
                    }
                    return sharedDatasources;
                }
                
                return originalDatasources;
            }
            return new List<Item>();
        }

        protected override bool IsRenderingDatasourceSettingItem(Item item, ID renderingId)
        {
            // Check if datasource is a shared datasource
            if (((MultilistField)item.Fields[Templates.SharedDatasourceConfiguration.Fields.CompatibleRenderings]).TargetIDs.Contains<ID>(renderingId))
            {
                return true;
            }
            
            return base.IsRenderingDatasourceSettingItem(item, renderingId);
        }
    }
}
