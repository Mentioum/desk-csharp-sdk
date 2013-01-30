using Desk.Request;
using NUnit.Framework;

namespace Desk.Tests.Request
{
    public class GetTopicsParametersTests
    {
        [Test]
        public void ToString_ShouldHandleNoSetValues()
        {
            var param = new GetTopicsParameters();

            Assert.That(param.ToString(), Is.EqualTo(string.Empty));
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void ToString_ShouldHandleSingleValue(int val)
        {
            Assert.That(new GetTopicsParameters { Count = val }.ToString(), Is.EqualTo("?count=" + val));
            Assert.That(new GetTopicsParameters { Page = val }.ToString(), Is.EqualTo("?page=" + val));
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(30, 40)]
        public void ToString_ShouldHandleMultipleValues(int count, int page)
        {
            var param = new GetTopicsParameters { Count = count, Page = page };

            Assert.That(param.ToString(), Is.EqualTo("?count=" + count + "&page=" + page));
        }
    }
}
