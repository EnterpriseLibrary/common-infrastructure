// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Configuration element for a redirected section.<br/>
    /// The <see cref="NamedConfigurationElement.Name"/> property is used to identify the redireced section, based on its section name.<br/>
    /// </summary>
    /// <seealso cref="ConfigurationSourceSection"/>
    [ResourceDescription(typeof(DesignResources), "RedirectedSectionElementDescription")]
    [ResourceDisplayName(typeof(DesignResources), "RedirectedSectionElementDisplayName")]
    public class RedirectedSectionElement : NamedConfigurationElement
    {
        private const string sourceNameProperty = "sourceName";

        /// <summary>
        /// Gets the name of the <see cref="ConfigurationSourceElement"/> which contains the configuration section.
        /// </summary>
        /// <value>
        /// The name of the <see cref="ConfigurationSourceElement"/> which contains the configuration section.
        /// </value>
        [ConfigurationProperty(sourceNameProperty, IsRequired = true)]
        [ResourceDescription(typeof(DesignResources), "RedirectedSectionElementSourceNameDescription")]
        [ResourceDisplayName(typeof(DesignResources), "RedirectedSectionElementSourceNameDisplayName")]
        [Reference(typeof(CustomConfigurationElementCollection<ConfigurationSourceElement, ConfigurationSourceElement>), typeof(ConfigurationSourceElement))]
        [ViewModel(CommonDesignTime.ViewModelTypeNames.RedirectedSectionSourceProperty)]
        [EnvironmentalOverrides(false)]
        public string SourceName
        {
            get { return (string)this[sourceNameProperty]; }
            set { this[sourceNameProperty] = value; }
        }

    }
}

