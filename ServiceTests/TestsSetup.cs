using NUnit.Framework;
using TestConfiguration;

namespace ServiceTests
{
    [SetUpFixture]
    public class TestsSetup
    {
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            Configurator.Create();
        }
    }
}