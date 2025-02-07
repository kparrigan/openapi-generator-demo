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
    /// PostChatConversationBodyChatAttachmentsInner
    /// </summary>
    [DataContract(Name = "PostChatConversationBody_chat_attachments_inner")]
    public partial class PostChatConversationBodyChatAttachmentsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostChatConversationBodyChatAttachmentsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostChatConversationBodyChatAttachmentsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostChatConversationBodyChatAttachmentsInner" /> class.
        /// </summary>
        /// <param name="id">A unique ID for the attachment. Used to reference attachments in the chat messages. (required).</param>
        /// <param name="name">The file name of the attachment. **Must match the file name of the actual attachment** (required).</param>
        /// <param name="size">The size in bytes of the attachment.</param>
        /// <param name="contentType">The content-type of the attachment. Uses standard [MIME types](https://www.iana.org/assignments/media-types/media-types.xhtml) (required).</param>
        /// <param name="createTime">The creation timestamp of the attachment in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        public PostChatConversationBodyChatAttachmentsInner(string id = default(string), string name = default(string), int size = default(int), string contentType = default(string), DateTime createTime = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PostChatConversationBodyChatAttachmentsInner and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PostChatConversationBodyChatAttachmentsInner and cannot be null");
            }
            this.Name = name;
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for PostChatConversationBodyChatAttachmentsInner and cannot be null");
            }
            this.ContentType = contentType;
            this.Size = size;
            this.CreateTime = createTime;
        }

        /// <summary>
        /// A unique ID for the attachment. Used to reference attachments in the chat messages.
        /// </summary>
        /// <value>A unique ID for the attachment. Used to reference attachments in the chat messages.</value>
        /*
        <example>example-attachment-id</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The file name of the attachment. **Must match the file name of the actual attachment**
        /// </summary>
        /// <value>The file name of the attachment. **Must match the file name of the actual attachment**</value>
        /*
        <example>shared_image.png</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The size in bytes of the attachment
        /// </summary>
        /// <value>The size in bytes of the attachment</value>
        /*
        <example>355435</example>
        */
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// The content-type of the attachment. Uses standard [MIME types](https://www.iana.org/assignments/media-types/media-types.xhtml)
        /// </summary>
        /// <value>The content-type of the attachment. Uses standard [MIME types](https://www.iana.org/assignments/media-types/media-types.xhtml)</value>
        /*
        <example>image/png</example>
        */
        [DataMember(Name = "content_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The creation timestamp of the attachment in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The creation timestamp of the attachment in [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2023-06-08T13:08:43Z</example>
        */
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostChatConversationBodyChatAttachmentsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
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
