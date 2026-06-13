using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("earthquakes.json");
        string[] dailySummaries = EarthquakeDailySummary(json);

        foreach (string summary in dailySummaries)
        {
            Console.WriteLine(summary);
        }
    }
}
