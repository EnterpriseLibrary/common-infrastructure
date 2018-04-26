// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Attribute that instructs the designtime to make the textbox for a property readonly. <br/>
    /// This property can is used together with an <see cref="EditorAttribute"/>, in which the created text box is readonly, 
    /// though the property can be edited by the editor.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=false)]
    public class EditorWithReadOnlyTextAttribute : Attribute
    {
        readonly bool readonlyText;

        /// <summary>
        /// Creates a new instance of <see cref="EditorWithReadOnlyTextAttribute"/>.
        /// </summary>
        /// <param name="readonlyText"><see langword="true"/> if the textbox created for this property should be readonly, otherwise <see langword="false"/>.</param>
        public EditorWithReadOnlyTextAttribute(bool readonlyText)
        {
            this.readonlyText = readonlyText;
        }

        /// <summary>
        /// Returns <see langword="true"/> if the textbox created for this property should be readonly, otherwise <see langword="false"/>.
        /// </summary>
        public bool ReadonlyText
        {
            get { return readonlyText; }
        }
    }
}

