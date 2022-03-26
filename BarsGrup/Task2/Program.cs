using Task2;

//string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\test.txt";
//var loggerString = new LocalFileLogger<string>(path);
//loggerString.LogInfo("hello");
//loggerString.LogWarning("3.2.1.boom...");
//loggerString.LogError("Luk,I your father",new Exception("NO NO NO NO..."));
//var loggerTask = new LocalFileLogger<Task>(path);
//loggerTask.LogInfo("Working");
//loggerTask.LogWarning("this maneuver will cost us 16 years");
//loggerTask.LogError("...", new TaskCanceledException("ohhh"));
//var loggerInt = new LocalFileLogger<int>(path);
//loggerInt.LogInfo("0/2");
//loggerInt.LogWarning("1/1");
//loggerInt.LogError("2/0", new DivideByZeroException("this is the end"));
var a = new List<Entity>() {
 new Entity { Id = 1, ParentId = 0, Name = "Root entity"},

new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity"},

new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity"},

new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity"},

 new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity"}
};
 var b =Entity.GetDictionary(a);
foreach (var item in b)
{
    foreach (var element in item.Value)
    {
        Console.WriteLine($"{item.Key} {element.Id}");
    }
}