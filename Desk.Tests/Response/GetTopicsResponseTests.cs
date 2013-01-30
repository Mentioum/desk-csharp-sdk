using System.Linq;
using Desk.Entities;
using Desk.Response;
using Desk.TestData;
using NSubstitute;
using NUnit.Framework;
using RestSharp;

namespace Desk.Tests.Response
{
    [TestFixture]
    public class GetTopicsResponseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static IRestResponse GetResponse()
        {
            var response = Substitute.For<IRestResponse>();
            response.Content = GetTopicsResponseTestData.Json;

            return response;
        }


        [Test]
        public void ShouldInitializeWithoutRawResponse()
        {
            var response = new GetTopicsResponse();

            Assert.That(response.Count, Is.EqualTo(0));
            Assert.That(response.Page, Is.EqualTo(0));
            Assert.That(response.Total, Is.EqualTo(0));
        }

        [Test]
        public void ShouldInitializeWithRawResponse()
        {
            var response = new GetTopicsResponse(GetResponse());

            Assert.That(response.Count, Is.EqualTo(20));
            Assert.That(response.Page, Is.EqualTo(1));
            Assert.That(response.Total, Is.EqualTo(3));
            Assert.That(response.Topics.Count(), Is.EqualTo(3));

            AssertTopic(response.Topics.ElementAt(0), 1, "Sample :: General", "Sample Topic Description :: Information about our company", true, 1);
            AssertTopic(response.Topics.ElementAt(1), 2, "Canned Responses", "Internal responses to common questions", false, 2);
            AssertTopic(response.Topics.ElementAt(2), 3, "Sample :: Products", "Sample Topic Description :: Information about our products", true, 3);
        }

        public void AssertTopic(Topic topic, int id, string name, string description, bool showInPortal, int position)
        {
            Assert.That(topic.Id, Is.EqualTo(id));
            Assert.That(topic.Name, Is.EqualTo(name));
            Assert.That(topic.Description, Is.EqualTo(description));
            Assert.That(topic.ShowInPortal, Is.EqualTo(showInPortal));
            Assert.That(topic.Position, Is.EqualTo(position));
        }
    }
}
