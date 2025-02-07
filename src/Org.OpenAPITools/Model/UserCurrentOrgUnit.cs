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
    /// The user&#39;s current org unit
    /// </summary>
    [DataContract(Name = "user_current_org_unit")]
    public partial class UserCurrentOrgUnit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCurrentOrgUnit" /> class.
        /// </summary>
        /// <param name="archiveOnly">Indicates if this org unit is archive Only.</param>
        /// <param name="id">The ID of the current org unit.</param>
        /// <param name="name">The name of current org unit.</param>
        public UserCurrentOrgUnit(bool archiveOnly = default(bool), int id = default(int), string name = default(string))
        {
            this.ArchiveOnly = archiveOnly;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Indicates if this org unit is archive Only
        /// </summary>
        /// <value>Indicates if this org unit is archive Only</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "archive_only", EmitDefaultValue = true)]
        public bool ArchiveOnly { get; set; }

        /// <summary>
        /// The ID of the current org unit
        /// </summary>
        /// <value>The ID of the current org unit</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of current org unit
        /// </summary>
        /// <value>The name of current org unit</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserCurrentOrgUnit {\n");
            sb.Append("  ArchiveOnly: ").Append(ArchiveOnly).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
