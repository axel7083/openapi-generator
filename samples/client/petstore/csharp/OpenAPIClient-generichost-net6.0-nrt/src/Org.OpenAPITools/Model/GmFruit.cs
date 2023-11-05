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
    /// GmFruit
    /// </summary>
    public partial class GmFruit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GmFruit" /> class.
        /// </summary>
        /// <param name="apple"></param>
        /// <param name="banana"></param>
        /// <param name="color">color</param>
        public GmFruit(Option<Apple?> apple, Option<Banana?> banana, Option<string?> color = default)
        {
            AppleOption = apple;
            BananaOption = banana;
            ColorOption = color;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Apple
        /// </summary>
        [JsonIgnore]
        public Option<Apple?> AppleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Apple
        /// </summary>
        public Apple? Apple { get { return this.AppleOption; } set { this.AppleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Banana
        /// </summary>
        [JsonIgnore]
        public Option<Banana?> BananaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Banana
        /// </summary>
        public Banana? Banana { get { return this.BananaOption; } set { this.BananaOption = new(value); } }

        /// <summary>
        /// Used to track the state of Color
        /// </summary>
        [JsonIgnore]
        public Option<string?> ColorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get { return this. ColorOption; } set { this.ColorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GmFruit {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
    /// A Json converter for type <see cref="GmFruit" />
    /// </summary>
    public class GmFruitJsonConverter : JsonConverter<GmFruit>
    {
        /// <summary>
        /// Deserializes json to <see cref="GmFruit" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GmFruit Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> color = default;

            Apple? apple = default;
            Banana? banana = default;

            Utf8JsonReader utf8JsonReaderAnyOf = utf8JsonReader;
            while (utf8JsonReaderAnyOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (utf8JsonReaderAnyOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderAnyOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderApple = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<Apple?>(ref utf8JsonReaderApple, jsonSerializerOptions, out apple);

                    Utf8JsonReader utf8JsonReaderBanana = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<Banana?>(ref utf8JsonReaderBanana, jsonSerializerOptions, out banana);
                }
            }

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
                        case "color":
                            color = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (color.IsSet && color.Value == null)
                throw new ArgumentNullException(nameof(color), "Property is not nullable for class GmFruit.");

            Option<Apple?> appleParsedValue = apple == null
                ? default
                : new Option<Apple?>(apple);
            Option<Banana?> bananaParsedValue = banana == null
                ? default
                : new Option<Banana?>(banana);

            return new GmFruit(appleParsedValue, bananaParsedValue, color);
        }

        /// <summary>
        /// Serializes a <see cref="GmFruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gmFruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GmFruit gmFruit, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (gmFruit.AppleOption.IsSet && gmFruit.AppleOption.Value != null)
            {
                AppleJsonConverter AppleJsonConverter = (AppleJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(gmFruit.AppleOption.Value.GetType()));
                AppleJsonConverter.WriteProperties(ref writer, gmFruit.AppleOption.Value, jsonSerializerOptions);
            }

            if (gmFruit.BananaOption.IsSet && gmFruit.BananaOption.Value != null)
            {
                BananaJsonConverter BananaJsonConverter = (BananaJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(gmFruit.BananaOption.Value.GetType()));
                BananaJsonConverter.WriteProperties(ref writer, gmFruit.BananaOption.Value, jsonSerializerOptions);
            }

            WriteProperties(ref writer, gmFruit, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GmFruit" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gmFruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GmFruit gmFruit, JsonSerializerOptions jsonSerializerOptions)
        {
            if (gmFruit.ColorOption.IsSet && gmFruit.Color == null)
                throw new ArgumentNullException(nameof(gmFruit.Color), "Property is required for class GmFruit.");

            if (gmFruit.ColorOption.IsSet)
                writer.WriteString("color", gmFruit.Color);
        }
    }
}
