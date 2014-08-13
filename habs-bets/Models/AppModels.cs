using System;
using System.Data.Entity;

namespace habs_bets.Models
{
    public class Better
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }
    }

    public class Bet
    {
        public int ID { get; set; }
        public Game GameID { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }

    public class Game
    {
        public int ID { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime StartTime { get; set; }
    }

    public class AppDBContext : DbContext
    {
        public DbSet<Better> Betters { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}