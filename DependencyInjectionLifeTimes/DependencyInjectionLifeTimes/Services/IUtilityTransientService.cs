using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifeTimes.Services
{
    public interface IUtilityTransientService
    {
        string ReturnValue();
    }

    public class UtilityTransientService : IUtilityTransientService
    {
        private string key = Guid.NewGuid().ToString();
        public string ReturnValue()
        {
            return $"transient{key}";
        }
    }
}
