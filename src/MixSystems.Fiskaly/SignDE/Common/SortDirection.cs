using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.SignDE.Common;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SortDirection
{
    [JsonStringEnumMemberName("asc")]
    Ascending,
    [JsonStringEnumMemberName("desc")]
    Descending
}
