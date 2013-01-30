using Desk.Request;
using NUnit.Framework;

namespace Desk.Tests.Request
{
    [TestFixture]
    public class ParametersBaseTests
    {
        private ParametersBase parametersBase;


        [SetUp]
        public void Setup()
        {
            parametersBase = new ParametersBase();
        }


        [Test]
        public void Serialize_ShouldReturnEmptyStringForNoParameters()
        {
            Assert.That(parametersBase.ToString(), Is.EqualTo(string.Empty));
        }

        [Test]
        public void Serialize_ShouldReturnCorrectSingleParameterString()
        {
            parametersBase.SetParameter("foo", "bar");

            Assert.That(parametersBase.ToString(), Is.EqualTo("?foo=bar"));
        }

        [Test]
        public void Serialize_ShouldReturnCorrectMultiParameterString()
        {
            parametersBase.SetParameter("foo", "bar");
            parametersBase.SetParameter("bar", "1");

            Assert.That(parametersBase.ToString(), Is.EqualTo("?foo=bar&bar=1"));
        }

        [Test]
        [TestCase("foo", "bar")]
        [TestCase("foo", 1)]
        [TestCase("foo", 1.0)]
        public void ShouldSetAndGetUntypedParameters(string key, object val)
        {
            parametersBase.SetParameter(key, val);

            Assert.That(parametersBase.GetParameter(key), Is.EqualTo(val));
        }

        [Test]
        public void ShouldSetAndGetTypedParameters()
        {
            parametersBase.SetParameter("foo", 1);

            Assert.That(parametersBase.GetParameter<int>("foo"), Is.EqualTo(1));
        }
    }
}
