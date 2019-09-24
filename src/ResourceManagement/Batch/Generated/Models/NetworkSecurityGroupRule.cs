// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A network security group rule to apply to an inbound endpoint.
    /// </summary>
    public partial class NetworkSecurityGroupRule
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroupRule class.
        /// </summary>
        public NetworkSecurityGroupRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroupRule class.
        /// </summary>
        /// <param name="priority">The priority for this rule.</param>
        /// <param name="access">The action that should be taken for a
        /// specified IP address, subnet range or tag.</param>
        /// <param name="sourceAddressPrefix">The source address prefix or tag
        /// to match for the rule.</param>
        /// <param name="sourcePortRanges">The source port ranges to match for
        /// the rule.</param>
        public NetworkSecurityGroupRule(int priority, NetworkSecurityGroupRuleAccess access, string sourceAddressPrefix, IList<string> sourcePortRanges = default(IList<string>))
        {
            Priority = priority;
            Access = access;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRanges = sourcePortRanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the priority for this rule.
        /// </summary>
        /// <remarks>
        /// Priorities within a pool must be unique and are evaluated in order
        /// of priority. The lower the number the higher the priority. For
        /// example, rules could be specified with order numbers of 150, 250,
        /// and 350. The rule with the order number of 150 takes precedence
        /// over the rule that has an order of 250. Allowed priorities are 150
        /// to 3500. If any reserved or duplicate values are provided the
        /// request fails with HTTP status code 400.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the action that should be taken for a specified IP
        /// address, subnet range or tag.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Allow', 'Deny'
        /// </remarks>
        [JsonProperty(PropertyName = "access")]
        public NetworkSecurityGroupRuleAccess Access { get; set; }

        /// <summary>
        /// Gets or sets the source address prefix or tag to match for the
        /// rule.
        /// </summary>
        /// <remarks>
        /// Valid values are a single IP address (i.e. 10.10.10.10), IP subnet
        /// (i.e. 192.168.1.0/24), default tag, or * (for all addresses).  If
        /// any other values are provided the request fails with HTTP status
        /// code 400.
        /// </remarks>
        [JsonProperty(PropertyName = "sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the source port ranges to match for the rule.
        /// </summary>
        /// <remarks>
        /// Valid values are '*' (for all ports 0 - 65535) or arrays of ports
        /// or port ranges (i.e. 100-200). The ports should in the range of 0
        /// to 65535 and the port ranges or ports can't overlap. If any other
        /// values are provided the request fails with HTTP status code 400.
        /// Default value will be *.
        /// </remarks>
        [JsonProperty(PropertyName = "sourcePortRanges")]
        public IList<string> SourcePortRanges { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceAddressPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceAddressPrefix");
            }
        }
    }
}
