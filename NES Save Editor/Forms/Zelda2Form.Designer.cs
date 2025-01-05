namespace NESSaveEditor.Forms
{
    partial class Zelda2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zelda2Form));
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            game0 = new ToolStripMenuItem();
            game1 = new ToolStripMenuItem();
            game2 = new ToolStripMenuItem();
            grpName = new GroupBox();
            txtName = new TextBox();
            grpPlayCount = new GroupBox();
            label3 = new Label();
            lblPlayCount = new Label();
            label1 = new Label();
            trkPlayCount = new TrackBar();
            grpTriforce = new GroupBox();
            chkHaveTriforce = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            grpLevels = new GroupBox();
            label4 = new Label();
            label9 = new Label();
            lblLifeLevel = new Label();
            label12 = new Label();
            trkLifeLevel = new TrackBar();
            label7 = new Label();
            label8 = new Label();
            lblMagicLevel = new Label();
            label10 = new Label();
            trkMagicLevel = new TrackBar();
            label6 = new Label();
            label2 = new Label();
            lblSwordLevel = new Label();
            label5 = new Label();
            trkSwordLevel = new TrackBar();
            grpContainers = new GroupBox();
            label11 = new Label();
            label13 = new Label();
            lblLifeContainer = new Label();
            label15 = new Label();
            trkLifeContainer = new TrackBar();
            label16 = new Label();
            label17 = new Label();
            lblMagicContainer = new Label();
            label19 = new Label();
            trkMagicContainer = new TrackBar();
            grpTechnique = new GroupBox();
            chkUpward = new CheckBox();
            chkDownward = new CheckBox();
            grpSpells = new GroupBox();
            chkThunder = new CheckBox();
            chkFairy = new CheckBox();
            chkSpell = new CheckBox();
            chkLife = new CheckBox();
            chkReflect = new CheckBox();
            chkJump = new CheckBox();
            chkFire = new CheckBox();
            chkShield = new CheckBox();
            grpItems = new GroupBox();
            chkHammer = new CheckBox();
            chkBoots = new CheckBox();
            chkMagicKey = new CheckBox();
            chkRaft = new CheckBox();
            chkFlute = new CheckBox();
            chkGlove = new CheckBox();
            chkCross = new CheckBox();
            chkCandle = new CheckBox();
            grpPalaceSeals = new GroupBox();
            chkThreeEyeRock = new CheckBox();
            chkIsland = new CheckBox();
            chkSeaPalace = new CheckBox();
            chkMidoro = new CheckBox();
            chkMazePalace = new CheckBox();
            chkParapa = new CheckBox();
            grpKeys = new GroupBox();
            label20 = new Label();
            lblKeys = new Label();
            label22 = new Label();
            trkKeys = new TrackBar();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            grpName.SuspendLayout();
            grpPlayCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkPlayCount).BeginInit();
            grpTriforce.SuspendLayout();
            grpLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkLifeLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkMagicLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkSwordLevel).BeginInit();
            grpContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkLifeContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkMagicContainer).BeginInit();
            grpTechnique.SuspendLayout();
            grpSpells.SuspendLayout();
            grpItems.SuspendLayout();
            grpPalaceSeals.SuspendLayout();
            grpKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkKeys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(639, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { game0, game1, game2 });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(53, 20);
            gameToolStripMenuItem.Text = "Profile";
            // 
            // game0
            // 
            game0.CheckOnClick = true;
            game0.Name = "game0";
            game0.Size = new Size(80, 22);
            game0.Text = "0";
            game0.Click += game0_Click;
            // 
            // game1
            // 
            game1.CheckOnClick = true;
            game1.Name = "game1";
            game1.Size = new Size(80, 22);
            game1.Text = "1";
            game1.Click += game1_Click;
            // 
            // game2
            // 
            game2.CheckOnClick = true;
            game2.Name = "game2";
            game2.Size = new Size(80, 22);
            game2.Text = "2";
            game2.Click += game2_Click;
            // 
            // grpName
            // 
            grpName.Controls.Add(pictureBox1);
            grpName.Controls.Add(txtName);
            grpName.Location = new Point(12, 27);
            grpName.Name = "grpName";
            grpName.Size = new Size(168, 90);
            grpName.TabIndex = 1;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(53, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 23);
            txtName.TabIndex = 0;
            // 
            // grpPlayCount
            // 
            grpPlayCount.Controls.Add(label3);
            grpPlayCount.Controls.Add(lblPlayCount);
            grpPlayCount.Controls.Add(label1);
            grpPlayCount.Controls.Add(trkPlayCount);
            grpPlayCount.Location = new Point(188, 27);
            grpPlayCount.Name = "grpPlayCount";
            grpPlayCount.Size = new Size(200, 90);
            grpPlayCount.TabIndex = 2;
            grpPlayCount.TabStop = false;
            grpPlayCount.Text = "Play Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 19);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "255";
            // 
            // lblPlayCount
            // 
            lblPlayCount.AutoSize = true;
            lblPlayCount.Location = new Point(93, 19);
            lblPlayCount.Name = "lblPlayCount";
            lblPlayCount.Size = new Size(13, 15);
            lblPlayCount.TabIndex = 2;
            lblPlayCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // trkPlayCount
            // 
            trkPlayCount.Location = new Point(17, 37);
            trkPlayCount.Maximum = 255;
            trkPlayCount.Name = "trkPlayCount";
            trkPlayCount.Size = new Size(165, 45);
            trkPlayCount.TabIndex = 0;
            trkPlayCount.TickFrequency = 85;
            trkPlayCount.TickStyle = TickStyle.None;
            trkPlayCount.ValueChanged += trkPlayCount_ValueChanged;
            // 
            // grpTriforce
            // 
            grpTriforce.Controls.Add(chkHaveTriforce);
            grpTriforce.Location = new Point(397, 27);
            grpTriforce.Name = "grpTriforce";
            grpTriforce.Size = new Size(88, 90);
            grpTriforce.TabIndex = 3;
            grpTriforce.TabStop = false;
            grpTriforce.Text = "Triforce";
            // 
            // chkHaveTriforce
            // 
            chkHaveTriforce.AutoSize = true;
            chkHaveTriforce.Location = new Point(16, 26);
            chkHaveTriforce.Name = "chkHaveTriforce";
            chkHaveTriforce.Size = new Size(53, 19);
            chkHaveTriforce.TabIndex = 0;
            chkHaveTriforce.Text = "Have";
            chkHaveTriforce.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpLevels
            // 
            grpLevels.Controls.Add(label4);
            grpLevels.Controls.Add(label9);
            grpLevels.Controls.Add(lblLifeLevel);
            grpLevels.Controls.Add(label12);
            grpLevels.Controls.Add(trkLifeLevel);
            grpLevels.Controls.Add(label7);
            grpLevels.Controls.Add(label8);
            grpLevels.Controls.Add(lblMagicLevel);
            grpLevels.Controls.Add(label10);
            grpLevels.Controls.Add(trkMagicLevel);
            grpLevels.Controls.Add(label6);
            grpLevels.Controls.Add(label2);
            grpLevels.Controls.Add(lblSwordLevel);
            grpLevels.Controls.Add(label5);
            grpLevels.Controls.Add(trkSwordLevel);
            grpLevels.Location = new Point(16, 128);
            grpLevels.Name = "grpLevels";
            grpLevels.Size = new Size(233, 189);
            grpLevels.TabIndex = 4;
            grpLevels.TabStop = false;
            grpLevels.Text = "Levels";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 18;
            label4.Text = "Life";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 118);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 17;
            label9.Text = "8";
            // 
            // lblLifeLevel
            // 
            lblLifeLevel.AutoSize = true;
            lblLifeLevel.Location = new Point(128, 118);
            lblLifeLevel.Name = "lblLifeLevel";
            lblLifeLevel.Size = new Size(13, 15);
            lblLifeLevel.TabIndex = 16;
            lblLifeLevel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 118);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 15;
            label12.Text = "1";
            // 
            // trkLifeLevel
            // 
            trkLifeLevel.Location = new Point(52, 136);
            trkLifeLevel.Maximum = 8;
            trkLifeLevel.Minimum = 1;
            trkLifeLevel.Name = "trkLifeLevel";
            trkLifeLevel.Size = new Size(165, 45);
            trkLifeLevel.TabIndex = 14;
            trkLifeLevel.TickFrequency = 2;
            trkLifeLevel.TickStyle = TickStyle.None;
            trkLifeLevel.Value = 1;
            trkLifeLevel.Scroll += trkLifeLevel_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 85);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 13;
            label7.Text = "Magic";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(191, 67);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 12;
            label8.Text = "8";
            // 
            // lblMagicLevel
            // 
            lblMagicLevel.AutoSize = true;
            lblMagicLevel.Location = new Point(129, 67);
            lblMagicLevel.Name = "lblMagicLevel";
            lblMagicLevel.Size = new Size(13, 15);
            lblMagicLevel.TabIndex = 11;
            lblMagicLevel.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 67);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 10;
            label10.Text = "1";
            // 
            // trkMagicLevel
            // 
            trkMagicLevel.Location = new Point(53, 85);
            trkMagicLevel.Maximum = 8;
            trkMagicLevel.Minimum = 1;
            trkMagicLevel.Name = "trkMagicLevel";
            trkMagicLevel.Size = new Size(165, 45);
            trkMagicLevel.TabIndex = 9;
            trkMagicLevel.TickFrequency = 2;
            trkMagicLevel.TickStyle = TickStyle.None;
            trkMagicLevel.Value = 1;
            trkMagicLevel.Scroll += trkMagicLevel_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 36);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 8;
            label6.Text = "Sword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 18);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 7;
            label2.Text = "8";
            // 
            // lblSwordLevel
            // 
            lblSwordLevel.AutoSize = true;
            lblSwordLevel.Location = new Point(128, 18);
            lblSwordLevel.Name = "lblSwordLevel";
            lblSwordLevel.Size = new Size(13, 15);
            lblSwordLevel.TabIndex = 6;
            lblSwordLevel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 18);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 5;
            label5.Text = "1";
            // 
            // trkSwordLevel
            // 
            trkSwordLevel.Location = new Point(52, 36);
            trkSwordLevel.Maximum = 8;
            trkSwordLevel.Minimum = 1;
            trkSwordLevel.Name = "trkSwordLevel";
            trkSwordLevel.Size = new Size(165, 45);
            trkSwordLevel.TabIndex = 4;
            trkSwordLevel.TickFrequency = 2;
            trkSwordLevel.TickStyle = TickStyle.None;
            trkSwordLevel.Value = 1;
            trkSwordLevel.Scroll += trkSwordLevel_Scroll;
            // 
            // grpContainers
            // 
            grpContainers.Controls.Add(label11);
            grpContainers.Controls.Add(label13);
            grpContainers.Controls.Add(lblLifeContainer);
            grpContainers.Controls.Add(label15);
            grpContainers.Controls.Add(trkLifeContainer);
            grpContainers.Controls.Add(label16);
            grpContainers.Controls.Add(label17);
            grpContainers.Controls.Add(lblMagicContainer);
            grpContainers.Controls.Add(label19);
            grpContainers.Controls.Add(trkMagicContainer);
            grpContainers.Location = new Point(255, 128);
            grpContainers.Name = "grpContainers";
            grpContainers.Size = new Size(224, 189);
            grpContainers.TabIndex = 5;
            grpContainers.TabStop = false;
            grpContainers.Text = "Containers";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 85);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 23;
            label11.Text = "Life";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(189, 67);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 22;
            label13.Text = "8";
            // 
            // lblLifeContainer
            // 
            lblLifeContainer.AutoSize = true;
            lblLifeContainer.Location = new Point(127, 67);
            lblLifeContainer.Name = "lblLifeContainer";
            lblLifeContainer.Size = new Size(13, 15);
            lblLifeContainer.TabIndex = 21;
            lblLifeContainer.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(57, 67);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 20;
            label15.Text = "1";
            // 
            // trkLifeContainer
            // 
            trkLifeContainer.Location = new Point(51, 85);
            trkLifeContainer.Maximum = 8;
            trkLifeContainer.Minimum = 1;
            trkLifeContainer.Name = "trkLifeContainer";
            trkLifeContainer.Size = new Size(165, 45);
            trkLifeContainer.TabIndex = 19;
            trkLifeContainer.TickFrequency = 2;
            trkLifeContainer.TickStyle = TickStyle.None;
            trkLifeContainer.Value = 1;
            trkLifeContainer.Scroll += trkLifeContainer_Scroll;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 36);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 18;
            label16.Text = "Magic";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(188, 18);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 17;
            label17.Text = "8";
            // 
            // lblMagicContainer
            // 
            lblMagicContainer.AutoSize = true;
            lblMagicContainer.Location = new Point(126, 18);
            lblMagicContainer.Name = "lblMagicContainer";
            lblMagicContainer.Size = new Size(13, 15);
            lblMagicContainer.TabIndex = 16;
            lblMagicContainer.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(56, 18);
            label19.Name = "label19";
            label19.Size = new Size(13, 15);
            label19.TabIndex = 15;
            label19.Text = "1";
            // 
            // trkMagicContainer
            // 
            trkMagicContainer.Location = new Point(50, 36);
            trkMagicContainer.Maximum = 8;
            trkMagicContainer.Minimum = 1;
            trkMagicContainer.Name = "trkMagicContainer";
            trkMagicContainer.Size = new Size(165, 45);
            trkMagicContainer.TabIndex = 14;
            trkMagicContainer.TickFrequency = 2;
            trkMagicContainer.TickStyle = TickStyle.None;
            trkMagicContainer.Value = 1;
            trkMagicContainer.Scroll += trkMagicContainer_Scroll;
            // 
            // grpTechnique
            // 
            grpTechnique.Controls.Add(chkUpward);
            grpTechnique.Controls.Add(chkDownward);
            grpTechnique.Location = new Point(485, 128);
            grpTechnique.Name = "grpTechnique";
            grpTechnique.Size = new Size(148, 189);
            grpTechnique.TabIndex = 6;
            grpTechnique.TabStop = false;
            grpTechnique.Text = "Techniques";
            // 
            // chkUpward
            // 
            chkUpward.AutoSize = true;
            chkUpward.Location = new Point(15, 44);
            chkUpward.Name = "chkUpward";
            chkUpward.Size = new Size(104, 19);
            chkUpward.TabIndex = 2;
            chkUpward.Text = "Upward Thrust";
            chkUpward.UseVisualStyleBackColor = true;
            // 
            // chkDownward
            // 
            chkDownward.AutoSize = true;
            chkDownward.Location = new Point(15, 19);
            chkDownward.Name = "chkDownward";
            chkDownward.Size = new Size(120, 19);
            chkDownward.TabIndex = 1;
            chkDownward.Text = "Downward Thrust";
            chkDownward.UseVisualStyleBackColor = true;
            // 
            // grpSpells
            // 
            grpSpells.Controls.Add(chkThunder);
            grpSpells.Controls.Add(chkFairy);
            grpSpells.Controls.Add(chkSpell);
            grpSpells.Controls.Add(chkLife);
            grpSpells.Controls.Add(chkReflect);
            grpSpells.Controls.Add(chkJump);
            grpSpells.Controls.Add(chkFire);
            grpSpells.Controls.Add(chkShield);
            grpSpells.Location = new Point(15, 326);
            grpSpells.Name = "grpSpells";
            grpSpells.Size = new Size(271, 82);
            grpSpells.TabIndex = 7;
            grpSpells.TabStop = false;
            grpSpells.Text = "Spells";
            // 
            // chkThunder
            // 
            chkThunder.AutoSize = true;
            chkThunder.Location = new Point(192, 47);
            chkThunder.Name = "chkThunder";
            chkThunder.Size = new Size(71, 19);
            chkThunder.TabIndex = 8;
            chkThunder.Text = "Thunder";
            chkThunder.UseVisualStyleBackColor = true;
            // 
            // chkFairy
            // 
            chkFairy.AutoSize = true;
            chkFairy.Location = new Point(192, 22);
            chkFairy.Name = "chkFairy";
            chkFairy.Size = new Size(51, 19);
            chkFairy.TabIndex = 7;
            chkFairy.Text = "Fairy";
            chkFairy.UseVisualStyleBackColor = true;
            // 
            // chkSpell
            // 
            chkSpell.AutoSize = true;
            chkSpell.Location = new Point(130, 47);
            chkSpell.Name = "chkSpell";
            chkSpell.Size = new Size(51, 19);
            chkSpell.TabIndex = 6;
            chkSpell.Text = "Spell";
            chkSpell.UseVisualStyleBackColor = true;
            // 
            // chkLife
            // 
            chkLife.AutoSize = true;
            chkLife.Location = new Point(130, 22);
            chkLife.Name = "chkLife";
            chkLife.Size = new Size(45, 19);
            chkLife.TabIndex = 5;
            chkLife.Text = "Life";
            chkLife.UseVisualStyleBackColor = true;
            // 
            // chkReflect
            // 
            chkReflect.AutoSize = true;
            chkReflect.Location = new Point(67, 47);
            chkReflect.Name = "chkReflect";
            chkReflect.Size = new Size(62, 19);
            chkReflect.TabIndex = 4;
            chkReflect.Text = "Reflect";
            chkReflect.UseVisualStyleBackColor = true;
            // 
            // chkJump
            // 
            chkJump.AutoSize = true;
            chkJump.Location = new Point(67, 22);
            chkJump.Name = "chkJump";
            chkJump.Size = new Size(55, 19);
            chkJump.TabIndex = 3;
            chkJump.Text = "Jump";
            chkJump.UseVisualStyleBackColor = true;
            // 
            // chkFire
            // 
            chkFire.AutoSize = true;
            chkFire.Location = new Point(8, 47);
            chkFire.Name = "chkFire";
            chkFire.Size = new Size(45, 19);
            chkFire.TabIndex = 2;
            chkFire.Text = "Fire";
            chkFire.UseVisualStyleBackColor = true;
            // 
            // chkShield
            // 
            chkShield.AutoSize = true;
            chkShield.Location = new Point(8, 22);
            chkShield.Name = "chkShield";
            chkShield.Size = new Size(58, 19);
            chkShield.TabIndex = 1;
            chkShield.Text = "Shield";
            chkShield.UseVisualStyleBackColor = true;
            // 
            // grpItems
            // 
            grpItems.Controls.Add(chkHammer);
            grpItems.Controls.Add(chkBoots);
            grpItems.Controls.Add(chkMagicKey);
            grpItems.Controls.Add(chkRaft);
            grpItems.Controls.Add(chkFlute);
            grpItems.Controls.Add(chkGlove);
            grpItems.Controls.Add(chkCross);
            grpItems.Controls.Add(chkCandle);
            grpItems.Location = new Point(292, 326);
            grpItems.Name = "grpItems";
            grpItems.Size = new Size(311, 82);
            grpItems.TabIndex = 9;
            grpItems.TabStop = false;
            grpItems.Text = "Items";
            // 
            // chkHammer
            // 
            chkHammer.AutoSize = true;
            chkHammer.Location = new Point(218, 47);
            chkHammer.Name = "chkHammer";
            chkHammer.Size = new Size(73, 19);
            chkHammer.TabIndex = 8;
            chkHammer.Text = "Hammer";
            chkHammer.UseVisualStyleBackColor = true;
            // 
            // chkBoots
            // 
            chkBoots.AutoSize = true;
            chkBoots.Location = new Point(218, 22);
            chkBoots.Name = "chkBoots";
            chkBoots.Size = new Size(56, 19);
            chkBoots.TabIndex = 7;
            chkBoots.Text = "Boots";
            chkBoots.UseVisualStyleBackColor = true;
            // 
            // chkMagicKey
            // 
            chkMagicKey.AutoSize = true;
            chkMagicKey.Location = new Point(134, 47);
            chkMagicKey.Name = "chkMagicKey";
            chkMagicKey.Size = new Size(81, 19);
            chkMagicKey.TabIndex = 6;
            chkMagicKey.Text = "Magic Key";
            chkMagicKey.UseVisualStyleBackColor = true;
            // 
            // chkRaft
            // 
            chkRaft.AutoSize = true;
            chkRaft.Location = new Point(134, 22);
            chkRaft.Name = "chkRaft";
            chkRaft.Size = new Size(47, 19);
            chkRaft.TabIndex = 5;
            chkRaft.Text = "Raft";
            chkRaft.UseVisualStyleBackColor = true;
            // 
            // chkFlute
            // 
            chkFlute.AutoSize = true;
            chkFlute.Location = new Point(71, 47);
            chkFlute.Name = "chkFlute";
            chkFlute.Size = new Size(52, 19);
            chkFlute.TabIndex = 4;
            chkFlute.Text = "Flute";
            chkFlute.UseVisualStyleBackColor = true;
            // 
            // chkGlove
            // 
            chkGlove.AutoSize = true;
            chkGlove.Location = new Point(71, 22);
            chkGlove.Name = "chkGlove";
            chkGlove.Size = new Size(56, 19);
            chkGlove.TabIndex = 3;
            chkGlove.Text = "Glove";
            chkGlove.UseVisualStyleBackColor = true;
            // 
            // chkCross
            // 
            chkCross.AutoSize = true;
            chkCross.Location = new Point(8, 47);
            chkCross.Name = "chkCross";
            chkCross.Size = new Size(55, 19);
            chkCross.TabIndex = 2;
            chkCross.Text = "Cross";
            chkCross.UseVisualStyleBackColor = true;
            // 
            // chkCandle
            // 
            chkCandle.AutoSize = true;
            chkCandle.Location = new Point(8, 22);
            chkCandle.Name = "chkCandle";
            chkCandle.Size = new Size(63, 19);
            chkCandle.TabIndex = 1;
            chkCandle.Text = "Candle";
            chkCandle.UseVisualStyleBackColor = true;
            // 
            // grpPalaceSeals
            // 
            grpPalaceSeals.Controls.Add(chkThreeEyeRock);
            grpPalaceSeals.Controls.Add(chkIsland);
            grpPalaceSeals.Controls.Add(chkSeaPalace);
            grpPalaceSeals.Controls.Add(chkMidoro);
            grpPalaceSeals.Controls.Add(chkMazePalace);
            grpPalaceSeals.Controls.Add(chkParapa);
            grpPalaceSeals.Location = new Point(12, 414);
            grpPalaceSeals.Name = "grpPalaceSeals";
            grpPalaceSeals.Size = new Size(343, 92);
            grpPalaceSeals.TabIndex = 10;
            grpPalaceSeals.TabStop = false;
            grpPalaceSeals.Text = "Palace Seals";
            // 
            // chkThreeEyeRock
            // 
            chkThreeEyeRock.AutoSize = true;
            chkThreeEyeRock.Location = new Point(229, 47);
            chkThreeEyeRock.Name = "chkThreeEyeRock";
            chkThreeEyeRock.Size = new Size(106, 19);
            chkThreeEyeRock.TabIndex = 12;
            chkThreeEyeRock.Text = "Three Eye Rock";
            chkThreeEyeRock.UseVisualStyleBackColor = true;
            // 
            // chkIsland
            // 
            chkIsland.AutoSize = true;
            chkIsland.Location = new Point(229, 22);
            chkIsland.Name = "chkIsland";
            chkIsland.Size = new Size(94, 19);
            chkIsland.TabIndex = 11;
            chkIsland.Text = "Island Palace";
            chkIsland.UseVisualStyleBackColor = true;
            // 
            // chkSeaPalace
            // 
            chkSeaPalace.AutoSize = true;
            chkSeaPalace.Location = new Point(114, 47);
            chkSeaPalace.Name = "chkSeaPalace";
            chkSeaPalace.Size = new Size(81, 19);
            chkSeaPalace.TabIndex = 10;
            chkSeaPalace.Text = "Sea Palace";
            chkSeaPalace.UseVisualStyleBackColor = true;
            // 
            // chkMidoro
            // 
            chkMidoro.AutoSize = true;
            chkMidoro.Location = new Point(114, 22);
            chkMidoro.Name = "chkMidoro";
            chkMidoro.Size = new Size(107, 19);
            chkMidoro.TabIndex = 9;
            chkMidoro.Text = "Midoro Swamp";
            chkMidoro.UseVisualStyleBackColor = true;
            // 
            // chkMazePalace
            // 
            chkMazePalace.AutoSize = true;
            chkMazePalace.Location = new Point(10, 47);
            chkMazePalace.Name = "chkMazePalace";
            chkMazePalace.Size = new Size(91, 19);
            chkMazePalace.TabIndex = 8;
            chkMazePalace.Text = "Maze Palace";
            chkMazePalace.UseVisualStyleBackColor = true;
            // 
            // chkParapa
            // 
            chkParapa.AutoSize = true;
            chkParapa.Location = new Point(10, 22);
            chkParapa.Name = "chkParapa";
            chkParapa.Size = new Size(98, 19);
            chkParapa.TabIndex = 7;
            chkParapa.Text = "Parapa Desert";
            chkParapa.UseVisualStyleBackColor = true;
            // 
            // grpKeys
            // 
            grpKeys.Controls.Add(label20);
            grpKeys.Controls.Add(lblKeys);
            grpKeys.Controls.Add(label22);
            grpKeys.Controls.Add(trkKeys);
            grpKeys.Location = new Point(361, 414);
            grpKeys.Name = "grpKeys";
            grpKeys.Size = new Size(200, 92);
            grpKeys.TabIndex = 11;
            grpKeys.TabStop = false;
            grpKeys.Text = "Keys";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(156, 16);
            label20.Name = "label20";
            label20.Size = new Size(13, 15);
            label20.TabIndex = 7;
            label20.Text = "9";
            // 
            // lblKeys
            // 
            lblKeys.AutoSize = true;
            lblKeys.Location = new Point(94, 16);
            lblKeys.Name = "lblKeys";
            lblKeys.Size = new Size(13, 15);
            lblKeys.TabIndex = 6;
            lblKeys.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(24, 16);
            label22.Name = "label22";
            label22.Size = new Size(13, 15);
            label22.TabIndex = 5;
            label22.Text = "0";
            // 
            // trkKeys
            // 
            trkKeys.Location = new Point(18, 34);
            trkKeys.Maximum = 9;
            trkKeys.Name = "trkKeys";
            trkKeys.Size = new Size(165, 45);
            trkKeys.TabIndex = 4;
            trkKeys.TickFrequency = 3;
            trkKeys.TickStyle = TickStyle.None;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AoLicon32x32;
            pictureBox1.Location = new Point(6, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Zelda2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 510);
            Controls.Add(grpKeys);
            Controls.Add(grpPalaceSeals);
            Controls.Add(grpItems);
            Controls.Add(grpSpells);
            Controls.Add(grpTechnique);
            Controls.Add(grpContainers);
            Controls.Add(grpLevels);
            Controls.Add(grpTriforce);
            Controls.Add(grpPlayCount);
            Controls.Add(grpName);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Zelda2Form";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Zelda II SRAM Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            grpPlayCount.ResumeLayout(false);
            grpPlayCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkPlayCount).EndInit();
            grpTriforce.ResumeLayout(false);
            grpTriforce.PerformLayout();
            grpLevels.ResumeLayout(false);
            grpLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkLifeLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkMagicLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkSwordLevel).EndInit();
            grpContainers.ResumeLayout(false);
            grpContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkLifeContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkMagicContainer).EndInit();
            grpTechnique.ResumeLayout(false);
            grpTechnique.PerformLayout();
            grpSpells.ResumeLayout(false);
            grpSpells.PerformLayout();
            grpItems.ResumeLayout(false);
            grpItems.PerformLayout();
            grpPalaceSeals.ResumeLayout(false);
            grpPalaceSeals.PerformLayout();
            grpKeys.ResumeLayout(false);
            grpKeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkKeys).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem game0;
        private ToolStripMenuItem game1;
        private ToolStripMenuItem game2;
        private GroupBox grpName;
        private TextBox txtName;
        private GroupBox grpPlayCount;
        private Label label3;
        private Label lblPlayCount;
        private Label label1;
        private TrackBar trkPlayCount;
        private GroupBox grpTriforce;
        private CheckBox chkHaveTriforce;
        private OpenFileDialog openFileDialog1;
        private GroupBox grpLevels;
        private Label label7;
        private Label label8;
        private Label lblMagicLevel;
        private Label label10;
        private TrackBar trkMagicLevel;
        private Label label6;
        private Label label2;
        private Label lblSwordLevel;
        private Label label5;
        private TrackBar trkSwordLevel;
        private Label label4;
        private Label label9;
        private Label lblLifeLevel;
        private Label label12;
        private TrackBar trkLifeLevel;
        private GroupBox grpContainers;
        private Label label11;
        private Label label13;
        private Label lblLifeContainer;
        private Label label15;
        private TrackBar trkLifeContainer;
        private Label label16;
        private Label label17;
        private Label lblMagicContainer;
        private Label label19;
        private TrackBar trkMagicContainer;
        private GroupBox grpTechnique;
        private CheckBox chkUpward;
        private CheckBox chkDownward;
        private GroupBox grpSpells;
        private CheckBox chkThunder;
        private CheckBox chkFairy;
        private CheckBox chkSpell;
        private CheckBox chkLife;
        private CheckBox chkReflect;
        private CheckBox chkJump;
        private CheckBox chkFire;
        private CheckBox chkShield;
        private GroupBox grpItems;
        private CheckBox chkHammer;
        private CheckBox chkBoots;
        private CheckBox chkMagicKey;
        private CheckBox chkRaft;
        private CheckBox chkFlute;
        private CheckBox chkGlove;
        private CheckBox chkCross;
        private CheckBox chkCandle;
        private GroupBox grpPalaceSeals;
        private CheckBox chkThreeEyeRock;
        private CheckBox chkIsland;
        private CheckBox chkSeaPalace;
        private CheckBox chkMidoro;
        private CheckBox chkMazePalace;
        private CheckBox chkParapa;
        private GroupBox grpKeys;
        private Label label20;
        private Label lblKeys;
        private Label label22;
        private TrackBar trkKeys;
        private PictureBox pictureBox1;
    }
}