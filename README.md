# FullContactSharp
Full Contact C# API Wrapper - Used to query, wrap and cast data from FullContact.com

```csharp
// Person Data:
// Use the service to perform a search by person email.
var personData = Service.Search(
        apiKey,
        PersonLookup.Email,
        "person@domain.com"
);
```

```csharp
// Company Data:
// Use the service to perform a search by company domain.
var companyData = Service.Search(
        apiKey,
        CompanyLookup.Domain,
        "domain.com"
);
```
