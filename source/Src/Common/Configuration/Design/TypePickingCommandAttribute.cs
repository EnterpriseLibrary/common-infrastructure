// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Attribute class that is used to add a custom add command for a Element View Model.<br/>
    /// The Type Picking Command displays a type picker prior to adding the target element and can use its result to initialize the added element.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TypePickingCommandAttribute : CommandAttribute
    {
        private string property;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypePickingCommandAttribute"/> class.
        /// </summary>
        public TypePickingCommandAttribute()
            :this("TypeName")
        {

        }

        ///<summary>
        /// Initializes a new instance of the <see cref="TypePickingCommandAttribute"/> class.
        ///</summary>
        ///<param name="property">The clr-name of the property to which the selected type should be assigned. This property is expected to be of type <see cref="System.String"/>.</param>
        public TypePickingCommandAttribute(string property)
            :base(CommonDesignTime.CommandTypeNames.AddProviderUsingTypePickerCommand)
        {
            this.property = property;
            CommandPlacement = CommandPlacement.ContextAdd;
        }

        /// <summary>
        /// Gets the clr-name of the property to which the selected type should be assigned.
        /// </summary>
        /// <value>
        /// The clr-name of the property to which the selected type should be assigned.
        /// </value>
        public string Property
        {
            get { return property; }
        }

    }
}

