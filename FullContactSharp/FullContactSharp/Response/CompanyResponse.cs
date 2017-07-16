using Newtonsoft.Json;

namespace FullContactSharp
{
	/// <summary>
	/// Company response.
	/// </summary>
	public class CompanyResponse
    {
        /// <summary>
        /// Source JSON string.
        /// </summary>
        /// <value>The source.</value>
        public string JSON { get; set; }

        /// <summary>
        /// Deserialized Model.
        /// </summary>
        /// <value>The model.</value>
        public CompanyData Model { get; private set; }

		/// <summary>
		/// The Company request used to generate the model.
		/// </summary>
		/// <value>The request.</value>
		CompanyRequest Request { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:FullContactSharp.CompanyResponse"/> class.
        /// </summary>
        /// <param name="request">Request.</param>
		public CompanyResponse( CompanyRequest request )
        {
            // Store the request.
            this.Request = request;

            // Deserialize the json, into the model.
            this.Model = JsonConvert.DeserializeObject<CompanyData>(this.Request.JSON);
        }
    }
}
