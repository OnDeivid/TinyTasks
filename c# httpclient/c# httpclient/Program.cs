using c__httpclient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RickAndMortyClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string url = "https://rickandmortyapi.com/api/character";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString);

                var characterListResponse = JsonSerializer.Deserialize<CharacterListResponse>(jsonString, new JsonSerializerOptions
                {
                    //game changer !!!
                    PropertyNameCaseInsensitive = true
                });

                if (characterListResponse?.Results != null)
                {
                    foreach (var character in characterListResponse.Results)
                    {
                        Console.WriteLine($"Name: {character.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("No characters");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"error: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
