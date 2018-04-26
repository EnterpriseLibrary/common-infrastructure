// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.


namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class DerivedPolymorphicObject1Data : BasePolymorphicObjectData
    {
        public DerivedPolymorphicObject1Data()
            : base()
        { }

        public DerivedPolymorphicObject1Data(string name)
            : base(name, typeof(DerivedPolymorphicObject1))
        { }
    }
}

