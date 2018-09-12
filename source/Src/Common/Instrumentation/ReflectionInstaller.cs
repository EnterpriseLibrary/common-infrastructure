// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Configuration.Install;
using System.Reflection;
using System.Security;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation
{
    /// <summary>
    /// Generic installer wrapper around installer builder. Used to find and install 
    /// given type of installable resource.
    /// </summary>
    /// <typeparam name="TInstallerBuilder">Specific type of installer builder to instantiate</typeparam>
    [SecurityCritical]
    public class ReflectionInstaller<TInstallerBuilder> : Installer
        where TInstallerBuilder : AbstractInstallerBuilder
    {
        /// <summary>
        /// Installs the instrumentation resources
        /// </summary>
        /// <param name="stateSaver">An <see cref="IDictionary"/> used to save information needed to perform a commit, rollback, or uninstall operation.</param>
        [SecurityCritical]
        public override void Install(IDictionary stateSaver)
        {
            PrepareInstaller();
            base.Install(stateSaver);
        }

        /// <summary>
        /// Uninstalls the instrumentation resources
        /// </summary>
        /// <param name="stateSaver">An <see cref="IDictionary"/> that contains the state of the computer after the installation was complete.</param>
        [SecurityCritical]
        public override void Uninstall(IDictionary stateSaver)
        {
            PrepareInstaller();
            base.Uninstall(stateSaver);
        }

        private void PrepareInstaller()
        {
            string assemblyName = this.Context.Parameters["assemblypath"];
            Type[] types = Assembly.LoadFile(assemblyName).GetTypes();

            TInstallerBuilder builder = (TInstallerBuilder)Activator.CreateInstance(typeof(TInstallerBuilder), new object[] { types });

            builder.Fill(this);
        }
    }
}

