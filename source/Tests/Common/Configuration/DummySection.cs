// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;

namespace EnterpriseLibrary.Common.Configuration.Tests
{
    public class DummySection : SerializableConfigurationSection
    {
        private const string nameProperty = "name";
        private const string valueProperty = "value";

        public DummySection()
        {
        }

        [ConfigurationProperty(nameProperty)]
        public string Name
        {
            get { return (string)base[nameProperty]; }
            set { base[nameProperty] = value; }
        }

        [ConfigurationProperty(valueProperty)]
        public int Value
        {
            get { return (int)base[valueProperty]; }
            set { base[valueProperty] = value; }
        }
    }
}

