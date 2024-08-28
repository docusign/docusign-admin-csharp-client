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
    /// AssetGroupAccountsResponse
    /// </summary>
    [DataContract]
    public partial class AssetGroupAccountsResponse :  IEquatable<AssetGroupAccountsResponse>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupAccountsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AssetGroupAccountsResponse()
        {
        }
        
        /// <summary>
        /// The list of asset group accounts.
        /// </summary>
        /// <value>The list of asset group accounts.</value>
        [DataMember(Name="assetGroupAccounts", EmitDefaultValue=false)]
        public List<AssetGroupAccountResponse> AssetGroupAccounts { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetGroupAccountsResponse {\n");
            sb.Append("  AssetGroupAccounts: ").Append(AssetGroupAccounts).Append("\n");
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
            return this.Equals(obj as AssetGroupAccountsResponse);
        }

        /// <summary>
        /// Returns true if AssetGroupAccountsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetGroupAccountsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetGroupAccountsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssetGroupAccounts == other.AssetGroupAccounts ||
                    this.AssetGroupAccounts != null &&
                    this.AssetGroupAccounts.SequenceEqual(other.AssetGroupAccounts)
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
                if (this.AssetGroupAccounts != null)
                    hash = hash * 59 + this.AssetGroupAccounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
