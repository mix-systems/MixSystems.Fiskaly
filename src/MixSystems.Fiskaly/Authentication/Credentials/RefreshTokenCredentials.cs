using MixSystems.Fiskaly.Authentication.Models;
using MixSystems.Fiskaly.Authentication.ValueObjects;

namespace MixSystems.Fiskaly.Authentication.Credentials;

public sealed class RefreshTokenCredentials : IFiskalyCredentials
{
    public RefreshTokenCredentials(RefreshToken refreshToken)
    {
        RefreshToken = refreshToken;
    }

    public RefreshToken RefreshToken { get; }

    public AuthenticationPayload CreatePayload() => new RefreshTokenAuthenticationPayload(RefreshToken);
}
