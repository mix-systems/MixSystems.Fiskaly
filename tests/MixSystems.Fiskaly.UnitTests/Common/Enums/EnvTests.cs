using System.Text.Json;
using AwesomeAssertions;
using MixSystems.Fiskaly.Common.Enums;

namespace MixSystems.Fiskaly.UnitTests.Common.Enums;

public class EnvTests
{
    [Trait("Category", "Unit")]
    [Fact]
    public void Serialize_Test_WritesApiValue()
    {
        string json = JsonSerializer.Serialize(Env.Test);

        json.Should().Be("\"TEST\"");
    }

    [Trait("Category", "Unit")]
    [Fact]
    public void Deserialize_Live_ReadsApiValue()
    {
        Env value = JsonSerializer.Deserialize<Env>("\"LIVE\"");

        value.Should().Be(Env.Live);
    }
}
