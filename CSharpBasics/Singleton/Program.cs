using Singleton;

var instance = OS.GetInstance("Windows");

var computer = new Computer();
computer.Launch("Linex");
var os = computer.OS;
Console.WriteLine(os);
