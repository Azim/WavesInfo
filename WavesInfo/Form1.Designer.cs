
namespace WavesOverlay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageWindowCB = new System.Windows.Forms.CheckBox();
            this.refreshCB = new System.Windows.Forms.CheckBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topmostCB = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nextWaveCB = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.player3label = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.player1label = new System.Windows.Forms.Label();
            this.player3status = new System.Windows.Forms.Label();
            this.player2status = new System.Windows.Forms.Label();
            this.player1status = new System.Windows.Forms.Label();
            this.player0status = new System.Windows.Forms.Label();
            this.player0label = new System.Windows.Forms.Label();
            this.timeDiff = new System.Windows.Forms.Label();
            this.drawHalfsCB = new System.Windows.Forms.CheckBox();
            this.respawnTimerCB = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select waves file";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waves file not selected";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log file not selected";
            // 
            // imageWindowCB
            // 
            this.imageWindowCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageWindowCB.AutoSize = true;
            this.imageWindowCB.Enabled = false;
            this.imageWindowCB.Location = new System.Drawing.Point(12, 621);
            this.imageWindowCB.Name = "imageWindowCB";
            this.imageWindowCB.Size = new System.Drawing.Size(94, 17);
            this.imageWindowCB.TabIndex = 8;
            this.imageWindowCB.Text = "Image window";
            this.imageWindowCB.UseVisualStyleBackColor = true;
            this.imageWindowCB.CheckedChanged += new System.EventHandler(this.imageWindowCB_CheckedChanged);
            // 
            // refreshCB
            // 
            this.refreshCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshCB.AutoSize = true;
            this.refreshCB.Enabled = false;
            this.refreshCB.Location = new System.Drawing.Point(12, 574);
            this.refreshCB.Name = "refreshCB";
            this.refreshCB.Size = new System.Drawing.Size(113, 17);
            this.refreshCB.TabIndex = 9;
            this.refreshCB.Text = "Autorefresh log file";
            this.refreshCB.UseVisualStyleBackColor = true;
            this.refreshCB.CheckedChanged += new System.EventHandler(this.refreshCB_CheckedChanged);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteLabel.Location = new System.Drawing.Point(16, 30);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(21, 31);
            this.noteLabel.TabIndex = 10;
            this.noteLabel.Text = " ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "bots";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 34);
            this.label5.TabIndex = 19;
            this.label5.Text = "cannons";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "hurricane";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "rockets";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "fat";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "additional mobs";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "boss";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 258);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 244);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.Image = global::WavesOverlay.Properties.Resources.mob;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 34);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.Image = global::WavesOverlay.Properties.Resources.cannon;
            this.pictureBox7.Location = new System.Drawing.Point(0, 34);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 34);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.Image = global::WavesOverlay.Properties.Resources.hurricane;
            this.pictureBox6.Location = new System.Drawing.Point(0, 68);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 34);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::WavesOverlay.Properties.Resources.rocket;
            this.pictureBox5.Location = new System.Drawing.Point(0, 102);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 34);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::WavesOverlay.Properties.Resources.fat;
            this.pictureBox4.Location = new System.Drawing.Point(0, 136);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 34);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::WavesOverlay.Properties.Resources.extra;
            this.pictureBox3.Location = new System.Drawing.Point(0, 170);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 34);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::WavesOverlay.Properties.Resources.boss;
            this.pictureBox2.Location = new System.Drawing.Point(0, 204);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 34);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 683);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // topmostCB
            // 
            this.topmostCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.topmostCB.AutoSize = true;
            this.topmostCB.Location = new System.Drawing.Point(12, 551);
            this.topmostCB.Name = "topmostCB";
            this.topmostCB.Size = new System.Drawing.Size(80, 17);
            this.topmostCB.TabIndex = 26;
            this.topmostCB.Text = "Stay on top";
            this.topmostCB.UseVisualStyleBackColor = true;
            this.topmostCB.CheckedChanged += new System.EventHandler(this.topmostCB_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 39);
            this.label11.TabIndex = 27;
            this.label11.Text = "Developed by Azim\r\n\r\nDefault wave info collected by LSTR clan";
            // 
            // nextWaveCB
            // 
            this.nextWaveCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextWaveCB.AutoSize = true;
            this.nextWaveCB.Enabled = false;
            this.nextWaveCB.Location = new System.Drawing.Point(12, 597);
            this.nextWaveCB.Name = "nextWaveCB";
            this.nextWaveCB.Size = new System.Drawing.Size(152, 17);
            this.nextWaveCB.TabIndex = 28;
            this.nextWaveCB.Text = "Image window (next wave)";
            this.nextWaveCB.UseVisualStyleBackColor = true;
            this.nextWaveCB.CheckedChanged += new System.EventHandler(this.nextWaveCB_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.player3label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.player2label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.player1label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.player3status, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.player2status, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.player1status, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.player0status, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.player0label, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(186, 360);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 136);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // player3label
            // 
            this.player3label.AutoSize = true;
            this.player3label.Location = new System.Drawing.Point(3, 90);
            this.player3label.Name = "player3label";
            this.player3label.Size = new System.Drawing.Size(45, 13);
            this.player3label.TabIndex = 2;
            this.player3label.Text = "Player 3";
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.Location = new System.Drawing.Point(3, 60);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(45, 13);
            this.player2label.TabIndex = 1;
            this.player2label.Text = "Player 2";
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Location = new System.Drawing.Point(3, 30);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(45, 13);
            this.player1label.TabIndex = 0;
            this.player1label.Text = "Player 1";
            // 
            // player3status
            // 
            this.player3status.AutoSize = true;
            this.player3status.Location = new System.Drawing.Point(152, 90);
            this.player3status.Name = "player3status";
            this.player3status.Size = new System.Drawing.Size(39, 13);
            this.player3status.TabIndex = 6;
            this.player3status.Text = "no info";
            // 
            // player2status
            // 
            this.player2status.AutoSize = true;
            this.player2status.Location = new System.Drawing.Point(152, 60);
            this.player2status.Name = "player2status";
            this.player2status.Size = new System.Drawing.Size(39, 13);
            this.player2status.TabIndex = 5;
            this.player2status.Text = "no info";
            // 
            // player1status
            // 
            this.player1status.AutoSize = true;
            this.player1status.Location = new System.Drawing.Point(152, 30);
            this.player1status.Name = "player1status";
            this.player1status.Size = new System.Drawing.Size(39, 13);
            this.player1status.TabIndex = 4;
            this.player1status.Text = "no info";
            // 
            // player0status
            // 
            this.player0status.AutoSize = true;
            this.player0status.Location = new System.Drawing.Point(152, 0);
            this.player0status.Name = "player0status";
            this.player0status.Size = new System.Drawing.Size(39, 13);
            this.player0status.TabIndex = 7;
            this.player0status.Text = "no info";
            // 
            // player0label
            // 
            this.player0label.AutoSize = true;
            this.player0label.Location = new System.Drawing.Point(3, 0);
            this.player0label.Name = "player0label";
            this.player0label.Size = new System.Drawing.Size(45, 13);
            this.player0label.TabIndex = 3;
            this.player0label.Text = "Player 0";
            // 
            // timeDiff
            // 
            this.timeDiff.AutoSize = true;
            this.timeDiff.Location = new System.Drawing.Point(189, 337);
            this.timeDiff.Name = "timeDiff";
            this.timeDiff.Size = new System.Drawing.Size(0, 13);
            this.timeDiff.TabIndex = 8;
            // 
            // drawHalfsCB
            // 
            this.drawHalfsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drawHalfsCB.AutoSize = true;
            this.drawHalfsCB.Location = new System.Drawing.Point(12, 528);
            this.drawHalfsCB.Name = "drawHalfsCB";
            this.drawHalfsCB.Size = new System.Drawing.Size(98, 17);
            this.drawHalfsCB.TabIndex = 30;
            this.drawHalfsCB.Text = "Draw only halfs";
            this.drawHalfsCB.UseVisualStyleBackColor = true;
            // 
            // respawnTimerCB
            // 
            this.respawnTimerCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.respawnTimerCB.AutoSize = true;
            this.respawnTimerCB.Enabled = false;
            this.respawnTimerCB.Location = new System.Drawing.Point(12, 505);
            this.respawnTimerCB.Name = "respawnTimerCB";
            this.respawnTimerCB.Size = new System.Drawing.Size(123, 17);
            this.respawnTimerCB.TabIndex = 31;
            this.respawnTimerCB.Text = "Player respawn timer";
            this.respawnTimerCB.UseVisualStyleBackColor = true;
            this.respawnTimerCB.CheckedChanged += new System.EventHandler(this.respawnTimerCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 708);
            this.Controls.Add(this.respawnTimerCB);
            this.Controls.Add(this.drawHalfsCB);
            this.Controls.Add(this.timeDiff);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.nextWaveCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.topmostCB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.refreshCB);
            this.Controls.Add(this.imageWindowCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Waves Info v1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox imageWindowCB;
        private System.Windows.Forms.CheckBox refreshCB;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox topmostCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox nextWaveCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label player0status;
        private System.Windows.Forms.Label player3status;
        private System.Windows.Forms.Label player2status;
        private System.Windows.Forms.Label player1status;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.Label player3label;
        private System.Windows.Forms.Label player0label;
        private System.Windows.Forms.Label timeDiff;
        private System.Windows.Forms.CheckBox drawHalfsCB;
        private System.Windows.Forms.CheckBox respawnTimerCB;
    }
}

