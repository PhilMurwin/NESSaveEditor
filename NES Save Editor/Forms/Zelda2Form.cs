using NESSaveEditor.Games.Zelda2;

namespace NESSaveEditor.Forms
{
    public partial class Zelda2Form : Form
    {
        private Zelda2SRAM? sram = null;
        private Zelda2SaveProfile currentProfile;

        public Zelda2Form(string fileName)
        {
            InitializeComponent();
            Load(fileName);
        }

        public void Load(string fileName)
        {
            sram = new Zelda2SRAM(fileName);

            int first = -1;
            var gameList = gameToolStripMenuItem.DropDownItems;
            for (int game = 2; game >= 0; game--)
            {
                if (sram.isValidGame(game))
                {
                    gameList[game].Enabled = true;
                    first = game;
                }
                else
                {
                    gameList[game].Enabled = false;
                }
            }

            if (first == -1)
            {
                MessageBox.Show("No game data is in the file you loaded.");
            }
            else
            {
                LoadGameData(first);
                ((ToolStripMenuItem)(gameList[first])).Checked = true;
            }
        }

        public void LoadGameData(int game)
        {
            sram.setCurrentGame(game);
            currentProfile = sram.getCurrentGame();

            txtName.Text = currentProfile.getName();
            trkPlayCount.Value = currentProfile.getPlayCount();
            chkHaveTriforce.Checked = currentProfile.hasTriforce();

            trkSwordLevel.Value = currentProfile.getLevel(Levels.SWORDLEVEL);
            lblSwordLevel.Text = trkSwordLevel.Value.ToString();
            trkMagicLevel.Value = currentProfile.getLevel(Levels.MAGICLEVEL);
            lblMagicLevel.Text = trkMagicLevel.Value.ToString();
            trkLifeLevel.Value = currentProfile.getLevel(Levels.LIFELEVEL);
            lblLifeLevel.Text = trkLifeLevel.Value.ToString();
            trkMagicContainer.Value = currentProfile.getContainers(Containers.MAGICCONTAINER);
            lblMagicContainer.Text = trkMagicContainer.Value.ToString();
            trkLifeContainer.Value = currentProfile.getContainers(Containers.LIFECONTAINER);
            lblLifeContainer.Text = trkLifeContainer.Value.ToString();
            chkDownward.Checked = currentProfile.hasTechnique(Techniques.DOWNWARDTHRUST);
            chkUpward.Checked = currentProfile.hasTechnique(Techniques.UPWARDTHRUST);

            chkShield.Checked = currentProfile.hasSpell(Spells.SHIELD);
            chkFire.Checked = currentProfile.hasSpell(Spells.FIRE);
            chkJump.Checked = currentProfile.hasSpell(Spells.JUMP);
            chkReflect.Checked = currentProfile.hasSpell(Spells.REFLECT);
            chkLife.Checked = currentProfile.hasSpell(Spells.LIFE);
            chkSpell.Checked = currentProfile.hasSpell(Spells.SPELL);
            chkFairy.Checked = currentProfile.hasSpell(Spells.FAIRY);
            chkThunder.Checked = currentProfile.hasSpell(Spells.THUNDER);

            chkCandle.Checked = currentProfile.hasItem(Items.CANDLE);
            chkCross.Checked = currentProfile.hasItem(Items.CROSS);
            chkGlove.Checked = currentProfile.hasItem(Items.GLOVE);
            chkFlute.Checked = currentProfile.hasItem(Items.FLUTE);
            chkRaft.Checked = currentProfile.hasItem(Items.RAFT);
            chkMagicKey.Checked = currentProfile.hasItem(Items.MAGICKEY);
            chkBoots.Checked = currentProfile.hasItem(Items.BOOTS);
            chkHammer.Checked = currentProfile.hasItem(Items.HAMMER);

            chkParapa.Checked = currentProfile.hasSeal(0);
            chkMidoro.Checked = currentProfile.hasSeal(1);
            chkIsland.Checked = currentProfile.hasSeal(2);
            chkMazePalace.Checked = currentProfile.hasSeal(3);
            chkSeaPalace.Checked = currentProfile.hasSeal(4);
            chkThreeEyeRock.Checked = currentProfile.hasSeal(5);
            trkKeys.Value = currentProfile.getKeys();
            lblKeys.Text = trkKeys.Value.ToString();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                Load(fileName);
            }
        }

        private void trkPlayCount_ValueChanged(object sender, EventArgs e)
        {
            lblPlayCount.Text = trkPlayCount.Value.ToString();
            currentProfile.setPlayCount((byte)trkPlayCount.Value);
        }

        private void trkSwordLevel_Scroll(object sender, EventArgs e)
        {
            lblSwordLevel.Text = trkSwordLevel.Value.ToString();
        }

        private void trkMagicLevel_Scroll(object sender, EventArgs e)
        {
            lblMagicLevel.Text = trkMagicLevel.Value.ToString();
        }
        private void trkLifeLevel_Scroll(object sender, EventArgs e)
        {
            lblLifeLevel.Text = trkLifeLevel.Value.ToString();
        }

        private void trkMagicContainer_Scroll(object sender, EventArgs e)
        {
            lblMagicContainer.Text = trkMagicContainer.Value.ToString();
        }
        private void trkLifeContainer_Scroll(object sender, EventArgs e)
        {
            lblLifeContainer.Text = trkLifeContainer.Value.ToString();
        }

        private void game0_Click(object sender, EventArgs e)
        {
            LoadGameData(0);
            game0.Checked = true;
            game1.Checked = game2.Checked = false;
        }

        private void game1_Click(object sender, EventArgs e)
        {
            LoadGameData(1);
            game1.Checked = true;
            game0.Checked = game2.Checked = false;
        }

        private void game2_Click(object sender, EventArgs e)
        {
            LoadGameData(2);
            game2.Checked = true;
            game0.Checked = game1.Checked = false;
        }
    }
}
