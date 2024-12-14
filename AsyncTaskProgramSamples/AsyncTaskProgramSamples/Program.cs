// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using (HttpClient client = new HttpClient())
{
    string url = "https://jsonplaceholder.typicode.com/posts/1";
    try
    {
        //If you need the raw JSON response, GetStringAsync is quick and straightforward
        string response = await client.GetStringAsync(url);
        Console.WriteLine("Response from GetStringAsync:{0}", response);
        //If you need the full HTTP response meta data including headers, status code then GetAsync is useful.
        HttpResponseMessage httpResponse = await client.GetAsync(url);
        Console.WriteLine("Response from GetAsync:{0}", httpResponse);
        string content = await httpResponse.Content.ReadAsStringAsync();
    
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Request error: {ex.Message}");
    }
}