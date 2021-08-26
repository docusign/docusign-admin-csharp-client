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
    /// AddDSGroupUsersResponse
    /// </summary>
    [DataContract]
    public partial class AddDSGroupUsersResponse :  IEquatable<AddDSGroupUsersResponse>, IValidatableObject
    {
        public AddDSGroupUsersResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDSGroupUsersResponse" /> class.
        /// </summary>
        /// <param name="IsSuccess">IsSuccess.</param>
        /// <param name="TotalCount">TotalCount.</param>
        /// <param name="Users">Users.</param>
        public AddDSGroupUsersResponse(bool? IsSuccess = default(bool?), int? TotalCount = default(int?), List<DSGroupUserResponse> Users = default(List<DSGroupUserResponse>))
        {
            this.IsSuccess = IsSuccess;
            this.TotalCount = TotalCount;
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets IsSuccess
        /// </summary>
        [DataMember(Name="is_success", EmitDefaultValue=false)]
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="TotalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<DSGroupUserResponse> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDSGroupUsersResponse {\n");
            sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as AddDSGroupUsersResponse);
        }

        /// <summary>
        /// Returns true if AddDSGroupUsersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AddDSGroupUsersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddDSGroupUsersResponse other)
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
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
