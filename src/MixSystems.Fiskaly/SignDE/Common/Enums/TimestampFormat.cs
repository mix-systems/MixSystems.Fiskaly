using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TimestampFormat
{
    [JsonStringEnumMemberName("unixTime")]
    UnixTime
}
