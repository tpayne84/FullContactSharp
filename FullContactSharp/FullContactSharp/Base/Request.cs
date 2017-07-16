using System.Net;

namespace FullContactSharp
{
    /// <summary>
    /// Base Full Contact Request Class.
    /// </summary>
    public abstract class Request
    {
        /// <summary>
        /// Services used in request.
        /// </summary>
        /// <value>The service.</value>
        private Service service { get; set; }

        /// <summary>
        /// Gets the json.
        /// </summary>
        /// <value>The json.</value>
        public string JSON { get; private set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        private HttpWebRequest request { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        protected HttpWebResponse Response { get; set; }

        /// <summary>
        /// Sends the request using the the specified apiKey and args.
        /// Loads the Resonse.
        /// </summary>
        /// <returns>The initialize.</returns>
        /// <param name="endpoint">API endpoint.</param>
        /// <param name="apiKey">API key.</param>
        /// <param name="parameters">HTTP params.</param>
        public void Execute(Endpoint endpoint, string apiKey, HttpParams parameters)
        {
            // Create the HTTP request.
            this.request = (HttpWebRequest)WebRequest.Create($"https://api.fullcontact.com/v2/{endpoint.ToString().ToLower()}.json" + parameters);

            // Assign the method.
            this.request.Method = WebRequestMethods.Http.Post;

            // Set the accept type to json.
            this.request.Accept = "application/json";

            // Set the api key header.
            this.request.Headers["X-FullContact-APIKey"] = apiKey;

            // Get the Response.
            this.Response = (HttpWebResponse)this.request.GetResponse();

            // Extract the JSON.
            using (var reader = new System.IO.StreamReader(this.Response.GetResponseStream()))
            {
                //  Store the JSON text string.
                this.JSON = reader.ReadToEnd();
            }
        }
    }
}
