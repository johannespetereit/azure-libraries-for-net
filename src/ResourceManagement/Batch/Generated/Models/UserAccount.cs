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
    using System.Linq;

    /// <summary>
    /// Properties used to create a user on an Azure Batch node.
    /// </summary>
    public partial class UserAccount
    {
        /// <summary>
        /// Initializes a new instance of the UserAccount class.
        /// </summary>
        public UserAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAccount class.
        /// </summary>
        /// <param name="name">The name of the user account.</param>
        /// <param name="password">The password for the user account.</param>
        /// <param name="elevationLevel">The elevation level of the user
        /// account.</param>
        /// <param name="linuxUserConfiguration">The Linux-specific user
        /// configuration for the user account.</param>
        /// <param name="windowsUserConfiguration">The Windows-specific user
        /// configuration for the user account.</param>
        public UserAccount(string name, string password, ElevationLevel? elevationLevel = default(ElevationLevel?), LinuxUserConfiguration linuxUserConfiguration = default(LinuxUserConfiguration), WindowsUserConfiguration windowsUserConfiguration = default(WindowsUserConfiguration))
        {
            Name = name;
            Password = password;
            ElevationLevel = elevationLevel;
            LinuxUserConfiguration = linuxUserConfiguration;
            WindowsUserConfiguration = windowsUserConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the user account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the password for the user account.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the elevation level of the user account.
        /// </summary>
        /// <remarks>
        /// nonAdmin - The auto user is a standard user without elevated
        /// access. admin - The auto user is a user with elevated access and
        /// operates with full Administrator permissions. The default value is
        /// nonAdmin. Possible values include: 'NonAdmin', 'Admin'
        /// </remarks>
        [JsonProperty(PropertyName = "elevationLevel")]
        public ElevationLevel? ElevationLevel { get; set; }

        /// <summary>
        /// Gets or sets the Linux-specific user configuration for the user
        /// account.
        /// </summary>
        /// <remarks>
        /// This property is ignored if specified on a Windows pool. If not
        /// specified, the user is created with the default options.
        /// </remarks>
        [JsonProperty(PropertyName = "linuxUserConfiguration")]
        public LinuxUserConfiguration LinuxUserConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the Windows-specific user configuration for the user
        /// account.
        /// </summary>
        /// <remarks>
        /// This property can only be specified if the user is on a Windows
        /// pool. If not specified and on a Windows pool, the user is created
        /// with the default options.
        /// </remarks>
        [JsonProperty(PropertyName = "windowsUserConfiguration")]
        public WindowsUserConfiguration WindowsUserConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
