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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DocGenFormFieldValidation
    /// </summary>
    [DataContract]
    public partial class DocGenFormFieldValidation :  IEquatable<DocGenFormFieldValidation>, IValidatableObject
    {
        public DocGenFormFieldValidation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenFormFieldValidation" /> class.
        /// </summary>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="Expression">Expression.</param>
        public DocGenFormFieldValidation(string ErrorMessage = default(string), string Expression = default(string))
        {
            this.ErrorMessage = ErrorMessage;
            this.Expression = Expression;
        }
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenFormFieldValidation {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
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
            return this.Equals(obj as DocGenFormFieldValidation);
        }

        /// <summary>
        /// Returns true if DocGenFormFieldValidation instances are equal
        /// </summary>
        /// <param name="other">Instance of DocGenFormFieldValidation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenFormFieldValidation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.Expression == other.Expression ||
                    this.Expression != null &&
                    this.Expression.Equals(other.Expression)
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
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
