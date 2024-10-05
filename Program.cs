using System.Text.Json;

Person person = new()
{
  Name = "Joe",
  Age = 22,
  Hobbies = [
    "Fishing", "Camping"
  ]
};

Person anotherPerson = new()
{
  Name = "Lisa",
  Age = 37,
  Hobbies = [
    "Biking"
  ]
};

List<Person> people = [
  person,
  anotherPerson
];

string JsonString = JsonSerializer.Serialize(people);
Console.WriteLine(JsonString);
