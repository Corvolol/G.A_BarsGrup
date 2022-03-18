using Task1;

Class1 test = new();
test.OnKeyPressed += (sender, buttonKey) => Console.WriteLine($"\nвы нажали {buttonKey}");
test.Run();