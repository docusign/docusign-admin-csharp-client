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
    /// OrganizationExportRequest
    /// </summary>
    [DataContract]
    public partial class OrganizationExportRequest :  IEquatable<OrganizationExportRequest>, IValidatableObject
    {
        public OrganizationExportRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationExportRequest" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Accounts">Accounts.</param>
        /// <param name="Domains">Domains.</param>
        public OrganizationExportRequest(string Type = default(string), List<OrganizationExportAccount> Accounts = default(List<OrganizationExportAccount>), List<OrganizationExportDomain> Domains = default(List<OrganizationExportDomain>))
        {
            this.Type = Type;
            this.Accounts = Accounts;
            this.Domains = Domains;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<OrganizationExportAccount> Accounts { get; set; }
        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name="domains", EmitDefaultValue=false)]
        public List<OrganizationExportDomain> Domains { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationExportRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
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
            return this.Equals(obj as OrganizationExportRequest);
        }

        /// <summary>
        /// Returns true if OrganizationExportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationExportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationExportRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
                ) && 
                (
                    this.Domains == other.Domains ||
                    this.Domains != null &&
                    this.Domains.SequenceEqual(other.Domains)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                if (this.Domains != null)
                    hash = hash * 59 + this.Domains.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
