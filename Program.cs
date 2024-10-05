using System.Text.Json;

Person person = new()
{
  Name = "Joe",
  Age = 22
};

string JsonString = JsonSerializer.Serialize(person);
Console.WriteLine(JsonString);
