using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifeTimes.Services
{
   public interface IUtilityScopedService
    {
        string ReturnValue();
    }

    public class UtilityScopedService : IUtilityScopedService
    {
        private string key = Guid.NewGuid().ToString();
        public string ReturnValue()
        {
            return $"scoped{key}";
        }
    }
}
