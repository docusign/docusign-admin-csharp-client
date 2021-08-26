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
    /// NewUserRequest
    /// </summary>
    [DataContract]
    public partial class NewUserRequest :  IEquatable<NewUserRequest>, IValidatableObject
    {
        public NewUserRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequest" /> class.
        /// </summary>
        /// <param name="Accounts">Accounts (required).</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="DefaultAccountId">DefaultAccountId.</param>
        /// <param name="LanguageCulture">LanguageCulture.</param>
        /// <param name="SelectedLanguages">SelectedLanguages.</param>
        /// <param name="AccessCode">AccessCode.</param>
        /// <param name="FederatedStatus">FederatedStatus.</param>
        /// <param name="AutoActivateMemberships">AutoActivateMemberships.</param>
        public NewUserRequest(List<NewUserRequestAccountProperties> Accounts = default(List<NewUserRequestAccountProperties>), string UserName = default(string), string FirstName = default(string), string LastName = default(string), string Email = default(string), Guid? DefaultAccountId = default(Guid?), string LanguageCulture = default(string), string SelectedLanguages = default(string), string AccessCode = default(string), string FederatedStatus = default(string), bool? AutoActivateMemberships = default(bool?))
        {
            // to ensure "Accounts" is required (not null)
            if (Accounts == null)
            {
                throw new InvalidDataException("Accounts is a required property for NewUserRequest and cannot be null");
            }
            else
            {
                this.Accounts = Accounts;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for NewUserRequest and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DefaultAccountId = DefaultAccountId;
            this.LanguageCulture = LanguageCulture;
            this.SelectedLanguages = SelectedLanguages;
            this.AccessCode = AccessCode;
            this.FederatedStatus = FederatedStatus;
            this.AutoActivateMemberships = AutoActivateMemberships;
        }
        
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<NewUserRequestAccountProperties> Accounts { get; set; }
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
        /// Gets or Sets DefaultAccountId
        /// </summary>
        [DataMember(Name="default_account_id", EmitDefaultValue=false)]
        public Guid? DefaultAccountId { get; set; }
        /// <summary>
        /// Gets or Sets LanguageCulture
        /// </summary>
        [DataMember(Name="language_culture", EmitDefaultValue=false)]
        public string LanguageCulture { get; set; }
        /// <summary>
        /// Gets or Sets SelectedLanguages
        /// </summary>
        [DataMember(Name="selected_languages", EmitDefaultValue=false)]
        public string SelectedLanguages { get; set; }
        /// <summary>
        /// Gets or Sets AccessCode
        /// </summary>
        [DataMember(Name="access_code", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Gets or Sets FederatedStatus
        /// </summary>
        [DataMember(Name="federated_status", EmitDefaultValue=false)]
        public string FederatedStatus { get; set; }
        /// <summary>
        /// Gets or Sets AutoActivateMemberships
        /// </summary>
        [DataMember(Name="auto_activate_memberships", EmitDefaultValue=false)]
        public bool? AutoActivateMemberships { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUserRequest {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DefaultAccountId: ").Append(DefaultAccountId).Append("\n");
            sb.Append("  LanguageCulture: ").Append(LanguageCulture).Append("\n");
            sb.Append("  SelectedLanguages: ").Append(SelectedLanguages).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  FederatedStatus: ").Append(FederatedStatus).Append("\n");
            sb.Append("  AutoActivateMemberships: ").Append(AutoActivateMemberships).Append("\n");
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
            return this.Equals(obj as NewUserRequest);
        }

        /// <summary>
        /// Returns true if NewUserRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NewUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUserRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
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
                    this.DefaultAccountId == other.DefaultAccountId ||
                    this.DefaultAccountId != null &&
                    this.DefaultAccountId.Equals(other.DefaultAccountId)
                ) && 
                (
                    this.LanguageCulture == other.LanguageCulture ||
                    this.LanguageCulture != null &&
                    this.LanguageCulture.Equals(other.LanguageCulture)
                ) && 
                (
                    this.SelectedLanguages == other.SelectedLanguages ||
                    this.SelectedLanguages != null &&
                    this.SelectedLanguages.Equals(other.SelectedLanguages)
                ) && 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.FederatedStatus == other.FederatedStatus ||
                    this.FederatedStatus != null &&
                    this.FederatedStatus.Equals(other.FederatedStatus)
                ) && 
                (
                    this.AutoActivateMemberships == other.AutoActivateMemberships ||
                    this.AutoActivateMemberships != null &&
                    this.AutoActivateMemberships.Equals(other.AutoActivateMemberships)
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
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.DefaultAccountId != null)
                    hash = hash * 59 + this.DefaultAccountId.GetHashCode();
                if (this.LanguageCulture != null)
                    hash = hash * 59 + this.LanguageCulture.GetHashCode();
                if (this.SelectedLanguages != null)
                    hash = hash * 59 + this.SelectedLanguages.GetHashCode();
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                if (this.FederatedStatus != null)
                    hash = hash * 59 + this.FederatedStatus.GetHashCode();
                if (this.AutoActivateMemberships != null)
                    hash = hash * 59 + this.AutoActivateMemberships.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
