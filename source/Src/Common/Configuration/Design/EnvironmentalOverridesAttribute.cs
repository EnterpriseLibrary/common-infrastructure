// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{

    /// <summary>
    /// Attribute class used to indicate whether a property can be overwritten per environment.<br/>
    /// The default behavior is that any property can be overwritten.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false)]
    public sealed class EnvironmentalOverridesAttribute : Attribute
    {
        private readonly bool canOverride;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentalOverridesAttribute"/> class.
        /// </summary>
        /// <param name="canOverride"><see langword="true"/> to specify the property can be overwritten per environment. Otherwise <see langword="false"/>.</param>
        public EnvironmentalOverridesAttribute(bool canOverride)
        {
            this.canOverride = canOverride;
        }

        /// <summary>
        /// <see langword="true"/> if the property can be overwritten per environment. Otherwise <see langword="false"/>.
        /// </summary>
        public bool CanOverride
        {
            get { return canOverride; }
        }

        /// <summary>
        /// Specifies a custom property type for the overrides property.<br/>
        /// </summary>
        public Type CustomOverridesPropertyType
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies a <see cref="TypeConverter"/> that should be used to serialize the overriden value to the delta configuration file. <br/>
        /// This can be used to overwrite a property that doesnt implement <see cref="IConvertible"/>.  <br/>
        /// </summary>
        public Type StorageConverterType
        {
            get;
            set;
        }
    }
}

