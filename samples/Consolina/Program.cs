using Newtonsoft.Json;

Fruit fruit = new()
{
    Name = "Apple",
    Color = "Red",
    Weight = 0.25M,
    IsRipe = true
};

string json = JsonConvert.SerializeObject(fruit, Formatting.Indented);
Console.WriteLine(json);


