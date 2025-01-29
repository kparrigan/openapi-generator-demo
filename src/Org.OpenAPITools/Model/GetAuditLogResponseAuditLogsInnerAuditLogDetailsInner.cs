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
    /// GetAuditLogResponseAuditLogsInnerAuditLogDetailsInner
    /// </summary>
    [DataContract(Name = "GetAuditLogResponse_audit_logs_inner_audit_log_details_inner")]
    public partial class GetAuditLogResponseAuditLogsInnerAuditLogDetailsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuditLogResponseAuditLogsInnerAuditLogDetailsInner" /> class.
        /// </summary>
        /// <param name="auditablePreviousValueId">The previous auditable value identifier.</param>
        /// <param name="auditablePreviousValueStr">The previous auditable value identifier as in string format.</param>
        /// <param name="auditablePreviousValueType">The previous auditable human readable type.</param>
        /// <param name="auditableValueId">The current auditable value identifier.</param>
        /// <param name="auditableValueStr">The current auditable value identifier as in string format.</param>
        /// <param name="auditableValueType">The current auditable human readable type.</param>
        /// <param name="description">The description of the auditable_value.</param>
        /// <param name="id">The id of the auditable_value.</param>
        /// <param name="longDescription">Long description of the auditable_value.</param>
        public GetAuditLogResponseAuditLogsInnerAuditLogDetailsInner(int? auditablePreviousValueId = default(int?), string auditablePreviousValueStr = default(string), string auditablePreviousValueType = default(string), string auditableValueId = default(string), string auditableValueStr = default(string), string auditableValueType = default(string), string description = default(string), int id = default(int), string longDescription = default(string))
        {
            this.AuditablePreviousValueId = auditablePreviousValueId;
            this.AuditablePreviousValueStr = auditablePreviousValueStr;
            this.AuditablePreviousValueType = auditablePreviousValueType;
            this.AuditableValueId = auditableValueId;
            this.AuditableValueStr = auditableValueStr;
            this.AuditableValueType = auditableValueType;
            this.Description = description;
            this.Id = id;
            this.LongDescription = longDescription;
        }

        /// <summary>
        /// The previous auditable value identifier
        /// </summary>
        /// <value>The previous auditable value identifier</value>
        /*
        <example>125</example>
        */
        [DataMember(Name = "auditable_previous_value_id", EmitDefaultValue = true)]
        public int? AuditablePreviousValueId { get; set; }

        /// <summary>
        /// The previous auditable value identifier as in string format
        /// </summary>
        /// <value>The previous auditable value identifier as in string format</value>
        /*
        <example>125</example>
        */
        [DataMember(Name = "auditable_previous_value_str", EmitDefaultValue = false)]
        public string AuditablePreviousValueStr { get; set; }

        /// <summary>
        /// The previous auditable human readable type
        /// </summary>
        /// <value>The previous auditable human readable type</value>
        /*
        <example>Integer</example>
        */
        [DataMember(Name = "auditable_previous_value_type", EmitDefaultValue = false)]
        public string AuditablePreviousValueType { get; set; }

        /// <summary>
        /// The current auditable value identifier
        /// </summary>
        /// <value>The current auditable value identifier</value>
        /*
        <example>125</example>
        */
        [DataMember(Name = "auditable_value_id", EmitDefaultValue = true)]
        public string AuditableValueId { get; set; }

        /// <summary>
        /// The current auditable value identifier as in string format
        /// </summary>
        /// <value>The current auditable value identifier as in string format</value>
        /*
        <example>125</example>
        */
        [DataMember(Name = "auditable_value_str", EmitDefaultValue = false)]
        public string AuditableValueStr { get; set; }

        /// <summary>
        /// The current auditable human readable type
        /// </summary>
        /// <value>The current auditable human readable type</value>
        /*
        <example>Integer</example>
        */
        [DataMember(Name = "auditable_value_type", EmitDefaultValue = false)]
        public string AuditableValueType { get; set; }

        /// <summary>
        /// The description of the auditable_value
        /// </summary>
        /// <value>The description of the auditable_value</value>
        /*
        <example>Supervision space priority</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The id of the auditable_value
        /// </summary>
        /// <value>The id of the auditable_value</value>
        /*
        <example>1234515</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Long description of the auditable_value
        /// </summary>
        /// <value>Long description of the auditable_value</value>
        /*
        <example>Supervision space priority updated from &#39;50&#39; to &#39;51&#39;</example>
        */
        [DataMember(Name = "long_description", EmitDefaultValue = false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAuditLogResponseAuditLogsInnerAuditLogDetailsInner {\n");
            sb.Append("  AuditablePreviousValueId: ").Append(AuditablePreviousValueId).Append("\n");
            sb.Append("  AuditablePreviousValueStr: ").Append(AuditablePreviousValueStr).Append("\n");
            sb.Append("  AuditablePreviousValueType: ").Append(AuditablePreviousValueType).Append("\n");
            sb.Append("  AuditableValueId: ").Append(AuditableValueId).Append("\n");
            sb.Append("  AuditableValueStr: ").Append(AuditableValueStr).Append("\n");
            sb.Append("  AuditableValueType: ").Append(AuditableValueType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
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
