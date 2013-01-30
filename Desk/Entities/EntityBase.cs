namespace Desk.Entities
{
    /// <summary>
    /// This class is inherited by all classes that correspond to
    /// an API entity. It provides methods for dynamic properties.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://github.com/danielsaidi/desk-csharp-sdk
    /// </remarks>
    public class EntityBase
    {
        public EntityBase()
        {
        }

        public EntityBase(dynamic dynamicProperties)
        {
            DynamicProperties = dynamicProperties;
        }


        public dynamic DynamicProperties { get; private set; }


        public T GetDynamicProperty<T>(string propertyName)
        {
            var value = DynamicProperties[propertyName];

            return (T)value;
        }
    }
}
