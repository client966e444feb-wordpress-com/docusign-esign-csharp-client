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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// EnvelopeViewRequest
    /// </summary>
    [DataContract]
    public partial class EnvelopeViewRequest :  IEquatable<EnvelopeViewRequest>, IValidatableObject
    {
        public EnvelopeViewRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeViewRequest" /> class.
        /// </summary>
        /// <param name="ReturnUrl">ReturnUrl.</param>
        /// <param name="Settings">Settings.</param>
        /// <param name="ViewAccess">ViewAccess.</param>
        public EnvelopeViewRequest(string ReturnUrl = default(string), EnvelopeViewSettings Settings = default(EnvelopeViewSettings), string ViewAccess = default(string))
        {
            this.ReturnUrl = ReturnUrl;
            this.Settings = Settings;
            this.ViewAccess = ViewAccess;
        }
        
        /// <summary>
        /// Gets or Sets ReturnUrl
        /// </summary>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public EnvelopeViewSettings Settings { get; set; }
        /// <summary>
        /// Gets or Sets ViewAccess
        /// </summary>
        [DataMember(Name="viewAccess", EmitDefaultValue=false)]
        public string ViewAccess { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeViewRequest {\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  ViewAccess: ").Append(ViewAccess).Append("\n");
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
            return this.Equals(obj as EnvelopeViewRequest);
        }

        /// <summary>
        /// Returns true if EnvelopeViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.ViewAccess == other.ViewAccess ||
                    this.ViewAccess != null &&
                    this.ViewAccess.Equals(other.ViewAccess)
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
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.ViewAccess != null)
                    hash = hash * 59 + this.ViewAccess.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
