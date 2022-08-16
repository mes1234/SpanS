// See https://aka.ms/new-console-template for more information
using SpanS;
using System.Text.Json;

Console.WriteLine("Hello, World!");


var data = await MeteoClient.GetMeteo();

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var parsedData = JsonSerializer.Deserialize<MeteoDataDto>(data, options);

Console.WriteLine(parsedData!.ToString());