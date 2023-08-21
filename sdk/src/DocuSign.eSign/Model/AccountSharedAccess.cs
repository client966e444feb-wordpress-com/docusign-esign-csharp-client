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
    /// Contains shared access information.
    /// </summary>
    [DataContract]
    public partial class AccountSharedAccess :  IEquatable<AccountSharedAccess>, IValidatableObject
    {
        public AccountSharedAccess()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSharedAccess" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="EndPosition">The last position in the result set. .</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="NextUri">The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. .</param>
        /// <param name="PreviousUri">The postal code for the billing address..</param>
        /// <param name="ResultSetSize">The number of results returned in this response. .</param>
        /// <param name="SharedAccess">A complex type containing the shared access information to an envelope for the users specified in the request..</param>
        /// <param name="StartPosition">Starting position of the current result set..</param>
        /// <param name="TotalSetSize">The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response..</param>
        public AccountSharedAccess(string AccountId = default(string), string EndPosition = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string NextUri = default(string), string PreviousUri = default(string), string ResultSetSize = default(string), List<MemberSharedItems> SharedAccess = default(List<MemberSharedItems>), string StartPosition = default(string), string TotalSetSize = default(string))
        {
            this.AccountId = AccountId;
            this.EndPosition = EndPosition;
            this.ErrorDetails = ErrorDetails;
            this.NextUri = NextUri;
            this.PreviousUri = PreviousUri;
            this.ResultSetSize = ResultSetSize;
            this.SharedAccess = SharedAccess;
            this.StartPosition = StartPosition;
            this.TotalSetSize = TotalSetSize;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The last position in the result set. 
        /// </summary>
        /// <value>The last position in the result set. </value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. 
        /// </summary>
        /// <value>The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. </value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        /// <summary>
        /// The postal code for the billing address.
        /// </summary>
        /// <value>The postal code for the billing address.</value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
        /// <summary>
        /// The number of results returned in this response. 
        /// </summary>
        /// <value>The number of results returned in this response. </value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
        /// <summary>
        /// A complex type containing the shared access information to an envelope for the users specified in the request.
        /// </summary>
        /// <value>A complex type containing the shared access information to an envelope for the users specified in the request.</value>
        [DataMember(Name="sharedAccess", EmitDefaultValue=false)]
        public List<MemberSharedItems> SharedAccess { get; set; }
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSharedAccess {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  SharedAccess: ").Append(SharedAccess).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
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
            return this.Equals(obj as AccountSharedAccess);
        }

        /// <summary>
        /// Returns true if AccountSharedAccess instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSharedAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSharedAccess other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) && 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.SharedAccess == other.SharedAccess ||
                    this.SharedAccess != null &&
                    this.SharedAccess.SequenceEqual(other.SharedAccess)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.EndPosition != null)
                    hash = hash * 59 + this.EndPosition.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();
                if (this.ResultSetSize != null)
                    hash = hash * 59 + this.ResultSetSize.GetHashCode();
                if (this.SharedAccess != null)
                    hash = hash * 59 + this.SharedAccess.GetHashCode();
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                if (this.TotalSetSize != null)
                    hash = hash * 59 + this.TotalSetSize.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
