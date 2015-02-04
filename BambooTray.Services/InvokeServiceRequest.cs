namespace BambooTray.Services
{
    public class InvokeServiceRequest
    {
        public InvokeServiceRequest(string resource)
        {
            this.Resource = resource;
        }

        public string Resource { get; set; }
    }
}
