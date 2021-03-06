﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryCore.Dtos
{
    public class PlayerInfo
    {
        public string Name { get; set; }
        public int ClientId { get; set; }
        public string Level { get; set; }
        public int LevelInt { get; set; }
        public string IPAddress { get; set; }
        public long NetworkId { get; set; }
        public List<string> Aliases { get; set; }
        public List<string> IPs { get; set; }
        public bool HasActivePenalty { get; set; }
        public string ActivePenaltyType { get; set; }
        public bool Authenticated { get; set; }
        public List<ProfileMeta> Meta { get; set; }
        public bool Online { get; set; }
        public string TimeOnline { get; set; }
        public DateTime LastConnection { get; set; }
        public string LastConnectionText => Utilities.GetTimePassed(LastConnection, true);
        public IDictionary<int, long> LinkedAccounts { get; set; }
    }
}
