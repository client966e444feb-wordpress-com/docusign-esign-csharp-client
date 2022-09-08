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
    /// Describes the form data of the envelope.
    /// </summary>
    [DataContract]
    public partial class EnvelopeFormData :  IEquatable<EnvelopeFormData>, IValidatableObject
    {
        public EnvelopeFormData()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeFormData" /> class.
        /// </summary>
        /// <param name="EmailSubject">Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject..</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="FormData">FormData.</param>
        /// <param name="PrefillFormData">An array of &#x60;formDataItem&#x60; objects for [prefill tabs](/docs/esign-rest-api/reference/envelopes/envelopedocumenttabs/create/#definition__tabs_prefilltabs). .</param>
        /// <param name="RecipientFormData">RecipientFormData.</param>
        /// <param name="SentDateTime">The date and time the envelope was sent..</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        public EnvelopeFormData(string EmailSubject = default(string), string EnvelopeId = default(string), List<FormDataItem> FormData = default(List<FormDataItem>), PrefillFormData PrefillFormData = default(PrefillFormData), List<RecipientFormData> RecipientFormData = default(List<RecipientFormData>), string SentDateTime = default(string), string Status = default(string))
        {
            this.EmailSubject = EmailSubject;
            this.EnvelopeId = EnvelopeId;
            this.FormData = FormData;
            this.PrefillFormData = PrefillFormData;
            this.RecipientFormData = RecipientFormData;
            this.SentDateTime = SentDateTime;
            this.Status = Status;
        }
        
        /// <summary>
        /// Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.
        /// </summary>
        /// <value>Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=false)]
        public string EmailSubject { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public List<FormDataItem> FormData { get; set; }
        /// <summary>
        /// An array of &#x60;formDataItem&#x60; objects for [prefill tabs](/docs/esign-rest-api/reference/envelopes/envelopedocumenttabs/create/#definition__tabs_prefilltabs). 
        /// </summary>
        /// <value>An array of &#x60;formDataItem&#x60; objects for [prefill tabs](/docs/esign-rest-api/reference/envelopes/envelopedocumenttabs/create/#definition__tabs_prefilltabs). </value>
        [DataMember(Name="prefillFormData", EmitDefaultValue=false)]
        public PrefillFormData PrefillFormData { get; set; }
        /// <summary>
        /// Gets or Sets RecipientFormData
        /// </summary>
        [DataMember(Name="recipientFormData", EmitDefaultValue=false)]
        public List<RecipientFormData> RecipientFormData { get; set; }
        /// <summary>
        /// The date and time the envelope was sent.
        /// </summary>
        /// <value>The date and time the envelope was sent.</value>
        [DataMember(Name="sentDateTime", EmitDefaultValue=false)]
        public string SentDateTime { get; set; }
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
            sb.Append("class EnvelopeFormData {\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
            sb.Append("  PrefillFormData: ").Append(PrefillFormData).Append("\n");
            sb.Append("  RecipientFormData: ").Append(RecipientFormData).Append("\n");
            sb.Append("  SentDateTime: ").Append(SentDateTime).Append("\n");
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
            return this.Equals(obj as EnvelopeFormData);
        }

        /// <summary>
        /// Returns true if EnvelopeFormData instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeFormData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeFormData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailSubject == other.EmailSubject ||
                    this.EmailSubject != null &&
                    this.EmailSubject.Equals(other.EmailSubject)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.FormData == other.FormData ||
                    this.FormData != null &&
                    this.FormData.SequenceEqual(other.FormData)
                ) && 
                (
                    this.PrefillFormData == other.PrefillFormData ||
                    this.PrefillFormData != null &&
                    this.PrefillFormData.Equals(other.PrefillFormData)
                ) && 
                (
                    this.RecipientFormData == other.RecipientFormData ||
                    this.RecipientFormData != null &&
                    this.RecipientFormData.SequenceEqual(other.RecipientFormData)
                ) && 
                (
                    this.SentDateTime == other.SentDateTime ||
                    this.SentDateTime != null &&
                    this.SentDateTime.Equals(other.SentDateTime)
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
                if (this.EmailSubject != null)
                    hash = hash * 59 + this.EmailSubject.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.FormData != null)
                    hash = hash * 59 + this.FormData.GetHashCode();
                if (this.PrefillFormData != null)
                    hash = hash * 59 + this.PrefillFormData.GetHashCode();
                if (this.RecipientFormData != null)
                    hash = hash * 59 + this.RecipientFormData.GetHashCode();
                if (this.SentDateTime != null)
                    hash = hash * 59 + this.SentDateTime.GetHashCode();
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
