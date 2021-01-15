using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavesOverlay.Properties;

namespace WavesOverlay
{
    public class ImageDrawer
    {
        public static readonly Dictionary<int, SpawnInfo> doors = new Dictionary<int, SpawnInfo>
        {
            {1, new SpawnInfo(){  x1 = 70,  y1 = 112, x2 = 77,  y2 = 106, ix = 68,  iy = 105, direction = Direction.LEFT }},
            {2, new SpawnInfo(){  x1 = 79,  y1 = 181, x2 = 69,  y2 = 175, ix = 68,  iy = 175, direction = Direction.LEFT }},
            {3, new SpawnInfo(){  x1 = 120, y1 = 99,  x2 = 123, y2 = 106, ix = 123, iy = 97,  direction = Direction.RIGHT}},
            {4, new SpawnInfo(){  x1 = 143, y1 = 162, x2 = 147, y2 = 175, ix = 150, iy = 161, direction = Direction.RIGHT}},

            {5, new SpawnInfo(){  x1 = 101, y1 = 53,  x2 = 101, y2 = 53,  ix = 108, iy = 55,  direction = Direction.LEFT   }}, //circle

            {6, new SpawnInfo(){  x1 = 68,  y1 = 480, x2 = 59,  y2 = 484, ix = 70,  iy = 445, direction = Direction.LEFT }},
            {7, new SpawnInfo(){  x1 = 77,  y1 = 549, x2 = 86,  y2 = 550, ix = 77,  iy = 548, direction = Direction.LEFT }},
            {8, new SpawnInfo(){  x1 = 125, y1 = 465, x2 = 130, y2 = 478, ix = 134, iy = 460, direction = Direction.RIGHT}},
            {9, new SpawnInfo(){  x1 = 135, y1 = 549, x2 = 126, y2 = 555, ix = 140, iy = 550, direction = Direction.RIGHT}},

            {10, new SpawnInfo(){ x1 = 54,  y1 = 492, x2 = 54,  y2 = 503, ix = 46,  iy = 492, direction = Direction.LEFT }}, //cannon
            {11, new SpawnInfo(){ x1 = 65,  y1 = 525, x2 = 69,  y2 = 536, ix = 60,  iy = 520, direction = Direction.LEFT }}, //cannon
            {12, new SpawnInfo(){ x1 = 86,  y1 = 591, x2 = 86,  y2 = 591, ix = 85,  iy = 585, direction = Direction.RIGHT}}  //circle
        };


        public static readonly Dictionary<char, Bitmap> enemiesImages = new Dictionary<char, Bitmap>
        {
            {'b', new Bitmap(Resources.mob)       }, //bots
            {'c', new Bitmap(Resources.cannon)    }, //cannons
            {'B', new Bitmap(Resources.boss)      }, //boss
            {'H', new Bitmap(Resources.hurricane) }, //hurricane
            {'R', new Bitmap(Resources.rocket)    }, //rockets
            {'A', new Bitmap(Resources.extra)     }, //additional mobs
            {'F', new Bitmap(Resources.fat)       }  //fat
        };

        private static readonly Pen red = new Pen(Color.Red, 3), orange = new Pen(Color.Orange, 3);

        public static Bitmap createImage(Bitmap image, Wave wave)
        {
            using(Graphics g = Graphics.FromImage(image))
            {
                foreach(int s in wave.spawns.Keys)
                {
                    SpawnInfo spawn = doors[s];
                    drawIcons(g, spawn, wave.spawns[s]);

                    if (s == 5 || s == 12) //boss and extra mobs spawns
                    {
                        g.DrawEllipse(orange, new Rectangle(spawn.x1 - 3, spawn.y1 - 3, 6, 6));
                    }
                    else //everything else
                    {
                        g.DrawLine(red, new Point(spawn.x1, spawn.y1), new Point(spawn.x2, spawn.y2));
                    }
                    g.DrawString("" + wave.Number, new Font(SystemFonts.DefaultFont.FontFamily, 18, FontStyle.Bold), Brushes.Green, 0, 0);

                }

            }
            return image;
        }

        private static void drawIcons(Graphics g, SpawnInfo spawn, string enemies)
        {
            Bitmap target;
            Point where;
            switch (enemies.Length)
            {
                case 1:
                    target = new Bitmap(enemiesImages[enemies[0]]);
                    where = (spawn.direction == Direction.LEFT) ? new Point(spawn.ix - target.Width, spawn.iy) : new Point(spawn.ix, spawn.iy);
                    g.DrawImage(target, where);
                    target.Dispose();
                    break;
                case 2:
                    target = mergeImages(new Bitmap(enemiesImages[enemies[0]]), new Bitmap(enemiesImages[enemies[1]]));
                    where = (spawn.direction == Direction.LEFT) ? new Point(spawn.ix - target.Width, spawn.iy) : new Point(spawn.ix, spawn.iy);
                    g.DrawImage(target, where);
                    target.Dispose();
                    break;
                case 3:
                    target = mergeImages(new Bitmap(enemiesImages[enemies[0]]), new Bitmap(enemiesImages[enemies[1]]), new Bitmap(enemiesImages[enemies[2]]));
                    where = (spawn.direction == Direction.LEFT) ? new Point(spawn.ix - target.Width, spawn.iy) : new Point(spawn.ix, spawn.iy);
                    g.DrawImage(target, where);
                    target.Dispose();
                    break;
                default:
                    Debug.WriteLine("Unknown enemy {} ()", enemies);
                    break;
            }
        }


        public static Bitmap mergeImages(Bitmap image1, Bitmap image2)
        {
            Bitmap bitmap = new Bitmap(image1.Width + image2.Width, Math.Max(image1.Height, image2.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(image1, 0, 0);
                g.DrawImage(image2, image1.Width, 0);
                image1.Dispose();
                image2.Dispose();
            }
            return bitmap;
        }

        public static Bitmap mergeImages(Bitmap image1, Bitmap image2, Bitmap image3)
        {
            Bitmap bitmap = new Bitmap(image1.Width + image2.Width, Math.Max(image1.Height, image2.Height) + image3.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(image1, 0, 0);
                g.DrawImage(image2, image1.Width, 0);
                g.DrawImage(image3, image1.Width/2, Math.Max(image1.Height, image2.Height));
                image1.Dispose();
                image2.Dispose();
                image3.Dispose();
            }
            return bitmap;
        }

    }
}
