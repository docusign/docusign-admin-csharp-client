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
    /// NewUserResponse
    /// </summary>
    [DataContract]
    public partial class NewUserResponse :  IEquatable<NewUserResponse>, IValidatableObject
    {
        public NewUserResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Email">Email.</param>
        /// <param name="LanguageCulture">LanguageCulture.</param>
        /// <param name="FederatedStatus">FederatedStatus.</param>
        /// <param name="Accounts">Accounts.</param>
        public NewUserResponse(Guid? Id = default(Guid?), int? SiteId = default(int?), string UserName = default(string), string FirstName = default(string), string LastName = default(string), string Email = default(string), string LanguageCulture = default(string), string FederatedStatus = default(string), List<NewUserResponseAccountProperties> Accounts = default(List<NewUserResponseAccountProperties>))
        {
            this.Id = Id;
            this.SiteId = SiteId;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.LanguageCulture = LanguageCulture;
            this.FederatedStatus = FederatedStatus;
            this.Accounts = Accounts;
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
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets LanguageCulture
        /// </summary>
        [DataMember(Name="language_culture", EmitDefaultValue=false)]
        public string LanguageCulture { get; set; }
        /// <summary>
        /// Gets or Sets FederatedStatus
        /// </summary>
        [DataMember(Name="federated_status", EmitDefaultValue=false)]
        public string FederatedStatus { get; set; }
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<NewUserResponseAccountProperties> Accounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUserResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LanguageCulture: ").Append(LanguageCulture).Append("\n");
            sb.Append("  FederatedStatus: ").Append(FederatedStatus).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(obj as NewUserResponse);
        }

        /// <summary>
        /// Returns true if NewUserResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NewUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUserResponse other)
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
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.LanguageCulture == other.LanguageCulture ||
                    this.LanguageCulture != null &&
                    this.LanguageCulture.Equals(other.LanguageCulture)
                ) && 
                (
                    this.FederatedStatus == other.FederatedStatus ||
                    this.FederatedStatus != null &&
                    this.FederatedStatus.Equals(other.FederatedStatus)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
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
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.LanguageCulture != null)
                    hash = hash * 59 + this.LanguageCulture.GetHashCode();
                if (this.FederatedStatus != null)
                    hash = hash * 59 + this.FederatedStatus.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
