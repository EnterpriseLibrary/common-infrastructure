// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Storage
{
    /// <summary>
    /// <para>Provides a way to watch for changes to configuration in storage.</para>
    /// </summary>
    public interface IConfigurationChangeWatcher : IDisposable
    {
        /// <summary>
        /// Event raised when the underlying persistence mechanism for configuration notices that
        /// the persistent representation of configuration information has changed.
        /// </summary>
        event ConfigurationChangedEventHandler ConfigurationChanged;

        /// <summary>
        /// When implemented by a subclass, starts the object watching for configuration changes
        /// </summary>
        void StartWatching();

        /// <summary>
        /// When implemented by a subclass, stops the object from watching for configuration changes
        /// </summary>
        void StopWatching();

        /// <summary>
        /// When implemented by a subclass, returns the section name that is being watched.
        /// </summary>
        string SectionName { get; }
    }
}

