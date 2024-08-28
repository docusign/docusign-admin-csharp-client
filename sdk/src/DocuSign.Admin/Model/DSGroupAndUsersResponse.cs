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
    /// DSGroupAndUsersResponse
    /// </summary>
    [DataContract]
    public partial class DSGroupAndUsersResponse :  IEquatable<DSGroupAndUsersResponse>, IValidatableObject
    {
        public DSGroupAndUsersResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSGroupAndUsersResponse" /> class.
        /// </summary>
        /// <param name="Group">Group.</param>
        /// <param name="GroupUsers">GroupUsers.</param>
        public DSGroupAndUsersResponse(DSGroupResponse Group = default(DSGroupResponse), DSGroupUsersResponse GroupUsers = default(DSGroupUsersResponse))
        {
            this.Group = Group;
            this.GroupUsers = GroupUsers;
        }
        
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public DSGroupResponse Group { get; set; }
        /// <summary>
        /// Gets or Sets GroupUsers
        /// </summary>
        [DataMember(Name="group_users", EmitDefaultValue=false)]
        public DSGroupUsersResponse GroupUsers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSGroupAndUsersResponse {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  GroupUsers: ").Append(GroupUsers).Append("\n");
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
            return this.Equals(obj as DSGroupAndUsersResponse);
        }

        /// <summary>
        /// Returns true if DSGroupAndUsersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DSGroupAndUsersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSGroupAndUsersResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.GroupUsers == other.GroupUsers ||
                    this.GroupUsers != null &&
                    this.GroupUsers.Equals(other.GroupUsers)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.GroupUsers != null)
                    hash = hash * 59 + this.GroupUsers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
