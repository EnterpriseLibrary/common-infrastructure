// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Threading;
using EnterpriseLibrary.Common.Configuration.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Configuration.Tests
{
    [TestClass]
    public class ConfigurationChangeWatcherFixture
    {
        int notifications;

        [TestInitialize]
        public void SetUp()
        {
            notifications = 0;
        }

        [TestMethod]
        public void RunningWatcherKeepsOnlyOnePollingThread()
        {
            using (TestConfigurationChangeWatcher watcher = new TestConfigurationChangeWatcher(50))
            {
                try
                {
                    watcher.ConfigurationChanged += new ConfigurationChangedEventHandler(OnConfigurationChanged);

                    for (int i = 0; i < 20; i++)
                    {
                        watcher.StopWatching();
                        watcher.StartWatching();
                    }

                    // ramp up
                    Thread.Sleep(50);

                    watcher.DoNotification();

                    // wait for notification
                    Thread.Sleep(150);

                    Assert.AreEqual(1, notifications);
                }
                finally
                {
                    watcher.StopWatching();
                }
            }
        }

        void OnConfigurationChanged(object sender, ConfigurationChangedEventArgs e)
        {
            lock (this)
            {
                notifications++;
            }
        }
    }

    class TestConfigurationChangeWatcher : ConfigurationChangeWatcher
    {
        public TestConfigurationChangeWatcher(int pollDelay)
        {
            SetPollDelayInMilliseconds(pollDelay);
        }

        static bool notified;

        DateTime lastWriteTime = DateTime.Now;
        bool notify = false;

        public override string SectionName
        {
            get { return "section"; }
        }

        protected override ConfigurationChangedEventArgs BuildEventData()
        {
            return new ConfigurationChangedEventArgs(SectionName);
        }

        internal void DoNotification()
        {
            notify = true;
        }

        protected override DateTime GetCurrentLastWriteTime()
        {
            if (notify && !notified)
            {
                notified = true;
                lastWriteTime = DateTime.Now;
            }
            return lastWriteTime;
        }

        protected override string GetEventSourceName()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}

