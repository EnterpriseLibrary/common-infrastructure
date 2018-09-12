// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Attribute class used to associate a <see cref="System.Configuration.ConfigurationElement"/> class with an <see cref="ICloneableConfigurationElement"/> implementation.
    /// </summary>
    /// <seealso cref="ICloneableConfigurationElement"/>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CloneableConfigurationElementTypeAttribute : Attribute
    {
        private readonly Type cloneableConfigurationElementType;

        /// <summary>
        /// Creates a new instance of the <see cref="CloneableConfigurationElementTypeAttribute"/> class.
        /// </summary>
        /// <param name="cloneableConfigurationElementType">The type of <see cref="ICloneableConfigurationElement"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElement"/> class.</param>
        public CloneableConfigurationElementTypeAttribute(Type cloneableConfigurationElementType)
        {
            this.cloneableConfigurationElementType = cloneableConfigurationElementType;
        }
        /// <summary>
        /// Gets the type of <see cref="ICloneableConfigurationElement"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElement"/> class.
        /// </summary>
        /// <value>
        /// The type of <see cref="ICloneableConfigurationElement"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElement"/> class.
        /// </value>
        public Type CloneableConfigurationElementType
        {
            get { return cloneableConfigurationElementType; }
        }
    }
}

