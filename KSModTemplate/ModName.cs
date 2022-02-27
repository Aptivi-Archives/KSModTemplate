
// The KS.Modifications import is necessary for mod routine to work. You can specify IScript explicitly, but it may reduce the readability of your
// mod code.

using KS.Modifications;
using KS.Shell.ShellBase;
using System.Collections.Generic;

namespace KSModTemplate
{
    // Change the ModName class to your mod name
    public class ModName : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public void InitEvents(string ev)
        {
            // Here you can respond to any kernel event fired.
            // 
            // Compare the ev field with one of the kernel event names using the Switch..Case statement like this:
            //
            // switch (ev)
            // {
            //     case "KernelEvent":
            //         break;
            //     default:
            //         break;
            // }
        }

        public void InitEvents(string ev, params object[] Args)
        {
            // Here you can respond to any kernel event fired. This overload comes with arguments.
            // 
            // Compare the ev field with one of the kernel event names using the Switch..Case statement like this:
            //
            // switch (ev)
            // {
            //     case "KernelEvent":
            //         break;
            //     default:
            //         break;
            // }
        }

        public void PerformCmd(CommandInfo Command, string Args = "")
        {
            // Here you can write statements about what happens when a mod command is executed. Arguments is a string literal, so you might have
            // to split them yourself.
            //
            // Compare the CommandInfo.Command property with one of your mod commands using the Switch..Case statement like this:
            //
            // switch (Command.Command)
            // {
            //     case "command":
            //         break;
            //     default:
            //         break;
            // }
        }

        public void StartMod()
        {
            // Statements written here will be executed when the mod starts up. They start up either by starting up the kernel or manually starting
            // it using the "modman" command.
            //
            // Put your initialization statements here. You can initialize your commands here. For example,
            //
            // Name = "ModName";
            // ModPart = "Main";
            // Version = "1.0.0";
            // Commands = new Dictionary<string, CommandInfo> { { "command", new CommandInfo("command", ShellType.Shell, "Define the command here", new[] { "<RequiredArgument> [OptionalArgument]" }, true, 1, null) },
            //                                                  { "command2", new CommandInfo("command2", ShellType.Shell, "Define the second command here", new[] { "<RequiredArgument> [OptionalArgument]" }, true, 1, null) }, };
            //
            // Leave CommandBase null for now; it'll be changed later in upcoming releases.
        }

        public void StopMod()
        {
            // Statements written here will be executed when the mod stops. Usually, the mod stops either by shutting down the kernel, restarting
            // the kernel, reloading the mod, or stopping the mod.
            //
            // Put your decommissioning statements here, or leave blank to do nothing as mod stops.
        }
    }
}

// Refer to https://eoflaoe.github.io/Kernel-Simulator for up-to-date API documentation for mod developers.
