/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// FeatureAvailableMetadata
    /// </summary>
    [DataContract]
    public partial class FeatureAvailableMetadata :  IEquatable<FeatureAvailableMetadata>, IValidatableObject
    {
        public FeatureAvailableMetadata()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureAvailableMetadata" /> class.
        /// </summary>
        /// <param name="Availabilty">Availabilty.</param>
        /// <param name="FeatureName">FeatureName.</param>
        public FeatureAvailableMetadata(string Availabilty = default(string), string FeatureName = default(string))
        {
            this.Availabilty = Availabilty;
            this.FeatureName = FeatureName;
        }
        
        /// <summary>
        /// Gets or Sets Availabilty
        /// </summary>
        [DataMember(Name="availabilty", EmitDefaultValue=false)]
        public string Availabilty { get; set; }
        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public string FeatureName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureAvailableMetadata {\n");
            sb.Append("  Availabilty: ").Append(Availabilty).Append("\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FeatureAvailableMetadata);
        }

        /// <summary>
        /// Returns true if FeatureAvailableMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of FeatureAvailableMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureAvailableMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Availabilty == other.Availabilty ||
                    this.Availabilty != null &&
                    this.Availabilty.Equals(other.Availabilty)
                ) && 
                (
                    this.FeatureName == other.FeatureName ||
                    this.FeatureName != null &&
                    this.FeatureName.Equals(other.FeatureName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Availabilty != null)
                    hash = hash * 59 + this.Availabilty.GetHashCode();
                if (this.FeatureName != null)
                    hash = hash * 59 + this.FeatureName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
