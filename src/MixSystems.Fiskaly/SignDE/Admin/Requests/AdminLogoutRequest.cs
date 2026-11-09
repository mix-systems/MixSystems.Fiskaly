using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.SignDE.Admin.Requests;

public sealed class AdminLogoutRequest
{
    [JsonIgnore]
    public static AdminLogoutRequest Empty { get; } = new();
}
