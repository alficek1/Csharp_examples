using S1.Api;

Console.WriteLine("Hello, World!");

IMessageProvider provider = new DateTimeInfoProvider();

string message = provider.GetMessage();

Console.WriteLine(message);

Console.WriteLine("Stastne cislo je:" + provider.GetLuckyNumber());