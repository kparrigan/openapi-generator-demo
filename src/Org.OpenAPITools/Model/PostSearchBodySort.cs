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
    /// Sort by attribute of the results. See [this documentation](/documentation/search#sort) for more details
    /// </summary>
    [DataContract(Name = "PostSearchBody_sort")]
    public partial class PostSearchBodySort : IValidatableObject
    {
        /// <summary>
        /// How to sort the results, default is *upload_date*
        /// </summary>
        /// <value>How to sort the results, default is *upload_date*</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ByEnum
        {
            /// <summary>
            /// Enum CreateDate for value: create_date
            /// </summary>
            [EnumMember(Value = "create_date")]
            CreateDate = 1,

            /// <summary>
            /// Enum UploadDate for value: upload_date
            /// </summary>
            [EnumMember(Value = "upload_date")]
            UploadDate = 2
        }


        /// <summary>
        /// How to sort the results, default is *upload_date*
        /// </summary>
        /// <value>How to sort the results, default is *upload_date*</value>
        /*
        <example>create_date</example>
        */
        [DataMember(Name = "by", EmitDefaultValue = false)]
        public ByEnum? By { get; set; }
        /// <summary>
        /// How to sort the results, default is *desc*
        /// </summary>
        /// <value>How to sort the results, default is *desc*</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2
        }


        /// <summary>
        /// How to sort the results, default is *desc*
        /// </summary>
        /// <value>How to sort the results, default is *desc*</value>
        /*
        <example>desc</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSearchBodySort" /> class.
        /// </summary>
        /// <param name="by">How to sort the results, default is *upload_date*.</param>
        /// <param name="order">How to sort the results, default is *desc*.</param>
        public PostSearchBodySort(ByEnum? by = default(ByEnum?), OrderEnum? order = default(OrderEnum?))
        {
            this.By = by;
            this.Order = order;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostSearchBodySort {\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
