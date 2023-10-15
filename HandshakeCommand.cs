using RPC.Model;

namespace Olimpo.RPC.Model;

public class HandshakeCommand : CommandBase
{
    public HandshakeCommandParameters InputParameters { get; set; }

    public HandshakeCommand()
    {
        this.Command = Commands.HandshakeCommand;
        this.InputParameters = new HandshakeCommandParameters();
    }
}
