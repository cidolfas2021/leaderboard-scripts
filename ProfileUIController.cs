using HeathenEngineering.SteamworksIntegration;
using HeathenEngineering.SteamworksIntegration.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameZero
{
    public class ProfileUIController : MonoBehaviour
    {
        public TMPro.TextMeshProUGUI lifetimePlayerKills;
        public TMPro.TextMeshProUGUI GoonKills;

        public LeaderboardObject LifeKillsBoard;
        public LeaderboardObject GoonKillsBoard;
        public LeaderboardObject BossKillsBoard;
        public LeaderboardObject LifeDeathsBoard;

        public void Refresh()
        {
            LifeKillsBoard.GetUserEntry(0, UpdateLifeKillsEntry);

            GoonKillsBoard.GetUserEntry(0, UpdateGoonKillsEntry);

            //Etc.
        }

        private void UpdateLifeKillsEntry(LeaderboardEntry entry, bool IOError)
        {
            lifetimePlayerKills.text = entry.Score.ToString();
        }

        private void UpdateGoonKillsEntry(LeaderboardEntry entry, bool IOError)
        {
            GoonKills.text = entry.Score.ToString();
        }
    }
}