using Desk.Entities;
using Desk.TestData;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Desk.Tests.Entities
{
    [TestFixture]
    public class TopicTests
    {
        [Test]
        public void Topic_ShouldParseGetTopicJsonData()
        {
            var topic = new Topic(JsonConvert.DeserializeObject(TopicTestData.GetTopicJson));

            AssertTopic(topic, 1, "Sample :: General", "Sample Topic Description :: Information about our company", true, 0);
        }

        [Test]
        public void Topic_ShouldParseGetTopicsJsonData()
        {
            var topic = new Topic(JsonConvert.DeserializeObject(TopicTestData.GetTopicsJson));

            AssertTopic(topic, 1, "Sample :: General", "Sample Topic Description :: Information about our company", true, 1);
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
