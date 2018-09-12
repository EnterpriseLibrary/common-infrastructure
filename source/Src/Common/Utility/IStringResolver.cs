// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Utility
{
    /// <summary>
    /// Resolves string objects. 
    /// </summary>
    public interface IStringResolver
    {
        /// <summary>
        /// Returns a string represented by the receiver.
        /// </summary>
        /// <returns>The string object.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024", Justification = "May be computationally expensive.")]
        string GetString();
    }
}

