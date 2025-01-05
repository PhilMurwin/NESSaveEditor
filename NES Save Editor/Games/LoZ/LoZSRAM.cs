using NESSaveEditor.Games.Zelda2;

namespace NESSaveEditor.Games.LoZ
{
    public class LoZSRAM
    {
        private string _fileName;
        public int currentProfile;
        public byte[] data;

        public LoZSRAM(string fileName)
        {
            currentProfile = -1;
            _fileName = fileName;
            load(fileName);
        }

        /// <summary>
        /// Loads the SRAM data from a file
        /// </summary>
        /// <param name="fileName">The file to load SRAM data from</param>
        private void load(string fileName)
        {
            data = File.ReadAllBytes(fileName);

            //for (int slot = 2; slot >= 0; slot--)
            //{
            //    profiles[slot] = new LoZSaveProfile(data, slot);

            //    //if (games[slot].isValid())
            //    //{
            //    //    current = slot;
            //    //}
            //}
        }

        /// <summary>
        /// Sets the current slot.
        /// </summary>
        /// <param name="slot">The new game</param>
        /// <returns>true if the current game was changed; false otherwise</returns>
        public bool setCurrentGame(int slot)
        {
            if (slot > 2)
            {
                return false;
            }

            this.currentProfile = slot;
            return true;
        }
    }
}
