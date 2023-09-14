using System.Linq;
using UnityEngine;
using GameZero;
namespace HeathenEngineering.SteamworksIntegration
{
    // ===================================================================================
    // Leaderboard
    // ===================================================================================
    public class Leaderboard : MonoBehaviour
{
    [SerializeField] private KeyCode hotkey = KeyCode.L;
    //[SerializeField] private Transform trnGrid = null;
    //[SerializeField] private GameObject gobEntry = null;
    [SerializeField] private GameObject gobLeaderboardPanel = null;

    private float updateRate = 1f, updateNext = 0f;
    private Player player;

    private int sortCategory;           // 0 = rank / 1 = level / 2 = gold
    private int sortMode;               // 0 = up / 1 = down

    // -----------------------------------------------------------------------------------
    //
    // -----------------------------------------------------------------------------------
    private void Update()
    {
        if (player == null) player = Player.localPlayer;
        if (player == null) return;

        if (Input.GetKeyDown(hotkey) && !UIUtils.AnyInputActive())
            gobLeaderboardPanel.SetActive(!gobLeaderboardPanel.activeSelf);

        /*if (Time.time > updateNext && gobLeaderboardPanel.activeSelf)
        {
            player.playerLeaderboard.Cmd_AllPlayersOnline();
            updateNext = Time.time + updateRate;
        }

        if (gobLeaderboardPanel.activeSelf)
        {
            if (player.playerLeaderboard.currentOnlinePlayers.Count <= 0) return;

            player.playerLeaderboard.currentOnlinePlayers.OrderBy(x => x.level);

            // Destroy all entries before adding new entries, otherwise endless building list.
            foreach (Transform child in trnGrid)
                Destroy(child.gameObject);
            
            // Add each player to our leaderboard and set their information.

            for (int i = 1; i <= player.playerLeaderboard.currentOnlinePlayers.Count; i++)
            {
                GameObject entry = Instantiate(gobEntry, trnGrid);
                entry.name = "Entry: Place " + i;
                    LeaderboardEntryUIRecord lEntry = entry.GetComponent<LeaderboardEntryUIRecord>();

                //lEntry.txtRank.text = i.ToString();
                //lEntry.txtName.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].name;
                //lEntry.txtLevel.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].level.ToString();
                //lEntry.txtGold.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].gold.ToString();
                /*
				lEntry.txtStatistcOne.text = rankPlayers[i - 1].strength.ToString();
				lEntry.txtStatisticTwo.text = rankPlayers[i - 1].intelligence.ToString();
				lEntry.txtStatisticThree.text = rankPlayers[i - 1].defense.ToString();
				
             lEntry.txtlifetimePlayerKills.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].lifetimePlayerKills.ToString();
                    lEntry.txtthismatchPlayerKills.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].lifetimePlayerKills.ToString();
                    lEntry.txtGoonKills.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].GoonKills.ToString();
             lEntry.txtBossKills.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].BossKills.ToString();
             lEntry.txtlifetimedeaths.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].lifetimedeaths.ToString();
                    lEntry.txtthismatchdeaths.text = player.playerLeaderboard.currentOnlinePlayers[i - 1].lifetimedeaths.ToString();
                }
        

    }*/
    }
}
}
// -----------------------------------------------------------------------------------


// ===================================================================================
