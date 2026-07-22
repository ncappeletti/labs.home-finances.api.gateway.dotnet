namespace Api.Configuration;

public class CorsOptions
{
    public const string SectionName = "Cors";

    /// <summary>
    /// Comma-separated list of allowed origins.
    /// Env: Cors__AllowedOrigins=https://app.example.com,http://localhost:3000
    /// </summary>
    public string AllowedOrigins { get; set; } = string.Empty;

    /// <summary>
    /// When true, allows credentials (cookies / auth headers) on CORS requests.
    /// Env: Cors__AllowCredentials=true
    /// </summary>
    public bool AllowCredentials { get; set; }

    public string[] GetAllowedOrigins() =>
        AllowedOrigins.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
}
