using Newtonsoft.Json;

namespace FullContactSharp
{
    /// <summary>
    /// Person response.
    /// </summary>
    public class PersonResponse
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
        public PersonData Model { get; private set; }

        /// <summary>
        /// The person request used to generate the model.
        /// </summary>
        /// <value>The request.</value>
        PersonRequest Request { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:FullContactSharp.PersonResponse"/> class.
        /// </summary>
        /// <param name="request">Request.</param>
		public PersonResponse( PersonRequest request )
        {
            // Store the request.
            this.Request = request;

            // Deserialize the json, into the model.
            this.Model = JsonConvert.DeserializeObject<PersonData>(this.Request.JSON);
        }
    }
}
