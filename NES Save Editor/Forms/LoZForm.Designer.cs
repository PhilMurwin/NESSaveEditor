namespace NESSaveEditor.Forms
{
    partial class LoZForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoZForm));
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            game0 = new ToolStripMenuItem();
            game1 = new ToolStripMenuItem();
            game2 = new ToolStripMenuItem();
            grpName = new GroupBox();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            grpPlayCount = new GroupBox();
            numPlayCount = new NumericUpDown();
            grpQuest = new GroupBox();
            chkQuest2 = new RadioButton();
            chkQuest1 = new RadioButton();
            grpEquipment = new GroupBox();
            grpArrows = new GroupBox();
            chkArrowSilver = new RadioButton();
            chkArrowWooden = new RadioButton();
            chkArrowNone = new RadioButton();
            grpInventory = new GroupBox();
            grpDungeons = new GroupBox();
            grpPotionNote = new GroupBox();
            grpTreasure = new GroupBox();
            grpBombs = new GroupBox();
            numBombCapacity = new NumericUpDown();
            lblCapacity = new Label();
            lblCarrying = new Label();
            numBombCarry = new NumericUpDown();
            grpSword = new GroupBox();
            chkSwordWhite = new RadioButton();
            chkSwordWooden = new RadioButton();
            chkSwordNone = new RadioButton();
            chkSwordMaster = new RadioButton();
            menuStrip1.SuspendLayout();
            grpName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpPlayCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlayCount).BeginInit();
            grpQuest.SuspendLayout();
            grpEquipment.SuspendLayout();
            grpArrows.SuspendLayout();
            grpBombs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBombCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBombCarry).BeginInit();
            grpSword.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(623, 24);
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
            game0.Name = "game0";
            game0.Size = new Size(80, 22);
            game0.Text = "0";
            game0.Click += game0_Click;
            // 
            // game1
            // 
            game1.Name = "game1";
            game1.Size = new Size(80, 22);
            game1.Text = "1";
            game1.Click += game1_Click;
            // 
            // game2
            // 
            game2.Name = "game2";
            game2.Size = new Size(80, 22);
            game2.Text = "2";
            game2.Click += game2_Click;
            // 
            // grpName
            // 
            grpName.Controls.Add(pictureBox1);
            grpName.Controls.Add(txtName);
            grpName.Location = new Point(5, 27);
            grpName.Name = "grpName";
            grpName.Size = new Size(171, 61);
            grpName.TabIndex = 2;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoZicon32x32;
            pictureBox1.Location = new Point(6, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 23);
            txtName.TabIndex = 0;
            // 
            // grpPlayCount
            // 
            grpPlayCount.Controls.Add(numPlayCount);
            grpPlayCount.Location = new Point(182, 27);
            grpPlayCount.Name = "grpPlayCount";
            grpPlayCount.Size = new Size(81, 61);
            grpPlayCount.TabIndex = 3;
            grpPlayCount.TabStop = false;
            grpPlayCount.Text = "Play Count";
            // 
            // numPlayCount
            // 
            numPlayCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numPlayCount.Location = new Point(18, 23);
            numPlayCount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numPlayCount.Name = "numPlayCount";
            numPlayCount.Size = new Size(47, 23);
            numPlayCount.TabIndex = 0;
            // 
            // grpQuest
            // 
            grpQuest.Controls.Add(chkQuest2);
            grpQuest.Controls.Add(chkQuest1);
            grpQuest.Location = new Point(269, 27);
            grpQuest.Name = "grpQuest";
            grpQuest.Size = new Size(134, 61);
            grpQuest.TabIndex = 4;
            grpQuest.TabStop = false;
            grpQuest.Text = "Quest";
            // 
            // chkQuest2
            // 
            chkQuest2.AutoSize = true;
            chkQuest2.Location = new Point(59, 23);
            chkQuest2.Name = "chkQuest2";
            chkQuest2.Size = new Size(64, 19);
            chkQuest2.TabIndex = 2;
            chkQuest2.TabStop = true;
            chkQuest2.Text = "Second";
            chkQuest2.UseVisualStyleBackColor = true;
            // 
            // chkQuest1
            // 
            chkQuest1.AutoSize = true;
            chkQuest1.Location = new Point(6, 23);
            chkQuest1.Name = "chkQuest1";
            chkQuest1.Size = new Size(47, 19);
            chkQuest1.TabIndex = 1;
            chkQuest1.TabStop = true;
            chkQuest1.Text = "First";
            chkQuest1.UseVisualStyleBackColor = true;
            // 
            // grpEquipment
            // 
            grpEquipment.Controls.Add(grpSword);
            grpEquipment.Controls.Add(grpArrows);
            grpEquipment.Location = new Point(5, 94);
            grpEquipment.Name = "grpEquipment";
            grpEquipment.Size = new Size(387, 176);
            grpEquipment.TabIndex = 5;
            grpEquipment.TabStop = false;
            grpEquipment.Text = "Equipment";
            // 
            // grpArrows
            // 
            grpArrows.Controls.Add(chkArrowSilver);
            grpArrows.Controls.Add(chkArrowWooden);
            grpArrows.Controls.Add(chkArrowNone);
            grpArrows.Location = new Point(0, 55);
            grpArrows.Name = "grpArrows";
            grpArrows.Size = new Size(387, 42);
            grpArrows.TabIndex = 0;
            grpArrows.TabStop = false;
            grpArrows.Text = "Arrows";
            // 
            // chkArrowSilver
            // 
            chkArrowSilver.AutoSize = true;
            chkArrowSilver.Location = new Point(142, 16);
            chkArrowSilver.Name = "chkArrowSilver";
            chkArrowSilver.Size = new Size(53, 19);
            chkArrowSilver.TabIndex = 2;
            chkArrowSilver.TabStop = true;
            chkArrowSilver.Text = "Silver";
            chkArrowSilver.UseVisualStyleBackColor = true;
            // 
            // chkArrowWooden
            // 
            chkArrowWooden.AutoSize = true;
            chkArrowWooden.Location = new Point(66, 16);
            chkArrowWooden.Name = "chkArrowWooden";
            chkArrowWooden.Size = new Size(70, 19);
            chkArrowWooden.TabIndex = 1;
            chkArrowWooden.TabStop = true;
            chkArrowWooden.Text = "Wooden";
            chkArrowWooden.UseVisualStyleBackColor = true;
            // 
            // chkArrowNone
            // 
            chkArrowNone.AutoSize = true;
            chkArrowNone.Location = new Point(6, 16);
            chkArrowNone.Name = "chkArrowNone";
            chkArrowNone.Size = new Size(54, 19);
            chkArrowNone.TabIndex = 0;
            chkArrowNone.TabStop = true;
            chkArrowNone.Text = "None";
            chkArrowNone.UseVisualStyleBackColor = true;
            // 
            // grpInventory
            // 
            grpInventory.Location = new Point(411, 107);
            grpInventory.Name = "grpInventory";
            grpInventory.Size = new Size(200, 100);
            grpInventory.TabIndex = 6;
            grpInventory.TabStop = false;
            grpInventory.Text = "Inventory";
            // 
            // grpDungeons
            // 
            grpDungeons.Location = new Point(12, 276);
            grpDungeons.Name = "grpDungeons";
            grpDungeons.Size = new Size(200, 57);
            grpDungeons.TabIndex = 6;
            grpDungeons.TabStop = false;
            grpDungeons.Text = "Dungeons";
            // 
            // grpPotionNote
            // 
            grpPotionNote.Location = new Point(389, 343);
            grpPotionNote.Name = "grpPotionNote";
            grpPotionNote.Size = new Size(178, 100);
            grpPotionNote.TabIndex = 6;
            grpPotionNote.TabStop = false;
            grpPotionNote.Text = "Potion Note";
            // 
            // grpTreasure
            // 
            grpTreasure.Location = new Point(18, 367);
            grpTreasure.Name = "grpTreasure";
            grpTreasure.Size = new Size(200, 92);
            grpTreasure.TabIndex = 6;
            grpTreasure.TabStop = false;
            grpTreasure.Text = "Treasure";
            // 
            // grpBombs
            // 
            grpBombs.Controls.Add(numBombCapacity);
            grpBombs.Controls.Add(lblCapacity);
            grpBombs.Controls.Add(lblCarrying);
            grpBombs.Controls.Add(numBombCarry);
            grpBombs.Location = new Point(233, 377);
            grpBombs.Name = "grpBombs";
            grpBombs.Size = new Size(127, 82);
            grpBombs.TabIndex = 6;
            grpBombs.TabStop = false;
            grpBombs.Text = "Bombs";
            // 
            // numBombCapacity
            // 
            numBombCapacity.Location = new Point(67, 49);
            numBombCapacity.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numBombCapacity.Name = "numBombCapacity";
            numBombCapacity.Size = new Size(47, 23);
            numBombCapacity.TabIndex = 3;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(5, 51);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 1;
            lblCapacity.Text = "Capacity:";
            // 
            // lblCarrying
            // 
            lblCarrying.AutoSize = true;
            lblCarrying.Location = new Point(6, 19);
            lblCarrying.Name = "lblCarrying";
            lblCarrying.Size = new Size(55, 15);
            lblCarrying.TabIndex = 0;
            lblCarrying.Text = "Carrying:";
            // 
            // numBombCarry
            // 
            numBombCarry.Location = new Point(67, 17);
            numBombCarry.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numBombCarry.Name = "numBombCarry";
            numBombCarry.Size = new Size(47, 23);
            numBombCarry.TabIndex = 2;
            // 
            // grpSword
            // 
            grpSword.Controls.Add(chkSwordMaster);
            grpSword.Controls.Add(chkSwordWhite);
            grpSword.Controls.Add(chkSwordWooden);
            grpSword.Controls.Add(chkSwordNone);
            grpSword.Location = new Point(0, 13);
            grpSword.Name = "grpSword";
            grpSword.Size = new Size(387, 42);
            grpSword.TabIndex = 3;
            grpSword.TabStop = false;
            grpSword.Text = "Sword";
            // 
            // chkSwordWhite
            // 
            chkSwordWhite.AutoSize = true;
            chkSwordWhite.Location = new Point(142, 16);
            chkSwordWhite.Name = "chkSwordWhite";
            chkSwordWhite.Size = new Size(56, 19);
            chkSwordWhite.TabIndex = 2;
            chkSwordWhite.TabStop = true;
            chkSwordWhite.Text = "White";
            chkSwordWhite.UseVisualStyleBackColor = true;
            // 
            // chkSwordWooden
            // 
            chkSwordWooden.AutoSize = true;
            chkSwordWooden.Location = new Point(66, 16);
            chkSwordWooden.Name = "chkSwordWooden";
            chkSwordWooden.Size = new Size(70, 19);
            chkSwordWooden.TabIndex = 1;
            chkSwordWooden.TabStop = true;
            chkSwordWooden.Text = "Wooden";
            chkSwordWooden.UseVisualStyleBackColor = true;
            // 
            // chkSwordNone
            // 
            chkSwordNone.AutoSize = true;
            chkSwordNone.Location = new Point(6, 16);
            chkSwordNone.Name = "chkSwordNone";
            chkSwordNone.Size = new Size(54, 19);
            chkSwordNone.TabIndex = 0;
            chkSwordNone.TabStop = true;
            chkSwordNone.Text = "None";
            chkSwordNone.UseVisualStyleBackColor = true;
            // 
            // chkSwordMaster
            // 
            chkSwordMaster.AutoSize = true;
            chkSwordMaster.Location = new Point(204, 17);
            chkSwordMaster.Name = "chkSwordMaster";
            chkSwordMaster.Size = new Size(61, 19);
            chkSwordMaster.TabIndex = 3;
            chkSwordMaster.TabStop = true;
            chkSwordMaster.Text = "Master";
            chkSwordMaster.UseVisualStyleBackColor = true;
            // 
            // LoZForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 471);
            Controls.Add(grpInventory);
            Controls.Add(grpDungeons);
            Controls.Add(grpPotionNote);
            Controls.Add(grpTreasure);
            Controls.Add(grpBombs);
            Controls.Add(grpEquipment);
            Controls.Add(grpQuest);
            Controls.Add(grpPlayCount);
            Controls.Add(grpName);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "LoZForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpPlayCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPlayCount).EndInit();
            grpQuest.ResumeLayout(false);
            grpQuest.PerformLayout();
            grpEquipment.ResumeLayout(false);
            grpArrows.ResumeLayout(false);
            grpArrows.PerformLayout();
            grpBombs.ResumeLayout(false);
            grpBombs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBombCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBombCarry).EndInit();
            grpSword.ResumeLayout(false);
            grpSword.PerformLayout();
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
        private PictureBox pictureBox1;
        private GroupBox grpPlayCount;
        private GroupBox grpQuest;
        private NumericUpDown numPlayCount;
        private RadioButton chkQuest2;
        private RadioButton chkQuest1;
        private GroupBox grpEquipment;
        private GroupBox grpInventory;
        private GroupBox grpDungeons;
        private GroupBox grpPotionNote;
        private GroupBox grpTreasure;
        private GroupBox grpBombs;
        private NumericUpDown numBombCapacity;
        private Label lblCapacity;
        private Label lblCarrying;
        private NumericUpDown numBombCarry;
        private GroupBox grpArrows;
        private RadioButton chkArrowSilver;
        private RadioButton chkArrowWooden;
        private RadioButton chkArrowNone;
        private GroupBox grpSword;
        private RadioButton chkSwordMaster;
        private RadioButton chkSwordWhite;
        private RadioButton chkSwordWooden;
        private RadioButton chkSwordNone;
    }
}