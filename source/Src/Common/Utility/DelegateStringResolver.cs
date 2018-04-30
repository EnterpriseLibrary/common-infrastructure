// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Utility
{
    /// <summary>
    /// Resolves strings by invoking a delegate and returning the resulting value.
    /// </summary>
    public sealed class DelegateStringResolver : IStringResolver
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ConstantStringResolver"/> with a delegate.
        /// </summary>
        /// <param name="resolverDelegate">The delegate to invoke when resolving a string.</param>
        public DelegateStringResolver(Func<string> resolverDelegate)
        {
            this.resolverDelegate = resolverDelegate;
        }

        private readonly Func<string> resolverDelegate;

        string IStringResolver.GetString()
        {
            return this.resolverDelegate();
        }
    }
}

