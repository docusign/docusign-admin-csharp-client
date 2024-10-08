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
    /// AssetGroupAccountCloneTargetAccount
    /// </summary>
    [DataContract]
    public partial class AssetGroupAccountCloneTargetAccount :  IEquatable<AssetGroupAccountCloneTargetAccount>, IValidatableObject
    {
        public AssetGroupAccountCloneTargetAccount()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupAccountCloneTargetAccount" /> class.
        /// </summary>
        /// <param name="Id">The target account id to clone to. It will be empty Guid if account not yet created..</param>
        /// <param name="Name">The name of the target account..</param>
        /// <param name="Region">The region where the target account is in..</param>
        /// <param name="CountryCode">The country code where the target account is in. This value is ignored if region is provided..</param>
        /// <param name="Site">The site where the target account is on..</param>
        /// <param name="Admin">The admin user for the target account..</param>
        public AssetGroupAccountCloneTargetAccount(Guid? Id = default(Guid?), string Name = default(string), string Region = default(string), string CountryCode = default(string), string Site = default(string), AssetGroupAccountCloneTargetAccountAdmin Admin = default(AssetGroupAccountCloneTargetAccountAdmin))
        {
            this.Id = Id;
            this.Name = Name;
            this.Region = Region;
            this.CountryCode = CountryCode;
            this.Site = Site;
            this.Admin = Admin;
        }
        
        /// <summary>
        /// The target account id to clone to. It will be empty Guid if account not yet created.
        /// </summary>
        /// <value>The target account id to clone to. It will be empty Guid if account not yet created.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// The name of the target account.
        /// </summary>
        /// <value>The name of the target account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The region where the target account is in.
        /// </summary>
        /// <value>The region where the target account is in.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        /// <summary>
        /// The country code where the target account is in. This value is ignored if region is provided.
        /// </summary>
        /// <value>The country code where the target account is in. This value is ignored if region is provided.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// The site where the target account is on.
        /// </summary>
        /// <value>The site where the target account is on.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public string Site { get; set; }
        /// <summary>
        /// The admin user for the target account.
        /// </summary>
        /// <value>The admin user for the target account.</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public AssetGroupAccountCloneTargetAccountAdmin Admin { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetGroupAccountCloneTargetAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
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
            return this.Equals(obj as AssetGroupAccountCloneTargetAccount);
        }

        /// <summary>
        /// Returns true if AssetGroupAccountCloneTargetAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetGroupAccountCloneTargetAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetGroupAccountCloneTargetAccount other)
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
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) && 
                (
                    this.Admin == other.Admin ||
                    this.Admin != null &&
                    this.Admin.Equals(other.Admin)
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
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                if (this.Admin != null)
                    hash = hash * 59 + this.Admin.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
