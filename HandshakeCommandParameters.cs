namespace Olimpo.RPC.Model;

public class HandshakeCommandParameters
{
    public NodeType NodeType { get; set; }

    public string NodeId { get; set; } = string.Empty;

    public string NodeResposablieAddress { get; set; } = string.Empty;
}