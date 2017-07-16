namespace FullContactSharp
{
    /// <summary>
    /// Full Contact API, Service.
    /// </summary>
    public class Service
    {
		/// <summary>
		/// Static helper used to search for Person Data.
		/// </summary>
		/// <returns>The <see cref="PersonResponse"/>.</returns>
		/// <param name="apiKey">API key.</param>
		/// <param name="type">Type.</param>
		/// <param name="value">Value.</param>
		/// <param name="conf">Required <see cref="Confidence"/> level.</param>
		public static PersonResponse Search(string apiKey, PersonLookup type, string value, Confidence conf = Confidence.None)
		{
            // Create the service.
            var svc = new Service(apiKey);

            // Perform the search.
            return svc.Search(type, value, conf);
		}

		/// <summary>
		/// Static helper used to search for Company Data.
		/// </summary>
		/// <returns>The <see cref="CompanyResponse"/>.</returns>
		/// <param name="apiKey">API key.</param>
		/// <param name="type">Type.</param>
		/// <param name="value">Value.</param>
		/// <param name="conf">Required <see cref="Confidence"/> level.</param>
		public static CompanyResponse Search(string apiKey, CompanyLookup type, string value, Confidence conf = Confidence.None)
		{
			// Create the service.
			var svc = new Service(apiKey);

			// Perform the search.
			return svc.Search(type, value, conf);
		}

		/// <summary>
		/// Full Contact API Key.
		/// </summary>
		/// <value>The API key.</value>
		public string ApiKey { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        public Service( string apiKey )
        {
            // Set the API key.
            this.ApiKey = apiKey;
        }

		/// <summary>
		/// Search overload for the Person data endpoint.
		/// </summary>
		/// <returns><see cref="PersonResponse"/></returns>
		/// <param name="type"><see cref="PersonLookup"/> Type.</param>
		/// <param name="value">Value to use in the search.</param>
		/// <param name="conf">Required <see cref="Confidence"/> level.</param>
		public PersonResponse Search( PersonLookup type, string value, Confidence conf = Confidence.None  ) => new PersonResponse(new PersonRequest( this, value, type, conf ));

		/// <summary>
		/// Search overload for the Company data endpoint.
		/// </summary>
		/// <returns><see cref="CompanyResponse"/></returns>
		/// <param name="type"><see cref="CompanyLookup"/> Type.</param>
		/// <param name="value">Value to use in the search.</param>
		/// <param name="conf">Required <see cref="Confidence"/> level.</param>
		public CompanyResponse Search(CompanyLookup type, string value, Confidence conf = Confidence.None) => new CompanyResponse(new CompanyRequest(this, value, type, conf));
	}
}
