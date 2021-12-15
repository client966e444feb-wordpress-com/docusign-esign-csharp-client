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
    /// AccountSignatureDefinition
    /// </summary>
    [DataContract]
    public partial class AccountSignatureDefinition :  IEquatable<AccountSignatureDefinition>, IValidatableObject
    {
        public AccountSignatureDefinition()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignatureDefinition" /> class.
        /// </summary>
        /// <param name="DateStampProperties">DateStampProperties.</param>
        /// <param name="DisallowUserResizeStamp">DisallowUserResizeStamp.</param>
        /// <param name="ExternalID">ExternalID.</param>
        /// <param name="ImageType">ImageType.</param>
        /// <param name="IsDefault">IsDefault.</param>
        /// <param name="NrdsId">NrdsId.</param>
        /// <param name="NrdsLastName">NrdsLastName.</param>
        /// <param name="PhoneticName">PhoneticName.</param>
        /// <param name="SignatureFont">SignatureFont.</param>
        /// <param name="SignatureGroups">SignatureGroups.</param>
        /// <param name="SignatureId">Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID..</param>
        /// <param name="SignatureInitials">SignatureInitials.</param>
        /// <param name="SignatureName">Specifies the user signature name..</param>
        /// <param name="SignatureType">SignatureType.</param>
        /// <param name="SignatureUsers">SignatureUsers.</param>
        /// <param name="StampFormat">StampFormat.</param>
        /// <param name="StampSizeMM">StampSizeMM.</param>
        public AccountSignatureDefinition(DateStampProperties DateStampProperties = default(DateStampProperties), string DisallowUserResizeStamp = default(string), string ExternalID = default(string), string ImageType = default(string), string IsDefault = default(string), string NrdsId = default(string), string NrdsLastName = default(string), string PhoneticName = default(string), string SignatureFont = default(string), List<SignatureGroupDef> SignatureGroups = default(List<SignatureGroupDef>), string SignatureId = default(string), string SignatureInitials = default(string), string SignatureName = default(string), string SignatureType = default(string), List<SignatureUserDef> SignatureUsers = default(List<SignatureUserDef>), string StampFormat = default(string), string StampSizeMM = default(string))
        {
            this.DateStampProperties = DateStampProperties;
            this.DisallowUserResizeStamp = DisallowUserResizeStamp;
            this.ExternalID = ExternalID;
            this.ImageType = ImageType;
            this.IsDefault = IsDefault;
            this.NrdsId = NrdsId;
            this.NrdsLastName = NrdsLastName;
            this.PhoneticName = PhoneticName;
            this.SignatureFont = SignatureFont;
            this.SignatureGroups = SignatureGroups;
            this.SignatureId = SignatureId;
            this.SignatureInitials = SignatureInitials;
            this.SignatureName = SignatureName;
            this.SignatureType = SignatureType;
            this.SignatureUsers = SignatureUsers;
            this.StampFormat = StampFormat;
            this.StampSizeMM = StampSizeMM;
        }
        
        /// <summary>
        /// Gets or Sets DateStampProperties
        /// </summary>
        [DataMember(Name="dateStampProperties", EmitDefaultValue=false)]
        public DateStampProperties DateStampProperties { get; set; }
        /// <summary>
        /// Gets or Sets DisallowUserResizeStamp
        /// </summary>
        [DataMember(Name="disallowUserResizeStamp", EmitDefaultValue=false)]
        public string DisallowUserResizeStamp { get; set; }
        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }
        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name="imageType", EmitDefaultValue=false)]
        public string ImageType { get; set; }
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public string IsDefault { get; set; }
        /// <summary>
        /// Gets or Sets NrdsId
        /// </summary>
        [DataMember(Name="nrdsId", EmitDefaultValue=false)]
        public string NrdsId { get; set; }
        /// <summary>
        /// Gets or Sets NrdsLastName
        /// </summary>
        [DataMember(Name="nrdsLastName", EmitDefaultValue=false)]
        public string NrdsLastName { get; set; }
        /// <summary>
        /// Gets or Sets PhoneticName
        /// </summary>
        [DataMember(Name="phoneticName", EmitDefaultValue=false)]
        public string PhoneticName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureFont
        /// </summary>
        [DataMember(Name="signatureFont", EmitDefaultValue=false)]
        public string SignatureFont { get; set; }
        /// <summary>
        /// Gets or Sets SignatureGroups
        /// </summary>
        [DataMember(Name="signatureGroups", EmitDefaultValue=false)]
        public List<SignatureGroupDef> SignatureGroups { get; set; }
        /// <summary>
        /// Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.
        /// </summary>
        /// <value>Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.</value>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
        /// <summary>
        /// Gets or Sets SignatureInitials
        /// </summary>
        [DataMember(Name="signatureInitials", EmitDefaultValue=false)]
        public string SignatureInitials { get; set; }
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureType
        /// </summary>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }
        /// <summary>
        /// Gets or Sets SignatureUsers
        /// </summary>
        [DataMember(Name="signatureUsers", EmitDefaultValue=false)]
        public List<SignatureUserDef> SignatureUsers { get; set; }
        /// <summary>
        /// Gets or Sets StampFormat
        /// </summary>
        [DataMember(Name="stampFormat", EmitDefaultValue=false)]
        public string StampFormat { get; set; }
        /// <summary>
        /// Gets or Sets StampSizeMM
        /// </summary>
        [DataMember(Name="stampSizeMM", EmitDefaultValue=false)]
        public string StampSizeMM { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSignatureDefinition {\n");
            sb.Append("  DateStampProperties: ").Append(DateStampProperties).Append("\n");
            sb.Append("  DisallowUserResizeStamp: ").Append(DisallowUserResizeStamp).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  NrdsId: ").Append(NrdsId).Append("\n");
            sb.Append("  NrdsLastName: ").Append(NrdsLastName).Append("\n");
            sb.Append("  PhoneticName: ").Append(PhoneticName).Append("\n");
            sb.Append("  SignatureFont: ").Append(SignatureFont).Append("\n");
            sb.Append("  SignatureGroups: ").Append(SignatureGroups).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  SignatureInitials: ").Append(SignatureInitials).Append("\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  SignatureUsers: ").Append(SignatureUsers).Append("\n");
            sb.Append("  StampFormat: ").Append(StampFormat).Append("\n");
            sb.Append("  StampSizeMM: ").Append(StampSizeMM).Append("\n");
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
            return this.Equals(obj as AccountSignatureDefinition);
        }

        /// <summary>
        /// Returns true if AccountSignatureDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSignatureDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSignatureDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateStampProperties == other.DateStampProperties ||
                    this.DateStampProperties != null &&
                    this.DateStampProperties.Equals(other.DateStampProperties)
                ) && 
                (
                    this.DisallowUserResizeStamp == other.DisallowUserResizeStamp ||
                    this.DisallowUserResizeStamp != null &&
                    this.DisallowUserResizeStamp.Equals(other.DisallowUserResizeStamp)
                ) && 
                (
                    this.ExternalID == other.ExternalID ||
                    this.ExternalID != null &&
                    this.ExternalID.Equals(other.ExternalID)
                ) && 
                (
                    this.ImageType == other.ImageType ||
                    this.ImageType != null &&
                    this.ImageType.Equals(other.ImageType)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.NrdsId == other.NrdsId ||
                    this.NrdsId != null &&
                    this.NrdsId.Equals(other.NrdsId)
                ) && 
                (
                    this.NrdsLastName == other.NrdsLastName ||
                    this.NrdsLastName != null &&
                    this.NrdsLastName.Equals(other.NrdsLastName)
                ) && 
                (
                    this.PhoneticName == other.PhoneticName ||
                    this.PhoneticName != null &&
                    this.PhoneticName.Equals(other.PhoneticName)
                ) && 
                (
                    this.SignatureFont == other.SignatureFont ||
                    this.SignatureFont != null &&
                    this.SignatureFont.Equals(other.SignatureFont)
                ) && 
                (
                    this.SignatureGroups == other.SignatureGroups ||
                    this.SignatureGroups != null &&
                    this.SignatureGroups.SequenceEqual(other.SignatureGroups)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
                ) && 
                (
                    this.SignatureInitials == other.SignatureInitials ||
                    this.SignatureInitials != null &&
                    this.SignatureInitials.Equals(other.SignatureInitials)
                ) && 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
                ) && 
                (
                    this.SignatureType == other.SignatureType ||
                    this.SignatureType != null &&
                    this.SignatureType.Equals(other.SignatureType)
                ) && 
                (
                    this.SignatureUsers == other.SignatureUsers ||
                    this.SignatureUsers != null &&
                    this.SignatureUsers.SequenceEqual(other.SignatureUsers)
                ) && 
                (
                    this.StampFormat == other.StampFormat ||
                    this.StampFormat != null &&
                    this.StampFormat.Equals(other.StampFormat)
                ) && 
                (
                    this.StampSizeMM == other.StampSizeMM ||
                    this.StampSizeMM != null &&
                    this.StampSizeMM.Equals(other.StampSizeMM)
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
                if (this.DateStampProperties != null)
                    hash = hash * 59 + this.DateStampProperties.GetHashCode();
                if (this.DisallowUserResizeStamp != null)
                    hash = hash * 59 + this.DisallowUserResizeStamp.GetHashCode();
                if (this.ExternalID != null)
                    hash = hash * 59 + this.ExternalID.GetHashCode();
                if (this.ImageType != null)
                    hash = hash * 59 + this.ImageType.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.NrdsId != null)
                    hash = hash * 59 + this.NrdsId.GetHashCode();
                if (this.NrdsLastName != null)
                    hash = hash * 59 + this.NrdsLastName.GetHashCode();
                if (this.PhoneticName != null)
                    hash = hash * 59 + this.PhoneticName.GetHashCode();
                if (this.SignatureFont != null)
                    hash = hash * 59 + this.SignatureFont.GetHashCode();
                if (this.SignatureGroups != null)
                    hash = hash * 59 + this.SignatureGroups.GetHashCode();
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureInitials != null)
                    hash = hash * 59 + this.SignatureInitials.GetHashCode();
                if (this.SignatureName != null)
                    hash = hash * 59 + this.SignatureName.GetHashCode();
                if (this.SignatureType != null)
                    hash = hash * 59 + this.SignatureType.GetHashCode();
                if (this.SignatureUsers != null)
                    hash = hash * 59 + this.SignatureUsers.GetHashCode();
                if (this.StampFormat != null)
                    hash = hash * 59 + this.StampFormat.GetHashCode();
                if (this.StampSizeMM != null)
                    hash = hash * 59 + this.StampSizeMM.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}