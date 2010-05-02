using CoJSON.Core;
using NUnit.Framework;

namespace CoJSON.Tests
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