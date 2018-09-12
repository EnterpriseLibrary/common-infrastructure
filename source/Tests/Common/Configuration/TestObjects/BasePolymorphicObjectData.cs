// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class BasePolymorphicObjectData : NameTypeConfigurationElement
    {
        public BasePolymorphicObjectData()
            : base()
        { }

        public BasePolymorphicObjectData(string name, Type type)
            : base(name, type)
        { }
    }
}

