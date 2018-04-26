// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Configuration.Design
{

    /// <summary>
    /// This attribute supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class OmitCustomAttributesPropertyAttribute :Attribute
    {
    }
}

