// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Instrumentation
{
    /// <summary>
    /// Formats an event log entry for logging to event log.
    /// </summary>
    public interface IEventLogEntryFormatter
    {
        /// <overloads>
        /// Creates a formatted message, suitable for logging to the event log.
        /// </overloads>
        /// <summary>
        /// Creates a formatted message, suitable for logging to the event log.
        /// </summary>
        /// <param name="message">Message to be formatted, with format tags embedded.</param>
        /// <param name="extraInformation">Extra strings to be matched up with the format tags provided in <paramref name="message"></paramref>.</param>
        /// <returns>Formatted message, suitable for logging to the event log.</returns>
        string GetEntryText(string message, params string[] extraInformation);

        /// <summary>
        /// Creates a formatted message, suitable for logging to the event log.
        /// </summary>
        /// <param name="message">Message to be formatted, with format tags embedded.</param>
        /// <param name="exception">Exception containing message text to be added to event log message produced by this method</param>
        /// <param name="extraInformation">Extra strings to be matched up with the format tags provided in <paramref name="message"></paramref>.</param>
        /// <returns>Formatted message, suitable for logging to the event log.</returns>
        string GetEntryText(string message, Exception exception, params string[] extraInformation);
    }
}

