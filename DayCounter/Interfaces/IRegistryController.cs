
namespace DayCounter.Interfaces
{
    interface IRegistryController
    {
        object Get(string keyName, string valueName, object defaultValue);
        bool Save(string keyName, string valueName, object value, out string message);
    }
}
