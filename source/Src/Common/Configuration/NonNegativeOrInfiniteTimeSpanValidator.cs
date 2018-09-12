// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;
using System.Threading;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Provides validation for a <see cref="TimeSpan"/> object allowing non-negative spans and 
    /// the value for <see cref="Timeout.InfiniteTimeSpan"/>.
    /// </summary>
    public class NonNegativeOrInfiniteTimeSpanValidator : TimeSpanValidator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonNegativeOrInfiniteTimeSpanValidator"/> class.
        /// </summary>
        public NonNegativeOrInfiniteTimeSpanValidator()
            : base(TimeSpan.Zero, TimeSpan.MaxValue)
        {
        }

        /// <summary>
        /// Determines whether the value of an object is valid.
        /// </summary>
        /// <param name="value">The value of an object.</param>
        public override void Validate(object value)
        {
            if (!(value is TimeSpan && ((TimeSpan)value) == Timeout.InfiniteTimeSpan))
            {
                base.Validate(value);
            }
        }
    }
}

