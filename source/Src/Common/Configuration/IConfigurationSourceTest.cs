// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// This interface supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
    /// Augmented version of the <see cref="IConfigurationSource"/> interface intended to be used by unit tests.
    /// </summary>
    public interface IConfigurationSourceTest : IConfigurationSource
    {
        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        void ConfigSourceChanged(string configSource);

        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        void ExternalConfigSourceChanged(string configSource);

        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        IDictionary<string, ConfigurationSourceWatcher> ConfigSourceWatcherMappings { get; }

        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        ICollection<string> WatchedConfigSources { get; }

        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        ICollection<string> WatchedSections { get; }
    }
}

