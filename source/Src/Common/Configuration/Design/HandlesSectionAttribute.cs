// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;

namespace EnterpriseLibrary.Common.Configuration.Design
{
    ///<summary>
    /// Indicates that this assembly handles the <see cref="ConfigurationSection"/>.
    ///</summary>
    [AttributeUsage(AttributeTargets.Assembly,AllowMultiple=true)]
    public class HandlesSectionAttribute : Attribute
    {
        private readonly string sectionName;

        /// <summary>
        /// Initializes a new instance of the <see cref="HandlesSectionAttribute"/> class.
        /// </summary>
        /// <param name="sectionName"></param>
        public HandlesSectionAttribute(string sectionName)
        {
            this.sectionName = sectionName;
        }

        ///<summary>
        /// Name of the section handled by this assembly.
        ///</summary>
        public string SectionName
        {
            get { return sectionName; }
        }

        /// <summary>
        /// Indicates this section should be cleared during save, but there is no 
        /// direct handler for it.
        /// </summary>
        public bool ClearOnly { get; set; }
    }
}

