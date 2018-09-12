// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Type converter used to work around enums with enums wrongly marked as "flags".
    /// </summary>
    public class EnumConverterWithExclusiveStandardValues<T> : EnumConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumConverterWithExclusiveStandardValues{T}"/> class.
        /// </summary>
        public EnumConverterWithExclusiveStandardValues()
            : base(typeof(T))
        { }

        /// <summary>
        /// Indicates where the standard values are exclusive.
        /// </summary>
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}

