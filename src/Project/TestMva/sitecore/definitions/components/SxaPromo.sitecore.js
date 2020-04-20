// eslint-disable-next-line no-unused-vars
import { CommonFieldTypes, SitecoreIcon, Manifest } from '@sitecore-jss/sitecore-jss-manifest';

/**
 * Adds the SxaPromo component to the disconnected manifest.
 * This function is invoked by convention (*.sitecore.js) when 'jss manifest' is run.
 * @param {Manifest} manifest Manifest instance to add components to
 */
export default function(manifest) {
  manifest.addComponent({
    name: 'SxaPromo',
    icon: SitecoreIcon.DocumentTag,
    fields: [
      { name: 'PromoText', type: CommonFieldTypes.RichText },
      { name: 'PromoText2', type: CommonFieldTypes.RichText },
      { name: 'PromoText3', type: CommonFieldTypes.RichText },
      { name: 'PromoLink', type: CommonFieldTypes.GeneralLink },
      { name: 'PromoIcon', type: CommonFieldTypes.Image },
      { name: 'PromoIcon2', type: CommonFieldTypes.Image },
    ],
    /*
    If the component implementation uses <Placeholder> or withPlaceholder to expose a placeholder,
    register it here, or components added to that placeholder will not be returned by Sitecore:
    placeholders: ['exposed-placeholder-name']
    */
  });
}
