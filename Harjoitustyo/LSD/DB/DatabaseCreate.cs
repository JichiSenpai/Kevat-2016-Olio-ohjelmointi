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
        public string gameImage { get; set; }
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


    //kaikki pelit listaan
    public class GameView
    {
        private List<Game> games = new List<Game>();
        public List<Game> Games { get { return games; } }

        public GameView()
        {
            games.Add(new Game { gameId = 1, gameName = "Star Wars: Episode 1 Racer", gamePlatform = "PC, N64, Dreamcast", gameRegion = "PAL, NTSC, NTSC-J", gameImage = "/Assets/cover_swe1r.jpg" });
            games.Add(new Game { gameId = 2, gameName = "Sly Cooper and the Thievius Raccoonus", gamePlatform = "PS2", gameRegion = "PAL, NTSC, NTSC-J", gameImage = "/Assets/cover_sly1.jpg" });
            games.Add(new Game { gameId = 3, gameName = "Devil May Cry 3 HD", gamePlatform = "PS3", gameRegion = "PAL, NTSC, NTSC-J", gameImage = "/Assets/cover_dmc3.jpg" });
            games.Add(new Game { gameId = 4, gameName = "Kingdom Hearts 2 Final Mix", gamePlatform = "PS2", gameRegion = "NTSC-J", gameImage = "/Assets/cover_kh2fm.jpg" });
            games.Add(new Game { gameId = 5, gameName = "Hitman Blood Money", gamePlatform = "PC", gameRegion = "N/A", gameImage = "/Assets/cover_hitmanbm.jpg" });
        }

    }

    //runin määrittely
    public class Run {

        public int runId { get; set; }
        public int gameId { get; set; }
        public string runTime { get; set; }
        public string runRunner { get; set; }
        public string gameRegion { get; set; }
        public string gamePlatform { get; set; }
        public string runComment { get; set; }
        

        public Run ()
        {

        }

        public Run(int runid, int gameid, string runrunner, string runtime, string gameregion, string gameplatform, string runcomment)
        {
            runId = runid;
            gameId = gameid;
            runTime = runtime;
            runRunner = runrunner;
            gameRegion = gameregion;
            gamePlatform = gameplatform;
            runComment = runcomment;
        }
    }

    //kaikki runit yhteiseen listaan
    public class RunView
    {
        private List<Run> runs = new List<Run>();
        public List<Run> Runs { get { return runs; } }

        public RunView()
        {
            runs.Add(new Run { runId = 1, gameId = 1, runTime = "00:52:43.50", runRunner = "Siistijäbä123", gamePlatform="PC", gameRegion = "PAL", runComment="siistikommentti123" });
            runs.Add(new Run { runId = 2, gameId = 2, runTime = "01:12:20.50", runRunner = "Jäbä2", gamePlatform = "PS2", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 3, gameId = 3, runTime = "00:32:43.50", runRunner = "Tosisiistijäbä", gamePlatform = "PS3", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 4, gameId = 4, runTime = "00:22:43.50", runRunner = "Epäsiistijäbä", gamePlatform = "PS2", gameRegion = "NTSC-J", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 5, gameId = 5, runTime = "00:59:55.50", runRunner = "Siistijäbä123", gamePlatform = "PC", gameRegion = "N/A", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 6, gameId = 1, runTime = "00:50:21.10", runRunner = "Juuhelikkäs", gamePlatform = "PC", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 7, gameId = 1, runTime = "00:45:11.40", runRunner = "John Elickas", gamePlatform = "PC", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 8, gameId = 3, runTime = "00:54:12.20", runRunner = "John Elickas", gamePlatform = "PS3", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 9, gameId = 4, runTime = "00:36:52.10", runRunner = "John Elickas", gamePlatform = "PS2", gameRegion = "NTSC-J", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 10, gameId = 5, runTime = "00:52:23.52", runRunner = "John Elickas", gamePlatform = "PC", gameRegion = "N/A", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 11, gameId = 5, runTime = "00:59:22.22", runRunner = "John Doe", gamePlatform = "PC", gameRegion = "N/A", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 12, gameId = 3, runTime = "00:35:11.53", runRunner = "John Doe", gamePlatform = "PS3", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 13, gameId = 2, runTime = "00:40:33.23", runRunner = "John Doe", gamePlatform = "PS2", gameRegion = "PAL", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 14, gameId = 4, runTime = "00:25:33.12", runRunner = "John Doe", gamePlatform = "PS2", gameRegion = "NTSC-J", runComment = "siistikommentti123" });
            runs.Add(new Run { runId = 15, gameId = 1, runTime = "01:00:12.55", runRunner = "John Doe", gamePlatform = "PC", gameRegion = "PAL", runComment = "siistikommentti123" });
        }

    }


}
