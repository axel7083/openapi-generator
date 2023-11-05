// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
    /// DateOnlyClass
    /// </summary>
    public partial class DateOnlyClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOnlyClass" /> class.
        /// </summary>
        /// <param name="dateOnlyProperty">dateOnlyProperty</param>
        [JsonConstructor]
        public DateOnlyClass(Option<DateTime?> dateOnlyProperty = default)
        {
            DateOnlyPropertyOption = dateOnlyProperty;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DateOnlyProperty
        /// </summary>
        [JsonIgnore]
        public Option<DateTime?> DateOnlyPropertyOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateOnlyProperty
        /// </summary>
        /// <example>Fri Jul 21 00:00:00 UTC 2017</example>
        [JsonPropertyName("dateOnlyProperty")]
        public DateTime? DateOnlyProperty { get { return this. DateOnlyPropertyOption; } set { this.DateOnlyPropertyOption = new(value); } }

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
            sb.Append("class DateOnlyClass {\n");
            sb.Append("  DateOnlyProperty: ").Append(DateOnlyProperty).Append("\n");
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
    /// A Json converter for type <see cref="DateOnlyClass" />
    /// </summary>
    public class DateOnlyClassJsonConverter : JsonConverter<DateOnlyClass>
    {
        /// <summary>
        /// The format to use to serialize DateOnlyProperty
        /// </summary>
        public static string DateOnlyPropertyFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// Deserializes json to <see cref="DateOnlyClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DateOnlyClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> dateOnlyProperty = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "dateOnlyProperty":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateOnlyProperty = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (dateOnlyProperty.IsSet && dateOnlyProperty.Value == null)
                throw new ArgumentNullException(nameof(dateOnlyProperty), "Property is not nullable for class DateOnlyClass.");

            return new DateOnlyClass(dateOnlyProperty);
        }

        /// <summary>
        /// Serializes a <see cref="DateOnlyClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateOnlyClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DateOnlyClass dateOnlyClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, dateOnlyClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DateOnlyClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateOnlyClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, DateOnlyClass dateOnlyClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dateOnlyClass.DateOnlyPropertyOption.IsSet)
                writer.WriteString("dateOnlyProperty", dateOnlyClass.DateOnlyPropertyOption.Value.Value.ToString(DateOnlyPropertyFormat));
        }
    }
}
