/* 
 * BRP historie bevragen
 *
 * API voor het zoeken en raadplegen van historische verblijfplaatsen, partners, nationaliteiten en verblijfstitels uit de BRP (inclusief de RNI).  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-historie-bevragen/tree/v1.0.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 0.0.1 (develop)
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Gegevens over de (historische) nationaliteiten van de persoon. * **datumTot**: Datum tot wanneer een nationaliteit geldig was. * **datumIngangGeldigheid**: Datum waarop de gegevens over de Nationaliteit geldig zijn geworden. * **nationaliteit** : Nationaliteittabel, die aangeeft over welke nationaliteit de ingeschrevene beschikt. * **redenOpname** : Tabel Reden opnemen/beëindigen nationaliteit, die aangeeft met welke reden de persoon de Nederlandse nationaliteit heeft verkregen of waarom een niet-Nederlandse nationaliteit is opgenomen. * **redenBeeindigen** : Tabel Reden opnemen/beëindigen nationaliteit, die aangeeft met welke reden een nationaliteit is beëindigd. 
    /// </summary>
    [DataContract]
    public partial class NationaliteithistorieAllOf :  IEquatable<NationaliteithistorieAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NationaliteithistorieAllOf" /> class.
        /// </summary>
        /// <param name="geheimhoudingPersoonsgegevens">Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. .</param>
        /// <param name="datumTot">datumTot.</param>
        /// <param name="redenBeeindigen">redenBeeindigen.</param>
        /// <param name="indicatieNationaliteitBeeindigd">Geeft aan dat de nationaliteit beëindigd is. .</param>
        public NationaliteithistorieAllOf(bool geheimhoudingPersoonsgegevens = default(bool), DatumOnvolledig datumTot = default(DatumOnvolledig), Waardetabel redenBeeindigen = default(Waardetabel), bool indicatieNationaliteitBeeindigd = default(bool))
        {
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
            this.DatumTot = datumTot;
            this.RedenBeeindigen = redenBeeindigen;
            this.IndicatieNationaliteitBeeindigd = indicatieNationaliteitBeeindigd;
        }
        
        /// <summary>
        /// Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. 
        /// </summary>
        /// <value>Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. </value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Gets or Sets DatumTot
        /// </summary>
        [DataMember(Name="datumTot", EmitDefaultValue=false)]
        public DatumOnvolledig DatumTot { get; set; }

        /// <summary>
        /// Gets or Sets RedenBeeindigen
        /// </summary>
        [DataMember(Name="redenBeeindigen", EmitDefaultValue=false)]
        public Waardetabel RedenBeeindigen { get; set; }

        /// <summary>
        /// Geeft aan dat de nationaliteit beëindigd is. 
        /// </summary>
        /// <value>Geeft aan dat de nationaliteit beëindigd is. </value>
        [DataMember(Name="indicatieNationaliteitBeeindigd", EmitDefaultValue=false)]
        public bool IndicatieNationaliteitBeeindigd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NationaliteithistorieAllOf {\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("  DatumTot: ").Append(DatumTot).Append("\n");
            sb.Append("  RedenBeeindigen: ").Append(RedenBeeindigen).Append("\n");
            sb.Append("  IndicatieNationaliteitBeeindigd: ").Append(IndicatieNationaliteitBeeindigd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NationaliteithistorieAllOf);
        }

        /// <summary>
        /// Returns true if NationaliteithistorieAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NationaliteithistorieAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NationaliteithistorieAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens)
                ) && 
                (
                    this.DatumTot == input.DatumTot ||
                    (this.DatumTot != null &&
                    this.DatumTot.Equals(input.DatumTot))
                ) && 
                (
                    this.RedenBeeindigen == input.RedenBeeindigen ||
                    (this.RedenBeeindigen != null &&
                    this.RedenBeeindigen.Equals(input.RedenBeeindigen))
                ) && 
                (
                    this.IndicatieNationaliteitBeeindigd == input.IndicatieNationaliteitBeeindigd ||
                    this.IndicatieNationaliteitBeeindigd.Equals(input.IndicatieNationaliteitBeeindigd)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                if (this.DatumTot != null)
                    hashCode = hashCode * 59 + this.DatumTot.GetHashCode();
                if (this.RedenBeeindigen != null)
                    hashCode = hashCode * 59 + this.RedenBeeindigen.GetHashCode();
                hashCode = hashCode * 59 + this.IndicatieNationaliteitBeeindigd.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
