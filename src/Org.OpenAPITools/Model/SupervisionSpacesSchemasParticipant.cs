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
    /// SupervisionSpacesSchemasParticipant
    /// </summary>
    [DataContract(Name = "supervision_spaces_schemas-participant")]
    public partial class SupervisionSpacesSchemasParticipant : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisionSpacesSchemasParticipant" /> class.
        /// </summary>
        /// <param name="email">The participant&#39;s email address.</param>
        /// <param name="identityId">The participant&#39;s ID.</param>
        /// <param name="isSubmitter">Indicates if the participant did submit data.</param>
        /// <param name="name">The participant&#39;s name.</param>
        /// <param name="phoneNumber">The participant&#39;s phone number.</param>
        public SupervisionSpacesSchemasParticipant(string email = default(string), int identityId = default(int), bool isSubmitter = default(bool), string name = default(string), string phoneNumber = default(string))
        {
            this.Email = email;
            this.IdentityId = identityId;
            this.IsSubmitter = isSubmitter;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// The participant&#39;s email address
        /// </summary>
        /// <value>The participant&#39;s email address</value>
        /*
        <example>john@smith.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The participant&#39;s ID
        /// </summary>
        /// <value>The participant&#39;s ID</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "identity_id", EmitDefaultValue = false)]
        public int IdentityId { get; set; }

        /// <summary>
        /// Indicates if the participant did submit data
        /// </summary>
        /// <value>Indicates if the participant did submit data</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "is_submitter", EmitDefaultValue = true)]
        public bool IsSubmitter { get; set; }

        /// <summary>
        /// The participant&#39;s name
        /// </summary>
        /// <value>The participant&#39;s name</value>
        /*
        <example>John Smith</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The participant&#39;s phone number
        /// </summary>
        /// <value>The participant&#39;s phone number</value>
        /*
        <example>555-867-5309</example>
        */
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupervisionSpacesSchemasParticipant {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
            sb.Append("  IsSubmitter: ").Append(IsSubmitter).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
