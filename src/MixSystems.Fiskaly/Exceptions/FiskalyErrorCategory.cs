#nullable enable

namespace MixSystems.Fiskaly.Exceptions;

public enum FiskalyErrorCategory
{
    Permanent,

    Transient,

    Infrastructure,

    Authentication
}
