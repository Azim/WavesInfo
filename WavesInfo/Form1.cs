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
        private CancellationTokenSource cts;
        private ImageForm imageFormCurrent, imageFormNext;

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
                parser = new LogParser(dlg.FileName);
                parser.setNewPath(dlg.FileName);
                refresh();

                //imageFileCB.Enabled = true;
                //textFileCB.Enabled = true;
                imageWindowCB.Enabled = true;
                nextWaveCB.Enabled = true;
                refreshCB.Enabled = true;
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
                if(parser.inBrawl) imageFormNext.updateImage(ImageDrawer.createImage(new Bitmap(Resources.map_small), waves[parser.wave]));
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

        private void updateImage()
        {
            if (parser.inBrawl)
            {
                Bitmap image = new Bitmap(Resources.map_small);
                pictureBox1.Image.Dispose();
                pictureBox1.Image = ImageDrawer.createImage(image, waves[parser.wave - (parser.convoy?0:1)]);
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
                imageFormNext.updateImage(parser.inBrawl ? ImageDrawer.createImage(new Bitmap(Resources.map_small), waves[parser.wave]) : pictureBox1.Image);
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

        private void refreshCB_CheckedChanged(object sender, EventArgs e)
        {
            if (refreshCB.Checked)
            {
                cts = new CancellationTokenSource();
                parser.runRepeatingTask(refresh, 2, cts.Token);
            }
            else
            {
                if (cts == null) return;
                cts.Cancel();
            }
        }

        private void topmostCB_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostCB.Checked;
        }
    }
}
