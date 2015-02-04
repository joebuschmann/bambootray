namespace BambooTray.Services
{
    public class InvokeServiceRequest
    {
        public InvokeServiceRequest(string resource)
        {
            Resource = resource;
        }

        public string Resource { get; private set; }
    }
}
