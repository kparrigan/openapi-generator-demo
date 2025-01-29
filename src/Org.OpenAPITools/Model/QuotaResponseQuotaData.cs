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
    /// QuotaResponseQuotaData
    /// </summary>
    [DataContract(Name = "QuotaResponse_quota_data")]
    public partial class QuotaResponseQuotaData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaResponseQuotaData" /> class.
        /// </summary>
        /// <param name="apiAttachmentBytesUsed">The used quota in bytes for API attachment data.</param>
        /// <param name="apiBytes">The quota in bytes for API data.</param>
        /// <param name="apiBytesDaily">The daily used quota in bytes for API data.</param>
        /// <param name="apiBytesUsed">The used quota in bytes for API data.</param>
        /// <param name="audioAttachmentBytesUsed">The used quota in bytes for audio attachment data.</param>
        /// <param name="audioBytes">The quota in bytes for audio data.</param>
        /// <param name="audioBytesUsed">The used quota in bytes for audio data.</param>
        /// <param name="documentAttachmentBytesUsed">The used quota in bytes for document attachment data.</param>
        /// <param name="documentBytes">The quota in bytes for document data.</param>
        /// <param name="documentBytesUsed">The used quota in bytes for document data.</param>
        /// <param name="emailAttachmentBytesUsed">The used quota in bytes for email attachment data.</param>
        /// <param name="emailBytes">The quota in bytes for email data.</param>
        /// <param name="emailBytesUsed">The used quota in bytes for email data.</param>
        /// <param name="otherAttachmentBytesUsed">The used quota in bytes for all other attachment data.</param>
        /// <param name="otherBytes">The quota in bytes for all other types of data.</param>
        /// <param name="otherBytesUsed">The used quota in bytes for all other types of data.</param>
        /// <param name="totalBytes">The quota in bytes for all data.</param>
        /// <param name="totalBytesDaily">The daily used quota in bytes for all data.</param>
        /// <param name="totalBytesUsed">The used quota in bytes for all data.</param>
        /// <param name="videoAttachmentBytesUsed">The used quota in bytes for video attachment data.</param>
        /// <param name="videoBytes">The quota in bytes for video data.</param>
        /// <param name="videoBytesUsed">The used quota in bytes for video data.</param>
        public QuotaResponseQuotaData(int apiAttachmentBytesUsed = default(int), int apiBytes = default(int), int apiBytesDaily = default(int), int apiBytesUsed = default(int), int audioAttachmentBytesUsed = default(int), int audioBytes = default(int), int audioBytesUsed = default(int), int documentAttachmentBytesUsed = default(int), int documentBytes = default(int), int documentBytesUsed = default(int), int emailAttachmentBytesUsed = default(int), int emailBytes = default(int), int emailBytesUsed = default(int), int otherAttachmentBytesUsed = default(int), int otherBytes = default(int), int otherBytesUsed = default(int), int totalBytes = default(int), int totalBytesDaily = default(int), int totalBytesUsed = default(int), int videoAttachmentBytesUsed = default(int), int videoBytes = default(int), int videoBytesUsed = default(int))
        {
            this.ApiAttachmentBytesUsed = apiAttachmentBytesUsed;
            this.ApiBytes = apiBytes;
            this.ApiBytesDaily = apiBytesDaily;
            this.ApiBytesUsed = apiBytesUsed;
            this.AudioAttachmentBytesUsed = audioAttachmentBytesUsed;
            this.AudioBytes = audioBytes;
            this.AudioBytesUsed = audioBytesUsed;
            this.DocumentAttachmentBytesUsed = documentAttachmentBytesUsed;
            this.DocumentBytes = documentBytes;
            this.DocumentBytesUsed = documentBytesUsed;
            this.EmailAttachmentBytesUsed = emailAttachmentBytesUsed;
            this.EmailBytes = emailBytes;
            this.EmailBytesUsed = emailBytesUsed;
            this.OtherAttachmentBytesUsed = otherAttachmentBytesUsed;
            this.OtherBytes = otherBytes;
            this.OtherBytesUsed = otherBytesUsed;
            this.TotalBytes = totalBytes;
            this.TotalBytesDaily = totalBytesDaily;
            this.TotalBytesUsed = totalBytesUsed;
            this.VideoAttachmentBytesUsed = videoAttachmentBytesUsed;
            this.VideoBytes = videoBytes;
            this.VideoBytesUsed = videoBytesUsed;
        }

        /// <summary>
        /// The used quota in bytes for API attachment data
        /// </summary>
        /// <value>The used quota in bytes for API attachment data</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "api_attachment_bytes_used", EmitDefaultValue = false)]
        public int ApiAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for API data
        /// </summary>
        /// <value>The quota in bytes for API data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "api_bytes", EmitDefaultValue = false)]
        public int ApiBytes { get; set; }

        /// <summary>
        /// The daily used quota in bytes for API data
        /// </summary>
        /// <value>The daily used quota in bytes for API data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "api_bytes_daily", EmitDefaultValue = false)]
        public int ApiBytesDaily { get; set; }

        /// <summary>
        /// The used quota in bytes for API data
        /// </summary>
        /// <value>The used quota in bytes for API data</value>
        /*
        <example>2136220124</example>
        */
        [DataMember(Name = "api_bytes_used", EmitDefaultValue = false)]
        public int ApiBytesUsed { get; set; }

        /// <summary>
        /// The used quota in bytes for audio attachment data
        /// </summary>
        /// <value>The used quota in bytes for audio attachment data</value>
        /*
        <example>397</example>
        */
        [DataMember(Name = "audio_attachment_bytes_used", EmitDefaultValue = false)]
        public int AudioAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for audio data
        /// </summary>
        /// <value>The quota in bytes for audio data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "audio_bytes", EmitDefaultValue = false)]
        public int AudioBytes { get; set; }

        /// <summary>
        /// The used quota in bytes for audio data
        /// </summary>
        /// <value>The used quota in bytes for audio data</value>
        /*
        <example>424210501</example>
        */
        [DataMember(Name = "audio_bytes_used", EmitDefaultValue = false)]
        public int AudioBytesUsed { get; set; }

        /// <summary>
        /// The used quota in bytes for document attachment data
        /// </summary>
        /// <value>The used quota in bytes for document attachment data</value>
        /*
        <example>8317757</example>
        */
        [DataMember(Name = "document_attachment_bytes_used", EmitDefaultValue = false)]
        public int DocumentAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for document data
        /// </summary>
        /// <value>The quota in bytes for document data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "document_bytes", EmitDefaultValue = false)]
        public int DocumentBytes { get; set; }

        /// <summary>
        /// The used quota in bytes for document data
        /// </summary>
        /// <value>The used quota in bytes for document data</value>
        /*
        <example>24145186</example>
        */
        [DataMember(Name = "document_bytes_used", EmitDefaultValue = false)]
        public int DocumentBytesUsed { get; set; }

        /// <summary>
        /// The used quota in bytes for email attachment data
        /// </summary>
        /// <value>The used quota in bytes for email attachment data</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "email_attachment_bytes_used", EmitDefaultValue = false)]
        public int EmailAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for email data
        /// </summary>
        /// <value>The quota in bytes for email data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "email_bytes", EmitDefaultValue = false)]
        public int EmailBytes { get; set; }

        /// <summary>
        /// The used quota in bytes for email data
        /// </summary>
        /// <value>The used quota in bytes for email data</value>
        /*
        <example>28652866</example>
        */
        [DataMember(Name = "email_bytes_used", EmitDefaultValue = false)]
        public int EmailBytesUsed { get; set; }

        /// <summary>
        /// The used quota in bytes for all other attachment data
        /// </summary>
        /// <value>The used quota in bytes for all other attachment data</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "other_attachment_bytes_used", EmitDefaultValue = false)]
        public int OtherAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for all other types of data
        /// </summary>
        /// <value>The quota in bytes for all other types of data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "other_bytes", EmitDefaultValue = false)]
        public int OtherBytes { get; set; }

        /// <summary>
        /// The used quota in bytes for all other types of data
        /// </summary>
        /// <value>The used quota in bytes for all other types of data</value>
        /*
        <example>653135</example>
        */
        [DataMember(Name = "other_bytes_used", EmitDefaultValue = false)]
        public int OtherBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for all data
        /// </summary>
        /// <value>The quota in bytes for all data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "total_bytes", EmitDefaultValue = false)]
        public int TotalBytes { get; set; }

        /// <summary>
        /// The daily used quota in bytes for all data
        /// </summary>
        /// <value>The daily used quota in bytes for all data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "total_bytes_daily", EmitDefaultValue = false)]
        public int TotalBytesDaily { get; set; }

        /// <summary>
        /// The used quota in bytes for all data
        /// </summary>
        /// <value>The used quota in bytes for all data</value>
        /*
        <example>6220124</example>
        */
        [DataMember(Name = "total_bytes_used", EmitDefaultValue = false)]
        public int TotalBytesUsed { get; set; }

        /// <summary>
        /// The used quota in bytes for video attachment data
        /// </summary>
        /// <value>The used quota in bytes for video attachment data</value>
        /*
        <example>25181</example>
        */
        [DataMember(Name = "video_attachment_bytes_used", EmitDefaultValue = false)]
        public int VideoAttachmentBytesUsed { get; set; }

        /// <summary>
        /// The quota in bytes for video data
        /// </summary>
        /// <value>The quota in bytes for video data</value>
        /*
        <example>1000000000</example>
        */
        [DataMember(Name = "video_bytes", EmitDefaultValue = false)]
        public int VideoBytes { get; set; }

        /// <summary>
        /// The used quota in bytes for video data
        /// </summary>
        /// <value>The used quota in bytes for video data</value>
        /*
        <example>81802101</example>
        */
        [DataMember(Name = "video_bytes_used", EmitDefaultValue = false)]
        public int VideoBytesUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotaResponseQuotaData {\n");
            sb.Append("  ApiAttachmentBytesUsed: ").Append(ApiAttachmentBytesUsed).Append("\n");
            sb.Append("  ApiBytes: ").Append(ApiBytes).Append("\n");
            sb.Append("  ApiBytesDaily: ").Append(ApiBytesDaily).Append("\n");
            sb.Append("  ApiBytesUsed: ").Append(ApiBytesUsed).Append("\n");
            sb.Append("  AudioAttachmentBytesUsed: ").Append(AudioAttachmentBytesUsed).Append("\n");
            sb.Append("  AudioBytes: ").Append(AudioBytes).Append("\n");
            sb.Append("  AudioBytesUsed: ").Append(AudioBytesUsed).Append("\n");
            sb.Append("  DocumentAttachmentBytesUsed: ").Append(DocumentAttachmentBytesUsed).Append("\n");
            sb.Append("  DocumentBytes: ").Append(DocumentBytes).Append("\n");
            sb.Append("  DocumentBytesUsed: ").Append(DocumentBytesUsed).Append("\n");
            sb.Append("  EmailAttachmentBytesUsed: ").Append(EmailAttachmentBytesUsed).Append("\n");
            sb.Append("  EmailBytes: ").Append(EmailBytes).Append("\n");
            sb.Append("  EmailBytesUsed: ").Append(EmailBytesUsed).Append("\n");
            sb.Append("  OtherAttachmentBytesUsed: ").Append(OtherAttachmentBytesUsed).Append("\n");
            sb.Append("  OtherBytes: ").Append(OtherBytes).Append("\n");
            sb.Append("  OtherBytesUsed: ").Append(OtherBytesUsed).Append("\n");
            sb.Append("  TotalBytes: ").Append(TotalBytes).Append("\n");
            sb.Append("  TotalBytesDaily: ").Append(TotalBytesDaily).Append("\n");
            sb.Append("  TotalBytesUsed: ").Append(TotalBytesUsed).Append("\n");
            sb.Append("  VideoAttachmentBytesUsed: ").Append(VideoAttachmentBytesUsed).Append("\n");
            sb.Append("  VideoBytes: ").Append(VideoBytes).Append("\n");
            sb.Append("  VideoBytesUsed: ").Append(VideoBytesUsed).Append("\n");
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
