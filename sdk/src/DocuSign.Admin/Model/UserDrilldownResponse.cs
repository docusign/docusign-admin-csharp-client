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
    /// UserDrilldownResponse
    /// </summary>
    [DataContract]
    public partial class UserDrilldownResponse :  IEquatable<UserDrilldownResponse>, IValidatableObject
    {
        public UserDrilldownResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDrilldownResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="SiteName">SiteName.</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="UserStatus">UserStatus.</param>
        /// <param name="DefaultAccountId">DefaultAccountId.</param>
        /// <param name="DefaultAccountName">DefaultAccountName.</param>
        /// <param name="LanguageCulture">LanguageCulture.</param>
        /// <param name="SelectedLanguages">SelectedLanguages.</param>
        /// <param name="FederatedStatus">FederatedStatus.</param>
        /// <param name="IsOrganizationAdmin">IsOrganizationAdmin.</param>
        /// <param name="CreatedOn">CreatedOn.</param>
        /// <param name="LastLogin">LastLogin.</param>
        /// <param name="Memberships">Memberships.</param>
        /// <param name="Identities">Identities.</param>
        /// <param name="DeviceVerificationEnabled">DeviceVerificationEnabled.</param>
        public UserDrilldownResponse(Guid? Id = default(Guid?), int? SiteId = default(int?), string SiteName = default(string), string UserName = default(string), string FirstName = default(string), string LastName = default(string), string UserStatus = default(string), Guid? DefaultAccountId = default(Guid?), string DefaultAccountName = default(string), string LanguageCulture = default(string), string SelectedLanguages = default(string), string FederatedStatus = default(string), bool? IsOrganizationAdmin = default(bool?), DateTime? CreatedOn = default(DateTime?), DateTime? LastLogin = default(DateTime?), List<MembershipResponse> Memberships = default(List<MembershipResponse>), List<UserIdentityResponse> Identities = default(List<UserIdentityResponse>), bool? DeviceVerificationEnabled = default(bool?))
        {
            this.Id = Id;
            this.SiteId = SiteId;
            this.SiteName = SiteName;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserStatus = UserStatus;
            this.DefaultAccountId = DefaultAccountId;
            this.DefaultAccountName = DefaultAccountName;
            this.LanguageCulture = LanguageCulture;
            this.SelectedLanguages = SelectedLanguages;
            this.FederatedStatus = FederatedStatus;
            this.IsOrganizationAdmin = IsOrganizationAdmin;
            this.CreatedOn = CreatedOn;
            this.LastLogin = LastLogin;
            this.Memberships = Memberships;
            this.Identities = Identities;
            this.DeviceVerificationEnabled = DeviceVerificationEnabled;
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
        /// Gets or Sets SiteName
        /// </summary>
        [DataMember(Name="site_name", EmitDefaultValue=false)]
        public string SiteName { get; set; }
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
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name="user_status", EmitDefaultValue=false)]
        public string UserStatus { get; set; }
        /// <summary>
        /// Gets or Sets DefaultAccountId
        /// </summary>
        [DataMember(Name="default_account_id", EmitDefaultValue=false)]
        public Guid? DefaultAccountId { get; set; }
        /// <summary>
        /// Gets or Sets DefaultAccountName
        /// </summary>
        [DataMember(Name="default_account_name", EmitDefaultValue=false)]
        public string DefaultAccountName { get; set; }
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
        /// Gets or Sets FederatedStatus
        /// </summary>
        [DataMember(Name="federated_status", EmitDefaultValue=false)]
        public string FederatedStatus { get; set; }
        /// <summary>
        /// Gets or Sets IsOrganizationAdmin
        /// </summary>
        [DataMember(Name="is_organization_admin", EmitDefaultValue=false)]
        public bool? IsOrganizationAdmin { get; set; }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=false)]
        public DateTime? LastLogin { get; set; }
        /// <summary>
        /// Gets or Sets Memberships
        /// </summary>
        [DataMember(Name="memberships", EmitDefaultValue=false)]
        public List<MembershipResponse> Memberships { get; set; }
        /// <summary>
        /// Gets or Sets Identities
        /// </summary>
        [DataMember(Name="identities", EmitDefaultValue=false)]
        public List<UserIdentityResponse> Identities { get; set; }
        /// <summary>
        /// Gets or Sets DeviceVerificationEnabled
        /// </summary>
        [DataMember(Name="device_verification_enabled", EmitDefaultValue=false)]
        public bool? DeviceVerificationEnabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDrilldownResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteName: ").Append(SiteName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  DefaultAccountId: ").Append(DefaultAccountId).Append("\n");
            sb.Append("  DefaultAccountName: ").Append(DefaultAccountName).Append("\n");
            sb.Append("  LanguageCulture: ").Append(LanguageCulture).Append("\n");
            sb.Append("  SelectedLanguages: ").Append(SelectedLanguages).Append("\n");
            sb.Append("  FederatedStatus: ").Append(FederatedStatus).Append("\n");
            sb.Append("  IsOrganizationAdmin: ").Append(IsOrganizationAdmin).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
            sb.Append("  DeviceVerificationEnabled: ").Append(DeviceVerificationEnabled).Append("\n");
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
            return this.Equals(obj as UserDrilldownResponse);
        }

        /// <summary>
        /// Returns true if UserDrilldownResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserDrilldownResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDrilldownResponse other)
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
                    this.SiteName == other.SiteName ||
                    this.SiteName != null &&
                    this.SiteName.Equals(other.SiteName)
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
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
                ) && 
                (
                    this.DefaultAccountId == other.DefaultAccountId ||
                    this.DefaultAccountId != null &&
                    this.DefaultAccountId.Equals(other.DefaultAccountId)
                ) && 
                (
                    this.DefaultAccountName == other.DefaultAccountName ||
                    this.DefaultAccountName != null &&
                    this.DefaultAccountName.Equals(other.DefaultAccountName)
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
                    this.FederatedStatus == other.FederatedStatus ||
                    this.FederatedStatus != null &&
                    this.FederatedStatus.Equals(other.FederatedStatus)
                ) && 
                (
                    this.IsOrganizationAdmin == other.IsOrganizationAdmin ||
                    this.IsOrganizationAdmin != null &&
                    this.IsOrganizationAdmin.Equals(other.IsOrganizationAdmin)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.LastLogin == other.LastLogin ||
                    this.LastLogin != null &&
                    this.LastLogin.Equals(other.LastLogin)
                ) && 
                (
                    this.Memberships == other.Memberships ||
                    this.Memberships != null &&
                    this.Memberships.SequenceEqual(other.Memberships)
                ) && 
                (
                    this.Identities == other.Identities ||
                    this.Identities != null &&
                    this.Identities.SequenceEqual(other.Identities)
                ) && 
                (
                    this.DeviceVerificationEnabled == other.DeviceVerificationEnabled ||
                    this.DeviceVerificationEnabled != null &&
                    this.DeviceVerificationEnabled.Equals(other.DeviceVerificationEnabled)
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
                if (this.SiteName != null)
                    hash = hash * 59 + this.SiteName.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.UserStatus != null)
                    hash = hash * 59 + this.UserStatus.GetHashCode();
                if (this.DefaultAccountId != null)
                    hash = hash * 59 + this.DefaultAccountId.GetHashCode();
                if (this.DefaultAccountName != null)
                    hash = hash * 59 + this.DefaultAccountName.GetHashCode();
                if (this.LanguageCulture != null)
                    hash = hash * 59 + this.LanguageCulture.GetHashCode();
                if (this.SelectedLanguages != null)
                    hash = hash * 59 + this.SelectedLanguages.GetHashCode();
                if (this.FederatedStatus != null)
                    hash = hash * 59 + this.FederatedStatus.GetHashCode();
                if (this.IsOrganizationAdmin != null)
                    hash = hash * 59 + this.IsOrganizationAdmin.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.LastLogin != null)
                    hash = hash * 59 + this.LastLogin.GetHashCode();
                if (this.Memberships != null)
                    hash = hash * 59 + this.Memberships.GetHashCode();
                if (this.Identities != null)
                    hash = hash * 59 + this.Identities.GetHashCode();
                if (this.DeviceVerificationEnabled != null)
                    hash = hash * 59 + this.DeviceVerificationEnabled.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
