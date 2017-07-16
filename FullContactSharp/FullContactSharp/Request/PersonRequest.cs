namespace FullContactSharp
{
    /// <summary>
    /// Person Contact Info, HTTP Request.
    /// </summary>
    public class PersonRequest : Request
    {
        /// <summary>
        /// Creates a new Person Contact Info request.
        /// </summary>
        /// <param name="svc">Svc.</param>
        public PersonRequest( Service svc, string value, PersonLookup type, Confidence conf = Confidence.None )
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
			this.Execute( Endpoint.Person, svc.ApiKey, parameters);
        }
    }
}
