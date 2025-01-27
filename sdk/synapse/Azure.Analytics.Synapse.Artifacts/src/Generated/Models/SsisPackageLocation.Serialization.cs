// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisPackageLocationConverter))]
    public partial class SsisPackageLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePath))
            {
                writer.WritePropertyName("packagePath");
                writer.WriteObjectValue(PackagePath);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PackagePassword))
            {
                writer.WritePropertyName("packagePassword");
                writer.WriteObjectValue(PackagePassword);
            }
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential");
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(ConfigurationPath))
            {
                writer.WritePropertyName("configurationPath");
                writer.WriteObjectValue(ConfigurationPath);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName");
                writer.WriteStringValue(PackageName);
            }
            if (Optional.IsDefined(PackageContent))
            {
                writer.WritePropertyName("packageContent");
                writer.WriteObjectValue(PackageContent);
            }
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate");
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            if (Optional.IsCollectionDefined(ChildPackages))
            {
                writer.WritePropertyName("childPackages");
                writer.WriteStartArray();
                foreach (var item in ChildPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisPackageLocation DeserializeSsisPackageLocation(JsonElement element)
        {
            Optional<object> packagePath = default;
            Optional<SsisPackageLocationType> type = default;
            Optional<SecretBase> packagePassword = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<object> configurationPath = default;
            Optional<string> packageName = default;
            Optional<object> packageContent = default;
            Optional<string> packageLastModifiedDate = default;
            Optional<IList<SsisChildPackage>> childPackages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    packagePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new SsisPackageLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packagePassword"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            packagePassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            configurationPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("packageName"))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageContent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            packageContent = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("packageLastModifiedDate"))
                        {
                            packageLastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("childPackages"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SsisChildPackage> array = new List<SsisChildPackage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SsisChildPackage.DeserializeSsisChildPackage(item));
                            }
                            childPackages = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisPackageLocation(packagePath.Value, Optional.ToNullable(type), packagePassword.Value, accessCredential.Value, configurationPath.Value, packageName.Value, packageContent.Value, packageLastModifiedDate.Value, Optional.ToList(childPackages));
        }

        internal partial class SsisPackageLocationConverter : JsonConverter<SsisPackageLocation>
        {
            public override void Write(Utf8JsonWriter writer, SsisPackageLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisPackageLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisPackageLocation(document.RootElement);
            }
        }
    }
}
