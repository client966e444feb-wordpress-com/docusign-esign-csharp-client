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
    /// TemplateNotificationRequest
    /// </summary>
    [DataContract]
    public partial class TemplateNotificationRequest :  IEquatable<TemplateNotificationRequest>, IValidatableObject
    {
        public TemplateNotificationRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateNotificationRequest" /> class.
        /// </summary>
        /// <param name="Expirations">A complex element that specifies the expiration settings for the envelope..</param>
        /// <param name="Password">Password.</param>
        /// <param name="Reminders">A complex element that specifies reminder settings for the envelope..</param>
        /// <param name="UseAccountDefaults">When set to **true**, the account default notification settings are used for the envelope..</param>
        public TemplateNotificationRequest(Expirations Expirations = default(Expirations), string Password = default(string), Reminders Reminders = default(Reminders), string UseAccountDefaults = default(string))
        {
            this.Expirations = Expirations;
            this.Password = Password;
            this.Reminders = Reminders;
            this.UseAccountDefaults = UseAccountDefaults;
        }
        
        /// <summary>
        /// A complex element that specifies the expiration settings for the envelope.
        /// </summary>
        /// <value>A complex element that specifies the expiration settings for the envelope.</value>
        [DataMember(Name="expirations", EmitDefaultValue=false)]
        public Expirations Expirations { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// A complex element that specifies reminder settings for the envelope.
        /// </summary>
        /// <value>A complex element that specifies reminder settings for the envelope.</value>
        [DataMember(Name="reminders", EmitDefaultValue=false)]
        public Reminders Reminders { get; set; }
        /// <summary>
        /// When set to **true**, the account default notification settings are used for the envelope.
        /// </summary>
        /// <value>When set to **true**, the account default notification settings are used for the envelope.</value>
        [DataMember(Name="useAccountDefaults", EmitDefaultValue=false)]
        public string UseAccountDefaults { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateNotificationRequest {\n");
            sb.Append("  Expirations: ").Append(Expirations).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Reminders: ").Append(Reminders).Append("\n");
            sb.Append("  UseAccountDefaults: ").Append(UseAccountDefaults).Append("\n");
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
            return this.Equals(obj as TemplateNotificationRequest);
        }

        /// <summary>
        /// Returns true if TemplateNotificationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateNotificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateNotificationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Expirations == other.Expirations ||
                    this.Expirations != null &&
                    this.Expirations.Equals(other.Expirations)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Reminders == other.Reminders ||
                    this.Reminders != null &&
                    this.Reminders.Equals(other.Reminders)
                ) && 
                (
                    this.UseAccountDefaults == other.UseAccountDefaults ||
                    this.UseAccountDefaults != null &&
                    this.UseAccountDefaults.Equals(other.UseAccountDefaults)
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
                if (this.Expirations != null)
                    hash = hash * 59 + this.Expirations.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Reminders != null)
                    hash = hash * 59 + this.Reminders.GetHashCode();
                if (this.UseAccountDefaults != null)
                    hash = hash * 59 + this.UseAccountDefaults.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
