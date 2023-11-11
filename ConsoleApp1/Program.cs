

using ConsoleApp1.models;

Acsses test1 = new("Nadir", "Shirinbayli", 13);
Console.WriteLine(test1.Name);
//Console.WriteLine(test1.Surname);
Console.WriteLine(test1.Position);
Console.WriteLine(test1.Age);
test1.Age = 16;
Console.WriteLine(test1.Age);
Console.WriteLine();

Prodact prodact1 = new ("GALAXY","TELEFON",11,2);
prodact1.Price = 16;
Console.WriteLine(prodact1.Price); 