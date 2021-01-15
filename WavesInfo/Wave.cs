using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavesOverlay
{
    public class Wave
    {
        private static readonly Dictionary<char, string> enemies = new Dictionary<char, string>
        {
            {'b', "Bots"},
            {'c', "Cannons"},
            {'H', "Hurricane"},
            {'R', "Rockets"},
            {'A', "Additional mobs"},
            {'B', "Boss"}
        };

        public int Number { get; protected set; }
        public string Note { get; set; }
        public Dictionary<int, string> spawns {get; protected set;}


        public Wave(int n)
        {
            Number = n;
            spawns = new Dictionary<int, string>();
        }

        public void AddEnemy(int spawn, string enemies)
        {
            spawns[spawn] = enemies;
        }

        public String getEnemyNames(int spawn)
        {
            if (spawns.ContainsKey(spawn))
            {
                string result = "";
                foreach(char e in spawns[spawn])
                {
                    result += enemies[e];
                }
                return result;
            }
            return "";
        }

    }
}
