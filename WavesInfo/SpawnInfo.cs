using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavesOverlay
{
    public class SpawnInfo
    {
        public int x1=0, y1=0, x2=0, y2=0, ix=0, iy=0;
        public Direction direction;
    }
    public enum Direction
    {
        LEFT,
        RIGHT
    }
}
