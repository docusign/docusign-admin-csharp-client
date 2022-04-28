/* 
 * DocuSign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
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
using SwaggerDateConverter = DocuSign.Admin.Client.SwaggerDateConverter;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// RemoveUserProductsResponse
    /// </summary>
    [DataContract]
    public partial class RemoveUserProductsResponse :  IEquatable<RemoveUserProductsResponse>, IValidatableObject
    {
        public RemoveUserProductsResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveUserProductsResponse" /> class.
        /// </summary>
        /// <param name="IsSuccess">IsSuccess (required).</param>
        /// <param name="UserEmail">UserEmail.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserProductResults">UserProductResults (required).</param>
        public RemoveUserProductsResponse(bool? IsSuccess = default(bool?), string UserEmail = default(string), Guid? UserId = default(Guid?), Dictionary<string, string> UserProductResults = default(Dictionary<string, string>))
        {
            // to ensure "IsSuccess" is required (not null)
            if (IsSuccess == null)
            {
                throw new InvalidDataException("IsSuccess is a required property for RemoveUserProductsResponse and cannot be null");
            }
            else
            {
                this.IsSuccess = IsSuccess;
            }
            // to ensure "UserProductResults" is required (not null)
            if (UserProductResults == null)
            {
                throw new InvalidDataException("UserProductResults is a required property for RemoveUserProductsResponse and cannot be null");
            }
            else
            {
                this.UserProductResults = UserProductResults;
            }
            this.UserEmail = UserEmail;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Gets or Sets IsSuccess
        /// </summary>
        [DataMember(Name="is_success", EmitDefaultValue=false)]
        public bool? IsSuccess { get; set; }
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
        /// Gets or Sets UserProductResults
        /// </summary>
        [DataMember(Name="user_product_results", EmitDefaultValue=false)]
        public Dictionary<string, string> UserProductResults { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveUserProductsResponse {\n");
            sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProductResults: ").Append(UserProductResults).Append("\n");
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
            return this.Equals(obj as RemoveUserProductsResponse);
        }

        /// <summary>
        /// Returns true if RemoveUserProductsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RemoveUserProductsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveUserProductsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsSuccess == other.IsSuccess ||
                    this.IsSuccess != null &&
                    this.IsSuccess.Equals(other.IsSuccess)
                ) && 
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
                    this.UserProductResults == other.UserProductResults ||
                    this.UserProductResults != null &&
                    this.UserProductResults.SequenceEqual(other.UserProductResults)
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
                if (this.IsSuccess != null)
                    hash = hash * 59 + this.IsSuccess.GetHashCode();
                if (this.UserEmail != null)
                    hash = hash * 59 + this.UserEmail.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserProductResults != null)
                    hash = hash * 59 + this.UserProductResults.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
