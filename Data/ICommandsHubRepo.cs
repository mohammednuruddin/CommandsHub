using System.Collections.Generic;
using CommandsHub.Models;

namespace CommandsHub.Data {
    public interface ICommandsHubRepo {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandbyId(int id);
    }
}