// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.Practices.EnterpriseLibrary.Common.TestSupport
{
    public static class EventLogExtensions
    {
        public static IEnumerable<EventLogEntry> GetNewEntries(this EventLog log, int oldEntriesCount)
        {
            for (int index = oldEntriesCount; index < log.Entries.Count; ++index)
            {
                yield return log.Entries[index];
            }
        }

        public static IEnumerable<EventLogEntry> GetEntriesSince(this EventLog log, DateTime startTime)
        {
            var entries = log.Entries;
            int i = entries.Count;

            do
            {
                var entry = entries[--i];
                if(entry.TimeGenerated < startTime)
                {
                    break;
                }
                yield return entry;
            } while (i >= 0);
        }
    }
}

