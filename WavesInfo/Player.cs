using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavesOverlay
{
    public class Player
    {
        public string Name { get; set; }
        public string NameWithBrackets { get; set; }
        public DateTime died { get; set; } = DateTime.Now.AddMinutes(-2);
        public bool dead { get; set; } = false;

    }
}
