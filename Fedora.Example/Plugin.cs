﻿using Sapiox.API;
using Sapiox.Events.EventArgs;
using PlayerEvent = Sapiox.Events.Handlers.Player;

namespace Sapiox.Example
{
    [PluginInfo(
        Author = "Naku",
        Name = "Sapiox.Example",
        Description = "Example plugin",
        Version = "1.0.0"
        )]
    public class Plugin : Sapiox.API.Plugin
    {
        public override void Load()
        {
            base.Load();
            PlayerEvent.Join += OnPlayerJoin;
            PlayerEvent.Leave += OnPlayerLeave;
        }
        public void OnPlayerLeave(PlayerLeaveEventArgs ev)
        {
            Log.Info($"Player {ev.Player.NickName} has left the server!");
        }
        public void OnPlayerJoin(PlayerJoinEventArgs ev)
        {
            Log.Info($"Player {ev.NickName} has joined the server!" + config);
        }
    }
}