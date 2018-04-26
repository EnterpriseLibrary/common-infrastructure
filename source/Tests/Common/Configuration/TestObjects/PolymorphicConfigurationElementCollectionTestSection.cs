// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using EnterpriseLibrary.Common.Configuration;

namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class PolymorphicConfigurationElementCollectionTestSection : ConfigurationSection
    {
        [ConfigurationProperty("withOverrides")]
        public TestNameTypeConfigurationElementCollectionWithOverridenAddAndClearNames<BasePolymorphicObjectData, CustomPolymorphicObjectData> WithOverrides
        {
            get { return (TestNameTypeConfigurationElementCollectionWithOverridenAddAndClearNames<BasePolymorphicObjectData, CustomPolymorphicObjectData>)this["withOverrides"]; }
            set { this["withOverrides"] = value; }
        }

        [ConfigurationProperty("withoutOverrides")]
        public NameTypeConfigurationElementCollection<BasePolymorphicObjectData, CustomPolymorphicObjectData> WithoutOverrides
        {
            get { return (NameTypeConfigurationElementCollection<BasePolymorphicObjectData, CustomPolymorphicObjectData>)this["withoutOverrides"]; }
            set { this["withoutOverrides"] = value; }
        }
    }
}

