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
    /// Stamp
    /// </summary>
    [DataContract]
    public partial class Stamp :  IEquatable<Stamp>, IValidatableObject
    {
        public Stamp()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stamp" /> class.
        /// </summary>
        /// <param name="AdoptedDateTime">AdoptedDateTime.</param>
        /// <param name="CreatedDateTime">Indicates the date and time the item was created..</param>
        /// <param name="CustomField">CustomField.</param>
        /// <param name="DateStampProperties">Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle..</param>
        /// <param name="DisallowUserResizeStamp">DisallowUserResizeStamp.</param>
        /// <param name="ErrorDetails">This object describes errors that occur. It is only valid for responses and ignored in requests..</param>
        /// <param name="ExternalID">ExternalID.</param>
        /// <param name="ImageBase64">ImageBase64.</param>
        /// <param name="ImageType">ImageType.</param>
        /// <param name="LastModifiedDateTime">The date and time the item was last modified..</param>
        /// <param name="PhoneticName">PhoneticName.</param>
        /// <param name="SignatureName">Specifies the user signature name..</param>
        /// <param name="StampFormat">StampFormat.</param>
        /// <param name="StampImageUri">StampImageUri.</param>
        /// <param name="StampSizeMM">StampSizeMM.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        public Stamp(string AdoptedDateTime = default(string), string CreatedDateTime = default(string), string CustomField = default(string), DateStampProperties DateStampProperties = default(DateStampProperties), string DisallowUserResizeStamp = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string ExternalID = default(string), string ImageBase64 = default(string), string ImageType = default(string), string LastModifiedDateTime = default(string), string PhoneticName = default(string), string SignatureName = default(string), string StampFormat = default(string), string StampImageUri = default(string), string StampSizeMM = default(string), string Status = default(string))
        {
            this.AdoptedDateTime = AdoptedDateTime;
            this.CreatedDateTime = CreatedDateTime;
            this.CustomField = CustomField;
            this.DateStampProperties = DateStampProperties;
            this.DisallowUserResizeStamp = DisallowUserResizeStamp;
            this.ErrorDetails = ErrorDetails;
            this.ExternalID = ExternalID;
            this.ImageBase64 = ImageBase64;
            this.ImageType = ImageType;
            this.LastModifiedDateTime = LastModifiedDateTime;
            this.PhoneticName = PhoneticName;
            this.SignatureName = SignatureName;
            this.StampFormat = StampFormat;
            this.StampImageUri = StampImageUri;
            this.StampSizeMM = StampSizeMM;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets AdoptedDateTime
        /// </summary>
        [DataMember(Name="adoptedDateTime", EmitDefaultValue=false)]
        public string AdoptedDateTime { get; set; }
        /// <summary>
        /// Indicates the date and time the item was created.
        /// </summary>
        /// <value>Indicates the date and time the item was created.</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }
        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name="customField", EmitDefaultValue=false)]
        public string CustomField { get; set; }
        /// <summary>
        /// Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle.
        /// </summary>
        /// <value>Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle.</value>
        [DataMember(Name="dateStampProperties", EmitDefaultValue=false)]
        public DateStampProperties DateStampProperties { get; set; }
        /// <summary>
        /// Gets or Sets DisallowUserResizeStamp
        /// </summary>
        [DataMember(Name="disallowUserResizeStamp", EmitDefaultValue=false)]
        public string DisallowUserResizeStamp { get; set; }
        /// <summary>
        /// This object describes errors that occur. It is only valid for responses and ignored in requests.
        /// </summary>
        /// <value>This object describes errors that occur. It is only valid for responses and ignored in requests.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }
        /// <summary>
        /// Gets or Sets ImageBase64
        /// </summary>
        [DataMember(Name="imageBase64", EmitDefaultValue=false)]
        public string ImageBase64 { get; set; }
        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name="imageType", EmitDefaultValue=false)]
        public string ImageType { get; set; }
        /// <summary>
        /// The date and time the item was last modified.
        /// </summary>
        /// <value>The date and time the item was last modified.</value>
        [DataMember(Name="lastModifiedDateTime", EmitDefaultValue=false)]
        public string LastModifiedDateTime { get; set; }
        /// <summary>
        /// Gets or Sets PhoneticName
        /// </summary>
        [DataMember(Name="phoneticName", EmitDefaultValue=false)]
        public string PhoneticName { get; set; }
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
        /// <summary>
        /// Gets or Sets StampFormat
        /// </summary>
        [DataMember(Name="stampFormat", EmitDefaultValue=false)]
        public string StampFormat { get; set; }
        /// <summary>
        /// Gets or Sets StampImageUri
        /// </summary>
        [DataMember(Name="stampImageUri", EmitDefaultValue=false)]
        public string StampImageUri { get; set; }
        /// <summary>
        /// Gets or Sets StampSizeMM
        /// </summary>
        [DataMember(Name="stampSizeMM", EmitDefaultValue=false)]
        public string StampSizeMM { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stamp {\n");
            sb.Append("  AdoptedDateTime: ").Append(AdoptedDateTime).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  DateStampProperties: ").Append(DateStampProperties).Append("\n");
            sb.Append("  DisallowUserResizeStamp: ").Append(DisallowUserResizeStamp).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  PhoneticName: ").Append(PhoneticName).Append("\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  StampFormat: ").Append(StampFormat).Append("\n");
            sb.Append("  StampImageUri: ").Append(StampImageUri).Append("\n");
            sb.Append("  StampSizeMM: ").Append(StampSizeMM).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as Stamp);
        }

        /// <summary>
        /// Returns true if Stamp instances are equal
        /// </summary>
        /// <param name="other">Instance of Stamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stamp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdoptedDateTime == other.AdoptedDateTime ||
                    this.AdoptedDateTime != null &&
                    this.AdoptedDateTime.Equals(other.AdoptedDateTime)
                ) && 
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    this.CustomField == other.CustomField ||
                    this.CustomField != null &&
                    this.CustomField.Equals(other.CustomField)
                ) && 
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
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.ExternalID == other.ExternalID ||
                    this.ExternalID != null &&
                    this.ExternalID.Equals(other.ExternalID)
                ) && 
                (
                    this.ImageBase64 == other.ImageBase64 ||
                    this.ImageBase64 != null &&
                    this.ImageBase64.Equals(other.ImageBase64)
                ) && 
                (
                    this.ImageType == other.ImageType ||
                    this.ImageType != null &&
                    this.ImageType.Equals(other.ImageType)
                ) && 
                (
                    this.LastModifiedDateTime == other.LastModifiedDateTime ||
                    this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(other.LastModifiedDateTime)
                ) && 
                (
                    this.PhoneticName == other.PhoneticName ||
                    this.PhoneticName != null &&
                    this.PhoneticName.Equals(other.PhoneticName)
                ) && 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
                ) && 
                (
                    this.StampFormat == other.StampFormat ||
                    this.StampFormat != null &&
                    this.StampFormat.Equals(other.StampFormat)
                ) && 
                (
                    this.StampImageUri == other.StampImageUri ||
                    this.StampImageUri != null &&
                    this.StampImageUri.Equals(other.StampImageUri)
                ) && 
                (
                    this.StampSizeMM == other.StampSizeMM ||
                    this.StampSizeMM != null &&
                    this.StampSizeMM.Equals(other.StampSizeMM)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.AdoptedDateTime != null)
                    hash = hash * 59 + this.AdoptedDateTime.GetHashCode();
                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CustomField != null)
                    hash = hash * 59 + this.CustomField.GetHashCode();
                if (this.DateStampProperties != null)
                    hash = hash * 59 + this.DateStampProperties.GetHashCode();
                if (this.DisallowUserResizeStamp != null)
                    hash = hash * 59 + this.DisallowUserResizeStamp.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.ExternalID != null)
                    hash = hash * 59 + this.ExternalID.GetHashCode();
                if (this.ImageBase64 != null)
                    hash = hash * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageType != null)
                    hash = hash * 59 + this.ImageType.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hash = hash * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.PhoneticName != null)
                    hash = hash * 59 + this.PhoneticName.GetHashCode();
                if (this.SignatureName != null)
                    hash = hash * 59 + this.SignatureName.GetHashCode();
                if (this.StampFormat != null)
                    hash = hash * 59 + this.StampFormat.GetHashCode();
                if (this.StampImageUri != null)
                    hash = hash * 59 + this.StampImageUri.GetHashCode();
                if (this.StampSizeMM != null)
                    hash = hash * 59 + this.StampSizeMM.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
