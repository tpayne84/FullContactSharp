using System;
using FullContactSharp;
using NUnit.Framework;

namespace FullContaxtSharpTests
{
    /// <summary>
    /// Person response tests.
    /// </summary>
    [TestFixture]
    public class PersonResponseTest
    {
        /// <summary>
        /// Tests the ability to search for person data by an email address.
        /// </summary>
        /// <param name="apiKey">API key.</param>
        /// <param name="email">Email.</param>
        [TestCase( TestValues.ApiKey, TestValues.Person.Email )]
        public void SearchPerson_ByEmail( string apiKey, string email )
        {
            // Use the service to perform a search.
            var personData = Service.Search(
                    apiKey,
                    PersonLookup.Email,
                    email
            );

            // Write the JSON as output.
            Console.WriteLine(personData.JSON);
        }

		/// <summary>
		/// Tests the ability to search for person data by a phone number.
		/// </summary>
		/// <param name="apiKey">API key.</param>
		/// <param name="phoneNumber">Phone Number to test.</param>
		[TestCase(TestValues.ApiKey, TestValues.Person.Phone)]
        public void SearchPerson_ByPhone(string apiKey, string phoneNumber)
		{
			// Use the service to perform a search.
			var personData = Service.Search(
					apiKey,
					PersonLookup.Phone,
					phoneNumber
			);

			// Write the JSON as output.
			Console.WriteLine(personData.JSON);
		}
    }
}
