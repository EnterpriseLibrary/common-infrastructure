// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents the abstraction of an object with a name and a type.
    /// </summary>
    public interface IObjectWithNameAndType : IObjectWithName
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        Type Type { get; }
    }
}

