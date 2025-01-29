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
    /// PostDirectoryGroupIdentityRequest
    /// </summary>
    [DataContract(Name = "PostDirectoryGroupIdentityRequest")]
    public partial class PostDirectoryGroupIdentityRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDirectoryGroupIdentityRequest" /> class.
        /// </summary>
        /// <param name="name">The identity&#39;s name.</param>
        /// <param name="phoneNumber">The identity&#39;s phone number.</param>
        /// <param name="email">The identity&#39;s email address.</param>
        /// <param name="externalId">An external ID for the identity.</param>
        public PostDirectoryGroupIdentityRequest(string name = default(string), string phoneNumber = default(string), string email = default(string), string externalId = default(string))
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// The identity&#39;s name
        /// </summary>
        /// <value>The identity&#39;s name</value>
        /*
        <example>John Smith</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The identity&#39;s phone number
        /// </summary>
        /// <value>The identity&#39;s phone number</value>
        /*
        <example>555-867-5309</example>
        */
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The identity&#39;s email address
        /// </summary>
        /// <value>The identity&#39;s email address</value>
        /*
        <example>john@smith.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// An external ID for the identity
        /// </summary>
        /// <value>An external ID for the identity</value>
        /*
        <example>it-236</example>
        */
        [DataMember(Name = "external_id", EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostDirectoryGroupIdentityRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
