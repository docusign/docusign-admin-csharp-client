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
    /// IndividualUserDataRedactionRequest
    /// </summary>
    [DataContract]
    public partial class IndividualUserDataRedactionRequest :  IEquatable<IndividualUserDataRedactionRequest>, IValidatableObject
    {
        public IndividualUserDataRedactionRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualUserDataRedactionRequest" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Memberships">Memberships.</param>
        public IndividualUserDataRedactionRequest(Guid? UserId = default(Guid?), List<MembershipDataRedactionRequest> Memberships = default(List<MembershipDataRedactionRequest>))
        {
            this.UserId = UserId;
            this.Memberships = Memberships;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Memberships
        /// </summary>
        [DataMember(Name="memberships", EmitDefaultValue=false)]
        public List<MembershipDataRedactionRequest> Memberships { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndividualUserDataRedactionRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
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
            return this.Equals(obj as IndividualUserDataRedactionRequest);
        }

        /// <summary>
        /// Returns true if IndividualUserDataRedactionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IndividualUserDataRedactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndividualUserDataRedactionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Memberships == other.Memberships ||
                    this.Memberships != null &&
                    this.Memberships.SequenceEqual(other.Memberships)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Memberships != null)
                    hash = hash * 59 + this.Memberships.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}