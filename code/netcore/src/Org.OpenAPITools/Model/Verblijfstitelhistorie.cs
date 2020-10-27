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
    /// Verblijfstitelhistorie
    /// </summary>
    [DataContract]
    public partial class Verblijfstitelhistorie :  IEquatable<Verblijfstitelhistorie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Verblijfstitelhistorie" /> class.
        /// </summary>
        /// <param name="aanduiding">aanduiding.</param>
        /// <param name="datumEinde">datumEinde.</param>
        /// <param name="datumIngang">datumIngang.</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        /// <param name="geheimhoudingPersoonsgegevens">Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. .</param>
        public Verblijfstitelhistorie(Waardetabel aanduiding = default(Waardetabel), DatumOnvolledig datumEinde = default(DatumOnvolledig), DatumOnvolledig datumIngang = default(DatumOnvolledig), VerblijfstitelInOnderzoek inOnderzoek = default(VerblijfstitelInOnderzoek), bool geheimhoudingPersoonsgegevens = default(bool))
        {
            this.Aanduiding = aanduiding;
            this.DatumEinde = datumEinde;
            this.DatumIngang = datumIngang;
            this.InOnderzoek = inOnderzoek;
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
        }
        
        /// <summary>
        /// Gets or Sets Aanduiding
        /// </summary>
        [DataMember(Name="aanduiding", EmitDefaultValue=false)]
        public Waardetabel Aanduiding { get; set; }

        /// <summary>
        /// Gets or Sets DatumEinde
        /// </summary>
        [DataMember(Name="datumEinde", EmitDefaultValue=false)]
        public DatumOnvolledig DatumEinde { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngang
        /// </summary>
        [DataMember(Name="datumIngang", EmitDefaultValue=false)]
        public DatumOnvolledig DatumIngang { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public VerblijfstitelInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. 
        /// </summary>
        /// <value>Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. </value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Verblijfstitelhistorie {\n");
            sb.Append("  Aanduiding: ").Append(Aanduiding).Append("\n");
            sb.Append("  DatumEinde: ").Append(DatumEinde).Append("\n");
            sb.Append("  DatumIngang: ").Append(DatumIngang).Append("\n");
            sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
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
            return this.Equals(input as Verblijfstitelhistorie);
        }

        /// <summary>
        /// Returns true if Verblijfstitelhistorie instances are equal
        /// </summary>
        /// <param name="input">Instance of Verblijfstitelhistorie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Verblijfstitelhistorie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aanduiding == input.Aanduiding ||
                    (this.Aanduiding != null &&
                    this.Aanduiding.Equals(input.Aanduiding))
                ) && 
                (
                    this.DatumEinde == input.DatumEinde ||
                    (this.DatumEinde != null &&
                    this.DatumEinde.Equals(input.DatumEinde))
                ) && 
                (
                    this.DatumIngang == input.DatumIngang ||
                    (this.DatumIngang != null &&
                    this.DatumIngang.Equals(input.DatumIngang))
                ) && 
                (
                    this.InOnderzoek == input.InOnderzoek ||
                    (this.InOnderzoek != null &&
                    this.InOnderzoek.Equals(input.InOnderzoek))
                ) && 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens)
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
                if (this.Aanduiding != null)
                    hashCode = hashCode * 59 + this.Aanduiding.GetHashCode();
                if (this.DatumEinde != null)
                    hashCode = hashCode * 59 + this.DatumEinde.GetHashCode();
                if (this.DatumIngang != null)
                    hashCode = hashCode * 59 + this.DatumIngang.GetHashCode();
                if (this.InOnderzoek != null)
                    hashCode = hashCode * 59 + this.InOnderzoek.GetHashCode();
                hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
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
