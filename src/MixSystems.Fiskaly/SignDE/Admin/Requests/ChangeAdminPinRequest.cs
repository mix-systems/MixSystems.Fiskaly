using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Admin.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Admin.Requests;

public class ChangeAdminPinRequest
{
    [JsonPropertyName("admin_puk")]
    public required AdminPuk AdminPuk { get; init; }
    [JsonPropertyName("new_admin_pin")]
    public required AdminPin NewAdminPin { get; init; }
}
