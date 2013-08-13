namespace Halltom.Bamboo.Tray.Services
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
