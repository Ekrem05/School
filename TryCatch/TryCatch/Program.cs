
try
{
Console.WriteLine("Enter hours:");
double hours = double.Parse(Console.ReadLine());
Console.WriteLine("Enter minutes:");
double minutes = double.Parse(Console.ReadLine());
Console.WriteLine("Enter secs:");
double sec = double.Parse(Console.ReadLine());
Console.WriteLine("Enter kms:");
double km = double.Parse(Console.ReadLine());
    double convertedSeconds = CalculateSeconds(hours, minutes, sec);
    double miles = ConvertToMiles(km);
    double speed = miles / convertedSeconds;
    Console.WriteLine($"Result: {speed:f5}miles/s");
}
catch (Exception e)
{
    Console.WriteLine($"Exception type: {e.GetType().Name}");
    Console.WriteLine($"Exception description: {e.Message}");
    Console.WriteLine($"Exception source: {e.Source}");
    Console.WriteLine($"Exception site: {e.TargetSite.Name}");
    Console.WriteLine($"Exception place: {e.StackTrace}");
    
}
Console.WriteLine("END");


double CalculateSeconds(double hours,double minutes,double sec)
{
    double totalSeconds = 0;
    totalSeconds += minutes * 60;
    totalSeconds += hours * 3600;
    totalSeconds += sec;
    return totalSeconds;
}
double ConvertToMiles(double km)
{
    double miles = km/ 1.609;
    
    return miles;
}