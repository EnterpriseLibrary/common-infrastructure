// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using EnterpriseLibrary.Common.Instrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Tests.Instrumentation
{
    [TestClass]
    public class PerformanceCounterInstanceNameFixture
    {
        [TestMethod]
        public void SingleCharacterPrefixAndSuffixCreateValidName()
        {
            PerformanceCounterInstanceName instanceName = new PerformanceCounterInstanceName("a", "b");
            Assert.AreEqual("a - b", instanceName.ToString());
        }

        [TestMethod]
        public void EmptyPrefixPrintsJustSuffixForName()
        {
            PerformanceCounterInstanceName instanceName = new PerformanceCounterInstanceName(String.Empty, "b");
            Assert.AreEqual("b", instanceName.ToString());
        }

        [TestMethod]
        public void OverlyLongPrefixIsTruncatedToMaxLengthInGeneratedName()
        {
            PerformanceCounterInstanceName instanceName = new PerformanceCounterInstanceName("01234", "b", 3, 15);
            Assert.AreEqual("012 - b", instanceName.ToString());
        }

        [TestMethod]
        public void OverlyLongSuffixIsTruncatedToMaxLengthInGeneratedName()
        {
            PerformanceCounterInstanceName instanceName = new PerformanceCounterInstanceName("a", "01234", 15, 3);
            Assert.AreEqual("a - 012", instanceName.ToString());
        }
    }
}

