import React from 'react';
import { RichText, Image, Link } from '@sitecore-jss/sitecore-jss-react';

const SxaPromo = (props) => (
  <div>
    <h3>SxaPromo Component</h3>

    <table>
      <tr>
        <td>PromoText:</td>
        <td><RichText field={props.fields.PromoText} /></td>
      </tr>
      <tr>
        <td>PromoText2:</td>
        <td><RichText field={props.fields.PromoText2} /></td>
      </tr>
      <tr>
        <td>PromoText3:</td>
        <td><RichText field={props.fields.PromoText3} /></td>
      </tr>
      <tr>
        <td>PromoLink:</td>
        <td><Link field={props.fields.PromoLink} /></td>
      </tr>
      <tr>
        <td>PromoIcon:</td>
        <td><Image field={props.fields.PromoIcon} /></td>
      </tr>
      <tr>
        <td>PromoIcon2:</td>
        <td><Image field={props.fields.PromoIcon2} /></td>
      </tr>
    </table>

  </div>
);

export default SxaPromo;
