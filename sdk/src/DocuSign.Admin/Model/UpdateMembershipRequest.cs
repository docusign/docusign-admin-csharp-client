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
    /// UpdateMembershipRequest
    /// </summary>
    [DataContract]
    public partial class UpdateMembershipRequest :  IEquatable<UpdateMembershipRequest>, IValidatableObject
    {
        public UpdateMembershipRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMembershipRequest" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="PermissionProfile">PermissionProfile.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="JobTitle">JobTitle.</param>
        /// <param name="SendActivation">SendActivation.</param>
        /// <param name="AccessCode">AccessCode.</param>
        public UpdateMembershipRequest(Guid? AccountId = default(Guid?), PermissionProfileRequest PermissionProfile = default(PermissionProfileRequest), List<GroupRequest> Groups = default(List<GroupRequest>), string CompanyName = default(string), string JobTitle = default(string), bool? SendActivation = default(bool?), string AccessCode = default(string))
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for UpdateMembershipRequest and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            this.PermissionProfile = PermissionProfile;
            this.Groups = Groups;
            this.CompanyName = CompanyName;
            this.JobTitle = JobTitle;
            this.SendActivation = SendActivation;
            this.AccessCode = AccessCode;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public Guid? AccountId { get; set; }
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
        /// Gets or Sets SendActivation
        /// </summary>
        [DataMember(Name="send_activation", EmitDefaultValue=false)]
        public bool? SendActivation { get; set; }
        /// <summary>
        /// Gets or Sets AccessCode
        /// </summary>
        [DataMember(Name="access_code", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMembershipRequest {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PermissionProfile: ").Append(PermissionProfile).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  SendActivation: ").Append(SendActivation).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
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
            return this.Equals(obj as UpdateMembershipRequest);
        }

        /// <summary>
        /// Returns true if UpdateMembershipRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateMembershipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMembershipRequest other)
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
                ) && 
                (
                    this.SendActivation == other.SendActivation ||
                    this.SendActivation != null &&
                    this.SendActivation.Equals(other.SendActivation)
                ) && 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
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
                if (this.PermissionProfile != null)
                    hash = hash * 59 + this.PermissionProfile.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                if (this.SendActivation != null)
                    hash = hash * 59 + this.SendActivation.GetHashCode();
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
