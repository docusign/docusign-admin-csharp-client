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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// AssetGroupAccountCloneTargetAccountAdmin
    /// </summary>
    [DataContract]
    public partial class AssetGroupAccountCloneTargetAccountAdmin :  IEquatable<AssetGroupAccountCloneTargetAccountAdmin>, IValidatableObject
    {
        public AssetGroupAccountCloneTargetAccountAdmin()
        {
            // Empty Constructor
        }

        /// <summary>
        /// The locale of the target account&#39;s admin user.
        /// </summary>
        /// <value>The locale of the target account&#39;s admin user.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocaleEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Zhcn for value: zh_cn
            /// </summary>
            [EnumMember(Value = "zh_cn")]
            Zhcn = 2,
            
            /// <summary>
            /// Enum Zhtw for value: zh_tw
            /// </summary>
            [EnumMember(Value = "zh_tw")]
            Zhtw = 3,
            
            /// <summary>
            /// Enum Nl for value: nl
            /// </summary>
            [EnumMember(Value = "nl")]
            Nl = 4,
            
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 5,
            
            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 6,
            
            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 7,
            
            /// <summary>
            /// Enum It for value: it
            /// </summary>
            [EnumMember(Value = "it")]
            It = 8,
            
            /// <summary>
            /// Enum Ja for value: ja
            /// </summary>
            [EnumMember(Value = "ja")]
            Ja = 9,
            
            /// <summary>
            /// Enum Ko for value: ko
            /// </summary>
            [EnumMember(Value = "ko")]
            Ko = 10,
            
            /// <summary>
            /// Enum Pt for value: pt
            /// </summary>
            [EnumMember(Value = "pt")]
            Pt = 11,
            
            /// <summary>
            /// Enum Ptbr for value: pt_br
            /// </summary>
            [EnumMember(Value = "pt_br")]
            Ptbr = 12,
            
            /// <summary>
            /// Enum Ru for value: ru
            /// </summary>
            [EnumMember(Value = "ru")]
            Ru = 13,
            
            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 14,
            
            /// <summary>
            /// Enum Pl for value: pl
            /// </summary>
            [EnumMember(Value = "pl")]
            Pl = 15
        }

        /// <summary>
        /// The locale of the target account's admin user.
        /// </summary>
        /// <value>The locale of the target account's admin user.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public LocaleEnum? Locale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupAccountCloneTargetAccountAdmin" /> class.
        /// </summary>
        /// <param name="Email">The email of the target account&#39;s admin user..</param>
        /// <param name="FirstName">The first name of the target account&#39;s admin user..</param>
        /// <param name="LastName">The last name of the target account&#39;s admin user..</param>
        /// <param name="Locale">The locale of the target account&#39;s admin user..</param>
        public AssetGroupAccountCloneTargetAccountAdmin(string Email = default(string), string FirstName = default(string), string LastName = default(string), LocaleEnum? Locale = default(LocaleEnum?))
        {
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Locale = Locale;
        }
        
        /// <summary>
        /// The email of the target account&#39;s admin user.
        /// </summary>
        /// <value>The email of the target account&#39;s admin user.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The first name of the target account&#39;s admin user.
        /// </summary>
        /// <value>The first name of the target account&#39;s admin user.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the target account&#39;s admin user.
        /// </summary>
        /// <value>The last name of the target account&#39;s admin user.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetGroupAccountCloneTargetAccountAdmin {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(obj as AssetGroupAccountCloneTargetAccountAdmin);
        }

        /// <summary>
        /// Returns true if AssetGroupAccountCloneTargetAccountAdmin instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetGroupAccountCloneTargetAccountAdmin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetGroupAccountCloneTargetAccountAdmin other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
