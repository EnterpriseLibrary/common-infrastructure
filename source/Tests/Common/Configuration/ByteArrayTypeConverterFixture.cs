// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Configuration.Tests
{
    [TestClass]
    public class ByteArrayConverterFixture
    {
        const string sectionName = "byteArrayConverter";

        [TestInitialize]
        public void TestInitialize()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.Sections.Remove(sectionName);
            config.Save();
        }

        [TestMethod]
        public void SerializeAndDeserializeAByteArray()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConverterSection section = new ConverterSection();
            section.ByteArray = new byte[] { 1, 2, 3, 4 };
            config.Sections.Add(sectionName, section);
            config.Save();

            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            section = config.Sections[sectionName] as ConverterSection;
            Assert.IsNotNull(section);
            byte actual = 1;
            Assert.AreEqual(section.ByteArray[0], actual);
        }

        [TestMethod]
        public void SerializeAndDeserialzieANullByteArray()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConverterSection section = new ConverterSection();
            section.ByteArray = null;
            config.Sections.Add(sectionName, section);
            config.Save();

            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            section = config.Sections[sectionName] as ConverterSection;
            Assert.IsNotNull(section);
            Assert.IsNull(section.ByteArray);
        }

        public class ConverterSection : SerializableConfigurationSection
        {
            const string propertyName = "property";

            [ConfigurationProperty(propertyName)]
            [TypeConverter(typeof(ByteArrayTypeConverter))]
            public byte[] ByteArray
            {
                get { return (byte[])base[propertyName]; }
                set { base[propertyName] = value; }
            }
        }
    }
}

