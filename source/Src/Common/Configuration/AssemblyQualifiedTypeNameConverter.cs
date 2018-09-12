// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;
using System.Globalization;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents a configuration converter that converts a string to <see cref="Type"/> based on a fully qualified name.
    /// </summary>
    public class AssemblyQualifiedTypeNameConverter : ConfigurationConverterBase
    {
        /// <summary>
        /// Returns the assembly qualified name for the passed in Type.
        /// </summary>
        /// <param name="context">The container representing this System.ComponentModel.TypeDescriptor.</param>
        /// <param name="culture">Culture info for assembly</param>
        /// <param name="value">Value to convert.</param>
        /// <param name="destinationType">Type to convert to.</param>
        /// <returns>Assembly Qualified Name as a string</returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (value != null)
            {
                Type typeValue = value as Type;
                if (typeValue == null)
                {
                    throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ExceptionCanNotConvertType, typeof(Type).Name));
                }

                if (typeValue != null) return (typeValue).AssemblyQualifiedName;
            }
            return null;
        }

        /// <summary>
        /// Returns a type based on the assembly qualified name passed in as data.
        /// </summary>
        /// <param name="context">The container representing this System.ComponentModel.TypeDescriptor.</param>
        /// <param name="culture">Culture info for assembly.</param>
        /// <param name="value">Data to convert.</param>
        /// <returns>Type of the data</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            string stringValue = (string)value;
            if (!string.IsNullOrEmpty(stringValue))
            {
                Type result = Type.GetType(stringValue, false);
                if (result == null)
                {
                    throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ExceptionInvalidType, stringValue));
                }

                return result;
            }
            return null;
        }
    }
}

