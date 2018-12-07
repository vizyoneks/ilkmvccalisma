using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifeTimes.Services
{
    public interface IUtilitySingletonService
    {
        string ReturnValue();
    }

    public class UtilitySingletonService : IUtilitySingletonService
    {
        private string key = Guid.NewGuid().ToString();
        public string ReturnValue()
        {
            return $"singleton{key}";
        }
    }
}
