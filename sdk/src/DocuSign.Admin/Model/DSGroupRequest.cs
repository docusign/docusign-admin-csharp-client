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
    /// DSGroupRequest
    /// </summary>
    [DataContract]
    public partial class DSGroupRequest :  IEquatable<DSGroupRequest>, IValidatableObject
    {
        public DSGroupRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSGroupRequest" /> class.
        /// </summary>
        /// <param name="DsGroupId">DsGroupId (required).</param>
        public DSGroupRequest(Guid? DsGroupId = default(Guid?))
        {
            // to ensure "DsGroupId" is required (not null)
            if (DsGroupId == null)
            {
                throw new InvalidDataException("DsGroupId is a required property for DSGroupRequest and cannot be null");
            }
            else
            {
                this.DsGroupId = DsGroupId;
            }
        }
        
        /// <summary>
        /// Gets or Sets DsGroupId
        /// </summary>
        [DataMember(Name="ds_group_id", EmitDefaultValue=false)]
        public Guid? DsGroupId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSGroupRequest {\n");
            sb.Append("  DsGroupId: ").Append(DsGroupId).Append("\n");
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
            return this.Equals(obj as DSGroupRequest);
        }

        /// <summary>
        /// Returns true if DSGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DSGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DsGroupId == other.DsGroupId ||
                    this.DsGroupId != null &&
                    this.DsGroupId.Equals(other.DsGroupId)
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
                if (this.DsGroupId != null)
                    hash = hash * 59 + this.DsGroupId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
