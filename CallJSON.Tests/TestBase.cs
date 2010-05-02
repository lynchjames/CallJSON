using CallJSON.Core;
using NUnit.Framework;

namespace CallJSON.Tests
{
    [TestFixture]
    public class TestBase
    {
        private ConversionService _conversionService;

        [TestFixtureSetUp]
        public void Setup()
        {
            _conversionService = new ConversionService();
        }
    }
}