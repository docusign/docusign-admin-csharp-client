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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// AssetGroupAccountClone
    /// </summary>
    [DataContract]
    public partial class AssetGroupAccountClone :  IEquatable<AssetGroupAccountClone>, IValidatableObject
    {
        public AssetGroupAccountClone()
        {
            // Empty Constructor
        }

        /// <summary>
        /// The type of asset group work.
        /// </summary>
        /// <value>The type of asset group work.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetGroupWorkTypeEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum GroupAssetFulfillment for value: GroupAssetFulfillment
            /// </summary>
            [EnumMember(Value = "GroupAssetFulfillment")]
            GroupAssetFulfillment = 2,
            
            /// <summary>
            /// Enum AccountAssetFulfillment for value: AccountAssetFulfillment
            /// </summary>
            [EnumMember(Value = "AccountAssetFulfillment")]
            AccountAssetFulfillment = 3,
            
            /// <summary>
            /// Enum AccountAssetClone for value: AccountAssetClone
            /// </summary>
            [EnumMember(Value = "AccountAssetClone")]
            AccountAssetClone = 4,
            
            /// <summary>
            /// Enum AccountAssetCreate for value: AccountAssetCreate
            /// </summary>
            [EnumMember(Value = "AccountAssetCreate")]
            AccountAssetCreate = 5
        }

        /// <summary>
        /// The clone status.
        /// </summary>
        /// <value>The clone status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,
            
            /// <summary>
            /// Enum Processing for value: Processing
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing = 3,
            
            /// <summary>
            /// Enum PendingError for value: PendingError
            /// </summary>
            [EnumMember(Value = "PendingError")]
            PendingError = 4,
            
            /// <summary>
            /// Enum ProcessingError for value: ProcessingError
            /// </summary>
            [EnumMember(Value = "ProcessingError")]
            ProcessingError = 5,
            
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 6,
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 7,
            
            /// <summary>
            /// Enum PermanentFailure for value: PermanentFailure
            /// </summary>
            [EnumMember(Value = "PermanentFailure")]
            PermanentFailure = 8
        }

        /// <summary>
        /// The type of asset group work.
        /// </summary>
        /// <value>The type of asset group work.</value>
        [DataMember(Name="assetGroupWorkType", EmitDefaultValue=false)]
        public AssetGroupWorkTypeEnum? AssetGroupWorkType { get; set; }
        /// <summary>
        /// The clone status.
        /// </summary>
        /// <value>The clone status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupAccountClone" /> class.
        /// </summary>
        /// <param name="SourceAccount">The source account to be cloned from. (required).</param>
        /// <param name="TargetAccount">The target account to clone to. (required).</param>
        public AssetGroupAccountClone(AssetGroupAccountCloneSourceAccount SourceAccount = default(AssetGroupAccountCloneSourceAccount), AssetGroupAccountCloneTargetAccount TargetAccount = default(AssetGroupAccountCloneTargetAccount))
        {
            // to ensure "SourceAccount" is required (not null)
            if (SourceAccount == null)
            {
                throw new InvalidDataException("SourceAccount is a required property for AssetGroupAccountClone and cannot be null");
            }
            else
            {
                this.SourceAccount = SourceAccount;
            }
            // to ensure "TargetAccount" is required (not null)
            if (TargetAccount == null)
            {
                throw new InvalidDataException("TargetAccount is a required property for AssetGroupAccountClone and cannot be null");
            }
            else
            {
                this.TargetAccount = TargetAccount;
            }
        }
        
        /// <summary>
        /// The source account to be cloned from.
        /// </summary>
        /// <value>The source account to be cloned from.</value>
        [DataMember(Name="sourceAccount", EmitDefaultValue=false)]
        public AssetGroupAccountCloneSourceAccount SourceAccount { get; set; }
        /// <summary>
        /// The target account to clone to.
        /// </summary>
        /// <value>The target account to clone to.</value>
        [DataMember(Name="targetAccount", EmitDefaultValue=false)]
        public AssetGroupAccountCloneTargetAccount TargetAccount { get; set; }
        /// <summary>
        /// The account clone work id.
        /// </summary>
        /// <value>The account clone work id.</value>
        [DataMember(Name="assetGroupWorkId", EmitDefaultValue=false)]
        public Guid? AssetGroupWorkId { get; private set; }
        /// <summary>
        /// The asset group id the accounts belong to.
        /// </summary>
        /// <value>The asset group id the accounts belong to.</value>
        [DataMember(Name="assetGroupId", EmitDefaultValue=false)]
        public Guid? AssetGroupId { get; private set; }
        /// <summary>
        /// The account entitlement/setting mirror request id created by the clone work.
        /// </summary>
        /// <value>The account entitlement/setting mirror request id created by the clone work.</value>
        [DataMember(Name="cloneRequestId", EmitDefaultValue=false)]
        public Guid? CloneRequestId { get; private set; }
        /// <summary>
        /// The order id created by the clone work.
        /// </summary>
        /// <value>The order id created by the clone work.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public Guid? OrderId { get; private set; }
        /// <summary>
        /// The number of times the work has been worked on.
        /// </summary>
        /// <value>The number of times the work has been worked on.</value>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public int? Attempts { get; private set; }
        /// <summary>
        /// The date the account clone work is created.
        /// </summary>
        /// <value>The date the account clone work is created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        /// <summary>
        /// The name of the creator of the account clone work.
        /// </summary>
        /// <value>The name of the creator of the account clone work.</value>
        [DataMember(Name="createdByName", EmitDefaultValue=false)]
        public string CreatedByName { get; private set; }
        /// <summary>
        /// The email of the creator of the account clone work.
        /// </summary>
        /// <value>The email of the creator of the account clone work.</value>
        [DataMember(Name="createdByEmail", EmitDefaultValue=false)]
        public string CreatedByEmail { get; private set; }
        /// <summary>
        /// The message associated with the account clone work.
        /// </summary>
        /// <value>The message associated with the account clone work.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }
        /// <summary>
        /// The processing failures if the work is in PendingError/ProcessingError status.
        /// </summary>
        /// <value>The processing failures if the work is in PendingError/ProcessingError status.</value>
        [DataMember(Name="cloneProcessingFailureDetails", EmitDefaultValue=false)]
        public CloneErrorDetails CloneProcessingFailureDetails { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetGroupAccountClone {\n");
            sb.Append("  SourceAccount: ").Append(SourceAccount).Append("\n");
            sb.Append("  TargetAccount: ").Append(TargetAccount).Append("\n");
            sb.Append("  AssetGroupWorkId: ").Append(AssetGroupWorkId).Append("\n");
            sb.Append("  AssetGroupId: ").Append(AssetGroupId).Append("\n");
            sb.Append("  AssetGroupWorkType: ").Append(AssetGroupWorkType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CloneRequestId: ").Append(CloneRequestId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByName: ").Append(CreatedByName).Append("\n");
            sb.Append("  CreatedByEmail: ").Append(CreatedByEmail).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CloneProcessingFailureDetails: ").Append(CloneProcessingFailureDetails).Append("\n");
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
            return this.Equals(obj as AssetGroupAccountClone);
        }

        /// <summary>
        /// Returns true if AssetGroupAccountClone instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetGroupAccountClone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetGroupAccountClone other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceAccount == other.SourceAccount ||
                    this.SourceAccount != null &&
                    this.SourceAccount.Equals(other.SourceAccount)
                ) && 
                (
                    this.TargetAccount == other.TargetAccount ||
                    this.TargetAccount != null &&
                    this.TargetAccount.Equals(other.TargetAccount)
                ) && 
                (
                    this.AssetGroupWorkId == other.AssetGroupWorkId ||
                    this.AssetGroupWorkId != null &&
                    this.AssetGroupWorkId.Equals(other.AssetGroupWorkId)
                ) && 
                (
                    this.AssetGroupId == other.AssetGroupId ||
                    this.AssetGroupId != null &&
                    this.AssetGroupId.Equals(other.AssetGroupId)
                ) && 
                (
                    this.AssetGroupWorkType == other.AssetGroupWorkType ||
                    this.AssetGroupWorkType != null &&
                    this.AssetGroupWorkType.Equals(other.AssetGroupWorkType)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CloneRequestId == other.CloneRequestId ||
                    this.CloneRequestId != null &&
                    this.CloneRequestId.Equals(other.CloneRequestId)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.Attempts == other.Attempts ||
                    this.Attempts != null &&
                    this.Attempts.Equals(other.Attempts)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CreatedByName == other.CreatedByName ||
                    this.CreatedByName != null &&
                    this.CreatedByName.Equals(other.CreatedByName)
                ) && 
                (
                    this.CreatedByEmail == other.CreatedByEmail ||
                    this.CreatedByEmail != null &&
                    this.CreatedByEmail.Equals(other.CreatedByEmail)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.CloneProcessingFailureDetails == other.CloneProcessingFailureDetails ||
                    this.CloneProcessingFailureDetails != null &&
                    this.CloneProcessingFailureDetails.Equals(other.CloneProcessingFailureDetails)
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
                if (this.SourceAccount != null)
                    hash = hash * 59 + this.SourceAccount.GetHashCode();
                if (this.TargetAccount != null)
                    hash = hash * 59 + this.TargetAccount.GetHashCode();
                if (this.AssetGroupWorkId != null)
                    hash = hash * 59 + this.AssetGroupWorkId.GetHashCode();
                if (this.AssetGroupId != null)
                    hash = hash * 59 + this.AssetGroupId.GetHashCode();
                if (this.AssetGroupWorkType != null)
                    hash = hash * 59 + this.AssetGroupWorkType.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CloneRequestId != null)
                    hash = hash * 59 + this.CloneRequestId.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.Attempts != null)
                    hash = hash * 59 + this.Attempts.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatedByName != null)
                    hash = hash * 59 + this.CreatedByName.GetHashCode();
                if (this.CreatedByEmail != null)
                    hash = hash * 59 + this.CreatedByEmail.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.CloneProcessingFailureDetails != null)
                    hash = hash * 59 + this.CloneProcessingFailureDetails.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}