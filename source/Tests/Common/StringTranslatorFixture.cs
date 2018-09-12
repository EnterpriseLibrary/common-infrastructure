// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests
{
    [TestClass]
    public class StringTranslatorFixture
    {
        [TestMethod]
        public void ReturnsTranslatedStringForGivenResourceAndLabel()
        {
            StringTranslator translator = new StringTranslator();
            ResourceManager manager = new ResourceManager(
                "Microsoft.Practices.EnterpriseLibrary.Common.Tests.Properties.Resources",
                Assembly.GetExecutingAssembly());
            Assert.AreEqual("Foo Text", translator.Translate(manager, "FooLabel"));
        }

        [TestMethod]
        public void ReturnsNullIfLabelCannotBeFound()
        {
            StringTranslator translator = new StringTranslator();
            ResourceManager manager = new ResourceManager(
                "Microsoft.Practices.EnterpriseLibrary.Common.Tests.Properties.Resources",
                Assembly.GetExecutingAssembly());
            Assert.IsNull(translator.Translate(manager, "UnknownLabel"));
        }

        [TestMethod, ExpectedException(typeof(MissingManifestResourceException))]
        public void ExceptionThrownIfResourcesCannotBeFound()
        {
            StringTranslator translator = new StringTranslator();
            ResourceManager manager = new ResourceManager(
                "UnknownResources",
                Assembly.GetExecutingAssembly());
            Assert.IsNull(translator.Translate(manager, "UnknownLabel"));
        }
    }

    public class StringTranslator
    {
        public string Translate(ResourceManager manager,
                                string resourceLabel)
        {
            return manager.GetString(resourceLabel);
        }
    }
}

