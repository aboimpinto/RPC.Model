namespace Olimpo.RPC.Model;

public interface ICommandProcessor
{
    bool CanHandle(CommandBase command);

     Task Handle(CommandBase commandBase, string channelId);
}