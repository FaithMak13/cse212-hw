static string[] EarthquakeDailySummary(string json)
{
    FeatureCollection data =
        JsonSerializer.Deserialize<FeatureCollection>(json);

    List<string> result = new List<string>();

    foreach (var feature in data.features)
    {
        string place = feature.properties.place;
        double mag = feature.properties.mag;

        result.Add($"{place} - Mag {mag}");
    }

    return result.ToArray();
}