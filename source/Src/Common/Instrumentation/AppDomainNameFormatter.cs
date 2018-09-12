// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Text.RegularExpressions;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation
{
    /// <summary>
    /// Provides the friendly name of the application domain as the prefix in formatting a 
    /// particular instance of a performance counter.
    /// </summary>
    public class AppDomainNameFormatter : IPerformanceCounterNameFormatter
    {
        private string applicationInstanceName;
        private const string InvalidCharacters = @"\()/#*";

        /// <summary>
        /// Creates an instance of the <see cref="AppDomainNameFormatter"/>
        /// </summary>
        public AppDomainNameFormatter()
        {
        }

        /// <summary>
        /// Creates an instance of the <see cref="AppDomainNameFormatter"/> with an Application Instance Name
        /// </summary>
        /// <param name="applicationInstanceName"></param>
        public AppDomainNameFormatter(string applicationInstanceName)
        {
            this.applicationInstanceName = applicationInstanceName;
        }

        /// <summary>
        /// Creates the formatted instance name for a performance counter, providing the Application
        /// Domain friendly name for the prefix for the instance.
        /// </summary>
        /// <param name="nameSuffix">Performance counter name, as defined during installation of the counter</param>
        /// <returns>Formatted instance name in form of "appDomainFriendlyName - nameSuffix"</returns>
        public string CreateName(string nameSuffix)
        {
            string replacePattern = "[\\\\()#/\\*]*";
            string appDomainFriendlyName = string.IsNullOrEmpty(this.applicationInstanceName) ? AppDomain.CurrentDomain.FriendlyName : this.applicationInstanceName;

            Regex filter = new Regex(replacePattern);
            appDomainFriendlyName = filter.Replace(appDomainFriendlyName, string.Empty);

            PerformanceCounterInstanceName instanceName = new PerformanceCounterInstanceName(appDomainFriendlyName, nameSuffix);
            return instanceName.ToString();
        }
    }
}

