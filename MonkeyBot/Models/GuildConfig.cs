﻿using System;
using System.Collections.Generic;

namespace MonkeyBot.Models
{
    public class GuildConfig
    {
        public static readonly string DefaultPrefix = "!";

        public int ID { get; set; }

        public ulong GuildID { get; set; }

        public string CommandPrefix { get; set; } = DefaultPrefix;

        public ulong DefaultChannelId { get; set; }

        public string? WelcomeMessageText { get; set; }

        public ulong WelcomeMessageChannelId { get; set; }

        public string? GoodbyeMessageText { get; set; }

        public ulong GoodbyeMessageChannelId { get; set; }

        public List<string> Rules { get; set; } = new List<string>();

        public bool BattlefieldUpdatesEnabled { get; set; }

        public ulong BattlefieldUpdatesChannel { get; set; }

        public DateTime? LastBattlefieldUpdate { get; set; }

        public bool StreamAnnouncementsEnabled { get; set; }

        public List<ulong> ConfirmedStreamerIds { get; set; } = new List<ulong>();
    }
}