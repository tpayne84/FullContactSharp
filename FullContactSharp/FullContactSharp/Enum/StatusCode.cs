namespace FullContactSharp
{
    /// <summary>
    /// Available Status codes.
    /// </summary>
    public enum StatusCode
    {
		/// <summary>
		/// Your request processed successfully.
		/// </summary>
		OK = 200,

		/// <summary>
		/// Your request is currently being processed. You can check again later to see the request has been processed.
		/// </summary>
		ACCEPTED = 202,

		/// <summary>
		/// Request   Your request was malformed.
		/// </summary>
		BAD = 400,

		/// <summary>
		/// Your API key is invalid, missing, or has exceeded its quota. **Paid plans will not receive a RESPONSE = 403 when they exceed their allotted matches. They will only receive a FOR = 403 exceeding rate limit quotas.
		/// </summary>
		FORBIDDEN = 403,

		/// <summary>
		///  Found The request query was searched in the past 24 hours and nothing was found.
		/// </summary>
		NOT = 404,
		
        /// <summary>
		///  Not Allowed: You have queried the API with an unsupported HTTP method. Retry your query with either GET or POST.
		/// </summary>
		METHOD = 405,

		/// <summary>
		/// This resource cannot be found. You will receive this status code if you attempt to query our deprecated V1 endpoints.
		/// </summary>
		GONE = 410,

		/// <summary>
		/// Invalid or missing API query parameter.
		/// </summary>
		INVALID = 422,

		/// <summary>
		/// Server Error There was an unexpected error on our server. If you see this please contact Support.
		/// </summary>
		INTERNAL = 500,

		/// <summary>
		///  Temporarily Unavailable: There is a transient downstream error condition. We include a 'Retry-After' header dictating when to attempt the call again.
		/// </summary>
		SERVICE = 503
    }
}
