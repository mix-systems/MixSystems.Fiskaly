using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.SignDE.Tss.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SupportedUpdateVariants
{
    [JsonStringEnumMemberName("SIGNED")]
    Signed
}
