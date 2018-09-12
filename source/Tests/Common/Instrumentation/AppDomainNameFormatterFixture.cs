// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation.Tests
{
    [TestClass]
    public class AppDomainNameFormatterFixture : MarshalByRefObject
    {
        [TestMethod]
        public void WillFormatNameWithAppDomainNamePrefix()
        {
            AppDomainNameFormatter nameFormatter = new AppDomainNameFormatter();

            string createdName = nameFormatter.CreateName("MyInstance");
            Assert.IsTrue(createdName.EndsWith(" - MyInstance"));
            Assert.IsTrue(createdName.Length <= 128);
        }

        [TestMethod]
        public void WillFormatNameUsingApplicationInstanceName()
        {
            string applicationInstanceName = "ApplicationInstanceName";
            string suffix = "MySuffix";
            string expectedInstanceName = string.Concat(applicationInstanceName, " - ", suffix);

            AppDomainNameFormatter formatter = new AppDomainNameFormatter(applicationInstanceName);

            string createdName = formatter.CreateName(suffix);
            Assert.AreEqual(expectedInstanceName, createdName);
        }

        /// <summary>
        /// Filter the invalid chars documented in http://msdn2.microsoft.com/en-us/library/aa373193.aspx
        /// </summary>
        [TestMethod]
        public void ShouldReplaceInvalidCharacters()
        {
            string invalidApplicationInstanceName = @"\\computer\object(parent/instance#index)\counter";
            string validApplicationIntanceName = "computerobjectparentinstanceindexcounter";

            //Normalize string length
            validApplicationIntanceName = validApplicationIntanceName.Substring(0, 32);

            string suffix = "MySuffix";
            string expectedInstanceName = string.Concat(validApplicationIntanceName, " - ", suffix);

            AppDomainNameFormatter formatter = new AppDomainNameFormatter(invalidApplicationInstanceName);

            string createdName = formatter.CreateName(suffix);
            Assert.AreEqual(expectedInstanceName, createdName);
        }
    }
}

