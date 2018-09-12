// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation
{
    /// <summary>
    /// Provides a pluggable way to format the name given to a particular instance of a performance counter.
    /// This class does no formatting, returning the provided name suffix as the counter name.
    /// </summary>
    public class NoPrefixNameFormatter : IPerformanceCounterNameFormatter
    {
        /// <summary>
        /// Returns the given <paramref name="nameSuffix"></paramref> as the created name.
        /// </summary>
        /// <param name="nameSuffix">Performance counter name, as defined during installation of the counter</param>
        /// <returns>Formatted instance name in form of "<paramref name="nameSuffix"/>"</returns>
        public string CreateName(string nameSuffix)
        {
            return new PerformanceCounterInstanceName("", nameSuffix).ToString();
        }
    }
}

