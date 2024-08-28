/* 
 * Docusign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
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

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// UserProductProfileDeleteRequest
    /// </summary>
    [DataContract]
    public partial class UserProductProfileDeleteRequest :  IEquatable<UserProductProfileDeleteRequest>, IValidatableObject
    {
        public UserProductProfileDeleteRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductProfileDeleteRequest" /> class.
        /// </summary>
        /// <param name="UserEmail">UserEmail.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="ProductIds">ProductIds (required).</param>
        public UserProductProfileDeleteRequest(string UserEmail = default(string), Guid? UserId = default(Guid?), List<Guid?> ProductIds = default(List<Guid?>))
        {
            // to ensure "ProductIds" is required (not null)
            if (ProductIds == null)
            {
                throw new InvalidDataException("ProductIds is a required property for UserProductProfileDeleteRequest and cannot be null");
            }
            else
            {
                this.ProductIds = ProductIds;
            }
            this.UserEmail = UserEmail;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Gets or Sets UserEmail
        /// </summary>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        public string UserEmail { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }
        /// <summary>
        /// Gets or Sets ProductIds
        /// </summary>
        [DataMember(Name="product_ids", EmitDefaultValue=false)]
        public List<Guid?> ProductIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProductProfileDeleteRequest {\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ProductIds: ").Append(ProductIds).Append("\n");
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
            return this.Equals(obj as UserProductProfileDeleteRequest);
        }

        /// <summary>
        /// Returns true if UserProductProfileDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProductProfileDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProductProfileDeleteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserEmail == other.UserEmail ||
                    this.UserEmail != null &&
                    this.UserEmail.Equals(other.UserEmail)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ProductIds == other.ProductIds ||
                    this.ProductIds != null &&
                    this.ProductIds.SequenceEqual(other.ProductIds)
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
                if (this.UserEmail != null)
                    hash = hash * 59 + this.UserEmail.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ProductIds != null)
                    hash = hash * 59 + this.ProductIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
