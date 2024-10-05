using System.Text.Json;

Person person = new()
{
  Name = "Joe",
  Age = 22,
  Hobbies = [
    "Fishing", "Camping"
  ]
};

string JsonString = JsonSerializer.Serialize(person);
Console.WriteLine(JsonString);
