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
    /// PutRetentionLibraryRequest
    /// </summary>
    [DataContract(Name = "PutRetentionLibraryRequest")]
    public partial class PutRetentionLibraryRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutRetentionLibraryRequest" /> class.
        /// </summary>
        /// <param name="storageAccountId">Storage account ID.</param>
        /// <param name="name">The name of the bucket.</param>
        /// <param name="description">A description of the bucket.</param>
        /// <param name="secCompliantStorageEnabled">Indicates if the storage has SEC Rule 17a-4 compliance enabled.</param>
        /// <param name="retentionPeriodEnabled">Indicates if a retention period policy is currently enabled.</param>
        /// <param name="retentionPeriodDays">Retention period in days.</param>
        /// <param name="retainInReview">Indicates if the retention library should be retained while review is open.</param>
        public PutRetentionLibraryRequest(int storageAccountId = default(int), string name = default(string), string description = default(string), bool secCompliantStorageEnabled = default(bool), bool retentionPeriodEnabled = default(bool), int retentionPeriodDays = default(int), bool retainInReview = default(bool))
        {
            this.StorageAccountId = storageAccountId;
            this.Name = name;
            this.Description = description;
            this.SecCompliantStorageEnabled = secCompliantStorageEnabled;
            this.RetentionPeriodEnabled = retentionPeriodEnabled;
            this.RetentionPeriodDays = retentionPeriodDays;
            this.RetainInReview = retainInReview;
        }

        /// <summary>
        /// Storage account ID
        /// </summary>
        /// <value>Storage account ID</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "storage_account_id", EmitDefaultValue = false)]
        public int StorageAccountId { get; set; }

        /// <summary>
        /// The name of the bucket
        /// </summary>
        /// <value>The name of the bucket</value>
        /*
        <example>Test Bucket</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the bucket
        /// </summary>
        /// <value>A description of the bucket</value>
        /*
        <example>Used to store data for the testing environment</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if the storage has SEC Rule 17a-4 compliance enabled
        /// </summary>
        /// <value>Indicates if the storage has SEC Rule 17a-4 compliance enabled</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "sec_compliant_storage_enabled", EmitDefaultValue = true)]
        public bool SecCompliantStorageEnabled { get; set; }

        /// <summary>
        /// Indicates if a retention period policy is currently enabled
        /// </summary>
        /// <value>Indicates if a retention period policy is currently enabled</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "retention_period_enabled", EmitDefaultValue = true)]
        public bool RetentionPeriodEnabled { get; set; }

        /// <summary>
        /// Retention period in days
        /// </summary>
        /// <value>Retention period in days</value>
        /*
        <example>90</example>
        */
        [DataMember(Name = "retention_period_days", EmitDefaultValue = false)]
        public int RetentionPeriodDays { get; set; }

        /// <summary>
        /// Indicates if the retention library should be retained while review is open
        /// </summary>
        /// <value>Indicates if the retention library should be retained while review is open</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "retain_in_review", EmitDefaultValue = true)]
        public bool RetainInReview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PutRetentionLibraryRequest {\n");
            sb.Append("  StorageAccountId: ").Append(StorageAccountId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SecCompliantStorageEnabled: ").Append(SecCompliantStorageEnabled).Append("\n");
            sb.Append("  RetentionPeriodEnabled: ").Append(RetentionPeriodEnabled).Append("\n");
            sb.Append("  RetentionPeriodDays: ").Append(RetentionPeriodDays).Append("\n");
            sb.Append("  RetainInReview: ").Append(RetainInReview).Append("\n");
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
