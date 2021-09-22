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
    /// IdentityProviderResponse
    /// </summary>
    [DataContract]
    public partial class IdentityProviderResponse :  IEquatable<IdentityProviderResponse>, IValidatableObject
    {
        public IdentityProviderResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="FriendlyName">FriendlyName.</param>
        /// <param name="AutoProvisionUsers">AutoProvisionUsers.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Saml20">Saml20.</param>
        /// <param name="Links">Links.</param>
        public IdentityProviderResponse(Guid? Id = default(Guid?), string FriendlyName = default(string), bool? AutoProvisionUsers = default(bool?), string Type = default(string), Saml2IdentityProviderResponse Saml20 = default(Saml2IdentityProviderResponse), List<LinkResponse> Links = default(List<LinkResponse>))
        {
            this.Id = Id;
            this.FriendlyName = FriendlyName;
            this.AutoProvisionUsers = AutoProvisionUsers;
            this.Type = Type;
            this.Saml20 = Saml20;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets FriendlyName
        /// </summary>
        [DataMember(Name="friendly_name", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }
        /// <summary>
        /// Gets or Sets AutoProvisionUsers
        /// </summary>
        [DataMember(Name="auto_provision_users", EmitDefaultValue=false)]
        public bool? AutoProvisionUsers { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Saml20
        /// </summary>
        [DataMember(Name="saml_20", EmitDefaultValue=false)]
        public Saml2IdentityProviderResponse Saml20 { get; set; }
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
            sb.Append("class IdentityProviderResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  AutoProvisionUsers: ").Append(AutoProvisionUsers).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Saml20: ").Append(Saml20).Append("\n");
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
            return this.Equals(obj as IdentityProviderResponse);
        }

        /// <summary>
        /// Returns true if IdentityProviderResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityProviderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderResponse other)
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
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) && 
                (
                    this.AutoProvisionUsers == other.AutoProvisionUsers ||
                    this.AutoProvisionUsers != null &&
                    this.AutoProvisionUsers.Equals(other.AutoProvisionUsers)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Saml20 == other.Saml20 ||
                    this.Saml20 != null &&
                    this.Saml20.Equals(other.Saml20)
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
                if (this.FriendlyName != null)
                    hash = hash * 59 + this.FriendlyName.GetHashCode();
                if (this.AutoProvisionUsers != null)
                    hash = hash * 59 + this.AutoProvisionUsers.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Saml20 != null)
                    hash = hash * 59 + this.Saml20.GetHashCode();
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
