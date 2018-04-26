// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Configuration.Tests
{
    [TestClass]
    public class DictionarySourceFixture
    {
        [TestMethod]
        public void CanRetrieveSectionFromSource()
        {
            DictionaryConfigurationSource source = LocalConfigurationSource.Create();

            Assert.IsTrue(source.Contains("test"));
            Assert.AreEqual(source.GetSection("test").GetType(), typeof(LocalConfigurationSection));
            source.Remove("test");
            Assert.IsNull(source.GetSection("random"));
        }

        class LocalConfigurationSection : SerializableConfigurationSection {}

        static class LocalConfigurationSource
        {
            public static DictionaryConfigurationSource Create()
            {
                DictionaryConfigurationSource source = new DictionaryConfigurationSource();
                source.Add("test", new LocalConfigurationSection());
                return source;
            }
        }
    }
}

