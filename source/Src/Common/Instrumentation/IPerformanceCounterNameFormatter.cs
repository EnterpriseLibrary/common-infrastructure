// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace EnterpriseLibrary.Common.Instrumentation
{
    /// <summary>
    /// Provides a pluggable way to format the name given to a particular instance of a performance counter.
    /// Each instance of a performance counter in Enterprise Library is given a name of the format
    /// "Name prefix - counter name"
    /// </summary>
    public interface IPerformanceCounterNameFormatter
    {
        /// <summary>
        /// Creates the formatted instance name for a performance counter, providing the prefix for the
        /// instance.
        /// </summary>
        /// <param name="nameSuffix">Performance counter name, as defined during installation of the counter</param>
        /// <returns>Formatted instance name in form of "prefix - nameSuffix"</returns>
        string CreateName(string nameSuffix);
    }
}

