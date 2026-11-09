using System.Runtime.CompilerServices;
using MixSystems.Fiskaly.ValueObjects;

namespace MixSystems.Fiskaly.Guards;

public static class ThrowIf
{
    public static void Default<T>(T value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
        where T : struct, IUuidIdentifier<T>
    {
        if (value.Equals(default(T)))
        {
            throw new ArgumentException("Identifier cannot be empty.", paramName);
        }
    }
}
