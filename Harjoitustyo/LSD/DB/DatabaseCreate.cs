using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSD.DB
{
    public class Game
    {
        public int gameId { get; set; }
        public string gameName { get; set; }
        public string gamePlatform { get; set; }
        public string gameRegion { get; set; }

        public static int gamecount;

        public Game()
        {
            gamecount++;
        }

        ~Game()
        {
            gamecount--;
        }

        public static int GetGameCount()
        {
            return gamecount;
        }

        public Game(int gameid, string gamename, string platform, string region)
        {
            gameId = gameid;
            gameName = gamename;
            gamePlatform = platform;
            gameRegion = region;
        }

        public override string ToString()
        {
            return gameName + "\nPlatform: " + gamePlatform + "\nRegion: " + gameRegion;
        }

    }


    public class GameView
    {
        private List<Game> games = new List<Game>();
        public List<Game> Games { get { return games; } }

        public GameView()
        {
            games.Add(new Game { gameId = 1, gameName = "Star Wars: Episode 1 Racer", gamePlatform = "PC", gameRegion = "N/A" });
            games.Add(new Game { gameId = 2, gameName = "Sly Cooper and the Thievius Raccoonus", gamePlatform = "PS2", gameRegion = "NTSC" });
            games.Add(new Game { gameId = 3, gameName = "Devil May Cry 3 HD", gamePlatform = "PS3", gameRegion = "PAL" });
            games.Add(new Game { gameId = 4, gameName = "Kingdom Hearts 2 Final Mix", gamePlatform = "PS2", gameRegion = "NTSC-J" });
            games.Add(new Game { gameId = 5, gameName = "Hitman Blood Money", gamePlatform = "PC", gameRegion = "N/A" });
        }

    }

    public class Run {

        public int runId { get; set; }
        public int gameId { get; set; }
        public string runTime { get; set; }
        public string runRunner { get; set; }
        public string gameRegion { get; set; }
        public string gamePlatform { get; set; }
        

        public Run ()
        {

        }

        public Run(int runid, int gameid, string runrunner, string runtime)
        {
            runId = runid;
            gameId = gameid;
            runTime = runtime;
            runRunner = runrunner;
        }
    }

    public class RunView
    {
        private List<Run> runs = new List<Run>();
        public List<Run> Runs { get { return runs; } }

        public RunView()
        {
            runs.Add(new Run { runId = 1, gameId = 1, runTime = "52:43.50", runRunner = "Siistijäbä123" });
            runs.Add(new Run { runId = 2, gameId = 2, runTime = "1:12:20.50", runRunner = "Jäbä2" });
            runs.Add(new Run { runId = 3, gameId = 3, runTime = "32:43.50", runRunner = "Tosisiistijäbä" });
            runs.Add(new Run { runId = 4, gameId = 4, runTime = "22:43.50", runRunner = "Epäsiistijäbä" });
            runs.Add(new Run { runId = 5, gameId = 5, runTime = "59:55.50", runRunner = "Siistijäbä123" });
            runs.Add(new Run { runId = 6, gameId = 1, runTime = "50:21.10", runRunner = "Juuhelikkäs" });
            runs.Add(new Run { runId = 7, gameId = 1, runTime = "45:11.40", runRunner = "John Elickas" });
            runs.Add(new Run { runId = 8, gameId = 3, runTime = "54:12.20", runRunner = "John Elickas" });
            runs.Add(new Run { runId = 9, gameId = 4, runTime = "36:52.10", runRunner = "John Elickas" });
            runs.Add(new Run { runId = 10, gameId = 5, runTime = "52:23.52", runRunner = "John Elickas" });
        }

    }


}
