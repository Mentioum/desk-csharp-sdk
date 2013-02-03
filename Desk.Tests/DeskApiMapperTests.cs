using Desk.Request;
using Desk.Response;
using NSubstitute;
using NUnit.Framework;
using RestSharp;

namespace Desk.Tests
{
    [TestFixture]
    public class DeskApiMapperTests
    {
        private IDeskApiMapper mapper;
        private IDeskApi connection;
        private IRestResponse getResponse;


        [SetUp]
        public void Setup()
        {
            getResponse = Substitute.For<IRestResponse>();
            
            connection = Substitute.For<IDeskApi>();
            connection.Call(Arg.Any<string>(), Method.GET).Returns(getResponse);

            mapper = new DeskApiMapper(connection);
        }


        [Test]
        public void GetTopics_ShouldAccessCorrectResourceWithoutParameters()
        {
            mapper.GetTopics(GetTopicsParameters.None);

            connection.Received().Call("topics.json", Method.GET);
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 30)]
        public void GetTopics_ShouldAccessCorrectResourceWithParameters(int count, int page)
        {
            mapper.GetTopics(new GetTopicsParameters { Count = count, Page = page });

            connection.Received().Call("topics.json?count=" + count + "&page=" + page, Method.GET);
        }

        [Test]
        public void GetTopics_ShouldReturnRawResponse()
        {
            var result = mapper.GetTopics(GetTopicsParameters.None);

            Assert.That(result, Is.EqualTo(getResponse));
        }

        [Test]
        public void GetTopicsMapped_ShouldAccessCorrectResourceWithoutParameters()
        {
            mapper.GetTopicsMapped(GetTopicsParameters.None);

            connection.Received().Call("topics.json", Method.GET);
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 30)]
        public void GetTopicsMapped_ShouldAccessCorrectResourceWithParameters(int count, int page)
        {
            mapper.GetTopicsMapped(new GetTopicsParameters { Count = count, Page = page });

            connection.Received().Call("topics.json?count=" + count + "&page=" + page, Method.GET);
        }

        [Test]
        public void GetTopics_ShouldReturnMappedResponse()
        {
            var result = mapper.GetTopicsMapped(GetTopicsParameters.None);

            Assert.That(result, Is.TypeOf(typeof(GetTopicsResponse)));
        }

        [Test]
        public void VerifyConnection_ShouldAccessCorrectResource()
        {
            mapper.VerifyConnection();

            connection.Received().Call("account/verify_credentials.json", Method.GET);
        }

        [Test]
        public void VerifyConnection_ShouldReturnRawResponse()
        {
            var result = mapper.VerifyConnection();

            Assert.That(result, Is.EqualTo(getResponse));
        }
    }
}
