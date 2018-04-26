// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Converts a <see cref="TimeSpan"/> expressed in as formatted string or as a standard infinite timeout.
    /// </summary>
    public class TimeSpanOrInfiniteConverter : TimeSpanConverter
    {
        /// <summary>
        /// The string representation of an infinite timeout.
        /// </summary>
        public const string Infinite = "infinite";

        /// <summary>
        /// Converts the given object to a <see cref="T:System.TimeSpan" />.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed.</param>
        /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
        /// <returns>
        /// An <see cref="T:System.Object" /> that represents the converted value.
        /// </returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var text = value as string;

            if (text != null && string.Equals(text, Infinite, StringComparison.OrdinalIgnoreCase))
            {
                return Timeout.InfiniteTimeSpan;
            }

            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Converts the given object to another type.
        /// </summary>
        /// <param name="context">A formatter context.</param>
        /// <param name="culture">The culture into which <paramref name="value" /> will be converted.</param>
        /// <param name="value">The object to convert.</param>
        /// <param name="destinationType">The type to convert the object to.</param>
        /// <returns>
        /// The converted object.
        /// </returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (((TimeSpan)value) == Timeout.InfiniteTimeSpan)
                {
                    return Infinite;
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

