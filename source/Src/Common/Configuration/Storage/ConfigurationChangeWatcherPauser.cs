// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Configuration.Storage
{
    internal class ConfigurationChangeWatcherPauser : IDisposable
    {
        private readonly IConfigurationChangeWatcher watcher;

        public ConfigurationChangeWatcherPauser(IConfigurationChangeWatcher watcher)
        {
            this.watcher = watcher;
            if(watcher != null) watcher.StopWatching();
        }

        public void Dispose()
        {
            if(watcher != null) watcher.StartWatching();
        }
    }
}

