using Desk.Entities;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Desk.Tests.Entities
{
    [TestFixture]
    public class DeskEntityTests
    {
        private EntityBase entity;


        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ShouldInitWithDynamicData()
        {
            entity = new EntityBase(JsonConvert.DeserializeObject("{\"id\":1,\"name\":\"General\"}".Replace("'", "\"")));

            Assert.That(entity.GetDynamicProperty<int>("id"), Is.EqualTo(1));
            Assert.That(entity.GetDynamicProperty<string>("name"), Is.EqualTo("General"));
        }
    }
}
