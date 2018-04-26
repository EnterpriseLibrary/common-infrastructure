// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Configuration;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseLibrary.Common.Configuration.Tests
{
    /// <summary>
    /// Summary description for SystemConfigurationSourceFixture
    /// </summary>
    public partial class SystemConfigurationSourceFixture2
    {
        [TestMethod]
        public void CanGetExistingSectionInAppConfigEvenIfTheAppDomainDoesNotHaveFileIOPermission()
        {
            var evidence = new Evidence();
            evidence.AddHostEvidence(new Zone(SecurityZone.Internet));
            var set = SecurityManager.GetStandardSandbox(evidence);
            set.AddPermission(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
            set.AddPermission(new ConfigurationPermission(PermissionState.Unrestricted));
            set.RemovePermission(typeof(FileIOPermission));

            var domain = AppDomain.CreateDomain("partial trust", null, AppDomain.CurrentDomain.SetupInformation, set);

            try
            {
                domain.DoCallBack(CheckSource);
            }
            catch
            {
                throw;
            }
            finally
            {
                AppDomain.Unload(domain);
            }
        }

        public static void CheckSource()
        {
            var source = new SystemConfigurationSource(false);
            object section = source.GetSection(localSection);

            if (section == null)
            {
                throw new Exception("could not get section");
            }
        }
    }
}

