using System;
using FullContactSharp;
using NUnit.Framework;

namespace FullContactSharpTests
{
    /// <summary>
    /// Company response tests.
    /// </summary>
    [TestFixture]
    public class CompanyResponseTest
    {
		/// <summary>
		/// Tests the ability to search for company data by domain.
		/// </summary>
		/// <param name="apiKey">API key.</param>
		/// <param name="domain">Domain.</param>
		[TestCase( TestValues.ApiKey, TestValues.Company.Domain )]
        public void SearchCompany_ByDomain( string apiKey, string domain )
        {
            // Use the service to perform a search.
            var companyData = Service.Search(
                    apiKey,
                    CompanyLookup.Domain,
                    domain
            );

            // Write the JSON as output.
            Console.WriteLine(companyData.JSON);
        }

		/// <summary>
		/// Tests the ability to search for person data by a name.
		/// </summary>
		/// <param name="apiKey">API key.</param>
		/// <param name="name">Name.</param>
		[TestCase(TestValues.ApiKey, TestValues.Company.Name)]
        public void SearchCompany_ByName(string apiKey, string name)
		{
			// Use the service to perform a search.
            var companyData = Service.Search(
					apiKey,
					CompanyLookup.Name,
					name
			);

			// Write the JSON as output.
			Console.WriteLine(companyData.JSON);
		}
    }
}
