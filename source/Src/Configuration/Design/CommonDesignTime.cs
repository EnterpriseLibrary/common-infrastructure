// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;

namespace EnterpriseLibrary.Common.Configuration.Design
{

    /// <summary>
    /// Class that contains common type names and metadata used by the designtime.
    /// </summary>
    public static class CommonDesignTime
    {
        /// <summary>
        /// Class that contains common command types used by the designtime.
        /// </summary>
        public static class CommandTypeNames
        {
            /// <summary>
            /// Type name of the WizardCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public static string WizardCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.Commands.WizardCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the AddSatelliteProviderCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string AddSatelliteProviderCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.Commands.AddSatelliteProviderCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the AddApplicationBlockCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string AddApplicationBlockCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.Commands.AddApplicationBlockCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the TypePickingCollectionElementAddCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string AddProviderUsingTypePickerCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.TypePickingCollectionElementAddCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the ExportAdmTemplateCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string ExportAdmTemplateCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.ExportAdmTemplateCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the HiddenCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string HiddenCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.Commands.HiddenCommand, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the AddInstrumentationBlockCommand class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string AddInstrumentationApplicationBlockCommand = "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.AddInstrumentationBlockCommand, EnterpriseLibrary.Configuration.DesignTime";
        }

        /// <summary>
        /// Class that contains common editor types used by the designtime.
        /// </summary>
        public static class EditorTypes
        {
            /// <summary>
            /// Type name of the DatePickerEditor class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string DatePickerEditor = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.DatePickerEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the ElementCollectionEditor, declared class in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string CollectionEditor = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.ElementCollectionEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the UITypeEditor class, declared in the System.Drawing Assembly.
            /// </summary>
            public const string UITypeEditor = "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

            /// <summary>
            /// Type name of the TypeSelectionEditor, declared class in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string TypeSelector = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.TypeSelectionEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the FilteredFileNameEditor, declared class in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string FilteredFilePath = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.FilteredFileNameEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the FrameworkElement, declared class in the PresentationFramework Assembly.
            /// </summary>
            public const string FrameworkElement = "System.Windows.FrameworkElement, PresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

            /// <summary>
            /// Type name of the MultilineTextEditor class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string MultilineText = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.MultilineTextEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the PopupTextEditor class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string PopupTextEditor = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.PopupTextEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the FlagsEditor class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string Flags = "EnterpriseLibrary.Configuration.Design.ComponentModel.Editors.FlagsEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the RegexTypeEditor class, declared in the System.Design Assembly.
            /// </summary>
            public const string RegexTypeEditor = "System.Web.UI.Design.WebControls.RegexTypeEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

            /// <summary>
            /// Type name of the ConnectionStringEditor class, declared in the System.Design Assembly.
            /// </summary>
            public const string ConnectionStringEditor = "System.Web.UI.Design.ConnectionStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

            /// <summary>
            /// Type name of the TemplateEditor class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string TemplateEditor = "EnterpriseLibrary.Logging.Configuration.Design.Formatters.TemplateEditor, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the IEnvironmentalOverridesEditor interface, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string OverridesEditor = "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.IEnvironmentalOverridesEditor, EnterpriseLibrary.Configuration.DesignTime";
        }

        /// <summary>
        /// Class that contains common view model types used by the designtime.
        /// </summary>
        public static class ViewModelTypeNames
        {
            /// <summary>
            /// Type name of the TypeNameProperty class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string TypeNameProperty = "EnterpriseLibrary.Configuration.Design.ViewModel.TypeNameProperty, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the ConfigurationProperty class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string ConfigurationPropertyViewModel =
                "EnterpriseLibrary.Configuration.Design.ViewModel.ConfigurationProperty, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the SectionViewModel class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string SectionViewModel = "EnterpriseLibrary.Configuration.Design.ViewModel.SectionViewModel, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the CollectionEditorContainedElementProperty class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string CollectionEditorContainedElementProperty =
                "EnterpriseLibrary.Configuration.Design.ViewModel.CollectionEditorContainedElementProperty, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the CollectionEditorContainedElementReferenceProperty class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string CollectionEditorContainedElementReferenceProperty =
                "EnterpriseLibrary.Configuration.Design.ViewModel.CollectionEditorContainedElementReferenceProperty, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the RedirectedSectionSourceProperty class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string RedirectedSectionSourceProperty = 
                "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.RedirectedSectionSourceProperty, EnterpriseLibrary.Configuration.DesignTime";
        }

        /// <summary>
        /// Class that contains common converter types used by the designtime runtime.
        /// </summary>
        public static class ConverterTypeNames
        {
            /// <summary>
            /// Type name of the RedirectedSectionNameConverter class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string RedirectedSectionNameConverter =
                "EnterpriseLibrary.Configuration.Design.ComponentModel.Converters.RedirectedSectionNameConverter, EnterpriseLibrary.Configuration.DesignTime";

        }

        /// <summary>
        /// Class that contains common metadata classes used by the designtime.<br/>
        /// This class supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// </summary>
        public static class MetadataTypes
        {
            /// <summary>This class supports the Enterprise Library infrastructure and is not intended to be used directly from your code.</summary>
            [RegisterAsMetadataType(typeof(RedirectedSectionElement))]
            public abstract class RedirectedSectionElementMetadata
            {

                /// <summary>This property supports the Enterprise Library infrastructure and is not intended to be used directly from your code.</summary>
                [TypeConverter(ConverterTypeNames.RedirectedSectionNameConverter)]
                public string Name
                {
                    get;
                    set;
                }
            }
        }

        /// <summary>
        /// Class that contains common validation types used by the designtime.
        /// </summary>
        public static class ValidationTypeNames
        {
            /// <summary>
            /// Type name of the FileWritableValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string FileWritableValidator = "EnterpriseLibrary.Configuration.Design.Validation.FileWritableValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the FilePathValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string FileValidator = "EnterpriseLibrary.Configuration.Design.Validation.FilePathValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the FilePathExistsValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string PathExistsValidator = "EnterpriseLibrary.Configuration.Design.Validation.FilePathExistsValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the RequiredFieldValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string RequiredFieldValidator = "EnterpriseLibrary.Configuration.Design.Validation.RequiredFieldValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the TypeValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string TypeValidator =
                "EnterpriseLibrary.Configuration.Design.Validation.TypeValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the SelectedSourceValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string SelectedSourceValidator =
                "EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.SelectedSourceValidator, EnterpriseLibrary.Configuration.DesignTime";

            /// <summary>
            /// Type name of the NameValueCollectionValidator class, declared in the Configuration.DesignTime Assembly.
            /// </summary>
            public const string NameValueCollectionValidator = "EnterpriseLibrary.Configuration.Design.Validation.NameValueCollectionValidator, EnterpriseLibrary.Configuration.DesignTime";
        }

        /// <summary>
        /// Type names for well known Enterprise Library <see cref="System.Configuration.ConfigurationSection"/> elements.
        /// </summary>
        public static class SectionType
        {
            /// <summary>
            /// Type name for the LoggingSettings section.
            /// </summary>
            public const string LoggingSettings = "EnterpriseLibrary.Logging.Configuration.LoggingSettings, EnterpriseLibrary.Logging";

            /// <summary>
            /// Type name for the DatabaseSettings section.
            /// </summary>
            public const string DatabaseSettings = "EnterpriseLibrary.Data.Configuration.DatabaseSettings, EnterpriseLibrary.Data";

            /// <summary>
            /// Type name for the ExceptionHandlingSettings section.
            /// </summary>
            public const string ExceptionHandlingSettings = "EnterpriseLibrary.ExceptionHandling.Configuration.ExceptionHandlingSettings, EnterpriseLibrary.ExceptionHandling";

        }
    }
}

