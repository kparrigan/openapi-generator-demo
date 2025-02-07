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
    /// ChatParticipantInfosInner
    /// </summary>
    [DataContract(Name = "chat_participant_infos_inner")]
    public partial class ChatParticipantInfosInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParticipantInfosInner" /> class.
        /// </summary>
        /// <param name="id">The unique identifier from the original platform where the content was generated.</param>
        /// <param name="name">The participant&#39;s name as a single string.</param>
        /// <param name="firstName">The participant&#39;s first name.</param>
        /// <param name="lastName">The participant&#39;s last name.</param>
        /// <param name="email">The participant&#39;s email address.</param>
        /// <param name="phoneNumber">The participant&#39;s phone number. This phone number can only be digits with an optional &#39;+&#39; prefix.</param>
        /// <param name="extension">The participant&#39;s extension.</param>
        /// <param name="location">The participant&#39;s location.</param>
        /// <param name="deviceId">The participant&#39;s device ID.</param>
        /// <param name="employeeId">The participant&#39;s employee ID.</param>
        public ChatParticipantInfosInner(string id = default(string), string name = default(string), string firstName = default(string), string lastName = default(string), string email = default(string), string phoneNumber = default(string), string extension = default(string), string location = default(string), string deviceId = default(string), string employeeId = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Extension = extension;
            this.Location = location;
            this.DeviceId = deviceId;
            this.EmployeeId = employeeId;
        }

        /// <summary>
        /// The unique identifier from the original platform where the content was generated
        /// </summary>
        /// <value>The unique identifier from the original platform where the content was generated</value>
        /*
        <example>abc123</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The participant&#39;s name as a single string
        /// </summary>
        /// <value>The participant&#39;s name as a single string</value>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The participant&#39;s first name
        /// </summary>
        /// <value>The participant&#39;s first name</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The participant&#39;s last name
        /// </summary>
        /// <value>The participant&#39;s last name</value>
        /*
        <example>Doe</example>
        */
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// The participant&#39;s email address
        /// </summary>
        /// <value>The participant&#39;s email address</value>
        /*
        <example>john.doe@email.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The participant&#39;s phone number. This phone number can only be digits with an optional &#39;+&#39; prefix
        /// </summary>
        /// <value>The participant&#39;s phone number. This phone number can only be digits with an optional &#39;+&#39; prefix</value>
        /*
        <example>+5551234567</example>
        */
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The participant&#39;s extension
        /// </summary>
        /// <value>The participant&#39;s extension</value>
        /*
        <example>x3071</example>
        */
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        public string Extension { get; set; }

        /// <summary>
        /// The participant&#39;s location
        /// </summary>
        /// <value>The participant&#39;s location</value>
        /*
        <example>France</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// The participant&#39;s device ID
        /// </summary>
        /// <value>The participant&#39;s device ID</value>
        /*
        <example>3e:24:21:df:02</example>
        */
        [DataMember(Name = "device_id", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The participant&#39;s employee ID
        /// </summary>
        /// <value>The participant&#39;s employee ID</value>
        /*
        <example>2232</example>
        */
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatParticipantInfosInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
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
