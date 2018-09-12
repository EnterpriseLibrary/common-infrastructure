// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    ///<summary>
    /// Determines if the corresponding property is read-only at designtime.
    ///</summary>
    ///<remarks>
    /// This attribute is used to mark properties that should be presented as read-only, but underlying code may change the value on.
    /// <seealso cref="ReadOnlyAttribute"/></remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public class DesignTimeReadOnlyAttribute : Attribute
    {
        ///<summary>
        /// Initializes a new instance of the <see cref="DesignTimeReadOnlyAttribute"/> class.
        ///</summary>
        ///<param name="readOnly"><see langword="true"/> if the property should be read-only at designtime.</param>
        public DesignTimeReadOnlyAttribute(bool readOnly)
        {
            ReadOnly = readOnly;
        }

        ///<summary>
        /// Determines if the property is read-only by design-time.
        /// Returns <see langword="true" /> if the property is read-only at design-time
        /// and <see langword="false" /> otherwise.
        ///</summary>
        public bool ReadOnly { get; private set; }

    }
}

