// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    [ConfigurationCollection(typeof(TestLeafConfigurationElement))]
    public class MergeableElementCollection : ConfigurationElementCollection, IMergeableConfigurationElementCollection
    {
        public MergeableElementCollection()
        {
        }

        public MergeableElementCollection(IEnumerable<TestLeafConfigurationElement> elements)
        {
            foreach (var e in elements)
            {
                base.BaseAdd(e);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new TestLeafConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TestLeafConfigurationElement)element).ID;
        }

        public void ResetCollection(IEnumerable<ConfigurationElement> configurationElements)
        {
            base.BaseClear();
            foreach (var element in configurationElements)
            {
                base.BaseAdd(element);
            }
        }


        ConfigurationElement IMergeableConfigurationElementCollection.CreateNewElement(Type configurationType)
        {
            return new TestLeafConfigurationElement();
        }
    }
}

