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
    /// Case
    /// </summary>
    [DataContract(Name = "varCase")]
    public partial class Case : IValidatableObject
    {
        /// <summary>
        /// The current case status
        /// </summary>
        /// <value>The current case status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN = 1,

            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 2
        }


        /// <summary>
        /// The current case status
        /// </summary>
        /// <value>The current case status</value>
        /*
        <example>OPEN</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The case visibility
        /// </summary>
        /// <value>The case visibility</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: PUBLIC
            /// </summary>
            [EnumMember(Value = "PUBLIC")]
            PUBLIC = 1,

            /// <summary>
            /// Enum PRIVATE for value: PRIVATE
            /// </summary>
            [EnumMember(Value = "PRIVATE")]
            PRIVATE = 2
        }


        /// <summary>
        /// The case visibility
        /// </summary>
        /// <value>The case visibility</value>
        /*
        <example>PUBLIC</example>
        */
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public VisibilityEnum? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Case" /> class.
        /// </summary>
        /// <param name="closeDate">The timestamp of when the case was closed. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="createdAt">The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="description">The case description.</param>
        /// <param name="id">The case ID.</param>
        /// <param name="name">The case name.</param>
        /// <param name="number">The case number.</param>
        /// <param name="openDate">The timestamp of when the case was opened. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="recordsCount">The number of records associated with the case.</param>
        /// <param name="status">The current case status.</param>
        /// <param name="updatedAt">The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="visibility">The case visibility.</param>
        public Case(DateTime closeDate = default(DateTime), DateTime createdAt = default(DateTime), string description = default(string), int id = default(int), string name = default(string), string number = default(string), DateTime openDate = default(DateTime), int recordsCount = default(int), StatusEnum? status = default(StatusEnum?), DateTime updatedAt = default(DateTime), VisibilityEnum? visibility = default(VisibilityEnum?))
        {
            this.CloseDate = closeDate;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.OpenDate = openDate;
            this.RecordsCount = recordsCount;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
        }

        /// <summary>
        /// The timestamp of when the case was closed. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The timestamp of when the case was closed. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2021-07-16T01:37:04.262Z</example>
        */
        [DataMember(Name = "close_date", EmitDefaultValue = false)]
        public DateTime CloseDate { get; set; }

        /// <summary>
        /// The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2021-06-16T01:37:04.262Z</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The case description
        /// </summary>
        /// <value>The case description</value>
        /*
        <example>Example test case description</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The case ID
        /// </summary>
        /// <value>The case ID</value>
        /*
        <example>27</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The case name
        /// </summary>
        /// <value>The case name</value>
        /*
        <example>Case name</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The case number
        /// </summary>
        /// <value>The case number</value>
        /*
        <example>Case number</example>
        */
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The timestamp of when the case was opened. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The timestamp of when the case was opened. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2021-06-16T01:37:04.262Z</example>
        */
        [DataMember(Name = "open_date", EmitDefaultValue = false)]
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// The number of records associated with the case
        /// </summary>
        /// <value>The number of records associated with the case</value>
        /*
        <example>31</example>
        */
        [DataMember(Name = "records_count", EmitDefaultValue = false)]
        public int RecordsCount { get; set; }

        /// <summary>
        /// The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2022-10-12T02:29:49.146Z</example>
        */
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Case {\n");
            sb.Append("  CloseDate: ").Append(CloseDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  RecordsCount: ").Append(RecordsCount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
