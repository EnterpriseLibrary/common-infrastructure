// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Declaratively instructs the .NET Framework to perform time validation on a configuration property. This class cannot be inherited.
    /// </summary>
    public sealed class NonNegativeOrInfiniteTimeSpanValidatorAttribute : ConfigurationValidatorAttribute
    {
        /// <summary>
        /// Gets the validator attribute instance.
        /// </summary>
        /// <returns>The current <see cref="NonNegativeOrInfiniteTimeSpanValidator" />.</returns>
        public override ConfigurationValidatorBase ValidatorInstance
        {
            get
            {
                return new NonNegativeOrInfiniteTimeSpanValidator();
            }
        }
    }
}

