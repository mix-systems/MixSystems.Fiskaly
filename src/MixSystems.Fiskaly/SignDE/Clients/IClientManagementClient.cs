using MixSystems.Fiskaly.SignDE.Clients.Models;
using MixSystems.Fiskaly.SignDE.Clients.Requests;
using MixSystems.Fiskaly.SignDE.Clients.Responses;
using MixSystems.Fiskaly.SignDE.Clients.ValueObjects;
using MixSystems.Fiskaly.SignDE.Common;
using MixSystems.Fiskaly.SignDE.Tss.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Clients;

/// <summary>
/// Wraps SIGN DE client endpoints (/api/v2/tss/{tss_id}/client*).
/// </summary>
public interface IClientManagementClient
{
    /// <summary>
    /// Calls PUT /api/v2/tss/{tss_id}/client/{client_id} to register a client.
    /// </summary>
    Task<ClientResponse> CreateClientAsync(
        TssId tssId,
        ClientId clientId,
        CreateClientRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Calls PATCH /api/v2/tss/{tss_id}/client/{client_id} to update state/metadata.
    /// </summary>
    Task<ClientResponse> UpdateClientAsync(
        TssId tssId,
        ClientId clientId,
        UpdateClientRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Calls GET /api/v2/tss/{tss_id}/client/{client_id}.
    /// </summary>
    Task<ClientResponse> GetClientAsync(
        TssId tssId,
        ClientId clientId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Calls GET /api/v2/tss/{tss_id}/client with optional filters.
    /// </summary>
    Task<ClientListResponse> ListClientsAsync(
        TssId tssId,
        ListClientsQueryParameters? queryParameters = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Auto-paginates GET /api/v2/tss/{tss_id}/client to return all clients.
    /// </summary>
    Task<ClientListResponse> ListAllClientsAsync(
        ListClientsQueryParameters? queryParameters = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Calls GET /api/v2/tss/{tss_id}/client/{client_id}/metadata.
    /// </summary>
    Task<MetadataCollection> GetClientMetadataAsync(
        TssId tssId,
        ClientId clientId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Calls PATCH /api/v2/tss/{tss_id}/client/{client_id}/metadata.
    /// </summary>
    Task<MetadataCollection> UpdateClientMetadataAsync(
        TssId tssId,
        ClientId clientId,
        MetadataCollection metadata,
        CancellationToken cancellationToken = default);
}
