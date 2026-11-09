using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using MixSystems.Fiskaly.Common;
using MixSystems.Fiskaly.Common.Enums;
using MixSystems.Fiskaly.SignDE.Clients.ValueObjects;
using MixSystems.Fiskaly.SignDE.Common;
using MixSystems.Fiskaly.SignDE.Exports.Enums;
using MixSystems.Fiskaly.SignDE.Exports.ValueObjects;
using MixSystems.Fiskaly.SignDE.Tss.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Exports.Models;

public class ExportJob
{
    [JsonPropertyName("_id")]
    public ExportId Id { get; init; }
    [JsonPropertyName("tss_id")]
    public TssId TssId { get; init; }
    [JsonPropertyName("state")]
    public ExportState State { get; init; }
    [JsonPropertyName("time_start")]
    public DateTimeOffset? TimeStart { get; init; }
    [JsonPropertyName("time_end")]
    public DateTimeOffset? TimeEnd { get; init; }
    [JsonPropertyName("time_request")]
    public DateTimeOffset? TimeRequest { get; init; }
    [JsonPropertyName("time_error")]
    public DateTimeOffset? TimeError { get; init; }
    [JsonPropertyName("time_expiration")]
    public DateTimeOffset? TimeExpiration { get; init; }
    [JsonPropertyName("estimated_time_of_completion")]
    public DateTimeOffset? EstimatedTimeOfCompletion { get; init; }
    [JsonPropertyName("exception")]
    public ExportExceptionCode? ExceptionCode { get; init; }
    [JsonPropertyName("metadata")]
    public MetadataCollection? Metadata { get; init; }
    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; init; }
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; init; }
    [JsonPropertyName("client_id")]
    public ClientId? ClientId { get; init; }
    [JsonPropertyName("_env")]
    public required Env Env { get; init; }
    [JsonPropertyName("_type")]
    public required ResourceType Type { get; init; }
    [JsonPropertyName("_version")]
    public string Version { get; init; } = null!;

    [OnDeserialized]
    internal void ValidateRequiredFields(StreamingContext _)
    {
        Guard.Json.NotNullOrWhiteSpace(Version, nameof(Version));
        Guard.Json.NotNull(TimeRequest, nameof(TimeRequest));
    }
}
