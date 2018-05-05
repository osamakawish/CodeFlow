using Microsoft.Extensions.Configuration;

namespace OdeToFood2
{
    public interface IGreeter
    {
        string Message();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration configuration;

        public Greeter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string Message()
        {
            // Goes to appsettings.json to find this.
            return configuration["Greeting"];
        }
    }
}