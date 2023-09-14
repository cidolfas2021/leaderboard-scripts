using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HeathenEngineering.SteamworksIntegration;

namespace GameZero
{
    public interface ILeaderboardEntryDisplay
    {
        LeaderboardEntry Entry { get; set; }
    }
}