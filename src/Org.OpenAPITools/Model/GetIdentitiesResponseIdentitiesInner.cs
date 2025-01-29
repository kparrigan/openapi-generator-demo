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
    /// GetIdentitiesResponseIdentitiesInner
    /// </summary>
    [DataContract(Name = "GetIdentitiesResponse_identities_inner")]
    public partial class GetIdentitiesResponseIdentitiesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIdentitiesResponseIdentitiesInner" /> class.
        /// </summary>
        /// <param name="createdAt">The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="email">Email of the identity user.</param>
        /// <param name="emailEndDate">Email end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="emailStartDate">Email start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="externalId">An external ID for the identity.</param>
        /// <param name="externalIdEndDate">External ID end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="externalIdStartDate">External ID start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="extraAttributes">Extra attributes are free form attributes that can be used to store any extra meta data about this identity.</param>
        /// <param name="id">The identity ID.</param>
        /// <param name="isSubmitter">Indicates if the identity did submit data.</param>
        /// <param name="managed">Indicates if the identity is externally managed by the API.</param>
        /// <param name="name">The identity&#39;s name.</param>
        /// <param name="phoneNumber">The identity&#39;s phone number.</param>
        /// <param name="phoneNumberEndDate">Phone number end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="phoneNumberStartDate">Phone number start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="risky">Indicates if the user has been classified as risky.</param>
        /// <param name="source">The originating source for the identity (e.g. Azure, MS Teams, Zoom, API, etc.).</param>
        /// <param name="updatedAt">The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        public GetIdentitiesResponseIdentitiesInner(DateTime createdAt = default(DateTime), string email = default(string), DateTime? emailEndDate = default(DateTime?), DateTime? emailStartDate = default(DateTime?), string externalId = default(string), DateTime? externalIdEndDate = default(DateTime?), DateTime? externalIdStartDate = default(DateTime?), List<IdentityExtraAttributesInner> extraAttributes = default(List<IdentityExtraAttributesInner>), int id = default(int), bool isSubmitter = default(bool), bool managed = default(bool), string name = default(string), string phoneNumber = default(string), DateTime? phoneNumberEndDate = default(DateTime?), DateTime? phoneNumberStartDate = default(DateTime?), bool risky = default(bool), string source = default(string), DateTime updatedAt = default(DateTime))
        {
            this.CreatedAt = createdAt;
            this.Email = email;
            this.EmailEndDate = emailEndDate;
            this.EmailStartDate = emailStartDate;
            this.ExternalId = externalId;
            this.ExternalIdEndDate = externalIdEndDate;
            this.ExternalIdStartDate = externalIdStartDate;
            this.ExtraAttributes = extraAttributes;
            this.Id = id;
            this.IsSubmitter = isSubmitter;
            this.Managed = managed;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberEndDate = phoneNumberEndDate;
            this.PhoneNumberStartDate = phoneNumberStartDate;
            this.Risky = risky;
            this.Source = source;
            this.UpdatedAt = updatedAt;
        }

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
        /// Email of the identity user
        /// </summary>
        /// <value>Email of the identity user</value>
        /*
        <example>john.smith@gmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Email end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Email end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "email_end_date", EmitDefaultValue = true)]
        public DateTime? EmailEndDate { get; set; }

        /// <summary>
        /// Email start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Email start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2018-11-28T17:12:12Z</example>
        */
        [DataMember(Name = "email_start_date", EmitDefaultValue = true)]
        public DateTime? EmailStartDate { get; set; }

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
        /// External ID end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>External ID end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "external_id_end_date", EmitDefaultValue = true)]
        public DateTime? ExternalIdEndDate { get; set; }

        /// <summary>
        /// External ID start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>External ID start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "external_id_start_date", EmitDefaultValue = true)]
        public DateTime? ExternalIdStartDate { get; set; }

        /// <summary>
        /// Extra attributes are free form attributes that can be used to store any extra meta data about this identity
        /// </summary>
        /// <value>Extra attributes are free form attributes that can be used to store any extra meta data about this identity</value>
        [DataMember(Name = "extra_attributes", EmitDefaultValue = false)]
        public List<IdentityExtraAttributesInner> ExtraAttributes { get; set; }

        /// <summary>
        /// The identity ID
        /// </summary>
        /// <value>The identity ID</value>
        /*
        <example>88532</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Indicates if the identity did submit data
        /// </summary>
        /// <value>Indicates if the identity did submit data</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "is_submitter", EmitDefaultValue = true)]
        public bool IsSubmitter { get; set; }

        /// <summary>
        /// Indicates if the identity is externally managed by the API
        /// </summary>
        /// <value>Indicates if the identity is externally managed by the API</value>
        [DataMember(Name = "managed", EmitDefaultValue = true)]
        public bool Managed { get; set; }

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
        /// Phone number end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Phone number end date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "phone_number_end_date", EmitDefaultValue = true)]
        public DateTime? PhoneNumberEndDate { get; set; }

        /// <summary>
        /// Phone number start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>Phone number start date timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "phone_number_start_date", EmitDefaultValue = true)]
        public DateTime? PhoneNumberStartDate { get; set; }

        /// <summary>
        /// Indicates if the user has been classified as risky
        /// </summary>
        /// <value>Indicates if the user has been classified as risky</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "risky", EmitDefaultValue = true)]
        public bool Risky { get; set; }

        /// <summary>
        /// The originating source for the identity (e.g. Azure, MS Teams, Zoom, API, etc.)
        /// </summary>
        /// <value>The originating source for the identity (e.g. Azure, MS Teams, Zoom, API, etc.)</value>
        /*
        <example>API</example>
        */
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

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
            sb.Append("class GetIdentitiesResponseIdentitiesInner {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailEndDate: ").Append(EmailEndDate).Append("\n");
            sb.Append("  EmailStartDate: ").Append(EmailStartDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ExternalIdEndDate: ").Append(ExternalIdEndDate).Append("\n");
            sb.Append("  ExternalIdStartDate: ").Append(ExternalIdStartDate).Append("\n");
            sb.Append("  ExtraAttributes: ").Append(ExtraAttributes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsSubmitter: ").Append(IsSubmitter).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberEndDate: ").Append(PhoneNumberEndDate).Append("\n");
            sb.Append("  PhoneNumberStartDate: ").Append(PhoneNumberStartDate).Append("\n");
            sb.Append("  Risky: ").Append(Risky).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
