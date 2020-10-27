using Boilerplate.Options;
using Microsoft.Extensions.Options;

namespace Boilerplate.Services
{
    public interface IGreetingService
    {
        string SayHello(string name);
    }

    public class GreetingService : IGreetingService
    {
        private readonly GreetingOptions _options;

        public GreetingService(IOptions<GreetingOptions> options)
        {
            _options = options.Value;
        }

        public string SayHello(string name)
        {
            return $"{_options.Prefix}, {name}!";
        }
    }
}
