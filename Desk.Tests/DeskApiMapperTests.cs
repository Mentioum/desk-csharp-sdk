using Desk.Request;
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
        private IRestResponse response;


        [SetUp]
        public void Setup()
        {
            response = Substitute.For<IRestResponse>();
            
            connection = Substitute.For<IDeskApi>();
            connection.Get(Arg.Any<string>()).Returns(response);

            mapper = new DeskApiMapper(connection);
        }


        [Test]
        public void GetTopics_ShouldAccessCorrectResouceWithoutParameters()
        {
            mapper.GetTopics(GetTopicsParameters.None);

            connection.Received().Get("topics.json");
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 30)]
        public void GetTopics_ShouldAccessCorrectResouceWithParameters(int count, int page)
        {
            mapper.GetTopics(new GetTopicsParameters { Count = count, Page = page });

            connection.Received().Get("topics.json?count=" + count + "&page=" + page);
        }

        [Test]
        public void GetTopics_ShouldReturnRawResponce()
        {
            var result = mapper.GetTopics(GetTopicsParameters.None);

            Assert.That(result, Is.EqualTo(response));
        }

        [Test]
        public void VerifyConnection_ShouldAccessCorrectResouce()
        {
            mapper.VerifyConnection();

            connection.Received().Get("account/verify_credentials.json");
        }

        [Test]
        public void VerifyConnection_ShouldReturnRawResponce()
        {
            var result = mapper.VerifyConnection();

            Assert.That(result, Is.EqualTo(response));
        }
    }
}
