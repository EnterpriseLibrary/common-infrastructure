// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.ContextBase;

namespace Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.Configuration
{

    public abstract class Given_AConfigurationSourceBuilder : ArrangeActAssert
    {
        public IConfigurationSourceBuilder Builder { get; private set; }

        protected override void Arrange()
        {
            base.Arrange();
            Builder = new ConfigurationSourceBuilder();
        }
    }

    //// TODO replace with other section from common
    //[TestClass]
    //public class When_GivenAnEmptyConfigurationSource : Given_AConfigurationSourceBuilder
    //{
    //    private IConfigurationSource mergedConfiguration;

    //    protected override void Arrange()
    //    {
    //        base.Arrange();

    //        Builder
    //            .ConfigureInstrumentation()
    //                .EnableLogging();

    //    }

    //    protected override void Act()
    //    {
    //        mergedConfiguration = new DictionaryConfigurationSource();
    //        Builder.UpdateConfigurationWithReplace(mergedConfiguration);
    //    }

    //    [TestMethod]
    //    public void Then_MergingConfigurationSourceMovesSections()
    //    {
    //        Assert.IsNotNull(mergedConfiguration.GetSection(InstrumentationConfigurationSection.SectionName));
    //    }
    //}

    //[TestClass]
    //public class When_GivenAPopulatedConfigurationSection : Given_AConfigurationSourceBuilder
    //{
    //    private IConfigurationSource mergedConfiguration;
    //    protected override void Arrange()
    //    {
    //        base.Arrange();

    //        mergedConfiguration = new DictionaryConfigurationSource();
    //        mergedConfiguration.Add(
    //                       InstrumentationConfigurationSection.SectionName,
    //                       new InstrumentationConfigurationSection(false, true));

    //        Builder
    //            .ConfigureInstrumentation()
    //                .EnablePerformanceCounters();
    //    }

    //    protected override void Act()
    //    {
    //        mergedConfiguration = new DictionaryConfigurationSource();
    //        Builder.UpdateConfigurationWithReplace(mergedConfiguration);
    //    }

    //    [TestMethod]
    //    public void Then_MergingConfigurationSourceMovesSections()
    //    {
    //        var section = (InstrumentationConfigurationSection)mergedConfiguration
    //                                                                .GetSection(InstrumentationConfigurationSection.SectionName);

    //        Assert.IsFalse(section.EventLoggingEnabled);
    //        Assert.IsTrue(section.PerformanceCountersEnabled);
    //    }
    //}
}

