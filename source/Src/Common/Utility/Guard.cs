// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using EnterpriseLibrary.Common.Properties;

namespace EnterpriseLibrary.Common.Utility
{
    /// <summary>
    /// A static helper class that includes various parameter checking routines.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if the given argument is null.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value is null.</exception>
        /// <param name="argumentValue">The argument value to test.</param>
        /// <param name="argumentName">The name of the argument to test.</param>
        public static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null) throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// Throws an exception if the tested string argument is null or an empty string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string value is null.</exception>
        /// <exception cref="ArgumentException">The string is empty.</exception>
        /// <param name="argumentValue">The argument value to test.</param>
        /// <param name="argumentName">The name of the argument to test.</param>
        public static void ArgumentNotNullOrEmpty(string argumentValue, string argumentName)
        {
            if (argumentValue == null) throw new ArgumentNullException(argumentName);
            if (argumentValue.Length == 0) throw new ArgumentException(Resources.ExceptionStringEmpty, argumentName);
        }

        /// <summary>
        /// Verifies that an argument instance is assignable from the provided type (meaning
        /// interfaces are implemented, or classes exist in the base class hierarchy, or instance can be 
        /// assigned through a runtime wrapper, as is the case for COM Objects).
        /// </summary>
        /// <param name="assignmentTargetType">The argument type that will be assigned to.</param>
        /// <param name="assignmentInstance">The instance that will be assigned.</param>
        /// <param name="argumentName">Argument name.</param>
        public static void InstanceIsAssignable(Type assignmentTargetType, object assignmentInstance, string argumentName)
        {
            if (assignmentTargetType == null)
            {
                throw new ArgumentNullException("assignmentTargetType");
            }

            if (assignmentInstance == null)
            {
                throw new ArgumentNullException("assignmentInstance");
            }

            if (!assignmentTargetType.GetTypeInfo().IsAssignableFrom(assignmentInstance.GetType().GetTypeInfo()))
            {
                throw new ArgumentException(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.TypesAreNotAssignable,
                        assignmentTargetType,
                        GetTypeName(assignmentInstance)),
                    argumentName);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
           Justification = "Need to use exception as flow control here, no other choice")]
        private static string GetTypeName(object assignmentInstance)
        {
            string assignmentInstanceType;
            try
            {
                assignmentInstanceType = assignmentInstance.GetType().FullName;
            }
            catch (Exception)
            {
                assignmentInstanceType = Resources.UnknownType;
            }
            return assignmentInstanceType;
        }
    }
}

