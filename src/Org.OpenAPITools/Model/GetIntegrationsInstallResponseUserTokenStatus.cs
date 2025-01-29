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
    /// The integration&#39;s user identity and token status
    /// </summary>
    [DataContract(Name = "GetIntegrationsInstallResponse_user_token_status")]
    public partial class GetIntegrationsInstallResponseUserTokenStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationsInstallResponseUserTokenStatus" /> class.
        /// </summary>
        /// <param name="tenantId">The Microsoft Active Directory tenant ID.</param>
        /// <param name="accountUserId">The user&#39;s Microsoft Active Directory account ID.</param>
        /// <param name="accountUserEmail">The user&#39;s Microsoft Active Directory email address.</param>
        /// <param name="accountUserName">Rich.</param>
        /// <param name="accessTokenExpirationDate">The access token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="refreshTokenExpirationDate">The refresh token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        public GetIntegrationsInstallResponseUserTokenStatus(string tenantId = default(string), string accountUserId = default(string), string accountUserEmail = default(string), string accountUserName = default(string), DateTime accessTokenExpirationDate = default(DateTime), DateTime refreshTokenExpirationDate = default(DateTime))
        {
            this.TenantId = tenantId;
            this.AccountUserId = accountUserId;
            this.AccountUserEmail = accountUserEmail;
            this.AccountUserName = accountUserName;
            this.AccessTokenExpirationDate = accessTokenExpirationDate;
            this.RefreshTokenExpirationDate = refreshTokenExpirationDate;
        }

        /// <summary>
        /// The Microsoft Active Directory tenant ID
        /// </summary>
        /// <value>The Microsoft Active Directory tenant ID</value>
        /*
        <example>5ab96ce0-ce6a-43d4-981b-2388dde4449f</example>
        */
        [DataMember(Name = "tenant_id", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The user&#39;s Microsoft Active Directory account ID
        /// </summary>
        /// <value>The user&#39;s Microsoft Active Directory account ID</value>
        /*
        <example>f6ad3565-db9f-4a63-bff3-7b89409bec32</example>
        */
        [DataMember(Name = "account_user_id", EmitDefaultValue = false)]
        public string AccountUserId { get; set; }

        /// <summary>
        /// The user&#39;s Microsoft Active Directory email address
        /// </summary>
        /// <value>The user&#39;s Microsoft Active Directory email address</value>
        /*
        <example>jane@email.com</example>
        */
        [DataMember(Name = "account_user_email", EmitDefaultValue = false)]
        public string AccountUserEmail { get; set; }

        /// <summary>
        /// Rich
        /// </summary>
        /// <value>Rich</value>
        /*
        <example>Jane Doe</example>
        */
        [DataMember(Name = "account_user_name", EmitDefaultValue = false)]
        public string AccountUserName { get; set; }

        /// <summary>
        /// The access token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The access token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2022-10-13T19:42:29Z</example>
        */
        [DataMember(Name = "access_token_expiration_date", EmitDefaultValue = false)]
        public DateTime AccessTokenExpirationDate { get; set; }

        /// <summary>
        /// The refresh token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The refresh token expiration date. Uses the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2022-08-01T13:31:38Z</example>
        */
        [DataMember(Name = "refresh_token_expiration_date", EmitDefaultValue = false)]
        public DateTime RefreshTokenExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetIntegrationsInstallResponseUserTokenStatus {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  AccountUserId: ").Append(AccountUserId).Append("\n");
            sb.Append("  AccountUserEmail: ").Append(AccountUserEmail).Append("\n");
            sb.Append("  AccountUserName: ").Append(AccountUserName).Append("\n");
            sb.Append("  AccessTokenExpirationDate: ").Append(AccessTokenExpirationDate).Append("\n");
            sb.Append("  RefreshTokenExpirationDate: ").Append(RefreshTokenExpirationDate).Append("\n");
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
