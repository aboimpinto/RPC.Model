using Olimpo.RPC.Model;

namespace RPC.Model;

public class HandshakeSuccessfulResponse : CommandBase
{
    public HandshakeSuccessfulResponse()
    {
        this.Command = Commands.HandshakeSuccessfulResponse;
    }
}
