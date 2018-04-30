// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Registers a class as a metadata body class for another class.
    /// </summary>
    /// <remarks>
    /// When applying metadata attributes to classes, the target class might not always allow itself to be anotated. <br/>
    /// This attribute can be used to nominate another class to contain the metadata attributes. <br/>
    /// The metadata type should follow the same structure as the target type and its members cab be decorated with the metadata attributes.<br/>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterAsMetadataTypeAttribute : Attribute
    {
        private readonly Type targetType;

        /// <summary>
        /// Creates a new instance of <see cref="RegisterAsMetadataTypeAttribute"/>.
        /// </summary>
        /// <param name="targetType">The type for which this class should contain metadata attributes.</param>
        public RegisterAsMetadataTypeAttribute(Type targetType)
        {
            this.targetType = targetType;
        }

        /// <summary>
        /// Gets the type for which this class should contain metadata attributes.
        /// </summary>
        /// <value>
        /// The type for which this class should contain metadata attributes.
        /// </value>
        public Type TargetType
        {
            get { return targetType; }
        }
    }
}

