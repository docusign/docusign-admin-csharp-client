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
    /// ProductPermissionProfilesRequest
    /// </summary>
    [DataContract]
    public partial class ProductPermissionProfilesRequest :  IEquatable<ProductPermissionProfilesRequest>, IValidatableObject
    {
        public ProductPermissionProfilesRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPermissionProfilesRequest" /> class.
        /// </summary>
        /// <param name="ProductPermissionProfiles">ProductPermissionProfiles (required).</param>
        public ProductPermissionProfilesRequest(List<ProductPermissionProfileRequest> ProductPermissionProfiles = default(List<ProductPermissionProfileRequest>))
        {
            // to ensure "ProductPermissionProfiles" is required (not null)
            if (ProductPermissionProfiles == null)
            {
                throw new InvalidDataException("ProductPermissionProfiles is a required property for ProductPermissionProfilesRequest and cannot be null");
            }
            else
            {
                this.ProductPermissionProfiles = ProductPermissionProfiles;
            }
        }
        
        /// <summary>
        /// Gets or Sets ProductPermissionProfiles
        /// </summary>
        [DataMember(Name="product_permission_profiles", EmitDefaultValue=false)]
        public List<ProductPermissionProfileRequest> ProductPermissionProfiles { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPermissionProfilesRequest {\n");
            sb.Append("  ProductPermissionProfiles: ").Append(ProductPermissionProfiles).Append("\n");
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
            return this.Equals(obj as ProductPermissionProfilesRequest);
        }

        /// <summary>
        /// Returns true if ProductPermissionProfilesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPermissionProfilesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPermissionProfilesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductPermissionProfiles == other.ProductPermissionProfiles ||
                    this.ProductPermissionProfiles != null &&
                    this.ProductPermissionProfiles.SequenceEqual(other.ProductPermissionProfiles)
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
                if (this.ProductPermissionProfiles != null)
                    hash = hash * 59 + this.ProductPermissionProfiles.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
