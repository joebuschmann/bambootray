namespace BambooTray.Services
{
    using System;
    using System.Net;

    using Newtonsoft.Json;

    using RestSharp;

    /// <summary>
    /// The service invoker.
    /// </summary>
    public class ServiceInvoker
    {
        private readonly Uri endPointUri;

        private readonly string userName;

        private readonly string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInvoker"/> class.
        /// </summary>
        /// <param name="endPointUri">
        /// The end point uri.
        /// </param>
        /// <param name="userName">
        /// The user Name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        public ServiceInvoker(Uri endPointUri, string userName, string password)
        {
            this.endPointUri = endPointUri;
            this.userName = userName;
            this.password = password;
        }

        /// <summary>
        /// The invoke.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <typeparam name="T">
        /// The type of request
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T Invoke<T>(InvokeServiceRequest request) where T : new()
        {
            var client = new RestClient(this.endPointUri.AbsoluteUri) { Authenticator = this.GetCredentials() };

            var restRequest = new RestRequest(request.Resource, Method.GET);
            
            var response = client.Execute(restRequest);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new BambooRequestException(
                    string.Format(
                        "Server Error: {0}",
                        string.IsNullOrEmpty(response.ErrorMessage) ? response.StatusDescription : response.ErrorMessage));
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        private IAuthenticator GetCredentials()
        {
            return !string.IsNullOrEmpty(this.userName) && !string.IsNullOrEmpty(this.password)
                       ? new HttpBasicAuthenticator(this.userName, this.password)
                       : null;
        }
    }
}
