// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace Microsoft.Kiota.Serialization.Multipart;
/// <summary>
/// Serialization writer for multipart payloads.
/// </summary>
public class MultipartSerializationWriter : ISerializationWriter
{
    /// <inheritdoc/>
    public Action<IParsable>? OnBeforeObjectSerialization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <inheritdoc/>
    public Action<IParsable>? OnAfterObjectSerialization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <inheritdoc/>
    public Action<IParsable, ISerializationWriter>? OnStartObjectSerialization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    /// <inheritdoc/>
    public void Dispose() => throw new NotImplementedException();
    /// <inheritdoc/>
    public Stream GetSerializedContent() => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteAdditionalData(IDictionary<string, object> value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteBoolValue(string? key, bool? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteByteArrayValue(string? key, byte[]? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteByteValue(string? key, byte? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteCollectionOfEnumValues<T>(string? key, IEnumerable<T?>? values) where T : struct, Enum => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteCollectionOfObjectValues<T>(string? key, IEnumerable<T>? values) where T : IParsable => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteCollectionOfPrimitiveValues<T>(string? key, IEnumerable<T>? values) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteDateTimeOffsetValue(string? key, DateTimeOffset? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteDateValue(string? key, Date? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteDecimalValue(string? key, decimal? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteDoubleValue(string? key, double? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteEnumValue<T>(string? key, T? value) where T : struct, Enum => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteFloatValue(string? key, float? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteGuidValue(string? key, Guid? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteIntValue(string? key, int? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteLongValue(string? key, long? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteNullValue(string? key) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteObjectValue<T>(string? key, T? value, params IParsable?[] additionalValuesToMerge) where T : IParsable => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteSbyteValue(string? key, sbyte? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteStringValue(string? key, string? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteTimeSpanValue(string? key, TimeSpan? value) => throw new NotImplementedException();
    /// <inheritdoc/>
    public void WriteTimeValue(string? key, Time? value) => throw new NotImplementedException();
}