// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Attribute class used to associate a <see cref="System.Configuration.ConfigurationElementCollection"/> class with an <see cref="IMergeableConfigurationElementCollection"/> implementation.
    /// </summary>
    /// <seealso cref="IMergeableConfigurationElementCollection"/>
    [AttributeUsage(AttributeTargets.Class)]
    public class MergeableConfigurationCollectionTypeAttribute : Attribute
    {
        private readonly Type mergeableConfigurationCollectionType;

        /// <summary>
        /// Creates a new instance of the <see cref="MergeableConfigurationCollectionTypeAttribute"/> class.
        /// </summary>
        /// <param name="mergeableConfigurationCollectionType">The type of <see cref="IMergeableConfigurationElementCollection"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElementCollection"/> class.</param>
        public MergeableConfigurationCollectionTypeAttribute(Type mergeableConfigurationCollectionType)
        {
            this.mergeableConfigurationCollectionType = mergeableConfigurationCollectionType;
        }

        /// <summary>
        /// Gets the type of <see cref="IMergeableConfigurationElementCollection"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElementCollection"/> class.
        /// </summary>
        /// <value>
        /// The type of <see cref="IMergeableConfigurationElementCollection"/> that should be associated with the target <see cref="System.Configuration.ConfigurationElementCollection"/> class.
        /// </value>
        public Type MergeableConfigurationCollectionType
        {
            get { return mergeableConfigurationCollectionType; }
        }
    }
}

