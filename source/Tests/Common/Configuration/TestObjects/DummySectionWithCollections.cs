// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using EnterpriseLibrary.Common.Configuration.Tests;

namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class DummySectionWithCollections : DummySection
    {
        private const string leafElementProperty = "leaf";
        private const string elementCollectionProperty = "collection";
        private const string polymorphicCollectionProperty = "polymorphicCollection";
        private const string connectionStringsProperty = "connectionStrings";
        private const string settingsProperty = "settings";

        [ConfigurationProperty(leafElementProperty)]
        public TestLeafConfigurationElement LeafElement
        {
            get { return (TestLeafConfigurationElement)base[leafElementProperty]; }
            set { base[leafElementProperty] = value; }
        }

        [ConfigurationProperty(elementCollectionProperty)]
        public MergeableElementCollection LeafElementCollection
        {
            get { return (MergeableElementCollection)base[elementCollectionProperty]; }
            set { base[elementCollectionProperty] = value; }
        }

        [ConfigurationProperty(polymorphicCollectionProperty)]
        public PolymorphicElementCollection PolymorphicCollection
        {
            get { return (PolymorphicElementCollection)base[polymorphicCollectionProperty]; }
            set { base[polymorphicCollectionProperty] = value; }
        }

        [ConfigurationProperty(connectionStringsProperty)]
        public ConnectionStringSettingsCollection ConnectionStringSettingsCollection
        {
            get { return (ConnectionStringSettingsCollection)base[connectionStringsProperty]; }
            set { base[connectionStringsProperty] = value; }
        }

        [ConfigurationProperty(settingsProperty)]
        public KeyValueConfigurationCollection AppSettingsLikeCollection
        {
            get { return (KeyValueConfigurationCollection)base[settingsProperty]; }
            set { base[settingsProperty] = value; }
        }

    }
}

