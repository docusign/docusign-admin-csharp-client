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
    /// OrganizationResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationResponse :  IEquatable<OrganizationResponse>, IValidatableObject
    {
        public OrganizationResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DefaultAccountId">DefaultAccountId.</param>
        /// <param name="DefaultPermissionProfileId">DefaultPermissionProfileId.</param>
        /// <param name="CreatedOn">CreatedOn.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="LastModifiedOn">LastModifiedOn.</param>
        /// <param name="LastModifiedBy">LastModifiedBy.</param>
        /// <param name="Accounts">Accounts.</param>
        /// <param name="Users">Users.</param>
        /// <param name="ReservedDomains">ReservedDomains.</param>
        /// <param name="IdentityProviders">IdentityProviders.</param>
        /// <param name="Links">Links.</param>
        public OrganizationResponse(Guid? Id = default(Guid?), string Name = default(string), string Description = default(string), Guid? DefaultAccountId = default(Guid?), long? DefaultPermissionProfileId = default(long?), DateTime CreatedOn = default(DateTime), Guid? CreatedBy = default(Guid?), DateTime LastModifiedOn = default(DateTime), Guid? LastModifiedBy = default(Guid?), List<OrganizationAccountResponse> Accounts = default(List<OrganizationAccountResponse>), List<OrganizationSimpleIdObject> Users = default(List<OrganizationSimpleIdObject>), List<DomainResponse> ReservedDomains = default(List<DomainResponse>), List<IdentityProvidersResponse> IdentityProviders = default(List<IdentityProvidersResponse>), List<LinkResponse> Links = default(List<LinkResponse>))
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.DefaultAccountId = DefaultAccountId;
            this.DefaultPermissionProfileId = DefaultPermissionProfileId;
            this.CreatedOn = CreatedOn;
            this.CreatedBy = CreatedBy;
            this.LastModifiedOn = LastModifiedOn;
            this.LastModifiedBy = LastModifiedBy;
            this.Accounts = Accounts;
            this.Users = Users;
            this.ReservedDomains = ReservedDomains;
            this.IdentityProviders = IdentityProviders;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DefaultAccountId
        /// </summary>
        [DataMember(Name="default_account_id", EmitDefaultValue=false)]
        public Guid? DefaultAccountId { get; set; }
        /// <summary>
        /// Gets or Sets DefaultPermissionProfileId
        /// </summary>
        [DataMember(Name="default_permission_profile_id", EmitDefaultValue=false)]
        public long? DefaultPermissionProfileId { get; set; }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public Guid? CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedOn
        /// </summary>
        [DataMember(Name="last_modified_on", EmitDefaultValue=false)]
        public DateTime LastModifiedOn { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="last_modified_by", EmitDefaultValue=false)]
        public Guid? LastModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<OrganizationAccountResponse> Accounts { get; set; }
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<OrganizationSimpleIdObject> Users { get; set; }
        /// <summary>
        /// Gets or Sets ReservedDomains
        /// </summary>
        [DataMember(Name="reserved_domains", EmitDefaultValue=false)]
        public List<DomainResponse> ReservedDomains { get; set; }
        /// <summary>
        /// Gets or Sets IdentityProviders
        /// </summary>
        [DataMember(Name="identity_providers", EmitDefaultValue=false)]
        public List<IdentityProvidersResponse> IdentityProviders { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<LinkResponse> Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultAccountId: ").Append(DefaultAccountId).Append("\n");
            sb.Append("  DefaultPermissionProfileId: ").Append(DefaultPermissionProfileId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  ReservedDomains: ").Append(ReservedDomains).Append("\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as OrganizationResponse);
        }

        /// <summary>
        /// Returns true if OrganizationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationResponse other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DefaultAccountId == other.DefaultAccountId ||
                    this.DefaultAccountId != null &&
                    this.DefaultAccountId.Equals(other.DefaultAccountId)
                ) && 
                (
                    this.DefaultPermissionProfileId == other.DefaultPermissionProfileId ||
                    this.DefaultPermissionProfileId != null &&
                    this.DefaultPermissionProfileId.Equals(other.DefaultPermissionProfileId)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.LastModifiedOn == other.LastModifiedOn ||
                    this.LastModifiedOn != null &&
                    this.LastModifiedOn.Equals(other.LastModifiedOn)
                ) && 
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.ReservedDomains == other.ReservedDomains ||
                    this.ReservedDomains != null &&
                    this.ReservedDomains.SequenceEqual(other.ReservedDomains)
                ) && 
                (
                    this.IdentityProviders == other.IdentityProviders ||
                    this.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(other.IdentityProviders)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DefaultAccountId != null)
                    hash = hash * 59 + this.DefaultAccountId.GetHashCode();
                if (this.DefaultPermissionProfileId != null)
                    hash = hash * 59 + this.DefaultPermissionProfileId.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModifiedOn != null)
                    hash = hash * 59 + this.LastModifiedOn.GetHashCode();
                if (this.LastModifiedBy != null)
                    hash = hash * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.ReservedDomains != null)
                    hash = hash * 59 + this.ReservedDomains.GetHashCode();
                if (this.IdentityProviders != null)
                    hash = hash * 59 + this.IdentityProviders.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
