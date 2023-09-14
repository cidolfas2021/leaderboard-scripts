using System;

// ===================================================================================
// Leaderboard Player
// ===================================================================================
[Serializable]
public partial struct LeaderboardPlayer
{
    public string name;
    public int rank;
    public int level;
    public long gold;
    public long lifetimePlayerKills;
    public long thismatchPlayerKills;
    public long GoonKills;
    public long BossKills;
    public long lifetimedeaths;
    public long thismatchdeaths;

    // -------------------------------------------------------------------------------
    // Extended_Quest (Constructor)
    // -------------------------------------------------------------------------------
    public LeaderboardPlayer(string _name, int _level, long _gold, long _lifetimePlayerKills, long _thismatchPlayerKills, long _GoonKills, long _BossKills, long _lifetimedeaths, long _thismatchdeaths)
    {
        name = _name;
        level = _level;
        gold = _gold;
        rank = 0;
        lifetimePlayerKills = _lifetimePlayerKills;
        thismatchPlayerKills = _thismatchPlayerKills;
        GoonKills = _GoonKills;
        BossKills = _BossKills;
        lifetimedeaths = _lifetimedeaths;
        thismatchdeaths = _thismatchdeaths;
        rank = calculateRank();
    }

    // -------------------------------------------------------------------------------
    //
    // -------------------------------------------------------------------------------
    public int calculateRank()
    {
        return 0;
    }

    // -------------------------------------------------------------------------------
}

//public class SyncList_LeaderboardPlayer : SyncList<LeaderboardPlayer> { }
