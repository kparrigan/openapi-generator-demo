/*
 * Theta Lake API
 *
 * We are excited to inform you that our documentation is interactive!  If you are logged in, this means that you can not only read about the features and capabilities of our product, but also try them out directly from the documentation pages. Our interactive documentation provides a hands-on experience that allows you to test the API endpoints, experiment with the input parameters, and see the corresponding responses. This makes it easier to understand how the API works and how to integrate it into your own applications. With interactive documentation, you can save time and avoid frustration by testing the API right from the documentation pages, without having to set up a local development environment. Whether you're a seasoned developer or just starting out, our interactive documentation is the perfect tool to help you learn, experiment, and succeed with our API. 
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PutOrgUnitByIdRequest
    /// </summary>
    [DataContract(Name = "PutOrgUnitByIdRequest")]
    public partial class PutOrgUnitByIdRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FallbackLanguage
        /// </summary>
        [DataMember(Name = "fallback_language", EmitDefaultValue = false)]
        public FallbackLanguage? FallbackLanguage { get; set; }
        /// <summary>
        /// Defines PreferredLanguages
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PreferredLanguagesEnum
        {
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 1,

            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 2,

            /// <summary>
            /// Enum Nl for value: nl
            /// </summary>
            [EnumMember(Value = "nl")]
            Nl = 3,

            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 4,

            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 5,

            /// <summary>
            /// Enum It for value: it
            /// </summary>
            [EnumMember(Value = "it")]
            It = 6,

            /// <summary>
            /// Enum Ja for value: ja
            /// </summary>
            [EnumMember(Value = "ja")]
            Ja = 7,

            /// <summary>
            /// Enum Cmn for value: cmn
            /// </summary>
            [EnumMember(Value = "cmn")]
            Cmn = 8,

            /// <summary>
            /// Enum Pt for value: pt
            /// </summary>
            [EnumMember(Value = "pt")]
            Pt = 9
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrgUnitByIdRequest" /> class.
        /// </summary>
        /// <param name="allowAnonymousViaSharedLinks">Indicates the ability to share a link to records publicly.</param>
        /// <param name="analysisSupervisionSpaceIds">Datums matching these supervision spaces will be analyzed for risky behaviors.</param>
        /// <param name="auditLogRetentionPeriod">The duration audit logs for this bucket will be retained.</param>
        /// <param name="defaultOrgTimezone">The org units default timezone.</param>
        /// <param name="deleteOnExpiration">Indicates if records in this org unit should be deleted when they expire from the archive.</param>
        /// <param name="fallbackLanguage">fallbackLanguage.</param>
        /// <param name="preferredLanguages">An array of selected preferred languages.</param>
        /// <param name="useNameMatcher">Indicates if the org unit identity matching algorithm uses names.</param>
        /// <param name="useOwnerOnlySpaceMatcher">Indicates if the org unit identity matching algorithm should stop after owner and then fallback to default.</param>
        public PutOrgUnitByIdRequest(bool allowAnonymousViaSharedLinks = default(bool), List<int> analysisSupervisionSpaceIds = default(List<int>), int? auditLogRetentionPeriod = default(int?), string defaultOrgTimezone = default(string), bool deleteOnExpiration = default(bool), FallbackLanguage? fallbackLanguage = default(FallbackLanguage?), List<PreferredLanguagesEnum> preferredLanguages = default(List<PreferredLanguagesEnum>), bool useNameMatcher = default(bool), bool useOwnerOnlySpaceMatcher = default(bool))
        {
            this.AllowAnonymousViaSharedLinks = allowAnonymousViaSharedLinks;
            this.AnalysisSupervisionSpaceIds = analysisSupervisionSpaceIds;
            this.AuditLogRetentionPeriod = auditLogRetentionPeriod;
            this.DefaultOrgTimezone = defaultOrgTimezone;
            this.DeleteOnExpiration = deleteOnExpiration;
            this.FallbackLanguage = fallbackLanguage;
            this.PreferredLanguages = preferredLanguages;
            this.UseNameMatcher = useNameMatcher;
            this.UseOwnerOnlySpaceMatcher = useOwnerOnlySpaceMatcher;
        }

        /// <summary>
        /// Indicates the ability to share a link to records publicly
        /// </summary>
        /// <value>Indicates the ability to share a link to records publicly</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "allow_anonymous_via_shared_links", EmitDefaultValue = true)]
        public bool AllowAnonymousViaSharedLinks { get; set; }

        /// <summary>
        /// Datums matching these supervision spaces will be analyzed for risky behaviors
        /// </summary>
        /// <value>Datums matching these supervision spaces will be analyzed for risky behaviors</value>
        /*
        <example>[1,2,3]</example>
        */
        [DataMember(Name = "analysis_supervision_space_ids", EmitDefaultValue = false)]
        public List<int> AnalysisSupervisionSpaceIds { get; set; }

        /// <summary>
        /// The duration audit logs for this bucket will be retained
        /// </summary>
        /// <value>The duration audit logs for this bucket will be retained</value>
        [DataMember(Name = "audit_log_retention_period", EmitDefaultValue = true)]
        public int? AuditLogRetentionPeriod { get; set; }

        /// <summary>
        /// The org units default timezone
        /// </summary>
        /// <value>The org units default timezone</value>
        /*
        <example>Etc/UTC</example>
        */
        [DataMember(Name = "default_org_timezone", EmitDefaultValue = false)]
        public string DefaultOrgTimezone { get; set; }

        /// <summary>
        /// Indicates if records in this org unit should be deleted when they expire from the archive
        /// </summary>
        /// <value>Indicates if records in this org unit should be deleted when they expire from the archive</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "delete_on_expiration", EmitDefaultValue = true)]
        public bool DeleteOnExpiration { get; set; }

        /// <summary>
        /// An array of selected preferred languages
        /// </summary>
        /// <value>An array of selected preferred languages</value>
        /*
        <example>[&quot;en&quot;,&quot;nl&quot;,&quot;de&quot;]</example>
        */
        [DataMember(Name = "preferred_languages", EmitDefaultValue = false)]
        public List<PutOrgUnitByIdRequest.PreferredLanguagesEnum> PreferredLanguages { get; set; }

        /// <summary>
        /// Indicates if the org unit identity matching algorithm uses names
        /// </summary>
        /// <value>Indicates if the org unit identity matching algorithm uses names</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "use_name_matcher", EmitDefaultValue = true)]
        public bool UseNameMatcher { get; set; }

        /// <summary>
        /// Indicates if the org unit identity matching algorithm should stop after owner and then fallback to default
        /// </summary>
        /// <value>Indicates if the org unit identity matching algorithm should stop after owner and then fallback to default</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "use_owner_only_space_matcher", EmitDefaultValue = true)]
        public bool UseOwnerOnlySpaceMatcher { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutOrgUnitByIdRequest {\n");
            sb.Append("  AllowAnonymousViaSharedLinks: ").Append(AllowAnonymousViaSharedLinks).Append("\n");
            sb.Append("  AnalysisSupervisionSpaceIds: ").Append(AnalysisSupervisionSpaceIds).Append("\n");
            sb.Append("  AuditLogRetentionPeriod: ").Append(AuditLogRetentionPeriod).Append("\n");
            sb.Append("  DefaultOrgTimezone: ").Append(DefaultOrgTimezone).Append("\n");
            sb.Append("  DeleteOnExpiration: ").Append(DeleteOnExpiration).Append("\n");
            sb.Append("  FallbackLanguage: ").Append(FallbackLanguage).Append("\n");
            sb.Append("  PreferredLanguages: ").Append(PreferredLanguages).Append("\n");
            sb.Append("  UseNameMatcher: ").Append(UseNameMatcher).Append("\n");
            sb.Append("  UseOwnerOnlySpaceMatcher: ").Append(UseOwnerOnlySpaceMatcher).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
