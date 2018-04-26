// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using EnterpriseLibrary.Common.Tests.Properties;
using EnterpriseLibrary.Common.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Tests.Utility
{
    [TestClass]
    public class StringResolverFixture
    {
        [TestMethod]
        public void CanGetValueFromConstantStringResolver()
        {
            string value = "test string";

            IStringResolver resolver = new ConstantStringResolver(value);

            Assert.AreEqual(value, resolver.GetString());
        }

        [TestMethod]
        public void CanGetValueFromDelegateStringResolver()
        {
            string value = "test string";

            IStringResolver resolver = new DelegateStringResolver(() => value);

            Assert.AreEqual(value, resolver.GetString());
        }

        [TestMethod]
        public void ResourceStringResolverUsesTypeAndNameIfBothAreAvailable()
        {
            Type resourceType = typeof(Resources);
            string resourceName = "CategoryHelp";
            string fallbackValue = "fallback";

            IStringResolver resolver = new ResourceStringResolver(resourceType, resourceName, fallbackValue);

            Assert.AreEqual(Resources.CategoryHelp, resolver.GetString());
        }

        [TestMethod]
        public void ResourceStringResolverUsesFallbackValueIfTypeIsNull()
        {
            Type resourceType = null;
            string resourceName = "CategoryHelp";
            string fallbackValue = "fallback";

            IStringResolver resolver = new ResourceStringResolver(resourceType, resourceName, fallbackValue);

            Assert.AreEqual(fallbackValue, resolver.GetString());
        }

        [TestMethod]
        public void ResourceStringResolverUsesFallbackValueIfResourceNameIsNull()
        {
            Type resourceType = typeof(Resources);
            string resourceName = null;
            string fallbackValue = "fallback";

            IStringResolver resolver = new ResourceStringResolver(resourceType, resourceName, fallbackValue);

            Assert.AreEqual(fallbackValue, resolver.GetString());
        }

        [TestMethod]
        public void ResourceStringResolverUsesTypeNameAndNameIfBothAreAvailable()
        {
            string resourceTypeName = typeof(Resources).AssemblyQualifiedName;
            string resourceName = "CategoryHelp";
            string fallbackValue = "fallback";

            IStringResolver resolver = new ResourceStringResolver(resourceTypeName, resourceName, fallbackValue);

            Assert.AreEqual(Resources.CategoryHelp, resolver.GetString());
        }
    }
}

