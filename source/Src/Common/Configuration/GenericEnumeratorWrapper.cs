// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <devdoc>
    /// Represents a genereic enumerator for the NamedElementCollection.
    /// </devdoc>    
    internal class GenericEnumeratorWrapper<T> : IEnumerator<T>
    {
        private IEnumerator wrappedEnumerator;

        internal GenericEnumeratorWrapper(IEnumerator wrappedEnumerator)
        {
            this.wrappedEnumerator = wrappedEnumerator;
        }

        T IEnumerator<T>.Current
        {
            get { return (T) this.wrappedEnumerator.Current; }
        }

        void IDisposable.Dispose()
        {
            this.wrappedEnumerator = null;
        }        

        object IEnumerator.Current
        {
            get { return this.wrappedEnumerator.Current; }
        }

        bool IEnumerator.MoveNext()
        {
            return this.wrappedEnumerator.MoveNext();
        }

        void IEnumerator.Reset()
        {
            this.wrappedEnumerator.Reset();
        }    
    }
}

