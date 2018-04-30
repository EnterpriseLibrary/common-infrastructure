// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Specialized;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents the configuration settings for a custom provider.
    /// </summary>
    public interface ICustomProviderData
    {
        /// <summary>
        /// Gets the name for the represented provider.
        /// </summary>
        string Name    { get; }

        /// <summary>
        /// Gets the attributes for the represented provider.
        /// </summary>
        NameValueCollection Attributes { get; }
    }
}

