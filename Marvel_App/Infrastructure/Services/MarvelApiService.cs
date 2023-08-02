
using System.Net.Http;

namespace Marvel_App.Infrastructure.Services
{
    public class MarvelApiService
    {
        string _marvelApiBaseUrl;
        string _hashParam;
        string _apiKeyParam;
        string _timestampParam;
        string _queryParameters;
        string _apiEndpoint;
        HttpClient _client;

        public MarvelApiService(string marvelApiBaseUrl, string hashParam, string apiKeyParam, string timestampParam, string queryParameters, string apiEndpoint, HttpClient client)
        {
            _marvelApiBaseUrl = "https://gateway.marvel.com/v1/public/";
            _hashParam = hashParam;
            _apiKeyParam = apiKeyParam;
            _timestampParam = timestampParam;
            _queryParameters = queryParameters;
            _apiEndpoint = apiEndpoint;
        }

    }

}

