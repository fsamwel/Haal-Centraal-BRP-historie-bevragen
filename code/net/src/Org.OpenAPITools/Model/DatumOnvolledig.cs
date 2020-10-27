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
    /// Gegevens over de datums die mogelijk niet volledig zijn.
    /// </summary>
    [DataContract]
    public partial class DatumOnvolledig :  IEquatable<DatumOnvolledig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatumOnvolledig" /> class.
        /// </summary>
        /// <param name="dag">Als de dag van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is..</param>
        /// <param name="datum">Als de volledige datum bekend is wordt de datum gevuld die in de date definitie past..</param>
        /// <param name="jaar">Als het jaar van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is..</param>
        /// <param name="maand">Als de maand van een datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is..</param>
        public DatumOnvolledig(int dag = default(int), DateTime datum = default(DateTime), int jaar = default(int), int maand = default(int))
        {
            this.Dag = dag;
            this.Datum = datum;
            this.Jaar = jaar;
            this.Maand = maand;
        }
        
        /// <summary>
        /// Als de dag van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
        /// </summary>
        /// <value>Als de dag van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.</value>
        [DataMember(Name="dag", EmitDefaultValue=false)]
        public int Dag { get; set; }

        /// <summary>
        /// Als de volledige datum bekend is wordt de datum gevuld die in de date definitie past.
        /// </summary>
        /// <value>Als de volledige datum bekend is wordt de datum gevuld die in de date definitie past.</value>
        [DataMember(Name="datum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Datum { get; set; }

        /// <summary>
        /// Als het jaar van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
        /// </summary>
        /// <value>Als het jaar van de datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.</value>
        [DataMember(Name="jaar", EmitDefaultValue=false)]
        public int Jaar { get; set; }

        /// <summary>
        /// Als de maand van een datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.
        /// </summary>
        /// <value>Als de maand van een datum bekend is wordt dit element gevuld, ook als de volledige datum bekend is.</value>
        [DataMember(Name="maand", EmitDefaultValue=false)]
        public int Maand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatumOnvolledig {\n");
            sb.Append("  Dag: ").Append(Dag).Append("\n");
            sb.Append("  Datum: ").Append(Datum).Append("\n");
            sb.Append("  Jaar: ").Append(Jaar).Append("\n");
            sb.Append("  Maand: ").Append(Maand).Append("\n");
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
            return this.Equals(input as DatumOnvolledig);
        }

        /// <summary>
        /// Returns true if DatumOnvolledig instances are equal
        /// </summary>
        /// <param name="input">Instance of DatumOnvolledig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatumOnvolledig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dag == input.Dag ||
                    (this.Dag != null &&
                    this.Dag.Equals(input.Dag))
                ) && 
                (
                    this.Datum == input.Datum ||
                    (this.Datum != null &&
                    this.Datum.Equals(input.Datum))
                ) && 
                (
                    this.Jaar == input.Jaar ||
                    (this.Jaar != null &&
                    this.Jaar.Equals(input.Jaar))
                ) && 
                (
                    this.Maand == input.Maand ||
                    (this.Maand != null &&
                    this.Maand.Equals(input.Maand))
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
                if (this.Dag != null)
                    hashCode = hashCode * 59 + this.Dag.GetHashCode();
                if (this.Datum != null)
                    hashCode = hashCode * 59 + this.Datum.GetHashCode();
                if (this.Jaar != null)
                    hashCode = hashCode * 59 + this.Jaar.GetHashCode();
                if (this.Maand != null)
                    hashCode = hashCode * 59 + this.Maand.GetHashCode();
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

            
            // Dag (int) maximum
            if(this.Dag > (int)31)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Dag, must be a value less than or equal to 31.", new [] { "Dag" });
            }

            // Dag (int) minimum
            if(this.Dag < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Dag, must be a value greater than or equal to 1.", new [] { "Dag" });
            }


            
            // Jaar (int) maximum
            if(this.Jaar > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Jaar, must be a value less than or equal to 9999.", new [] { "Jaar" });
            }


            
            // Maand (int) maximum
            if(this.Maand > (int)12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Maand, must be a value less than or equal to 12.", new [] { "Maand" });
            }

            // Maand (int) minimum
            if(this.Maand < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Maand, must be a value greater than or equal to 1.", new [] { "Maand" });
            }

            yield break;
        }
    }

}
