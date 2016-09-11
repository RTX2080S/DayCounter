using DayCounter.Interfaces;
using Microsoft.Win32;
using System;

namespace DayCounter.Controllers
{
    class RegistryController : IRegistryController
    {
        public object Get(string keyName, string valueName, object defaultValue)
        {
            return Registry.GetValue(keyName, valueName, defaultValue);
        }

        public bool Save(string keyName, string valueName, object value, out string message)
        {
            try
            {
                Registry.SetValue(keyName, valueName, value);
                message = "Successful! ";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
