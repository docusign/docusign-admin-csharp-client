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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// AddUserResponseAccountProperties
    /// </summary>
    [DataContract]
    public partial class AddUserResponseAccountProperties :  IEquatable<AddUserResponseAccountProperties>, IValidatableObject
    {
        public AddUserResponseAccountProperties()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserResponseAccountProperties" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="JobTitle">JobTitle.</param>
        public AddUserResponseAccountProperties(Guid? Id = default(Guid?), int? SiteId = default(int?), string CompanyName = default(string), string JobTitle = default(string))
        {
            this.Id = Id;
            this.SiteId = SiteId;
            this.CompanyName = CompanyName;
            this.JobTitle = JobTitle;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name="site_id", EmitDefaultValue=false)]
        public int? SiteId { get; set; }
        /// <summary>
        /// Gets or Sets ProductPermissionProfiles
        /// </summary>
        [DataMember(Name="product_permission_profiles", EmitDefaultValue=false)]
        public List<ProductPermissionProfileResponse> ProductPermissionProfiles { get; private set; }
        /// <summary>
        /// Gets or Sets DsGroups
        /// </summary>
        [DataMember(Name="ds_groups", EmitDefaultValue=false)]
        public List<DSGroupResponse> DsGroups { get; private set; }
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
            sb.Append("class AddUserResponseAccountProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  ProductPermissionProfiles: ").Append(ProductPermissionProfiles).Append("\n");
            sb.Append("  DsGroups: ").Append(DsGroups).Append("\n");
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
            return this.Equals(obj as AddUserResponseAccountProperties);
        }

        /// <summary>
        /// Returns true if AddUserResponseAccountProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of AddUserResponseAccountProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserResponseAccountProperties other)
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
                    this.SiteId == other.SiteId ||
                    this.SiteId != null &&
                    this.SiteId.Equals(other.SiteId)
                ) && 
                (
                    this.ProductPermissionProfiles == other.ProductPermissionProfiles ||
                    this.ProductPermissionProfiles != null &&
                    this.ProductPermissionProfiles.SequenceEqual(other.ProductPermissionProfiles)
                ) && 
                (
                    this.DsGroups == other.DsGroups ||
                    this.DsGroups != null &&
                    this.DsGroups.SequenceEqual(other.DsGroups)
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
                if (this.SiteId != null)
                    hash = hash * 59 + this.SiteId.GetHashCode();
                if (this.ProductPermissionProfiles != null)
                    hash = hash * 59 + this.ProductPermissionProfiles.GetHashCode();
                if (this.DsGroups != null)
                    hash = hash * 59 + this.DsGroups.GetHashCode();
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
