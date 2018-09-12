// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    ///<summary>
    /// Supports Enterprise Library design-time by providing ability to 
    /// retrieve, add, and remove sections.
    ///</summary>
    public interface IDesignConfigurationSource : IProtectedConfigurationSource
    {
        ///<summary>
        /// Retrieves a local section from the configuration source.
        ///</summary>
        ///<param name="sectionName"></param>
        ///<returns>The configuration section or null if it does not contain the section.</returns>
        ConfigurationSection GetLocalSection(string sectionName);

        /// <summary>
        /// Adds a local section to the configuration source.
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="section"></param>
        void AddLocalSection(string sectionName, ConfigurationSection section);

        ///<summary>
        /// Removes a local section from the configuration source.
        ///</summary>
        ///<param name="sectionName"></param>
        void RemoveLocalSection(string sectionName);
    }
}

