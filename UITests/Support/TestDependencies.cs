using Autofac;
using OpenQA.Selenium;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;
using TestConfiguration;
using UIFramework;
using UIFramework.Pages;

namespace UITests.Support
{
    /// <summary>
    /// Test dependencies.
    /// </summary>
    public static class TestDependencies
    {
        /// <summary>
        /// Create conteiner builder.
        /// </summary>
        /// <returns></returns>
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            Configurator.Create();

            var builder = new ContainerBuilder();

            builder.RegisterInstance(new SeleniumContext(Configurator.Settings.UI.Browser).WebDriver).As<IWebDriver>().SingleInstance();
            builder.RegisterTypes(typeof(BasePage).Assembly.GetTypes().ToArray()).SingleInstance();

            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray());

            return builder;
        }
    }
}
