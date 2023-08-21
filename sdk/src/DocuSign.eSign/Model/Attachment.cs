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
    /// Contains information about an attachment.
    /// </summary>
    [DataContract]
    public partial class Attachment :  IEquatable<Attachment>, IValidatableObject
    {
        public Attachment()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="AccessControl">AccessControl.</param>
        /// <param name="AttachmentId">AttachmentId.</param>
        /// <param name="AttachmentType">Specifies the type of the attachment for the recipient..</param>
        /// <param name="Data">Data.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RemoteUrl">RemoteUrl.</param>
        public Attachment(string AccessControl = default(string), string AttachmentId = default(string), string AttachmentType = default(string), string Data = default(string), string Label = default(string), string Name = default(string), string RemoteUrl = default(string))
        {
            this.AccessControl = AccessControl;
            this.AttachmentId = AttachmentId;
            this.AttachmentType = AttachmentType;
            this.Data = Data;
            this.Label = Label;
            this.Name = Name;
            this.RemoteUrl = RemoteUrl;
        }
        
        /// <summary>
        /// Gets or Sets AccessControl
        /// </summary>
        [DataMember(Name="accessControl", EmitDefaultValue=false)]
        public string AccessControl { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }
        /// <summary>
        /// Specifies the type of the attachment for the recipient.
        /// </summary>
        /// <value>Specifies the type of the attachment for the recipient.</value>
        [DataMember(Name="attachmentType", EmitDefaultValue=false)]
        public string AttachmentType { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RemoteUrl
        /// </summary>
        [DataMember(Name="remoteUrl", EmitDefaultValue=false)]
        public string RemoteUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  AccessControl: ").Append(AccessControl).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RemoteUrl: ").Append(RemoteUrl).Append("\n");
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
            return this.Equals(obj as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="other">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessControl == other.AccessControl ||
                    this.AccessControl != null &&
                    this.AccessControl.Equals(other.AccessControl)
                ) && 
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId)
                ) && 
                (
                    this.AttachmentType == other.AttachmentType ||
                    this.AttachmentType != null &&
                    this.AttachmentType.Equals(other.AttachmentType)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RemoteUrl == other.RemoteUrl ||
                    this.RemoteUrl != null &&
                    this.RemoteUrl.Equals(other.RemoteUrl)
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
                if (this.AccessControl != null)
                    hash = hash * 59 + this.AccessControl.GetHashCode();
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();
                if (this.AttachmentType != null)
                    hash = hash * 59 + this.AttachmentType.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RemoteUrl != null)
                    hash = hash * 59 + this.RemoteUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
