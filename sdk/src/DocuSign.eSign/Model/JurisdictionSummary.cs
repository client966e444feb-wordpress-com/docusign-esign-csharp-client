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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// JurisdictionSummary
    /// </summary>
    [DataContract]
    public partial class JurisdictionSummary :  IEquatable<JurisdictionSummary>, IValidatableObject
    {
        public JurisdictionSummary()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisdictionSummary" /> class.
        /// </summary>
        /// <param name="AuthorizedForIPen">AuthorizedForIPen.</param>
        /// <param name="AuthorizedForRon">AuthorizedForRon.</param>
        /// <param name="JurisdictionId">JurisdictionId.</param>
        /// <param name="JurisdictionName">JurisdictionName.</param>
        public JurisdictionSummary(string AuthorizedForIPen = default(string), string AuthorizedForRon = default(string), string JurisdictionId = default(string), string JurisdictionName = default(string))
        {
            this.AuthorizedForIPen = AuthorizedForIPen;
            this.AuthorizedForRon = AuthorizedForRon;
            this.JurisdictionId = JurisdictionId;
            this.JurisdictionName = JurisdictionName;
        }
        
        /// <summary>
        /// Gets or Sets AuthorizedForIPen
        /// </summary>
        [DataMember(Name="authorizedForIPen", EmitDefaultValue=false)]
        public string AuthorizedForIPen { get; set; }
        /// <summary>
        /// Gets or Sets AuthorizedForRon
        /// </summary>
        [DataMember(Name="authorizedForRon", EmitDefaultValue=false)]
        public string AuthorizedForRon { get; set; }
        /// <summary>
        /// Gets or Sets JurisdictionId
        /// </summary>
        [DataMember(Name="jurisdictionId", EmitDefaultValue=false)]
        public string JurisdictionId { get; set; }
        /// <summary>
        /// Gets or Sets JurisdictionName
        /// </summary>
        [DataMember(Name="jurisdictionName", EmitDefaultValue=false)]
        public string JurisdictionName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JurisdictionSummary {\n");
            sb.Append("  AuthorizedForIPen: ").Append(AuthorizedForIPen).Append("\n");
            sb.Append("  AuthorizedForRon: ").Append(AuthorizedForRon).Append("\n");
            sb.Append("  JurisdictionId: ").Append(JurisdictionId).Append("\n");
            sb.Append("  JurisdictionName: ").Append(JurisdictionName).Append("\n");
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
            return this.Equals(obj as JurisdictionSummary);
        }

        /// <summary>
        /// Returns true if JurisdictionSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of JurisdictionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JurisdictionSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthorizedForIPen == other.AuthorizedForIPen ||
                    this.AuthorizedForIPen != null &&
                    this.AuthorizedForIPen.Equals(other.AuthorizedForIPen)
                ) && 
                (
                    this.AuthorizedForRon == other.AuthorizedForRon ||
                    this.AuthorizedForRon != null &&
                    this.AuthorizedForRon.Equals(other.AuthorizedForRon)
                ) && 
                (
                    this.JurisdictionId == other.JurisdictionId ||
                    this.JurisdictionId != null &&
                    this.JurisdictionId.Equals(other.JurisdictionId)
                ) && 
                (
                    this.JurisdictionName == other.JurisdictionName ||
                    this.JurisdictionName != null &&
                    this.JurisdictionName.Equals(other.JurisdictionName)
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
                if (this.AuthorizedForIPen != null)
                    hash = hash * 59 + this.AuthorizedForIPen.GetHashCode();
                if (this.AuthorizedForRon != null)
                    hash = hash * 59 + this.AuthorizedForRon.GetHashCode();
                if (this.JurisdictionId != null)
                    hash = hash * 59 + this.JurisdictionId.GetHashCode();
                if (this.JurisdictionName != null)
                    hash = hash * 59 + this.JurisdictionName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
