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
    /// OrganizationSalesforceAccountManagersResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationSalesforceAccountManagersResponse :  IEquatable<OrganizationSalesforceAccountManagersResponse>, IValidatableObject
    {
        public OrganizationSalesforceAccountManagersResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSalesforceAccountManagersResponse" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="AccountName">AccountName.</param>
        /// <param name="AccountType">AccountType.</param>
        /// <param name="AccountOwner">AccountOwner.</param>
        /// <param name="AccountManager">AccountManager.</param>
        /// <param name="ParentAccount">ParentAccount.</param>
        public OrganizationSalesforceAccountManagersResponse(string AccountId = default(string), string AccountName = default(string), string AccountType = default(string), OSAMRContact AccountOwner = default(OSAMRContact), OSAMRContact AccountManager = default(OSAMRContact), OrganizationSalesforceAccountManagersResponse ParentAccount = default(OrganizationSalesforceAccountManagersResponse))
        {
            this.AccountId = AccountId;
            this.AccountName = AccountName;
            this.AccountType = AccountType;
            this.AccountOwner = AccountOwner;
            this.AccountManager = AccountManager;
            this.ParentAccount = ParentAccount;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="account_name", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="account_type", EmitDefaultValue=false)]
        public string AccountType { get; set; }
        /// <summary>
        /// Gets or Sets AccountOwner
        /// </summary>
        [DataMember(Name="account_owner", EmitDefaultValue=false)]
        public OSAMRContact AccountOwner { get; set; }
        /// <summary>
        /// Gets or Sets AccountManager
        /// </summary>
        [DataMember(Name="account_manager", EmitDefaultValue=false)]
        public OSAMRContact AccountManager { get; set; }
        /// <summary>
        /// Gets or Sets ParentAccount
        /// </summary>
        [DataMember(Name="parent_account", EmitDefaultValue=false)]
        public OrganizationSalesforceAccountManagersResponse ParentAccount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationSalesforceAccountManagersResponse {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountOwner: ").Append(AccountOwner).Append("\n");
            sb.Append("  AccountManager: ").Append(AccountManager).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
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
            return this.Equals(obj as OrganizationSalesforceAccountManagersResponse);
        }

        /// <summary>
        /// Returns true if OrganizationSalesforceAccountManagersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationSalesforceAccountManagersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationSalesforceAccountManagersResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.AccountOwner == other.AccountOwner ||
                    this.AccountOwner != null &&
                    this.AccountOwner.Equals(other.AccountOwner)
                ) && 
                (
                    this.AccountManager == other.AccountManager ||
                    this.AccountManager != null &&
                    this.AccountManager.Equals(other.AccountManager)
                ) && 
                (
                    this.ParentAccount == other.ParentAccount ||
                    this.ParentAccount != null &&
                    this.ParentAccount.Equals(other.ParentAccount)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.AccountOwner != null)
                    hash = hash * 59 + this.AccountOwner.GetHashCode();
                if (this.AccountManager != null)
                    hash = hash * 59 + this.AccountManager.GetHashCode();
                if (this.ParentAccount != null)
                    hash = hash * 59 + this.ParentAccount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
