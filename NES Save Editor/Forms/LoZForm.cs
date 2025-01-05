using NESSaveEditor.Games.LoZ;

namespace NESSaveEditor.Forms
{
    public partial class LoZForm : Form
    {
        private LoZSRAM? sram = null;

        public LoZForm(string fileName)
        {
            InitializeComponent();
            Load(fileName);
        }

        public void Load(string fileName)
        {
            sram = new LoZSRAM(fileName);

            int first = -1;
            var profileList = gameToolStripMenuItem.DropDownItems;

            for (int slot = 2; slot >= 0; slot--)
            {
                //if (sram.isValidGame(slot))
                {
                    profileList[slot].Enabled = true;
                    first = slot;
                }
                //else
                //{
                //    profileList[slot].Enabled = false;
                //}
            }

            if (first == -1)
            {
                MessageBox.Show("No game data is in the file you loaded.");
            }
            else
            {
                LoadGameData(first);
                ((ToolStripMenuItem)(profileList[first])).Checked = true;
            }
        }

        public void LoadGameData(int profileNumber)
        {
            sram.setCurrentGame(profileNumber);

            // Get Player Details
            txtName.Text = sram.getName();
            numPlayCount.Value = sram.getPlayCount();
            var quest = sram.getQuest();
            chkQuest1.Checked = quest == LoZEnums.Quest.FIRST;
            chkQuest2.Checked = quest == LoZEnums.Quest.SECOND;

            // Get Equipment
            var sword = sram.getSword();
            chkSwordNone.Checked = sword == LoZEnums.Sword.NONE;
            chkSwordWooden.Checked = sword == LoZEnums.Sword.WOODEN;
            chkSwordWhite.Checked = sword == LoZEnums.Sword.WHITE;
            chkSwordMaster.Checked = sword == LoZEnums.Sword.MASTER;

            var arrows = sram.getArrows();
            chkArrowNone.Checked = arrows == LoZEnums.Arrow.NONE;
            chkArrowWooden.Checked = arrows == LoZEnums.Arrow.WOODEN;
            chkArrowSilver.Checked = arrows == LoZEnums.Arrow.SILVER;

            var candle = sram.getCandle();
            chkCandleNone.Checked = candle == LoZEnums.Candle.NONE;
            chkCandleBlue.Checked = candle == LoZEnums.Candle.BLUE;
            chkCandleRed.Checked = candle == LoZEnums.Candle.RED;

            var potion = sram.getPotion();
            chkPotionNone.Checked = potion == LoZEnums.Potion.NONE;
            chkPotionBlue.Checked = potion == LoZEnums.Potion.BLUE;
            chkPotionRed.Checked = potion == LoZEnums.Potion.RED;

            var ring = sram.getRing();
            chkRingNone.Checked = ring == LoZEnums.Ring.NONE;
            chkRingBlue.Checked = ring == LoZEnums.Ring.BLUE;
            chkRingRed.Checked = ring == LoZEnums.Ring.RED;

            // Get Inventory
            chkBoomerang.Checked = sram.hasItem(LoZEnums.Items.BOOMERANG);
            chkMagicBoomerang.Checked = sram.hasItem(LoZEnums.Items.MAGICBOOMERANG);
            chkPowerBracelet.Checked = sram.hasItem(LoZEnums.Items.POWERBRACELET);
            chkMagicShield.Checked = sram.hasItem(LoZEnums.Items.MAGICSHIELD);
            chkBow.Checked = sram.hasItem(LoZEnums.Items.BOW);
            chkRaft.Checked = sram.hasItem(LoZEnums.Items.RAFT);
            chkLadder.Checked = sram.hasItem(LoZEnums.Items.LADDER);
            chkMagicKey.Checked = sram.hasItem(LoZEnums.Items.MAGICKEY);
            chkBook.Checked = sram.hasItem(LoZEnums.Items.BOOK);
            chkWhistle.Checked = sram.hasItem(LoZEnums.Items.WHISTLE);
            chkWand.Checked = sram.hasItem(LoZEnums.Items.WAND);
            chkBait.Checked = sram.hasItem(LoZEnums.Items.BAIT);

            // Get Potion Note
            var note = sram.getNote();
            chkPotionMan.Checked = note == LoZEnums.Note.OLDMAN;
            chkPotionLink.Checked = note == LoZEnums.Note.LINK;
            chkPotionLady.Checked = note == LoZEnums.Note.OLDWOMAN;

            // Get Treasure
            numRupees.Value = sram.getRupees();
            numKeys.Value = sram.getKeys();
            numHearts.Value = sram.getHeartContainers();

            // Get Bombs
            numBombCarry.Value = sram.getBombs();
            numBombCapacity.Value = sram.getBombCapacity();

            // Get Dungeon Details
            CheckBox[] compassCheckboxes = { chkCompass1, chkCompass2, chkCompass3, chkCompass4, chkCompass5, chkCompass6, chkCompass7, chkCompass8, chkCompass9 };
            CheckBox[] mapCheckboxes = {chkMap1, chkMap2, chkMap3, chkMap4, chkMap5, chkMap6, chkMap7, chkMap8, chkMap9 };
            CheckBox[] triforceCheckboxes = {chkTriforce1,  chkTriforce2, chkTriforce3, chkTriforce4, chkTriforce5, chkTriforce6, chkTriforce7, chkTriforce8};

            for(int i = 1; i <= 9; i ++)
            {
                compassCheckboxes[i - 1].Checked = sram.hasCompass(i);
                mapCheckboxes[i - 1].Checked = sram.hasMap(i);
                if (i < 9)
                {
                    triforceCheckboxes[i - 1].Checked = sram.hasTriforce(i);
                }
            }
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
            game2.Checked = true;
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
