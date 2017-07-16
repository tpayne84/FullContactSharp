namespace FullContactSharp
{
    /// <summary>
    /// Company Contact Info, HTTP Request.
    /// </summary>
    public class CompanyRequest : Request
    {
        /// <summary>
        /// Creates a new Company Contact Info request.
        /// </summary>
        /// <param name="svc">Svc.</param>
        public CompanyRequest( Service svc, string value, CompanyLookup type, Confidence conf = Confidence.None )
        {
            // Create the params.
            HttpParams parameters = new HttpParams
            {
                // Type param.
                { type.ToString().ToLower(), value.Trim() }
            };

            // Build the confidence section, if there is a given confidence.
            if (conf != Confidence.None)
				parameters.Add("confidence", conf.ToString().ToLower());

			// Execute via the base class.
			this.Execute( Endpoint.Company, svc.ApiKey, parameters);
        }
    }
}
