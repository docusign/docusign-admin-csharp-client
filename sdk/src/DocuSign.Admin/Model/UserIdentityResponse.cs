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
    /// UserIdentityResponse
    /// </summary>
    [DataContract]
    public partial class UserIdentityResponse :  IEquatable<UserIdentityResponse>, IValidatableObject
    {
        public UserIdentityResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ProviderId">ProviderId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="ImmutableId">ImmutableId.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        public UserIdentityResponse(Guid? Id = default(Guid?), Guid? ProviderId = default(Guid?), Guid? UserId = default(Guid?), string ImmutableId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails))
        {
            this.Id = Id;
            this.ProviderId = ProviderId;
            this.UserId = UserId;
            this.ImmutableId = ImmutableId;
            this.ErrorDetails = ErrorDetails;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name="provider_id", EmitDefaultValue=false)]
        public Guid? ProviderId { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }
        /// <summary>
        /// Gets or Sets ImmutableId
        /// </summary>
        [DataMember(Name="immutable_id", EmitDefaultValue=false)]
        public string ImmutableId { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="error_details", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentityResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ImmutableId: ").Append(ImmutableId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
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
            return this.Equals(obj as UserIdentityResponse);
        }

        /// <summary>
        /// Returns true if UserIdentityResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserIdentityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentityResponse other)
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
                    this.ProviderId == other.ProviderId ||
                    this.ProviderId != null &&
                    this.ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ImmutableId == other.ImmutableId ||
                    this.ImmutableId != null &&
                    this.ImmutableId.Equals(other.ImmutableId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                if (this.ProviderId != null)
                    hash = hash * 59 + this.ProviderId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ImmutableId != null)
                    hash = hash * 59 + this.ImmutableId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
