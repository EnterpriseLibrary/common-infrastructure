// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using EnterpriseLibrary.Common.Configuration;

namespace EnterpriseLibrary.Common.Tests.Configuration.TestObjects
{
    public class HierarchicalMergeNamedConfigurationElement : NamedConfigurationElement
    {
        private const string otherProperty = "other";

        [ConfigurationProperty(otherProperty)]
        public string Other
        {
            get { return (string)base[otherProperty]; }
            set { base[otherProperty] = value; }
        }

    }
}

