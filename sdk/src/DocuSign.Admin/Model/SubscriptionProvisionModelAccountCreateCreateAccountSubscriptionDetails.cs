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
    /// SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails
    /// </summary>
    [DataContract]
    public partial class SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails :  IEquatable<SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails>, IValidatableObject
    {
        public SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails" /> class.
        /// </summary>
        /// <param name="SubscriptionId">SubscriptionId.</param>
        /// <param name="PlanId">PlanId.</param>
        /// <param name="Modules">Modules.</param>
        public SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails(string SubscriptionId = default(string), Guid? PlanId = default(Guid?), List<Guid?> Modules = default(List<Guid?>))
        {
            this.SubscriptionId = SubscriptionId;
            this.PlanId = PlanId;
            this.Modules = Modules;
        }
        
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="PlanId", EmitDefaultValue=false)]
        public Guid? PlanId { get; set; }
        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name="Modules", EmitDefaultValue=false)]
        public List<Guid?> Modules { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
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
            return this.Equals(obj as SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails);
        }

        /// <summary>
        /// Returns true if SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProvisionModelAccountCreateCreateAccountSubscriptionDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubscriptionId == other.SubscriptionId ||
                    this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(other.SubscriptionId)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.Modules == other.Modules ||
                    this.Modules != null &&
                    this.Modules.SequenceEqual(other.Modules)
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
                if (this.SubscriptionId != null)
                    hash = hash * 59 + this.SubscriptionId.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.Modules != null)
                    hash = hash * 59 + this.Modules.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}