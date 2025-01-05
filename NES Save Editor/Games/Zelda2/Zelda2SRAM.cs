namespace NESSaveEditor.Games.Zelda2
{
    public class Zelda2SRAM
    {
        private const int GAME_SIZE = 0x32;
        private const int SRAM_SIZE = 0x2000;
        private const int GAME_OFFSET = 0x1402;

        private string _fileName;
        private Zelda2SaveProfile[] games = new Zelda2SaveProfile[3];
        private int current;
        private byte[] data;

        public Zelda2SRAM(string fileName)
        {
            current = -1;
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
                var ix = GAME_OFFSET + slot * GAME_SIZE;
                byte[] profile = new byte[GAME_SIZE];
                Array.Copy(data, ix, profile, 0, GAME_SIZE);
                games[slot] = new Zelda2SaveProfile(profile);

                if (games[slot].isValid())
                {
                    current = slot;
                }
            }

            // Create backup file
            File.WriteAllBytes(fileName + ".bak", data);
        }

        /// <summary>
        /// Checks if this SRAM file has been modified
        /// </summary>
        /// <returns>true if modified; false otherwise</returns>
        public bool isModified()
        {
            if (current == -1)
            {
                return false;
            }

            return games.Any(g => g.isModified());
        }

        /// <summary>
        /// Gets the current game
        /// </summary>
        /// <returns>The current game data</returns>
        public Zelda2SaveProfile? getCurrentGame()
        {
            if (current == -1)
            {
                return null;
            }

            return games[current];
        }

        /// <summary>
        /// Sets the current game.
        /// </summary>
        /// <param name="current">The new game</param>
        /// <returns>true if the current game was changed; false otherwise</returns>
        public bool setCurrentGame(int current)
        {
            if (current > 2)
            {
                return false;
            }
            if (!isValidGame(current))
            {
                return false;
            }

            this.current = current;
            return true;
        }

        /// <summary>
        /// Checks if a particular game is valid
        /// </summary>
        /// <param name="game">The game to check</param>
        /// <returns>true if the game is valid; false otherwise</returns>
        public bool isValidGame(int game)
        {
            return games[game].isValid();
        }

        /// <summary>
        /// Saves the SRAM data to the file it was opened from.
        /// </summary>
        /// <returns>true if the data was saved; false otherwise</returns>
        public bool save()
        {
            return save(_fileName);
        }

        /// <summary>
        /// Saves the SRAM data to a particular file
        /// </summary>
        /// <param name="fileName">The file to save to</param>
        /// <returns>true if the data was saved; false otherwise</returns>
        public bool save(string fileName)
        {
            return false;
        }
    }
}
