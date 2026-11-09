using System.Net;
using AwesomeAssertions;
using MixSystems.Fiskaly.Authentication.ValueObjects;
using MixSystems.Fiskaly.Exceptions;
using MixSystems.Fiskaly.IntegrationTests.Base;
using MixSystems.Fiskaly.Management.Common.Enums;
using MixSystems.Fiskaly.Management.Organizations.Models;
using MixSystems.Fiskaly.Management.Organizations.Requests;
using MixSystems.Fiskaly.Management.Organizations.Responses;
using MixSystems.Fiskaly.SignDE.Common;
using Xunit.Abstractions;

namespace MixSystems.Fiskaly.IntegrationTests.Management;

internal static class ManagementApiTestHelpers
{
    public static async Task<OrganizationId> GetManagingOrganizationIdAsync(
        FiskalyClientFixture fixture,
        ITestOutputHelper output)
    {
        ListOrganizationsResponse rootOrganizations = await fixture.OrganizationClient.ListOrganizationsAsync(new ListOrganizationsQueryParameters
        {
            Type = OrganizationType.Organization,
            Limit = 50
        });

        OrganizationResponse? organization = rootOrganizations.Data?
            .FirstOrDefault(candidate => candidate.Id is not null)
            ?? (await fixture.OrganizationClient.ListOrganizationsAsync()).Data?
                .FirstOrDefault(candidate => candidate.Id is not null);

        organization.Should().NotBeNull("Management tests require at least one accessible managing organization");
        organization!.Id.Should().NotBeNull("Managing organization must have an identifier");

        output.WriteLine($"Using managing organization: {organization.Name} ({organization.Id})");
        return organization.Id!.Value;
    }

    public static async Task<OrganizationResponse> CreateManagedOrganizationAsync(
        FiskalyClientFixture fixture,
        OrganizationId managingOrganizationId,
        string suffix,
        ITestOutputHelper output)
    {
        CreateOrganizationRequest request = new()
        {
            Name = $"sdk-mgmt-{suffix}",
            DisplayName = $"SDK Mgmt {suffix}",
            AddressLine1 = "Sdk Test Address 1",
            AddressLine2 = "Suite 1",
            Zip = "10437",
            Town = "Berlin",
            State = "Berlin",
            CountryCode = CountryCode.DEU,
            Metadata = MetadataCollection.Empty
                .Add("suite", "sdk-management")
                .Add("suffix", suffix),
            ManagedByOrganizationId = managingOrganizationId
        };

        OrganizationResponse response = await fixture.OrganizationClient.CreateOrganizationAsync(request);
        response.Id.Should().NotBeNull("Created managed organization must have an identifier");

        output.WriteLine($"Created managed organization: {response.Name} ({response.Id})");
        return response;
    }

    public static async Task TryDeleteOrganizationAsync(
        FiskalyClientFixture fixture,
        OrganizationId? organizationId,
        ITestOutputHelper output)
    {
        if (organizationId is null)
        {
            return;
        }

        try
        {
            await fixture.OrganizationClient.DeleteOrganizationAsync(organizationId.Value);
            output.WriteLine($"Deleted managed organization: {organizationId}");
        }
        catch (FiskalyApiException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            output.WriteLine($"Managed organization already deleted: {organizationId}");
        }
    }
}
