// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{

    /// <summary>
    /// Specifies a default value for a configuration property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=false)]
    public class DesigntimeDefaultAttribute : Attribute
    {
        readonly string bindableDefaultValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="DesigntimeDefaultAttribute"/> class.
        /// </summary>
        /// <remarks>
        /// The default value is a string representation which will be converted using <see cref="System.Globalization.CultureInfo.InvariantCulture"/>.
        /// </remarks>
        /// <param name="bindableDefaultValue">The string representation of the default value.</param>
        public DesigntimeDefaultAttribute(string bindableDefaultValue)
        {
            this.bindableDefaultValue = bindableDefaultValue;
        }

        /// <summary>
        /// Gets the string reprentation of the default value.
        /// </summary>
        /// <value>
        /// The string reprentation of the default value.
        /// </value>
        public string BindableDefaultValue
        {
            get { return bindableDefaultValue; }
        }
    }
}

