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
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// NewUserRequestAccountProperties
    /// </summary>
    [DataContract]
    public partial class NewUserRequestAccountProperties :  IEquatable<NewUserRequestAccountProperties>, IValidatableObject
    {
        public NewUserRequestAccountProperties()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequestAccountProperties" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="PermissionProfile">PermissionProfile.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="JobTitle">JobTitle.</param>
        public NewUserRequestAccountProperties(Guid? Id = default(Guid?), PermissionProfileRequest PermissionProfile = default(PermissionProfileRequest), List<GroupRequest> Groups = default(List<GroupRequest>), string CompanyName = default(string), string JobTitle = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for NewUserRequestAccountProperties and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.PermissionProfile = PermissionProfile;
            this.Groups = Groups;
            this.CompanyName = CompanyName;
            this.JobTitle = JobTitle;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets PermissionProfile
        /// </summary>
        [DataMember(Name="permission_profile", EmitDefaultValue=false)]
        public PermissionProfileRequest PermissionProfile { get; set; }
        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<GroupRequest> Groups { get; set; }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUserRequestAccountProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PermissionProfile: ").Append(PermissionProfile).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
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
            return this.Equals(obj as NewUserRequestAccountProperties);
        }

        /// <summary>
        /// Returns true if NewUserRequestAccountProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of NewUserRequestAccountProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUserRequestAccountProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PermissionProfile == other.PermissionProfile ||
                    this.PermissionProfile != null &&
                    this.PermissionProfile.Equals(other.PermissionProfile)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PermissionProfile != null)
                    hash = hash * 59 + this.PermissionProfile.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
