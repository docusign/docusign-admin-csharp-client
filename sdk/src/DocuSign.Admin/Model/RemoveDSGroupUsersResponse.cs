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
    /// RemoveDSGroupUsersResponse
    /// </summary>
    [DataContract]
    public partial class RemoveDSGroupUsersResponse :  IEquatable<RemoveDSGroupUsersResponse>, IValidatableObject
    {
        public RemoveDSGroupUsersResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDSGroupUsersResponse" /> class.
        /// </summary>
        /// <param name="IsSuccess">IsSuccess.</param>
        /// <param name="FailedUsers">FailedUsers.</param>
        public RemoveDSGroupUsersResponse(bool? IsSuccess = default(bool?), List<DSGroupUserResponse> FailedUsers = default(List<DSGroupUserResponse>))
        {
            this.IsSuccess = IsSuccess;
            this.FailedUsers = FailedUsers;
        }
        
        /// <summary>
        /// Gets or Sets IsSuccess
        /// </summary>
        [DataMember(Name="is_success", EmitDefaultValue=false)]
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// Gets or Sets FailedUsers
        /// </summary>
        [DataMember(Name="failed_users", EmitDefaultValue=false)]
        public List<DSGroupUserResponse> FailedUsers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveDSGroupUsersResponse {\n");
            sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  FailedUsers: ").Append(FailedUsers).Append("\n");
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
            return this.Equals(obj as RemoveDSGroupUsersResponse);
        }

        /// <summary>
        /// Returns true if RemoveDSGroupUsersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RemoveDSGroupUsersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveDSGroupUsersResponse other)
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
                    this.FailedUsers == other.FailedUsers ||
                    this.FailedUsers != null &&
                    this.FailedUsers.SequenceEqual(other.FailedUsers)
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
                if (this.FailedUsers != null)
                    hash = hash * 59 + this.FailedUsers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
