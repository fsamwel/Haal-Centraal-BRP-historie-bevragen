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
    /// Geeft aan dat de ontbinding van het huwelijk of de beëindiging van het partnerschap in onderzoek is.  [Zie functionele specificaties](https://github.com/VNG-Realisatie/Bevragingen-ingeschreven-personen/blob/master/features/in_onderzoek.feature) 
    /// </summary>
    [DataContract]
    public partial class OntbindingHuwelijkInOnderzoek :  IEquatable<OntbindingHuwelijkInOnderzoek>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OntbindingHuwelijkInOnderzoek" /> class.
        /// </summary>
        /// <param name="datum">datum.</param>
        /// <param name="land">land.</param>
        /// <param name="plaats">plaats.</param>
        /// <param name="reden">reden.</param>
        /// <param name="datumIngangOnderzoek">datumIngangOnderzoek.</param>
        public OntbindingHuwelijkInOnderzoek(bool datum = default(bool), bool land = default(bool), bool plaats = default(bool), bool reden = default(bool), DatumOnvolledig datumIngangOnderzoek = default(DatumOnvolledig))
        {
            this.Datum = datum;
            this.Land = land;
            this.Plaats = plaats;
            this.Reden = reden;
            this.DatumIngangOnderzoek = datumIngangOnderzoek;
        }
        
        /// <summary>
        /// Gets or Sets Datum
        /// </summary>
        [DataMember(Name="datum", EmitDefaultValue=false)]
        public bool Datum { get; set; }

        /// <summary>
        /// Gets or Sets Land
        /// </summary>
        [DataMember(Name="land", EmitDefaultValue=false)]
        public bool Land { get; set; }

        /// <summary>
        /// Gets or Sets Plaats
        /// </summary>
        [DataMember(Name="plaats", EmitDefaultValue=false)]
        public bool Plaats { get; set; }

        /// <summary>
        /// Gets or Sets Reden
        /// </summary>
        [DataMember(Name="reden", EmitDefaultValue=false)]
        public bool Reden { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngangOnderzoek
        /// </summary>
        [DataMember(Name="datumIngangOnderzoek", EmitDefaultValue=false)]
        public DatumOnvolledig DatumIngangOnderzoek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OntbindingHuwelijkInOnderzoek {\n");
            sb.Append("  Datum: ").Append(Datum).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
            sb.Append("  Plaats: ").Append(Plaats).Append("\n");
            sb.Append("  Reden: ").Append(Reden).Append("\n");
            sb.Append("  DatumIngangOnderzoek: ").Append(DatumIngangOnderzoek).Append("\n");
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
            return this.Equals(input as OntbindingHuwelijkInOnderzoek);
        }

        /// <summary>
        /// Returns true if OntbindingHuwelijkInOnderzoek instances are equal
        /// </summary>
        /// <param name="input">Instance of OntbindingHuwelijkInOnderzoek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OntbindingHuwelijkInOnderzoek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datum == input.Datum ||
                    (this.Datum != null &&
                    this.Datum.Equals(input.Datum))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
                ) && 
                (
                    this.Plaats == input.Plaats ||
                    (this.Plaats != null &&
                    this.Plaats.Equals(input.Plaats))
                ) && 
                (
                    this.Reden == input.Reden ||
                    (this.Reden != null &&
                    this.Reden.Equals(input.Reden))
                ) && 
                (
                    this.DatumIngangOnderzoek == input.DatumIngangOnderzoek ||
                    (this.DatumIngangOnderzoek != null &&
                    this.DatumIngangOnderzoek.Equals(input.DatumIngangOnderzoek))
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
                if (this.Datum != null)
                    hashCode = hashCode * 59 + this.Datum.GetHashCode();
                if (this.Land != null)
                    hashCode = hashCode * 59 + this.Land.GetHashCode();
                if (this.Plaats != null)
                    hashCode = hashCode * 59 + this.Plaats.GetHashCode();
                if (this.Reden != null)
                    hashCode = hashCode * 59 + this.Reden.GetHashCode();
                if (this.DatumIngangOnderzoek != null)
                    hashCode = hashCode * 59 + this.DatumIngangOnderzoek.GetHashCode();
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
