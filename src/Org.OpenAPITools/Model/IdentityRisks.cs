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
    /// IdentityRisks
    /// </summary>
    [DataContract(Name = "IdentityRisks")]
    public partial class IdentityRisks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityRisks" /> class.
        /// </summary>
        /// <param name="comment">Comment for the identity&#39;s risk in the datum.</param>
        /// <param name="createdAt">The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="datumId">The datum ID with the risky behavior in it.</param>
        /// <param name="id">Identity of the risk.</param>
        /// <param name="identityId">The ID of the identity behaving riskily.</param>
        /// <param name="risky">Indicates if identity is behaving in a risky fashion.</param>
        /// <param name="updatedAt">The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="userId">The ID of the user that created the risk.</param>
        public IdentityRisks(string comment = default(string), DateTime createdAt = default(DateTime), int? datumId = default(int?), int id = default(int), int identityId = default(int), bool risky = default(bool), DateTime updatedAt = default(DateTime), int userId = default(int))
        {
            this.Comment = comment;
            this.CreatedAt = createdAt;
            this.DatumId = datumId;
            this.Id = id;
            this.IdentityId = identityId;
            this.Risky = risky;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Comment for the identity&#39;s risk in the datum
        /// </summary>
        /// <value>Comment for the identity&#39;s risk in the datum</value>
        /*
        <example>John is sharing Personal Identifying Information of a client</example>
        */
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

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
        /// The datum ID with the risky behavior in it
        /// </summary>
        /// <value>The datum ID with the risky behavior in it</value>
        /*
        <example>215779</example>
        */
        [DataMember(Name = "datum_id", EmitDefaultValue = true)]
        public int? DatumId { get; set; }

        /// <summary>
        /// Identity of the risk
        /// </summary>
        /// <value>Identity of the risk</value>
        /*
        <example>138</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the identity behaving riskily
        /// </summary>
        /// <value>The ID of the identity behaving riskily</value>
        /*
        <example>66690</example>
        */
        [DataMember(Name = "identity_id", EmitDefaultValue = false)]
        public int IdentityId { get; set; }

        /// <summary>
        /// Indicates if identity is behaving in a risky fashion
        /// </summary>
        /// <value>Indicates if identity is behaving in a risky fashion</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "risky", EmitDefaultValue = true)]
        public bool Risky { get; set; }

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
        /// The ID of the user that created the risk
        /// </summary>
        /// <value>The ID of the user that created the risk</value>
        /*
        <example>188</example>
        */
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityRisks {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DatumId: ").Append(DatumId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
            sb.Append("  Risky: ").Append(Risky).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
