/* 
 * DocuSign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
 *
 * OpenAPI spec version: v2
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
    /// UserProductPermissionProfilesResponse
    /// </summary>
    [DataContract]
    public partial class UserProductPermissionProfilesResponse :  IEquatable<UserProductPermissionProfilesResponse>, IValidatableObject
    {
        public UserProductPermissionProfilesResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductPermissionProfilesResponse" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="ProductPermissionProfiles">ProductPermissionProfiles.</param>
        public UserProductPermissionProfilesResponse(Guid? UserId = default(Guid?), Guid? AccountId = default(Guid?), List<ProductPermissionProfileResponse> ProductPermissionProfiles = default(List<ProductPermissionProfileResponse>))
        {
            this.UserId = UserId;
            this.AccountId = AccountId;
            this.ProductPermissionProfiles = ProductPermissionProfiles;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public Guid? AccountId { get; set; }
        /// <summary>
        /// Gets or Sets ProductPermissionProfiles
        /// </summary>
        [DataMember(Name="product_permission_profiles", EmitDefaultValue=false)]
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProductPermissionProfilesResponse {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ProductPermissionProfiles: ").Append(ProductPermissionProfiles).Append("\n");
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
            return this.Equals(obj as UserProductPermissionProfilesResponse);
        }

        /// <summary>
        /// Returns true if UserProductPermissionProfilesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserProductPermissionProfilesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProductPermissionProfilesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.ProductPermissionProfiles == other.ProductPermissionProfiles ||
                    this.ProductPermissionProfiles != null &&
                    this.ProductPermissionProfiles.SequenceEqual(other.ProductPermissionProfiles)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ProductPermissionProfiles != null)
                    hash = hash * 59 + this.ProductPermissionProfiles.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}