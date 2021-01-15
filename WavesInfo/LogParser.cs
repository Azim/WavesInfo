using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WavesOverlay
{
    public class LogParser
    {
        private long endOfread = 0;
        public bool inBrawl { get; set; } = false;
        public bool convoy { get; set; } = false;
        public int wave { get; set; } = 0;
        private string path { get; set; }

        public LogParser(string path)
        {
            this.path = path;
        }

        public void setNewPath(string path)
        {
            this.path = path;
            wave = 0;
            convoy = false;
            inBrawl = false;
            endOfread = 0;
        }

        public void read()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Debug.WriteLine("reading further");
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
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
                wave = 1;
                Debug.WriteLine("gameplay started, in brawl now");
                return;
            } else if (data.StartsWith("===== Gameplay finish, reason: unknown"))
            {
                inBrawl = false;
                Debug.WriteLine("gameplay finish, not in brawl anymore");
                return;
            }
            else if(data.StartsWith("====== starting level"))
            {
                inBrawl = false;
                Debug.WriteLine("started some level, not in brawl anymore");
                return;
            }

            if (data.StartsWith("Wave:"))
            {
                parts = data.Split(':');
                if (parts.Length < 2) return;
                string nwave = parts[1];
                wave = Int32.Parse(nwave);
                Debug.WriteLine("Found wave: " + wave);
            }

            if(data.StartsWith("CONVOY STATE"))
            {
                convoy = true;
                Debug.WriteLine("cargo is driving");
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
            }

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
    }
}
