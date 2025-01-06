using NESSaveEditor.Forms;
using NESSaveEditor.Games.LoZ;

namespace NESSaveEditor
{
    public partial class Main : Form
    {
        private Form currentForm;

        public Main()
        {
            InitializeComponent();
        }

        private void SwitchGameInterface(string fileName)
        {
            this.lblOpenFile.Hide();

            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            var lozFile = new LoZSRAM(fileName);

            if (lozFile.isLoZFile())
            {
                currentForm = new LoZForm(fileName);
            }
            else
            {
                currentForm = new Zelda2Form(fileName);
            }

            currentForm.TopLevel = false; // Make the new form a child of the main form
            currentForm.Dock = DockStyle.Fill; // Ensure the new form fills the main form
            this.mainPanel.Controls.Add(currentForm); // Adds the new form to the main form

            currentForm.Show(); // Displays the new form
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                SwitchGameInterface(fileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}