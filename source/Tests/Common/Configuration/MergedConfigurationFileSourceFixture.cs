// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.ContextBase;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Tests;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration
{
    public abstract class Given_ConfigurationFileWithParentSource : ArrangeActAssert
    {
        protected string FileSourceDummySectionName = "externaldummy.filesource";
        protected IConfigurationSource MergedSource;

        protected override void Arrange()
        {
            MergedSource = new FileConfigurationSource(@"MergedConfigurationFile.config");
        }
    }

    [TestClass]
    public class When_CallingGetSection : Given_ConfigurationFileWithParentSource
    {
        DummySection section;

        protected override void Act()
        {
            section = (DummySection)MergedSource.GetSection(FileSourceDummySectionName);
        }

        [TestMethod]
        public void Then_LocalSourceReturnsValueFromParentSource()
        {
            Assert.AreEqual(11, section.Value);
        }
    }

}

