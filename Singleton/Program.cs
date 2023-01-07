
//var log = new Logger();

using Singleton;

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

//instance1.UserName = "Mohamed";
//instance1.Password = "123654";

//instance2.UserName = "Omar";
//instance2.Password = "123";

//Console.WriteLine($"instance1.UserName: {instance1.UserName}\n instance1.Password: {instance1.Password}" +
//    $"instance2.UserName: {instance2.UserName}\n instance2.Password: {instance2.Password} ");

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("The Instance are the same");
}

instance1.Log($"Message from {nameof(instance1)}");
instance2.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");