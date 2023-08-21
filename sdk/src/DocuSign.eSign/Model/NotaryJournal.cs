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
    /// NotaryJournal
    /// </summary>
    [DataContract]
    public partial class NotaryJournal :  IEquatable<NotaryJournal>, IValidatableObject
    {
        public NotaryJournal()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryJournal" /> class.
        /// </summary>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="DocumentName">DocumentName.</param>
        /// <param name="Jurisdiction">The notary&#39;s jurisdiction. .</param>
        /// <param name="NotaryJournalId">NotaryJournalId.</param>
        /// <param name="NotaryJournalMetaData">Additional journal data such as the witness list and signature image..</param>
        /// <param name="SignerName">SignerName.</param>
        public NotaryJournal(string CreatedDate = default(string), string DocumentName = default(string), Jurisdiction Jurisdiction = default(Jurisdiction), string NotaryJournalId = default(string), NotaryJournalMetaData NotaryJournalMetaData = default(NotaryJournalMetaData), string SignerName = default(string))
        {
            this.CreatedDate = CreatedDate;
            this.DocumentName = DocumentName;
            this.Jurisdiction = Jurisdiction;
            this.NotaryJournalId = NotaryJournalId;
            this.NotaryJournalMetaData = NotaryJournalMetaData;
            this.SignerName = SignerName;
        }
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets DocumentName
        /// </summary>
        [DataMember(Name="documentName", EmitDefaultValue=false)]
        public string DocumentName { get; set; }
        /// <summary>
        /// The notary&#39;s jurisdiction. 
        /// </summary>
        /// <value>The notary&#39;s jurisdiction. </value>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public Jurisdiction Jurisdiction { get; set; }
        /// <summary>
        /// Gets or Sets NotaryJournalId
        /// </summary>
        [DataMember(Name="notaryJournalId", EmitDefaultValue=false)]
        public string NotaryJournalId { get; set; }
        /// <summary>
        /// Additional journal data such as the witness list and signature image.
        /// </summary>
        /// <value>Additional journal data such as the witness list and signature image.</value>
        [DataMember(Name="notaryJournalMetaData", EmitDefaultValue=false)]
        public NotaryJournalMetaData NotaryJournalMetaData { get; set; }
        /// <summary>
        /// Gets or Sets SignerName
        /// </summary>
        [DataMember(Name="signerName", EmitDefaultValue=false)]
        public string SignerName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryJournal {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  NotaryJournalId: ").Append(NotaryJournalId).Append("\n");
            sb.Append("  NotaryJournalMetaData: ").Append(NotaryJournalMetaData).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
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
            return this.Equals(obj as NotaryJournal);
        }

        /// <summary>
        /// Returns true if NotaryJournal instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryJournal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryJournal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.DocumentName == other.DocumentName ||
                    this.DocumentName != null &&
                    this.DocumentName.Equals(other.DocumentName)
                ) && 
                (
                    this.Jurisdiction == other.Jurisdiction ||
                    this.Jurisdiction != null &&
                    this.Jurisdiction.Equals(other.Jurisdiction)
                ) && 
                (
                    this.NotaryJournalId == other.NotaryJournalId ||
                    this.NotaryJournalId != null &&
                    this.NotaryJournalId.Equals(other.NotaryJournalId)
                ) && 
                (
                    this.NotaryJournalMetaData == other.NotaryJournalMetaData ||
                    this.NotaryJournalMetaData != null &&
                    this.NotaryJournalMetaData.Equals(other.NotaryJournalMetaData)
                ) && 
                (
                    this.SignerName == other.SignerName ||
                    this.SignerName != null &&
                    this.SignerName.Equals(other.SignerName)
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
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.DocumentName != null)
                    hash = hash * 59 + this.DocumentName.GetHashCode();
                if (this.Jurisdiction != null)
                    hash = hash * 59 + this.Jurisdiction.GetHashCode();
                if (this.NotaryJournalId != null)
                    hash = hash * 59 + this.NotaryJournalId.GetHashCode();
                if (this.NotaryJournalMetaData != null)
                    hash = hash * 59 + this.NotaryJournalMetaData.GetHashCode();
                if (this.SignerName != null)
                    hash = hash * 59 + this.SignerName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
