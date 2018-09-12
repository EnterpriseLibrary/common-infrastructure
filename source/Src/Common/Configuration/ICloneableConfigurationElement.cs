// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Interface used to implement custom clone behavior for a <see cref="ConfigurationElement"/>.
    /// </summary>
    /// <seealso cref="ConfigurationSectionCloner"/>
    public interface ICloneableConfigurationElement
    {
        /// <summary>
        /// Creates a deep clone of the current <see cref="ConfigurationElement"/> instance.
        /// </summary>
        /// <returns>
        /// A deep clone of the current <see cref="ConfigurationElement"/> instance.
        /// </returns>
        ConfigurationElement CreateFullClone();
    }
}

