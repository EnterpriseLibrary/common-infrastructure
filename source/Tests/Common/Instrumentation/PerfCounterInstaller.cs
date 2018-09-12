// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation.Tests
{
    [RunInstaller(true)]
    public partial class PerfCounterInstaller : Installer
    {
        public PerfCounterInstaller()
        {
            InitializeComponent();
            InstallPerformanceCounters();
        }

        private void InstallPerformanceCounters()
        {
            PerformanceCounterInstaller installer = new PerformanceCounterInstaller();
            installer.CategoryName = EnterpriseLibraryPerformanceCounterFixture.counterCategoryName;
            installer.CategoryHelp = "J Random Text";
            installer.CategoryType = PerformanceCounterCategoryType.MultiInstance;

            CounterCreationData firstCounterData = new CounterCreationData(EnterpriseLibraryPerformanceCounterFixture.counterName, "Test Counter", PerformanceCounterType.NumberOfItems32);
            CounterCreationData secondCounterData = new CounterCreationData("SecondTestCounter", "Second Test Counter", PerformanceCounterType.NumberOfItems32);

            installer.Counters.Add(firstCounterData);
            installer.Counters.Add(secondCounterData);

            Installers.Add(installer);
        }
    }
}

