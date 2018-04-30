// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Configuration;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Interface that allows a <see cref="ConfigurationElementCollection"/> to be merged.
    /// </summary>
    public interface IMergeableConfigurationElementCollection
    {
        /// <summary>
        /// Resets the elements in the <see cref="ConfigurationElementCollection"/> to the <see cref="ConfigurationElement"/>s passed as <paramref name="configurationElements" />.
        /// </summary>
        /// <param name="configurationElements">The new contents of this <see cref="ConfigurationElementCollection"/>.</param>
        void ResetCollection(IEnumerable<ConfigurationElement> configurationElements);

        /// <summary>
        /// Creates a new <see cref="ConfigurationElement"/> for the specifies <paramref name="configurationType" />.
        /// </summary>
        /// <param name="configurationType">The type of <see cref="ConfigurationElement"/> that should be created.</param>
        ConfigurationElement CreateNewElement(Type configurationType);
    }


}

