using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WavesOverlay
{
    public class LogParser
    {
        private long endOfread = 0;
        public bool inBrawl { get; set; } = false;
        public bool convoy { get; set; } = false;
        public int wave { get; set; } = 0;
        private string path { get; set; }

        private DateTime lastTrigger;
        private Label diff;

        public Dictionary<int, Player> players = new Dictionary<int, Player>();

        public LogParser(string path, Label diff)
        {
            this.path = path;
            this.diff = diff;
        }

        public void setNewPath(string path)
        {
            this.path = path;
            reset();
        }

        public void reset()
        {
            players.Clear();
            inBrawl = false;
            convoy = false;
            wave = 0;
        }

        public void read()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Debug.WriteLine("reading further");
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (endOfread > 0) fs.Seek(endOfread, SeekOrigin.Begin);
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Debug.WriteLine("line: " + line);
                        endOfread = sr.BaseStream.Position;
                        parse(line);
                    }
                }
            }
            stopwatch.Stop();
            Debug.WriteLine("Parsed log. Took {0} ms", stopwatch.ElapsedMilliseconds);
        }

        private void parse(string row)
        {
            if (row.Length == 0) return;
            string[] parts = row.Split('|');
            if (parts.Length < 2) return;
            string data = parts[1];
            string time = parts[0];
            data = data.Trim(' ');
            if (data.StartsWith("===== Gameplay 'Brawl_NewYear_Convoy' started"))
            {
                inBrawl = true;
                convoy = false;
                wave = 1;
                updateTimediff(time);
                Debug.WriteLine("gameplay started, in brawl now");
                return;
            } else if (data.StartsWith("===== Gameplay finish, reason: unknown"))
            {
                reset();
                Debug.WriteLine("gameplay finish, not in brawl anymore");
                return;
            }
            else if(data.StartsWith("====== starting level"))
            {
                reset();
                Debug.WriteLine("started some level, not in brawl anymore");
                return;
            }
            if (players.Keys.Count < 4 && inBrawl)
            {
                if(data.StartsWith("Spawn player"))
                {
                    string[] spaces = data.Split(' ');
                    int number = Int32.Parse(spaces[2]);
                    string name = spaces[3];
                    Player player = new Player { NameWithBrackets = name, Name = name.Substring(1, name.Length - 3) };
                    players[number] = player;
                    return;
                }
            }
            else if(inBrawl)
            {
                for(int i = 0; i < 4; i++)
                {
                    if(data.StartsWith("Kill. Victim: " + players[i].Name+" "))
                    {
                        DateTime deathTime = DateTime.Parse(time);
                        players[i].died = deathTime;
                    }
                }
            }

            if (data.StartsWith("Wave:"))
            {
                parts = data.Split(':');
                if (parts.Length < 2) return;
                string nwave = parts[1];
                wave = Int32.Parse(nwave);
                Debug.WriteLine("Found wave: " + wave);
                updateTimediff(time);
            }

            if(data.StartsWith("CONVOY STATE"))
            {
                convoy = true;
                Debug.WriteLine("cargo is driving");
                updateTimediff(time);
            }
            else if (data.StartsWith("DEFENSE STATE"))
            {
                convoy = false;
                Debug.Write("cargo arrived, and ");
                parts = data.Split(':');
                if (parts.Length < 2) return;
                string nwave = parts[1];
                wave = Int32.Parse(nwave);
                Debug.WriteLine("found wave: " + wave);
                updateTimediff(time);
            }

        }

        private void updateTimediff(string time)
        {
            DateTime newtime = DateTime.Parse(time);
            if (lastTrigger == null)
            {
                lastTrigger = newtime;
                return;
            }
            TimeSpan tdiff = newtime - lastTrigger;
            lastTrigger = newtime;
            diff.Invoke(new Action(() =>
            {
                diff.Text = tdiff.Minutes + "m " + tdiff.Seconds + "s " + tdiff.Milliseconds + "ms";
            }));
        }

        public void runRepeatingTask(Action action, int seconds, CancellationToken token)
        {
            if (action == null)
                return;
            Task.Run(async () => {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                }
            }, token);
        }

        public void runRepeatingTaskMillis(Action action, int millis, CancellationToken token)
        {
            if (action == null)
                return;
            Task.Run(async () => {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromMilliseconds(millis), token);
                }
            }, token);
        }
    }
}
