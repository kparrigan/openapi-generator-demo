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
    /// GetRolesResponseRolesInner
    /// </summary>
    [DataContract(Name = "GetRolesResponse_roles_inner")]
    public partial class GetRolesResponseRolesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRolesResponseRolesInner" /> class.
        /// </summary>
        /// <param name="createdAt">Only included in custom roles. Role creation timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="varDefault">Indicates if this role is the default role.</param>
        /// <param name="description">A description of the role.</param>
        /// <param name="id">The role ID.</param>
        /// <param name="isBuiltIn">Indicates if the role is built in or custom.</param>
        /// <param name="name">The role&#39;s name.</param>
        /// <param name="numberOfUsers">The number of users currently assigned to this role.</param>
        /// <param name="updatedAt">Only included in custom roles. Role updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        public GetRolesResponseRolesInner(DateTime createdAt = default(DateTime), bool varDefault = default(bool), string description = default(string), int id = default(int), bool isBuiltIn = default(bool), string name = default(string), int numberOfUsers = default(int), DateTime updatedAt = default(DateTime))
        {
            this.CreatedAt = createdAt;
            this.Default = varDefault;
            this.Description = description;
            this.Id = id;
            this.IsBuiltIn = isBuiltIn;
            this.Name = name;
            this.NumberOfUsers = numberOfUsers;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Only included in custom roles. Role creation timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Only included in custom roles. Role creation timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2021-06-16T01:37:04.262Z</example>
        */
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Indicates if this role is the default role
        /// </summary>
        /// <value>Indicates if this role is the default role</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// A description of the role
        /// </summary>
        /// <value>A description of the role</value>
        /*
        <example>Permissions for a user tasked solely with reviewing content.</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The role ID
        /// </summary>
        /// <value>The role ID</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Indicates if the role is built in or custom
        /// </summary>
        /// <value>Indicates if the role is built in or custom</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "is_built_in", EmitDefaultValue = true)]
        public bool IsBuiltIn { get; set; }

        /// <summary>
        /// The role&#39;s name
        /// </summary>
        /// <value>The role&#39;s name</value>
        /*
        <example>Reviewer</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of users currently assigned to this role
        /// </summary>
        /// <value>The number of users currently assigned to this role</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "number_of_users", EmitDefaultValue = false)]
        public int NumberOfUsers { get; set; }

        /// <summary>
        /// Only included in custom roles. Role updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Only included in custom roles. Role updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
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
            sb.Append("class GetRolesResponseRolesInner {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsBuiltIn: ").Append(IsBuiltIn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
