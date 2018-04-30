// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;
using System.Runtime.Serialization;

namespace EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Exception class for exceptions that occur when reading configuration metadata from a <see cref="ConfigurationSourceSection"/>.
    /// </summary>
    /// <seealso cref="ConfigurationSourceSection"/>
    [Serializable]
    public class ConfigurationSourceErrorsException : ConfigurationErrorsException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceErrorsException"/> class.
        /// </summary>
        public ConfigurationSourceErrorsException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceErrorsException"/> class.
        /// </summary>
        /// <param name="message">A message that describes why this <see cref="ConfigurationSourceErrorsException"/> exception was thrown.</param>
        public ConfigurationSourceErrorsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceErrorsException"/> class.
        /// </summary>
        /// <param name="message">A message that describes why this <see cref="ConfigurationSourceErrorsException"/> exception was thrown.</param>
        /// <param name="innerException">The inner exception that caused this <see cref="ConfigurationSourceErrorsException"/> exception to be thrown.</param>
        public ConfigurationSourceErrorsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceErrorsException"/> class.
        /// </summary>
        /// <param name="message">A message that describes why this <see cref="ConfigurationSourceErrorsException"/> exception was thrown.</param>
        /// <param name="innerException">The inner exception that caused this <see cref="ConfigurationSourceErrorsException"/> exception to be thrown.</param>
        /// <param name="filename">The path to the configuration file that caused this <see cref="ConfigurationSourceErrorsException"/> exception to be thrown.</param>
        /// <param name="line">The line number within the configuration file at which this <see cref="ConfigurationSourceErrorsException"/> exception was thrown.</param>
        public ConfigurationSourceErrorsException(string message, Exception innerException, string filename, int line)
            :base(message, innerException, filename, line)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSourceErrorsException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the information to be serialized.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected ConfigurationSourceErrorsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}

