namespace Desk.Entities
{
    /// <summary>
    /// This class represents the object that is received when
    /// requesting topics from the desk.com API.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public class Topic : EntityBase
    {
        public Topic()
        {   
        }

        public Topic(object propertyContainer)
            : base(propertyContainer)
        {
            Id = GetDynamicProperty<int>("id");
            Name = GetDynamicProperty<string>("name");
            Description = GetDynamicProperty<string>("description");
            ShowInPortal = GetDynamicProperty<bool>("show_in_portal");
            Position = GetDynamicProperty<int>("position");
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool ShowInPortal { get; set; }

        public int Position { get; set; }
    }
}