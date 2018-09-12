// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Specialized;

namespace Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.Configuration
{
    public abstract class MockCustomProviderBase
    {
        public const string AttributeKey = "attributeKey";

        public string customValue;

        public MockCustomProviderBase(NameValueCollection attributes)
        {
            this.customValue = attributes[AttributeKey];
        }    
    }
}

