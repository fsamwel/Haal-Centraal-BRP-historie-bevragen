/*
 * BRP historie bevragen
 * API voor het zoeken en raadplegen van historische verblijfplaatsen, partners, nationaliteiten en verblijfstitels uit de BRP (inclusief de RNI).  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-historie-bevragen/tree/v1.0.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 0.0.1 (develop)
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.PartnerhistorieHal;

/**
 * PartnerhistorieHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-10-26T14:29:30.495Z[Etc/UTC]")
public class PartnerhistorieHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_PARTNERHISTORIE = "partnerhistorie";
  @SerializedName(SERIALIZED_NAME_PARTNERHISTORIE)
  private List<PartnerhistorieHal> partnerhistorie = null;


  public PartnerhistorieHalCollectieEmbedded partnerhistorie(List<PartnerhistorieHal> partnerhistorie) {
    
    this.partnerhistorie = partnerhistorie;
    return this;
  }

  public PartnerhistorieHalCollectieEmbedded addPartnerhistorieItem(PartnerhistorieHal partnerhistorieItem) {
    if (this.partnerhistorie == null) {
      this.partnerhistorie = new ArrayList<>();
    }
    this.partnerhistorie.add(partnerhistorieItem);
    return this;
  }

   /**
   * Get partnerhistorie
   * @return partnerhistorie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PartnerhistorieHal> getPartnerhistorie() {
    return partnerhistorie;
  }


  public void setPartnerhistorie(List<PartnerhistorieHal> partnerhistorie) {
    this.partnerhistorie = partnerhistorie;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PartnerhistorieHalCollectieEmbedded partnerhistorieHalCollectieEmbedded = (PartnerhistorieHalCollectieEmbedded) o;
    return Objects.equals(this.partnerhistorie, partnerhistorieHalCollectieEmbedded.partnerhistorie);
  }

  @Override
  public int hashCode() {
    return Objects.hash(partnerhistorie);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PartnerhistorieHalCollectieEmbedded {\n");
    sb.append("    partnerhistorie: ").append(toIndentedString(partnerhistorie)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

