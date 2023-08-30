using System.Collections.Generic;
using CommandsHub.Models;

namespace CommandsHub.Data {
    public class MockRepo : ICommandsHubRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Update system", Line="sudo update", Platform="Arch"},
                new Command{Id=1, HowTo="Copy file", Line="sudo copy", Platform="Debian"},
                new Command{Id=2, HowTo="Move file", Line="sudo move", Platform="Arch"}
            };
            return commands;
        }

        public Command GetCommandbyId(int id)
        {
            return new Command{Id=0, HowTo="Update system", Line="sudo update", Platform="Arch"};
        }
    }
}