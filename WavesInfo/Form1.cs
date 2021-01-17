using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavesOverlay.Properties;

namespace WavesOverlay
{
    public partial class Form1 : Form
    {

        private LogParser parser;
        private CancellationTokenSource cts1,cts2;
        private ImageForm imageFormCurrent, imageFormNext;
        private Label[] names, statuses;
        private readonly Dictionary<int, int> spawnToColumn = new Dictionary<int, int>
        {
            {1, 4},
            {2, 5},
            {3, 6},
            {4, 7},
            {5, 8},

            {6, 10},
            {7, 11},
            {8, 12},
            {9, 13},
            {10, 14},
            {11, 15},
            {12, 16}
        };




        private List<Wave> waves;

        public Form1()
        {
            InitializeComponent();
            names = new[] { player0label, player1label, player2label, player3label };
            statuses = new[] { player0status, player1status, player2status, player3status };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Select waves file",
                DefaultExt = "xlsx",
                Filter = "EXCEL files (*.xlsx)|*.xlsx",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Settings.Default.waves
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                label2.Text = dlg.FileName;
                FileInfo file_info = new FileInfo(dlg.FileName);
                Settings.Default.waves = file_info.DirectoryName;
                Settings.Default.Save();
                loadWavesFromFile(dlg.FileName);
                button2.Enabled = true;

            }
        }


        //waves file selection
        private void loadWavesFromFile(string file)
        {
            var wb = new XLWorkbook(file);
            var ws = wb.Worksheet(1);
            List<Wave> lwaves = new List<Wave>();
             

            for(int row = 2; row < 102; row++)
            {
                //1 - number, 2 - note, 3 - empty, 4 - P1, 5 - P2, 6 - P3, 7 - P4, 8 - P5, 9 - empty, 
                //10 - P6, 11 - P7, 12 = P8, 13 = P9, 14 = P10, 15 = P11, 16 = P12
                

                var rrow = ws.Row(row);
                if (rrow.Cell(1).IsEmpty()){
                    break;
                }
                Wave wave = new Wave(row-1);
                wave.Note = rrow.Cell(2).GetString();

                foreach(int spawn in spawnToColumn.Keys)
                {
                    int column = spawnToColumn[spawn];
                    if (!rrow.Cell(column).IsEmpty())
                    {
                        wave.AddEnemy(spawn, rrow.Cell(column).GetString());
                    }
                }
                lwaves.Add(wave);
            }
            waves = lwaves;
            label1.Text = "Loaded " + lwaves.Count + " waves";
            wb.Dispose();
        }

        //log file selection
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Select log file",
                DefaultExt = "log",
                Filter = "log files (*.log)|*.log",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\My Games\\Crossout\\logs\\"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                label3.Text = dlg.FileName;
                parser = new LogParser(dlg.FileName, timeDiff);
                parser.setNewPath(dlg.FileName);
                refresh();
                refreshDeaths();

                //imageFileCB.Enabled = true;
                //textFileCB.Enabled = true;
                imageWindowCB.Enabled = true;
                nextWaveCB.Enabled = true;
                refreshCB.Enabled = true;
                respawnTimerCB.Enabled = true;
            }
        }


        private void imageFileCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textFileCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imageWindowCB_CheckedChanged(object sender, EventArgs e)
        {
            if (imageWindowCB.Checked)
            {
                imageFormCurrent = new ImageForm(imageWindowCB);
                imageFormCurrent.Show();
                imageFormCurrent.updateImage(pictureBox1.Image);
            }
            else
            {
                if (imageFormCurrent == null) return;
                imageFormCurrent.Close();
            }
        }

        private void nextWaveCB_CheckedChanged(object sender, EventArgs e)
        {
            if (nextWaveCB.Checked)
            {
                imageFormNext = new ImageForm(nextWaveCB);
                imageFormNext.Show();
                int index = parser.wave + (drawHalfsCB.Checked ? 1 : 0);
                if (parser.inBrawl) imageFormNext.updateImage(ImageDrawer.createImage(Resources.map_small, waves[index], waves[index + 1], drawHalfsCB.Checked));
            }
            else
            {
                if (imageFormNext == null) return;
                imageFormNext.Close();
            }
        }

        private void refresh()
        {
            parser.read();
            noteLabel.Invoke(new Action(() => {
                updateImage();
                updateText();
            }));
        }

        private void refreshDeaths()
        {
            names[0].Invoke(new Action(() => {//apply them
                if (!parser.inBrawl)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        names[i].Text = "Player " + i;
                        statuses[i].Text = "no info";
                    }
                }
                else
                {
                    string[] newstatuses = new string[4];
                    for (int i = 0; i < 4; i++)//checks
                    {
                        if (!parser.players.ContainsKey(i)) continue;
                        var respawns = parser.players[i].died.AddSeconds(30);
                        if (respawns < DateTime.Now)
                        {
                            statuses[i].Text = "Alive";
                        }
                        else
                        {
                            statuses[i].Text = "" + Convert.ToInt32((respawns - DateTime.Now).TotalSeconds);
                        }
                        names[i].Text = parser.players[i].Name;
                    }
                }
            }));
        }

        private void updateImage()
        {
            if (parser.inBrawl)
            {
                pictureBox1.Image.Dispose();
                int index = parser.wave - (parser.convoy ? 0 : 1);
                pictureBox1.Image = ImageDrawer.createImage(Resources.map_small, waves[index], waves[index + 1], drawHalfsCB.Checked);
            }
            else
            {
                pictureBox1.Image = Resources.map_small;
            }

            if (imageWindowCB.Checked && imageFormCurrent != null)
            {
                imageFormCurrent.updateImage(pictureBox1.Image);
            }
            if (nextWaveCB.Checked && imageFormNext != null)
            {
                int index = parser.wave + (drawHalfsCB.Checked ? 1 : 0);
                imageFormNext.updateImage(parser.inBrawl ? ImageDrawer.createImage(Resources.map_small, waves[index], waves[index + 1], drawHalfsCB.Checked) : pictureBox1.Image);
            }


        }

        private void updateText()
        {
            if (parser.inBrawl)
            {
                if (parser.convoy)
                {
                    noteLabel.Text = "Wave: " + parser.wave + "\nCargo is moving\nNext: " + waves[parser.wave].Note;
                }
                else
                {
                    noteLabel.Text = "Wave: " + parser.wave + " \n" + waves[parser.wave - 1].Note + " \nNext: "+waves[parser.wave].Note;
                }
            }
            else
            {
                noteLabel.Text = " ";
            }
        }

        private void respawnTimerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (respawnTimerCB.Checked)
            {
                cts2 = new CancellationTokenSource();
                parser.runRepeatingTaskMillis(refreshDeaths, 500, cts2.Token);
            }
            else
            {
                if (cts2 == null) return;
                cts2.Cancel();
            }
        }

        private void refreshCB_CheckedChanged(object sender, EventArgs e)
        {
            if (refreshCB.Checked)
            {
                cts1 = new CancellationTokenSource();
                parser.runRepeatingTask(refresh, 2, cts1.Token);
            }
            else
            {
                if (cts1 == null) return;
                cts1.Cancel();
            }
        }

        private void topmostCB_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostCB.Checked;
        }
    }
}
