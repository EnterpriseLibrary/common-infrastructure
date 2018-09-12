// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design.Validation;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents a <see cref="ConfigurationElement"/> that has a name and type.
    /// </summary>
    public class NameTypeConfigurationElement : NamedConfigurationElement, IObjectWithNameAndType
    {
        private AssemblyQualifiedTypeNameConverter typeConverter = new AssemblyQualifiedTypeNameConverter();

        /// <summary>
        /// Name of the property that holds the type of <see cref="Microsoft.Practices.EnterpriseLibrary.Common.Configuration.NameTypeConfigurationElement"/>.
        /// </summary>
        public const string typeProperty = "type";

        /// <summary>
        /// Intialzie an instance of the <see cref="NameTypeConfigurationElement"/> class.
        /// </summary>
        public NameTypeConfigurationElement()
        {
        }

        /// <summary>
        /// Initialize an instance of the <see cref="NameTypeConfigurationElement"/> class
        /// </summary>
        /// <param name="name">The name of the element.</param>
        /// <param name="type">The <see cref="Type"/> that this element is the configuration for.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "As designed")]
        public NameTypeConfigurationElement(string name, Type type)
            : base(name)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> the element is the configuration for.
        /// </summary>
        /// <value>
        /// The <see cref="Type"/> the element is the configuration for.
        /// </value>
        public virtual Type Type
        {
            get { return (Type)typeConverter.ConvertFrom(TypeName); }
            set { TypeName = typeConverter.ConvertToString(value); }
        }

        /// <summary>
        /// Gets or sets the fully qualified name of the <see cref="Type"/> the element is the configuration for.
        /// </summary>
        /// <value>
        /// the fully qualified name of the <see cref="Type"/> the element is the configuration for.
        /// </value>
        [ConfigurationProperty(typeProperty, IsRequired = true)]
        [Browsable(true)]
        [DesignTimeReadOnly(true)]
        [ResourceDescription(typeof(DesignResources), "NameTypeConfigurationElementTypeNameDescription")]
        [ResourceDisplayName(typeof(DesignResources), "NameTypeConfigurationElementTypeNameDisplayName")]
        [Validation(CommonDesignTime.ValidationTypeNames.TypeValidator)]
        [ViewModel(CommonDesignTime.ViewModelTypeNames.TypeNameProperty)]
        public virtual string TypeName
        {
            get { return (string)this[typeProperty]; }
            set { this[typeProperty] = value; }
        }

        internal ConfigurationPropertyCollection MetadataProperties
        {
            get { return base.Properties; }
        }
    }
}

