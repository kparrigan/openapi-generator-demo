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
    /// DeleteIdentityByIdResponse
    /// </summary>
    [DataContract(Name = "DeleteIdentityByIdResponse")]
    public partial class DeleteIdentityByIdResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteIdentityByIdResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP response status code.</param>
        /// <param name="statusString">Text description of the HTTP response status code.</param>
        /// <param name="requestId">Unique identifier (UUID) for the request.</param>
        /// <param name="status">Request status.</param>
        public DeleteIdentityByIdResponse(int statusCode = default(int), string statusString = default(string), string requestId = default(string), string status = default(string))
        {
            this.StatusCode = statusCode;
            this.StatusString = statusString;
            this.RequestId = requestId;
            this.Status = status;
        }

        /// <summary>
        /// HTTP response status code
        /// </summary>
        /// <value>HTTP response status code</value>
        /*
        <example>200</example>
        */
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Text description of the HTTP response status code
        /// </summary>
        /// <value>Text description of the HTTP response status code</value>
        /*
        <example>OK</example>
        */
        [DataMember(Name = "status_string", EmitDefaultValue = false)]
        public string StatusString { get; set; }

        /// <summary>
        /// Unique identifier (UUID) for the request
        /// </summary>
        /// <value>Unique identifier (UUID) for the request</value>
        /*
        <example>ca116f96-bbd5-11ef-9468-53af98260bba</example>
        */
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Request status
        /// </summary>
        /// <value>Request status</value>
        /*
        <example>Request successfully completed</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteIdentityByIdResponse {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  StatusString: ").Append(StatusString).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
