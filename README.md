# Authorization Server: OpenIddict
Authorization Server implemented with [OpenIddict 3](https://github.com/openiddict/openiddict-core).

## Prerequisites
- [.NET 5](https://dotnet.microsoft.com/)

## Getting started
Open up a terminal in the root folder

    dotnet run --project AuthorizationServer

Visit [https://localhost:5001](https://localhost:5001). In case of certificate errors run the following command:

    dotnet dev-certs https --trust