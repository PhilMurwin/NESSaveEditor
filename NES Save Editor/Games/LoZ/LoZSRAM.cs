namespace NESSaveEditor.Games.LoZ
{
    public class LoZSRAM
    {
        private string _fileName;
        public int currentProfile;
        public byte[] data;
        private bool[] valid = new bool[3];
        private string emptyName = "        ";

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

            for (int slot = 2; slot >= 0; slot--)
            {
                valid[slot] = false;
                var calcChecksum = this.checksum(slot);
                var actualChecksum = this.getChecksum(slot);
                if (calcChecksum == actualChecksum)
                {
                    valid[slot] = true;
                    setCurrentGame(slot);

                    if (this.getName() == emptyName)
                    {
                        // empty slot
                        valid[slot] = false;
                    }
                }
            }
        }

        public bool isLoZFile()
        {
            return valid.Any(v => v);
        }

        public bool isValidGame(int slot)
        {
            return valid[slot];
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
