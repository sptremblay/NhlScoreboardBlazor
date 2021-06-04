using System;
using System.Collections.Generic;

namespace NhlScoreboard.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class MetaData
    {
        public int wait { get; set; }
        public string timeStamp { get; set; }
    }

    public class Game
    {
        public int pk { get; set; }
        public string season { get; set; }
        public string type { get; set; }
        public int gamePk { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue venue { get; set; }
        public Content content { get; set; }
    }

    public class Datetime
    {
        public DateTime dateTime { get; set; }
        public DateTime endDateTime { get; set; }
    }

    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
    }

    public class TimeZone
    {
        public string id { get; set; }
        public int offset { get; set; }
        public string tz { get; set; }
    }

    public class Venue
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string city { get; set; }
        public TimeZone timeZone { get; set; }
    }

    public class Division
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Conference
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Franchise
    {
        public int franchiseId { get; set; }
        public string teamName { get; set; }
        public string link { get; set; }
    }


    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Venue venue { get; set; }
        public string abbreviation { get; set; }
        public string triCode { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public Division division { get; set; }
        public Conference conference { get; set; }
        public Franchise franchise { get; set; }
        public string shortName { get; set; }
        public string officialSiteUrl { get; set; }
        public int franchiseId { get; set; }
        public bool active { get; set; }
        public int goals { get; set; }
        public int shotsOnGoal { get; set; }
        public string rinkSide { get; set; }
        public int scores { get; set; }
        public int attempts { get; set; }
        public Team team { get; set; }
        public bool goaliePulled { get; set; }
        public int numSkaters { get; set; }
        public bool powerPlay { get; set; }
        public TeamStats teamStats { get; set; }
        //public Players players { get; set; }
        public List<int> goalies { get; set; }
        public List<int> skaters { get; set; }
        public List<int> onIce { get; set; }
        public List<OnIcePlu> onIcePlus { get; set; }
        public List<int> scratches { get; set; }
        public List<PenaltyBox> penaltyBox { get; set; }
        public List<Coach> coaches { get; set; }
        public LeagueRecord leagueRecord { get; set; }
    }

    public class Teams
    {
        public Team away { get; set; }
        public Team home { get; set; }
    }

    public class CurrentTeam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string triCode { get; set; }
    }

    public class PrimaryPosition
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class GameData
    {
        public Game game { get; set; }
        public Datetime datetime { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        //public Players players { get; set; }
        public Venue venue { get; set; }
    }

    public class Strength
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Result
    {
        public string @event { get; set; }
        public string eventCode { get; set; }
        public string eventTypeId { get; set; }
        public string description { get; set; }
        public string secondaryType { get; set; }
        public Strength strength { get; set; }
        public bool? gameWinningGoal { get; set; }
        public bool? emptyNet { get; set; }
        public string penaltySeverity { get; set; }
        public int? penaltyMinutes { get; set; }
    }

    public class Goals
    {
        public int away { get; set; }
        public int home { get; set; }
    }

    public class About
    {
        public int eventIdx { get; set; }
        public int eventId { get; set; }
        public int period { get; set; }
        public string periodType { get; set; }
        public string ordinalNum { get; set; }
        public string periodTime { get; set; }
        public string periodTimeRemaining { get; set; }
        public DateTime dateTime { get; set; }
        public Goals goals { get; set; }
    }

    public class Coordinates
    {
        public double? x { get; set; }
        public double? y { get; set; }
    }

    public class Player2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class AllPlay
    {
        public Result result { get; set; }
        public About about { get; set; }
        public Coordinates coordinates { get; set; }
        //public List<Player> players { get; set; }
        public Team team { get; set; }
    }

    public class PlaysByPeriod
    {
        public int startIndex { get; set; }
        public List<int> plays { get; set; }
        public int endIndex { get; set; }
    }

    public class CurrentPlay
    {
        public Result result { get; set; }
        public About about { get; set; }
        public Coordinates coordinates { get; set; }
    }

    public class Plays
    {
        public List<AllPlay> allPlays { get; set; }
        public List<int> scoringPlays { get; set; }
        public List<int> penaltyPlays { get; set; }
        public List<PlaysByPeriod> playsByPeriod { get; set; }
        public CurrentPlay currentPlay { get; set; }
    }

    public class Period
    {
        public string periodType { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int num { get; set; }
        public string ordinalNum { get; set; }
        public Team home { get; set; }
        public Team away { get; set; }
    }

    public class ShootoutInfo
    {
        public Team away { get; set; }
        public Team home { get; set; }
    }

    public class IntermissionInfo
    {
        public int intermissionTimeRemaining { get; set; }
        public int intermissionTimeElapsed { get; set; }
        public bool inIntermission { get; set; }
    }

    public class PowerPlayInfo
    {
        public int situationTimeRemaining { get; set; }
        public int situationTimeElapsed { get; set; }
        public bool inSituation { get; set; }
    }

    public class Linescore
    {
        public int currentPeriod { get; set; }
        public string currentPeriodOrdinal { get; set; }
        public string currentPeriodTimeRemaining { get; set; }
        public List<Period> periods { get; set; }
        public ShootoutInfo shootoutInfo { get; set; }
        public Teams teams { get; set; }
        public string powerPlayStrength { get; set; }
        public bool hasShootout { get; set; }
        public IntermissionInfo intermissionInfo { get; set; }
        public PowerPlayInfo powerPlayInfo { get; set; }
    }

    public class TeamSkaterStats
    {
        public int goals { get; set; }
        public int pim { get; set; }
        public int shots { get; set; }
        public string powerPlayPercentage { get; set; }
        public double powerPlayGoals { get; set; }
        public double powerPlayOpportunities { get; set; }
        public string faceOffWinPercentage { get; set; }
        public int blocked { get; set; }
        public int takeaways { get; set; }
        public int giveaways { get; set; }
        public int hits { get; set; }
    }

    public class TeamStats
    {
        public TeamSkaterStats teamSkaterStats { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
        public string shootsCatches { get; set; }
        public string rosterStatus { get; set; }
    }

    public class Position
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class Stats
    {
        public SkaterStats skaterStats { get; set; }
        public GoalieStats goalieStats { get; set; }
    }

    public class SkaterStats
    {
        public string timeOnIce { get; set; }
        public int assists { get; set; }
        public int goals { get; set; }
        public int shots { get; set; }
        public int hits { get; set; }
        public int powerPlayGoals { get; set; }
        public int powerPlayAssists { get; set; }
        public int penaltyMinutes { get; set; }
        public double faceOffPct { get; set; }
        public int faceOffWins { get; set; }
        public int faceoffTaken { get; set; }
        public int takeaways { get; set; }
        public int giveaways { get; set; }
        public int shortHandedGoals { get; set; }
        public int shortHandedAssists { get; set; }
        public int blocked { get; set; }
        public int plusMinus { get; set; }
        public string evenTimeOnIce { get; set; }
        public string powerPlayTimeOnIce { get; set; }
        public string shortHandedTimeOnIce { get; set; }
    }

    public class GoalieStats
    {
        public string timeOnIce { get; set; }
        public int assists { get; set; }
        public int goals { get; set; }
        public int pim { get; set; }
        public int shots { get; set; }
        public int saves { get; set; }
        public int powerPlaySaves { get; set; }
        public int shortHandedSaves { get; set; }
        public int evenSaves { get; set; }
        public int shortHandedShotsAgainst { get; set; }
        public int evenShotsAgainst { get; set; }
        public int powerPlayShotsAgainst { get; set; }
        public string decision { get; set; }
        public double savePercentage { get; set; }
        public double powerPlaySavePercentage { get; set; }
        public double shortHandedSavePercentage { get; set; }
        public double evenStrengthSavePercentage { get; set; }
    }

    public class OnIcePlu
    {
        public int playerId { get; set; }
        public int shiftDuration { get; set; }
        public int stamina { get; set; }
    }

    public class Coach
    {
        public Person person { get; set; }
        public Position position { get; set; }
    }

    public class PenaltyBox
    {
        public int id { get; set; }
        public string timeRemaining { get; set; }
        public bool active { get; set; }
    }

    public class Official2
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Official
    {
        public Official official { get; set; }
        public string officialType { get; set; }
    }

    public class Boxscore
    {
        public Teams teams { get; set; }
        public List<Official> officials { get; set; }
    }

    public class Winner
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Loser
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class FirstStar
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class SecondStar
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class ThirdStar
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Decisions
    {
        public Winner winner { get; set; }
        public Loser loser { get; set; }
        public FirstStar firstStar { get; set; }
        public SecondStar secondStar { get; set; }
        public ThirdStar thirdStar { get; set; }
    }

    public class LiveData
    {
        public Plays plays { get; set; }
        public Linescore linescore { get; set; }
        public Boxscore boxscore { get; set; }
        public Decisions decisions { get; set; }
    }

    public class GameFeedLiveResponse
    {
        public string copyright { get; set; }
        public int gamePk { get; set; }
        public string link { get; set; }
        public MetaData metaData { get; set; }
        public GameData gameData { get; set; }
        public LiveData liveData { get; set; }
    }


    public class LeagueRecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
    }

    
    public class Content
    {
        public string link { get; set; }
    }

    public class Date
    {
        public string date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<Game> games { get; set; }
        public List<object> events { get; set; }
        public List<object> matches { get; set; }
    }

    public class ScheduleResponse
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public MetaData metaData { get; set; }
        public int wait { get; set; }
        public List<Date> dates { get; set; }
    }
}