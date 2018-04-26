// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class CustomPolymorphicObjectData : BasePolymorphicObjectData
    {
        public CustomPolymorphicObjectData()
            : base()
        { }

        public CustomPolymorphicObjectData(string name, Type type)
            : base(name, type)
        { }
    }
}

