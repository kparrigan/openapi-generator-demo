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
    /// GetIntegrationStateResponseState
    /// </summary>
    [DataContract(Name = "GetIntegrationStateResponse_state")]
    public partial class GetIntegrationStateResponseState : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public Status? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationStateResponseState" /> class.
        /// </summary>
        /// <param name="varInternal">Free form JSON object that can be used to track any internal integration state.</param>
        /// <param name="lastRun">The timestamp of the last run of the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6), must be set by the integration.</param>
        /// <param name="lastUpload">The timestamp of the last upload to the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6). Automatically set by the API..</param>
        /// <param name="paused">Indicates if the integration is paused.</param>
        /// <param name="status">status.</param>
        public GetIntegrationStateResponseState(Object varInternal = default(Object), DateTime lastRun = default(DateTime), DateTime lastUpload = default(DateTime), bool paused = default(bool), Status? status = default(Status?))
        {
            this.Internal = varInternal;
            this.LastRun = lastRun;
            this.LastUpload = lastUpload;
            this.Paused = paused;
            this.Status = status;
        }

        /// <summary>
        /// Free form JSON object that can be used to track any internal integration state
        /// </summary>
        /// <value>Free form JSON object that can be used to track any internal integration state</value>
        /*
        <example>{&quot;A&quot;:1,&quot;B&quot;:2,&quot;C&quot;:3}</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public Object Internal { get; set; }

        /// <summary>
        /// The timestamp of the last run of the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6), must be set by the integration
        /// </summary>
        /// <value>The timestamp of the last run of the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6), must be set by the integration</value>
        /*
        <example>2023-06-07T13:08:43Z</example>
        */
        [DataMember(Name = "last_run", EmitDefaultValue = false)]
        public DateTime LastRun { get; set; }

        /// <summary>
        /// The timestamp of the last upload to the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6). Automatically set by the API.
        /// </summary>
        /// <value>The timestamp of the last upload to the integration in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6). Automatically set by the API.</value>
        /*
        <example>2023-06-07T13:08:43Z</example>
        */
        [DataMember(Name = "last_upload", EmitDefaultValue = false)]
        public DateTime LastUpload { get; set; }

        /// <summary>
        /// Indicates if the integration is paused
        /// </summary>
        /// <value>Indicates if the integration is paused</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "paused", EmitDefaultValue = true)]
        public bool Paused { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetIntegrationStateResponseState {\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  LastRun: ").Append(LastRun).Append("\n");
            sb.Append("  LastUpload: ").Append(LastUpload).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
