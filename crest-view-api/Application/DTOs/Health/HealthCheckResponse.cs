namespace crest_view_api.Application.DTOs.Health;

public class HealthCheckResponse
{
    public string Status { get; set; } = string.Empty;
    public TimeSpan TotalDuration { get; set; }
    public List<HealthCheckEntry> Checks { get; set; } = new();
}

public class HealthCheckEntry
{
    public string Name { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string? Description { get; set; }
    public TimeSpan Duration { get; set; }
}
