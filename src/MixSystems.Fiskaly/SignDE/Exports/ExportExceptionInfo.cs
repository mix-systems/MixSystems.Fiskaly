using MixSystems.Fiskaly.Exceptions;

namespace MixSystems.Fiskaly.SignDE.Exports;

public record ExportExceptionInfo(
    FiskalyErrorCategory Category,
    bool IsRetryable,
    string RecoveryHint);
