using Newtonsoft.Json;

var json = JsonConvert.SerializeObject(new double[1, 2]);

Console.WriteLine("Hello, World!");
Console.WriteLine(json);