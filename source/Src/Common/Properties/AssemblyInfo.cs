// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Configuration;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

#if !NET6_0 && !NET7_0
[assembly: ReliabilityContract(Consistency.WillNotCorruptState, Cer.None)]
#endif

[assembly: AllowPartiallyTrustedCallers]

[assembly: ComVisible(false)]

[assembly: HandlesSection(ConfigurationSourceSection.SectionName)]
[assembly: HandlesSection(AppSettingsDesignTime.AppSettingsSectionName)]

[assembly: AddApplicationBlockCommand(
                AppSettingsDesignTime.AppSettingsSectionName,
                typeof(AppSettingsSection),
                TitleResourceType = typeof(DesignResources),
                TitleResourceName = "AddApplicationSettingsTitle")]

[assembly: AddApplicationBlockCommand(ConfigurationSourceSection.SectionName,
            typeof(ConfigurationSourceSection),
            TitleResourceType = typeof(DesignResources),
            TitleResourceName = "AddConfigurationSourcesTitle",
            CommandModelTypeName = ConfigurationSourcesDesignTime.CommandTypeNames.AddConfigurationSourcesBlockCommand)]

