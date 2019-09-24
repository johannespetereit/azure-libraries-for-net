// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ComputeNodeFillType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComputeNodeFillType
    {
        /// <summary>
        /// Tasks should be assigned evenly across all nodes in the pool.
        /// </summary>
        [EnumMember(Value = "Spread")]
        Spread,
        /// <summary>
        /// As many tasks as possible (maxTasksPerNode) should be assigned to
        /// each node in the pool before any tasks are assigned to the next
        /// node in the pool.
        /// </summary>
        [EnumMember(Value = "Pack")]
        Pack
    }
    internal static class ComputeNodeFillTypeEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeFillType? value)
        {
            return value == null ? null : ((ComputeNodeFillType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ComputeNodeFillType value)
        {
            switch( value )
            {
                case ComputeNodeFillType.Spread:
                    return "Spread";
                case ComputeNodeFillType.Pack:
                    return "Pack";
            }
            return null;
        }

        internal static ComputeNodeFillType? ParseComputeNodeFillType(this string value)
        {
            switch( value )
            {
                case "Spread":
                    return ComputeNodeFillType.Spread;
                case "Pack":
                    return ComputeNodeFillType.Pack;
            }
            return null;
        }
    }
}
