// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Just a string to inform instance is up and running. Make it nullable in hope to get it as pointer in generated model.
    /// </summary>
    public partial class HealthCheckResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckResult" /> class.
        /// </summary>
        /// <param name="nullableMessage">nullableMessage</param>
        [JsonConstructor]
        public HealthCheckResult(Option<string?> nullableMessage = default)
        {
            NullableMessageOption = nullableMessage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of NullableMessage
        /// </summary>
        [JsonIgnore]
        public Option<string?> NullableMessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets NullableMessage
        /// </summary>
        [JsonPropertyName("NullableMessage")]
        public string? NullableMessage { get { return this. NullableMessageOption; } set { this.NullableMessageOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HealthCheckResult {\n");
            sb.Append("  NullableMessage: ").Append(NullableMessage).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="HealthCheckResult" />
    /// </summary>
    public class HealthCheckResultJsonConverter : JsonConverter<HealthCheckResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="HealthCheckResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HealthCheckResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> nullableMessage = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "NullableMessage":
                            nullableMessage = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new HealthCheckResult(nullableMessage);
        }

        /// <summary>
        /// Serializes a <see cref="HealthCheckResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="healthCheckResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HealthCheckResult healthCheckResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, healthCheckResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="HealthCheckResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="healthCheckResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, HealthCheckResult healthCheckResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (healthCheckResult.NullableMessageOption.IsSet)
                if (healthCheckResult.NullableMessageOption.Value != null)
                    writer.WriteString("NullableMessage", healthCheckResult.NullableMessage);
                else
                    writer.WriteNull("NullableMessage");
        }
    }
}
