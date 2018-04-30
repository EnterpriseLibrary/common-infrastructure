// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;

namespace EnterpriseLibrary.Common.Configuration.Design
{
    /// <summary>
    /// Attribute class that can be oved to offer a properties add-commands to the containing Element View Model.<br/>
    /// This can be usefull for properties that contain a collection of providers, of which the Element Collection View Model is not shown in the UI (User Interface).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=true)]
    public class PromoteCommandsAttribute : Attribute
    {
    }
}

