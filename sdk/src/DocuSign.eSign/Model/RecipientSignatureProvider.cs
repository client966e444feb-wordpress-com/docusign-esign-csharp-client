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
    /// An Electronic or Standards Based Signature (digital signature) provider for the signer to use. [More information](/docs/esign-rest-api/esign101/concepts/standards-based-signatures/). 
    /// </summary>
    [DataContract]
    public partial class RecipientSignatureProvider :  IEquatable<RecipientSignatureProvider>, IValidatableObject
    {
        public RecipientSignatureProvider()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSignatureProvider" /> class.
        /// </summary>
        /// <param name="SealDocumentsWithTabsOnly">SealDocumentsWithTabsOnly.</param>
        /// <param name="SealName">SealName.</param>
        /// <param name="SignatureProviderName">SignatureProviderName.</param>
        /// <param name="SignatureProviderNameMetadata">Metadata that indicates whether the &#x60;signatureProviderName&#x60; property is editable. .</param>
        /// <param name="SignatureProviderOptions">Not applicable for this object..</param>
        public RecipientSignatureProvider(string SealDocumentsWithTabsOnly = default(string), string SealName = default(string), string SignatureProviderName = default(string), PropertyMetadata SignatureProviderNameMetadata = default(PropertyMetadata), RecipientSignatureProviderOptions SignatureProviderOptions = default(RecipientSignatureProviderOptions))
        {
            this.SealDocumentsWithTabsOnly = SealDocumentsWithTabsOnly;
            this.SealName = SealName;
            this.SignatureProviderName = SignatureProviderName;
            this.SignatureProviderNameMetadata = SignatureProviderNameMetadata;
            this.SignatureProviderOptions = SignatureProviderOptions;
        }
        
        /// <summary>
        /// Gets or Sets SealDocumentsWithTabsOnly
        /// </summary>
        [DataMember(Name="sealDocumentsWithTabsOnly", EmitDefaultValue=false)]
        public string SealDocumentsWithTabsOnly { get; set; }
        /// <summary>
        /// Gets or Sets SealName
        /// </summary>
        [DataMember(Name="sealName", EmitDefaultValue=false)]
        public string SealName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureProviderName
        /// </summary>
        [DataMember(Name="signatureProviderName", EmitDefaultValue=false)]
        public string SignatureProviderName { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;signatureProviderName&#x60; property is editable. 
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;signatureProviderName&#x60; property is editable. </value>
        [DataMember(Name="signatureProviderNameMetadata", EmitDefaultValue=false)]
        public PropertyMetadata SignatureProviderNameMetadata { get; set; }
        /// <summary>
        /// Not applicable for this object.
        /// </summary>
        /// <value>Not applicable for this object.</value>
        [DataMember(Name="signatureProviderOptions", EmitDefaultValue=false)]
        public RecipientSignatureProviderOptions SignatureProviderOptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSignatureProvider {\n");
            sb.Append("  SealDocumentsWithTabsOnly: ").Append(SealDocumentsWithTabsOnly).Append("\n");
            sb.Append("  SealName: ").Append(SealName).Append("\n");
            sb.Append("  SignatureProviderName: ").Append(SignatureProviderName).Append("\n");
            sb.Append("  SignatureProviderNameMetadata: ").Append(SignatureProviderNameMetadata).Append("\n");
            sb.Append("  SignatureProviderOptions: ").Append(SignatureProviderOptions).Append("\n");
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
            return this.Equals(obj as RecipientSignatureProvider);
        }

        /// <summary>
        /// Returns true if RecipientSignatureProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSignatureProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSignatureProvider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SealDocumentsWithTabsOnly == other.SealDocumentsWithTabsOnly ||
                    this.SealDocumentsWithTabsOnly != null &&
                    this.SealDocumentsWithTabsOnly.Equals(other.SealDocumentsWithTabsOnly)
                ) && 
                (
                    this.SealName == other.SealName ||
                    this.SealName != null &&
                    this.SealName.Equals(other.SealName)
                ) && 
                (
                    this.SignatureProviderName == other.SignatureProviderName ||
                    this.SignatureProviderName != null &&
                    this.SignatureProviderName.Equals(other.SignatureProviderName)
                ) && 
                (
                    this.SignatureProviderNameMetadata == other.SignatureProviderNameMetadata ||
                    this.SignatureProviderNameMetadata != null &&
                    this.SignatureProviderNameMetadata.Equals(other.SignatureProviderNameMetadata)
                ) && 
                (
                    this.SignatureProviderOptions == other.SignatureProviderOptions ||
                    this.SignatureProviderOptions != null &&
                    this.SignatureProviderOptions.Equals(other.SignatureProviderOptions)
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
                if (this.SealDocumentsWithTabsOnly != null)
                    hash = hash * 59 + this.SealDocumentsWithTabsOnly.GetHashCode();
                if (this.SealName != null)
                    hash = hash * 59 + this.SealName.GetHashCode();
                if (this.SignatureProviderName != null)
                    hash = hash * 59 + this.SignatureProviderName.GetHashCode();
                if (this.SignatureProviderNameMetadata != null)
                    hash = hash * 59 + this.SignatureProviderNameMetadata.GetHashCode();
                if (this.SignatureProviderOptions != null)
                    hash = hash * 59 + this.SignatureProviderOptions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
