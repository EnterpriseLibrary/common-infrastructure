// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Event arguments describing which sections have changed in a configuration source.
    /// </summary>
    public class ConfigurationSourceChangedEventArgs : EventArgs
    {
        private readonly IConfigurationSource configurationSource;
        private readonly ReadOnlyCollection<string> changedSectionNames;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceChangedEventArgs"/> class.
        /// </summary>
        /// <param name="configurationSource">Configuration source that changed.</param>
        /// <param name="changedSectionNames">Sequence of the section names in <paramref name="configurationSource"/>
        /// that have changed.</param>
        public ConfigurationSourceChangedEventArgs(IConfigurationSource configurationSource,
            IEnumerable<string> changedSectionNames)
        {
            this.configurationSource = configurationSource;
            this.changedSectionNames = new ReadOnlyCollection<string>(changedSectionNames.ToArray());
        }

        /// <summary>
        /// The configuration source that has changed.
        /// </summary>
        public IConfigurationSource ConfigurationSource
        {
            get { return configurationSource; }
        }

        /// <summary>
        /// The set of section names that have changed.
        /// </summary>
        public ReadOnlyCollection<string> ChangedSectionNames
        {
            get { return changedSectionNames; }
        }
    }
}

