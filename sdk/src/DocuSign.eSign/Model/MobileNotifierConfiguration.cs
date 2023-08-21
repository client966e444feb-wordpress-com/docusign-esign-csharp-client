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
    /// MobileNotifierConfiguration
    /// </summary>
    [DataContract]
    public partial class MobileNotifierConfiguration :  IEquatable<MobileNotifierConfiguration>, IValidatableObject
    {
        public MobileNotifierConfiguration()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNotifierConfiguration" /> class.
        /// </summary>
        /// <param name="DeviceId">DeviceId.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Platform">Platform.</param>
        public MobileNotifierConfiguration(string DeviceId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Platform = default(string))
        {
            this.DeviceId = DeviceId;
            this.ErrorDetails = ErrorDetails;
            this.Platform = Platform;
        }
        
        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileNotifierConfiguration {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(obj as MobileNotifierConfiguration);
        }

        /// <summary>
        /// Returns true if MobileNotifierConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of MobileNotifierConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileNotifierConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
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
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
