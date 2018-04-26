// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents the abstraction of an object with a name.
    /// </summary>
    public interface IObjectWithName
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
    }
}

