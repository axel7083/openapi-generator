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
    /// Model for testing model name starting with number
    /// </summary>
    public partial class Model200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model200Response" /> class.
        /// </summary>
        /// <param name="varClass">varClass</param>
        /// <param name="name">name</param>
        [JsonConstructor]
        public Model200Response(Option<string> varClass = default, Option<int?> name = default)
        {
            VarClassOption = varClass;
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VarClass
        /// </summary>
        [JsonIgnore]
        public Option<string> VarClassOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarClass
        /// </summary>
        [JsonPropertyName("class")]
        public string VarClass { get { return this. VarClassOption; } set { this.VarClassOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        public Option<int?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public int? Name { get { return this. NameOption; } set { this.NameOption = new(value); } }

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
            sb.Append("class Model200Response {\n");
            sb.Append("  VarClass: ").Append(VarClass).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="Model200Response" />
    /// </summary>
    public class Model200ResponseJsonConverter : JsonConverter<Model200Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="Model200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Model200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> varClass = default;
            Option<int?> name = default;

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
                        case "class":
                            varClass = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                name = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (varClass.IsSet && varClass.Value == null)
                throw new ArgumentNullException(nameof(varClass), "Property is not nullable for class Model200Response.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class Model200Response.");

            return new Model200Response(varClass, name);
        }

        /// <summary>
        /// Serializes a <see cref="Model200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="model200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Model200Response model200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, model200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Model200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="model200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Model200Response model200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (model200Response.VarClassOption.IsSet && model200Response.VarClass == null)
                throw new ArgumentNullException(nameof(model200Response.VarClass), "Property is required for class Model200Response.");

            if (model200Response.VarClassOption.IsSet)
                writer.WriteString("class", model200Response.VarClass);

            if (model200Response.NameOption.IsSet)
                writer.WriteNumber("name", model200Response.NameOption.Value.Value);
        }
    }
}
