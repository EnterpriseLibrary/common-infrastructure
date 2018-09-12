// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Provides attributes for the filter of types.
    /// </summary>
    [Flags]
    public enum TypeSelectorIncludes
    {
        /// <summary>
        /// No filter are applied to types.
        /// </summary>
        None = 0x00,
        /// <summary>
        /// Inclue abstract types in the filter.
        /// </summary>
        AbstractTypes = 0x01,
        /// <summary>
        /// Inclue interfaces in the filter.
        /// </summary>
        Interfaces = 0x02,
        /// <summary>
        /// Inclue base types in the filter.
        /// </summary>
        BaseType = 0x04,
        /// <summary>
        /// Inclue non public types in the filter.
        /// </summary>
        NonpublicTypes = 0x08,
        /// <summary>
        /// Include all types in the filter.
        /// </summary>
        All = 0x0F
    }
}

