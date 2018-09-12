// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// </summary>
    public interface IProtectedConfigurationSource
    {
        /// <summary>
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="configurationSection"></param>
        /// <param name="protectionProviderName"></param>
        void Add(string sectionName, ConfigurationSection configurationSection, string protectionProviderName);


    }
}

