// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class ConfigurationFileChangedEventArgs : ConfigurationChangedEventArgs
    {
        private readonly string configurationFile;


        /// <summary>
        /// <para>Initialize a new instance of the <see cref="ConfigurationChangedEventArgs"/> class with the 
        /// configuration file and the section name.</para>
        /// </summary>
        /// <param name="configurationFile"><para>The configuration file where the change occured.</para></param>
        /// <param name="sectionName"><para>The section name of the changes.</para></param>
        public ConfigurationFileChangedEventArgs(string configurationFile, string sectionName) : base(sectionName)
        {
            this.configurationFile = configurationFile;
        }

        /// <summary>
        /// <para>Gets the configuration file of the data that changed.</para>
        /// </summary>
        /// <value>
        /// <para>The configuration file of the data that changed.</para>
        /// </value>
        public string ConfigurationFile
        {
            get { return configurationFile; }
        }
    }
}

