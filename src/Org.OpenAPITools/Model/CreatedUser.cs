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
    /// CreatedUser
    /// </summary>
    [DataContract(Name = "CreatedUser")]
    public partial class CreatedUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedUser" /> class.
        /// </summary>
        /// <param name="createdAt">The created timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="currentOrgUnit">currentOrgUnit.</param>
        /// <param name="customer">customer.</param>
        /// <param name="disabled">Indicates if the user has been disabled.</param>
        /// <param name="defaultUserTimezone">Timezone the user is assigned to by default.</param>
        /// <param name="disabledAt">When the user was disabled timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="email">The email address associated with this user.</param>
        /// <param name="forceSso">Indicates if the user has to use SSO to sign in.</param>
        /// <param name="hasDatums">Indicates if the user is associated with any captured datums.</param>
        /// <param name="hasMultipleWorkspaces">Indicates if the user is assigned to multiple workspaces.</param>
        /// <param name="id">The user ID.</param>
        /// <param name="lastLogin">The user&#39;s last login timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="name">The user&#39;s name.</param>
        /// <param name="otpEnabled">Indicates if the use has OTP enabled.</param>
        /// <param name="otpEnabledAt">The timestamp of when OTP was enabled using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="passwordChangedAt">The timestamp of the last time the user&#39;s password was changed using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="queuePaused">Indicates if the users queue has been paused.</param>
        /// <param name="role">role.</param>
        /// <param name="searchId">The ID of the search used for the user&#39;s security filter.</param>
        /// <param name="updatedAt">The updated timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6).</param>
        /// <param name="userInitials">The user&#39;s initials.</param>
        public CreatedUser(DateTime createdAt = default(DateTime), SchemasCurrentOrgUnit currentOrgUnit = default(SchemasCurrentOrgUnit), Customer customer = default(Customer), bool disabled = default(bool), string defaultUserTimezone = default(string), DateTime? disabledAt = default(DateTime?), string email = default(string), bool forceSso = default(bool), bool hasDatums = default(bool), bool hasMultipleWorkspaces = default(bool), int id = default(int), DateTime? lastLogin = default(DateTime?), string name = default(string), bool otpEnabled = default(bool), DateTime? otpEnabledAt = default(DateTime?), DateTime? passwordChangedAt = default(DateTime?), bool queuePaused = default(bool), Role role = default(Role), int? searchId = default(int?), DateTime updatedAt = default(DateTime), string userInitials = default(string))
        {
            this.CreatedAt = createdAt;
            this.CurrentOrgUnit = currentOrgUnit;
            this.Customer = customer;
            this.Disabled = disabled;
            this.DefaultUserTimezone = defaultUserTimezone;
            this.DisabledAt = disabledAt;
            this.Email = email;
            this.ForceSso = forceSso;
            this.HasDatums = hasDatums;
            this.HasMultipleWorkspaces = hasMultipleWorkspaces;
            this.Id = id;
            this.LastLogin = lastLogin;
            this.Name = name;
            this.OtpEnabled = otpEnabled;
            this.OtpEnabledAt = otpEnabledAt;
            this.PasswordChangedAt = passwordChangedAt;
            this.QueuePaused = queuePaused;
            this.Role = role;
            this.SearchId = searchId;
            this.UpdatedAt = updatedAt;
            this.UserInitials = userInitials;
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
        /// Gets or Sets CurrentOrgUnit
        /// </summary>
        [DataMember(Name = "current_org_unit", EmitDefaultValue = false)]
        public SchemasCurrentOrgUnit CurrentOrgUnit { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Indicates if the user has been disabled
        /// </summary>
        /// <value>Indicates if the user has been disabled</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Timezone the user is assigned to by default
        /// </summary>
        /// <value>Timezone the user is assigned to by default</value>
        [DataMember(Name = "default_user_timezone", EmitDefaultValue = true)]
        public string DefaultUserTimezone { get; set; }

        /// <summary>
        /// When the user was disabled timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>When the user was disabled timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "disabled_at", EmitDefaultValue = true)]
        public DateTime? DisabledAt { get; set; }

        /// <summary>
        /// The email address associated with this user
        /// </summary>
        /// <value>The email address associated with this user</value>
        /*
        <example>jane@email.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates if the user has to use SSO to sign in
        /// </summary>
        /// <value>Indicates if the user has to use SSO to sign in</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "force_sso", EmitDefaultValue = true)]
        public bool ForceSso { get; set; }

        /// <summary>
        /// Indicates if the user is associated with any captured datums
        /// </summary>
        /// <value>Indicates if the user is associated with any captured datums</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "has_datums", EmitDefaultValue = true)]
        public bool HasDatums { get; set; }

        /// <summary>
        /// Indicates if the user is assigned to multiple workspaces
        /// </summary>
        /// <value>Indicates if the user is assigned to multiple workspaces</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "has_multiple_workspaces", EmitDefaultValue = true)]
        public bool HasMultipleWorkspaces { get; set; }

        /// <summary>
        /// The user ID
        /// </summary>
        /// <value>The user ID</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The user&#39;s last login timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The user&#39;s last login timestamp using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        /*
        <example>2022-10-21T16:08:37Z</example>
        */
        [DataMember(Name = "last_login", EmitDefaultValue = true)]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// The user&#39;s name
        /// </summary>
        /// <value>The user&#39;s name</value>
        /*
        <example>Jane Doe</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the use has OTP enabled
        /// </summary>
        /// <value>Indicates if the use has OTP enabled</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "otp_enabled", EmitDefaultValue = true)]
        public bool OtpEnabled { get; set; }

        /// <summary>
        /// The timestamp of when OTP was enabled using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The timestamp of when OTP was enabled using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "otp_enabled_at", EmitDefaultValue = true)]
        public DateTime? OtpEnabledAt { get; set; }

        /// <summary>
        /// The timestamp of the last time the user&#39;s password was changed using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)
        /// </summary>
        /// <value>The timestamp of the last time the user&#39;s password was changed using the [RFC3339 date-time format](https://www.rfc-editor.org/rfc/rfc3339#section-5.6)</value>
        [DataMember(Name = "password_changed_at", EmitDefaultValue = true)]
        public DateTime? PasswordChangedAt { get; set; }

        /// <summary>
        /// Indicates if the users queue has been paused
        /// </summary>
        /// <value>Indicates if the users queue has been paused</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "queue_paused", EmitDefaultValue = true)]
        public bool QueuePaused { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public Role Role { get; set; }

        /// <summary>
        /// The ID of the search used for the user&#39;s security filter
        /// </summary>
        /// <value>The ID of the search used for the user&#39;s security filter</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "search_id", EmitDefaultValue = true)]
        public int? SearchId { get; set; }

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
        /// The user&#39;s initials
        /// </summary>
        /// <value>The user&#39;s initials</value>
        /*
        <example>JD</example>
        */
        [DataMember(Name = "user_initials", EmitDefaultValue = false)]
        public string UserInitials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatedUser {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentOrgUnit: ").Append(CurrentOrgUnit).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  DefaultUserTimezone: ").Append(DefaultUserTimezone).Append("\n");
            sb.Append("  DisabledAt: ").Append(DisabledAt).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ForceSso: ").Append(ForceSso).Append("\n");
            sb.Append("  HasDatums: ").Append(HasDatums).Append("\n");
            sb.Append("  HasMultipleWorkspaces: ").Append(HasMultipleWorkspaces).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OtpEnabled: ").Append(OtpEnabled).Append("\n");
            sb.Append("  OtpEnabledAt: ").Append(OtpEnabledAt).Append("\n");
            sb.Append("  PasswordChangedAt: ").Append(PasswordChangedAt).Append("\n");
            sb.Append("  QueuePaused: ").Append(QueuePaused).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserInitials: ").Append(UserInitials).Append("\n");
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
