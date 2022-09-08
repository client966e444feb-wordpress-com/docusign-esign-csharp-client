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
    /// UserInfo
    /// </summary>
    [DataContract]
    public partial class UserInfo :  IEquatable<UserInfo>, IValidatableObject
    {
        public UserInfo()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="AccountName">AccountName.</param>
        /// <param name="ActivationAccessCode">ActivationAccessCode.</param>
        /// <param name="Email">Email.</param>
        /// <param name="ErrorDetails">This object describes errors that occur. It is only valid for responses and ignored in requests..</param>
        /// <param name="LoginStatus">LoginStatus.</param>
        /// <param name="MembershipId">MembershipId.</param>
        /// <param name="SendActivationEmail">SendActivationEmail.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="UserStatus">UserStatus.</param>
        /// <param name="UserType">UserType.</param>
        public UserInfo(string AccountId = default(string), string AccountName = default(string), string ActivationAccessCode = default(string), string Email = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string LoginStatus = default(string), string MembershipId = default(string), string SendActivationEmail = default(string), string Uri = default(string), string UserId = default(string), string UserName = default(string), string UserStatus = default(string), string UserType = default(string))
        {
            this.AccountId = AccountId;
            this.AccountName = AccountName;
            this.ActivationAccessCode = ActivationAccessCode;
            this.Email = Email;
            this.ErrorDetails = ErrorDetails;
            this.LoginStatus = LoginStatus;
            this.MembershipId = MembershipId;
            this.SendActivationEmail = SendActivationEmail;
            this.Uri = Uri;
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserStatus = UserStatus;
            this.UserType = UserType;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets ActivationAccessCode
        /// </summary>
        [DataMember(Name="activationAccessCode", EmitDefaultValue=false)]
        public string ActivationAccessCode { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// This object describes errors that occur. It is only valid for responses and ignored in requests.
        /// </summary>
        /// <value>This object describes errors that occur. It is only valid for responses and ignored in requests.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets LoginStatus
        /// </summary>
        [DataMember(Name="loginStatus", EmitDefaultValue=false)]
        public string LoginStatus { get; set; }
        /// <summary>
        /// Gets or Sets MembershipId
        /// </summary>
        [DataMember(Name="membershipId", EmitDefaultValue=false)]
        public string MembershipId { get; set; }
        /// <summary>
        /// Gets or Sets SendActivationEmail
        /// </summary>
        [DataMember(Name="sendActivationEmail", EmitDefaultValue=false)]
        public string SendActivationEmail { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public string UserStatus { get; set; }
        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public string UserType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ActivationAccessCode: ").Append(ActivationAccessCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  LoginStatus: ").Append(LoginStatus).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  SendActivationEmail: ").Append(SendActivationEmail).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
            return this.Equals(obj as UserInfo);
        }

        /// <summary>
        /// Returns true if UserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfo other)
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
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ActivationAccessCode == other.ActivationAccessCode ||
                    this.ActivationAccessCode != null &&
                    this.ActivationAccessCode.Equals(other.ActivationAccessCode)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.LoginStatus == other.LoginStatus ||
                    this.LoginStatus != null &&
                    this.LoginStatus.Equals(other.LoginStatus)
                ) && 
                (
                    this.MembershipId == other.MembershipId ||
                    this.MembershipId != null &&
                    this.MembershipId.Equals(other.MembershipId)
                ) && 
                (
                    this.SendActivationEmail == other.SendActivationEmail ||
                    this.SendActivationEmail != null &&
                    this.SendActivationEmail.Equals(other.SendActivationEmail)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
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
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ActivationAccessCode != null)
                    hash = hash * 59 + this.ActivationAccessCode.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.LoginStatus != null)
                    hash = hash * 59 + this.LoginStatus.GetHashCode();
                if (this.MembershipId != null)
                    hash = hash * 59 + this.MembershipId.GetHashCode();
                if (this.SendActivationEmail != null)
                    hash = hash * 59 + this.SendActivationEmail.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.UserStatus != null)
                    hash = hash * 59 + this.UserStatus.GetHashCode();
                if (this.UserType != null)
                    hash = hash * 59 + this.UserType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
