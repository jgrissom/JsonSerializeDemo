using System.Text.Json;

Person person = new()
{
  Name = "Joe"
};

string JsonString = JsonSerializer.Serialize(person);
Console.WriteLine(JsonString);
