// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class TestNameTypeConfigurationElementCollectionWithOverridenAddAndClearNames<T, TCustomElementData>
        : NameTypeConfigurationElementCollection<T, TCustomElementData>
        where T : NameTypeConfigurationElement, new()
        where TCustomElementData : T, new()
    {
        public TestNameTypeConfigurationElementCollectionWithOverridenAddAndClearNames()
        {
            this.AddElementName = "overridenAdd";
            this.ClearElementName = "overridenClear";
        }
    }
}

