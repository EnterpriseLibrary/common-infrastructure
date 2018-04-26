// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using EnterpriseLibrary.Common.Configuration;

namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class PolymorphicElementCollection : NameTypeConfigurationElementCollection<PolymorphicElement, CustomPolymorphicElement>
    {
    }

    public class PolymorphicElement : NameTypeConfigurationElement
    {

    }

    public class CustomPolymorphicElement : PolymorphicElement
    {
        public CustomPolymorphicElement()
        {
            Type = typeof(CustomPolymorphicElement);
        }
    }

    public class OtherDerivedPolymorphicElement : PolymorphicElement
    {
        public OtherDerivedPolymorphicElement()
        {
            Type = typeof(OtherDerivedPolymorphicElement);
        }
    }
}

