namespace NESSaveEditor.Games.Zelda2
{
    public class Zelda2SaveProfile
    {
        private const int PROFILE_SIZE = 0x32;
        private const int LEVEL_OFFSET = 0x00; // 0
        private const int SPELL_OFFSET = 0x04; // 4
        private const int CONTAINER_OFFSET = 0x0C; // 12
        private const int ITEM_OFFSET = 0x0E; // 14
        private const int PALACE_OFFSET = 0x16; // 22
        private const int KEYS_OFFSET = 0x1C; // 28
        private const int SEAL_OFFSET = 0x1D; // 29
        private const int TECHNIQUE_OFFSET = 0x1F; // 31
        private const int PLAY_COUNT_OFFSET = 0x28; // 40
        private const int TRIFORCE_OFFSET = 0x29; // 41
        private const int NAME_OFFSET = 0x2A; // 42

        private byte[] nvram;
        private bool modified { get; set; }
        private bool valid { get; set; }

        /// <summary>
        /// Constructor for a SaveSlot
        /// </summary>
        /// <param name="nvram">The SRAM data for this SaveSlot</param>
        public Zelda2SaveProfile(byte[] nvram)
        {
            this.nvram = new byte[PROFILE_SIZE];
            Array.Copy(nvram, this.nvram, PROFILE_SIZE);
            valid = false;
            for (int i = 0; i < 8; i++)
            {
                if (nvram[NAME_OFFSET + i] != '\xF4')
                {
                    valid = true;
                    break;
                }
            }
            //valid = nvram[NAME_OFFSET] != '\xF4';
            modified = false;
            checkForNewGame();
        }

        /// <summary>
        /// Queries if this SaveSlot has been modified
        /// </summary>
        /// <returns>true if modified; false otherwise</returns>
        public bool isModified() => modified;

        /// <summary>
        /// Queries if this SaveSlot is valid.
        /// </summary>
        /// <returns>true if valid; false otherwise</returns>
        public bool isValid() => valid;

        /// <summary>
        /// Fixes data for a new quest game.
        /// </summary>
        public void checkForNewGame()
        {
            if (nvram[TRIFORCE_OFFSET] == 1)
            {
                setTriforce(true);

                setContainers(Containers.MAGICCONTAINER, 4);
                setContainers(Containers.LIFECONTAINER, 4);

                setItem(Items.CANDLE, false);
                setItem(Items.GLOVE, false);
                setItem(Items.RAFT, false);
                setItem(Items.BOOTS, false);
                setItem(Items.CROSS, false);
                setItem(Items.FLUTE, false);
                setItem(Items.MAGICKEY, false);
                setItem(Items.HAMMER, false);

                for (int palace = 0; palace < 6; palace++)
                {
                    setSeal(palace, false);
                }

                setKeys(0);

                modified = false;
            }
        }

        /// <summary>
        /// Gets the name of the character
        /// </summary>
        /// <returns>The name</returns>
        public string getName()
        {
            var name = "";

            for (int i = 0; i < 8; i++)
            {
                char letter = fromNES(nvram[NAME_OFFSET + i]);
                name += letter;
            }

            return name;
        }

        /// <summary>
        /// Sets the name of the character
        /// </summary>
        /// <param name="name">The new name</param>
        public void setName(string name)
        {
            var length = name.Length;

            for (int i = 0; i < 8; i++)
            {
                byte letter;

                if (length - 1 < i)
                {
                    letter = 0xF4;
                }
                else
                {
                    letter = toNES(name[i]);
                }

                nvram[NAME_OFFSET + i] = letter;
            }

            modified = true;
        }

        public int getPlayCount() => nvram[PLAY_COUNT_OFFSET];
        public void setPlayCount(byte value)
        {
            nvram[PLAY_COUNT_OFFSET] = value;
            modified = true;
        }

        public bool hasTriforce() => nvram[TRIFORCE_OFFSET] == 2;
        public void setTriforce(bool value)
        {
            nvram[TRIFORCE_OFFSET] = (byte)(value ? 2 : 0);
            modified = true;
        }

        public int getLevel(Levels which) => nvram[LEVEL_OFFSET + (int)which];
        public void setLevel(Levels which, byte value)
        {
            nvram[LEVEL_OFFSET + (int)which] = value;
            modified = true;
        }

        public int getContainers(Containers which) => nvram[CONTAINER_OFFSET + (int)which];
        public void setContainers(Containers which, byte value)
        {
            nvram[CONTAINER_OFFSET + (int)which] = value;
            modified = true;
        }

        public bool hasTechnique(Techniques technique) => (nvram[TECHNIQUE_OFFSET] & (int)technique) > 0;
        public void setTechnique(Techniques technique, bool value)
        {
            if (value)
            {
                nvram[TECHNIQUE_OFFSET] |= (byte)technique;
            }
            else
            {
                nvram[TECHNIQUE_OFFSET] &= (byte)~technique;
            }
            modified = true;
        }

        public bool hasSpell(Spells spell) => nvram[SPELL_OFFSET + (int)spell] >= 1;
        public void setSpell(Spells spell, bool value)
        {
            nvram[SPELL_OFFSET + (int)spell] = (byte)(value ? 1 : 0);
            modified = true;
        }

        public bool hasItem(Items item) => nvram[ITEM_OFFSET + (int)item] == 1;
        public void setItem(Items item, bool value)
        {
            nvram[ITEM_OFFSET + (int)item] = (byte)(value ? 1 : 0);
            modified = true;
        }

        public bool hasSeal(int palace) => nvram[PALACE_OFFSET + palace] == palace + 1;
        public void setSeal(int palace, bool value)
        {
            if (value)
            {
                nvram[SEAL_OFFSET]--;
            }
            else
            {
                nvram[SEAL_OFFSET]++;
            }

            nvram[PALACE_OFFSET + palace] = (byte)(value ? palace + 1 : 0);
            modified = true;
        }

        public int getKeys() => nvram[KEYS_OFFSET];
        public void setKeys(byte value)
        {
            nvram[KEYS_OFFSET] = value;
            modified = true;
        }

        /// <summary>
        /// Translates a character from the Zelda alphabet to ASCII
        /// </summary>
        /// <param name="letter">The letter to translate.</param>
        /// <returns>The translated letter.</returns>
        private static char fromNES(byte letter)
        {
            if (letter >= 0xD0 && letter <= 0xD9)
            {
                return (char)('0' + (letter - 0xD0));
            }
            else if (letter >= 0xDA && letter <= 0xF3)
            {
                return (char)('A' + (letter - 0xDA));
            }
            else if (letter == 0xCF)
            {
                return '.';
            }

            return ' ';
        }

        /// <summary>
        /// Translates a character from ASCII to the Zelda alphabet
        /// </summary>
        /// <param name="letter">The letter to translate</param>
        /// <returns>The translated letter</returns>
        private static byte toNES(char letter)
        {
            if (letter >= '0' && letter <= '9')
            {
                return (byte)(0xD0 + (letter - '0'));
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                return (byte)(0xDA + (letter - 'A'));
            }
            return 0xF4;
        }
    }
}
