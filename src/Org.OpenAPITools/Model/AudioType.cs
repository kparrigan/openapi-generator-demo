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
    /// The type of audio
    /// </summary>
    /// <value>The type of audio</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudioType
    {
        /// <summary>
        /// Enum Callrecording for value: callrecording
        /// </summary>
        [EnumMember(Value = "callrecording")]
        Callrecording = 1,

        /// <summary>
        /// Enum Conferencecall for value: conferencecall
        /// </summary>
        [EnumMember(Value = "conferencecall")]
        Conferencecall = 2,

        /// <summary>
        /// Enum Voicemail for value: voicemail
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail = 3
    }

}
