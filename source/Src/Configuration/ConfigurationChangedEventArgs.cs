// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Event handler called after a configuration has changed.
    /// </summary>
    /// <param name="sender">
    /// <para>The source of the event.</para>
    /// </param>
    /// <param name="e">
    /// <para>A <see cref="ConfigurationChangedEventArgs"/> that contains the event data.</para>
    /// </param>
    public delegate void ConfigurationChangedEventHandler(object sender, ConfigurationChangedEventArgs e);

    /// <summary>
    /// </summary>
    [Serializable]
    public class ConfigurationChangedEventArgs : EventArgs
    {
        private readonly string sectionName;

        /// <summary>
        /// <para>Initialize a new instance of the <see cref="ConfigurationChangedEventArgs"/> class with the section name</para>
        /// </summary>
        /// <param name="sectionName"><para>The section name of the changes.</para></param>
        public ConfigurationChangedEventArgs(string sectionName)
        {
            this.sectionName = sectionName;
        }

        /// <summary>
        /// <para>Gets the section name where the changes occurred.</para>
        /// </summary>
        /// <value>
        /// <para>The section name where the changes occurred.</para>
        /// </value>
        public string SectionName
        {
            get { return sectionName; }
        }
    }
    
}

