using System.Text.Json;
using Olimpo.RPC.Model;

namespace RPC.Model;

public static class CommandBaseExtensions
{
    public static string ToJson(this CommandBase command)
    {
        // TODO [AboimPinto]: Need to find a way to inject the all strategies of deserialization into the CommandBaseConverter.

        var options = new JsonSerializerOptions
        {
            Converters = { new CommandBaseConverter() }
        };

        var commandInJson = JsonSerializer.Serialize(command, options);
        return commandInJson;
    }
}
