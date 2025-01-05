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

            txtName.Text = sram.getName();
            numPlayCount.Value = sram.getPlayCount();
            var quest = sram.getQuest();
            chkQuest1.Checked = quest == LoZEnums.Quest.FIRST;
            chkQuest2.Checked = quest == LoZEnums.Quest.SECOND;

            var sword = sram.getSword();
            chkSwordNone.Checked = sword == LoZEnums.Sword.NONE;
            chkSwordWooden.Checked = sword == LoZEnums.Sword.WOODEN;
            chkSwordWhite.Checked = sword == LoZEnums.Sword.WHITE;
            chkSwordMaster.Checked = sword == LoZEnums.Sword.MASTER;

            var arrows = sram.getArrows();
            chkArrowNone.Checked = arrows == LoZEnums.Arrow.NONE;
            chkArrowWooden.Checked = arrows == LoZEnums.Arrow.WOODEN;
            chkArrowSilver.Checked = arrows == LoZEnums.Arrow.SILVER;

            numBombCarry.Value = sram.getBombs();
            numBombCapacity.Value = sram.getBombCapacity();
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
