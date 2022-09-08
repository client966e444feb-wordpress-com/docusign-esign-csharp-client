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
    /// This object contains information about a seat discount.
    /// </summary>
    [DataContract]
    public partial class SeatDiscount :  IEquatable<SeatDiscount>, IValidatableObject
    {
        public SeatDiscount()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeatDiscount" /> class.
        /// </summary>
        /// <param name="BeginSeatCount">Reserved: TBD.</param>
        /// <param name="DiscountPercent">DiscountPercent.</param>
        /// <param name="EndSeatCount">Reserved: TBD.</param>
        public SeatDiscount(string BeginSeatCount = default(string), string DiscountPercent = default(string), string EndSeatCount = default(string))
        {
            this.BeginSeatCount = BeginSeatCount;
            this.DiscountPercent = DiscountPercent;
            this.EndSeatCount = EndSeatCount;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="beginSeatCount", EmitDefaultValue=false)]
        public string BeginSeatCount { get; set; }
        /// <summary>
        /// Gets or Sets DiscountPercent
        /// </summary>
        [DataMember(Name="discountPercent", EmitDefaultValue=false)]
        public string DiscountPercent { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="endSeatCount", EmitDefaultValue=false)]
        public string EndSeatCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeatDiscount {\n");
            sb.Append("  BeginSeatCount: ").Append(BeginSeatCount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  EndSeatCount: ").Append(EndSeatCount).Append("\n");
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
            return this.Equals(obj as SeatDiscount);
        }

        /// <summary>
        /// Returns true if SeatDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of SeatDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeatDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeginSeatCount == other.BeginSeatCount ||
                    this.BeginSeatCount != null &&
                    this.BeginSeatCount.Equals(other.BeginSeatCount)
                ) && 
                (
                    this.DiscountPercent == other.DiscountPercent ||
                    this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(other.DiscountPercent)
                ) && 
                (
                    this.EndSeatCount == other.EndSeatCount ||
                    this.EndSeatCount != null &&
                    this.EndSeatCount.Equals(other.EndSeatCount)
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
                if (this.BeginSeatCount != null)
                    hash = hash * 59 + this.BeginSeatCount.GetHashCode();
                if (this.DiscountPercent != null)
                    hash = hash * 59 + this.DiscountPercent.GetHashCode();
                if (this.EndSeatCount != null)
                    hash = hash * 59 + this.EndSeatCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
