// See https://aka.ms/new-console-template for more information
using System.Text.Json;
var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://cat-fact.herokuapp.com/facts/");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
string jsonText = await response.Content.ReadAsStringAsync();
//Console.WriteLine(await response.Content.ReadAsStringAsync());
var catFacts = JsonSerializer.Deserialize<List<Class1>>(jsonText);

foreach (var item in catFacts)
{
    Console.WriteLine(item.text + " " +  item.createdAt);
}

Console.ReadLine();

// not required
public class Rootobject 
{
    public List<Class1>? CatfactsList { get; set; }
}

public class Class1
{
    public Status status { get; set; }
    public string _id { get; set; }
    public string user { get; set; }
    public string text { get; set; }
    public int __v { get; set; }
    public string source { get; set; }
    public DateTime updatedAt { get; set; }
    public string type { get; set; }
    public DateTime createdAt { get; set; }
    public bool deleted { get; set; }
    public bool used { get; set; }
}

public class Status
{
    public bool verified { get; set; }
    public int sentCount { get; set; }
}


