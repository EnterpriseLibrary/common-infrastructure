// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;
using EnterpriseLibrary.Common.Properties;
using System.Globalization;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Contains factory methods to create configuration sources.
    /// </summary>
    public static class ConfigurationSourceFactory
    {
        /// <summary>
        /// Creates a new configuration sources based on the configuration information from the application's default
        /// configuration file.
        /// </summary>
        /// <param name="name">The name for the desired configuration source.</param>
        /// <returns>The new configuration source instance described in the configuration file.</returns>
        /// <exception cref="ConfigurationErrorsException">when no configuration information is found for name <paramref name="name"/>.</exception>
        /// <exception cref="ArgumentNullException">when <paramref name="name"/> is null or empty.</exception>
        public static IConfigurationSource Create(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            ConfigurationSourceSection configurationSourceSection
                = ConfigurationSourceSection.GetConfigurationSourceSection();

            if (configurationSourceSection == null)
            {
                throw new ConfigurationErrorsException(Resources.ExceptionConfigurationSourceSectionNotFound);
            }

            ConfigurationSourceElement objectConfiguration
                = configurationSourceSection.Sources.Get(name);

            if (objectConfiguration == null)
            {
                throw new ConfigurationErrorsException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.ExceptionNamedConfigurationNotFound,
                        name,
                        "ConfigurationSourceFactory"));
            }

            IConfigurationSource source = objectConfiguration.CreateSource();

            return source;
        }

        /// <summary>
        /// Creates a new configuration sources based on the default configuration information from the 
        /// application's default configuration file.
        /// </summary>
        /// <returns>The new configuration source instance described as the default in the configuration file,
        /// or a new instance of <see cref="SystemConfigurationSource"/> if the is no configuration sources configuration.</returns>
        /// <exception cref="ConfigurationSourceSection">when there is a configuration section but it does not define
        /// a default configurtion source, or when the configuration for the defined default configuration source is not found.</exception>
        public static IConfigurationSource Create()
        {
            ConfigurationSourceSection configurationSourceSection
                = ConfigurationSourceSection.GetConfigurationSourceSection();

            if (configurationSourceSection != null)
            {
                string systemSourceName = configurationSourceSection.SelectedSource;
                if (!string.IsNullOrEmpty(systemSourceName))
                {
                    return Create(systemSourceName);
                }
                else
                {
                    throw new ConfigurationErrorsException(Resources.ExceptionSystemSourceNotDefined);
                }
            }

            return new SystemConfigurationSource();
        }
    }
}

