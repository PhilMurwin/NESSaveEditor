using static NESSaveEditor.Games.LoZ.LoZEnums;

namespace NESSaveEditor.Games.LoZ
{
    public static class LoZSaveProfile
    {
        private const int PROFILE_SIZE = 0x32;
        private const int ARROWS_OFFSET = 0x2;
        private const int BOMBCAPACITY_OFFSET = 0x25;
        private const int BOMBS_OFFSET = 0x1;
        private const int CANDLE_OFFSET = 0x4;
        private const int CHECKSUM_OFFSET = 0x524;
        private const int COMPASS_OFFSET = 0x10;
        private const int COMPASS9_OFFSET = 0x12;
        private const int HEARTCONTAINERS_OFFSET = 0x18;
        private const int INVENTORY_OFFSET = 0x1A;
        private const int INVENTORY_SIZE = 0x28;
        private const int KEYS_OFFSET = 0x17;
        // starting offset of the map data
        private const int MAP_DATA = 0x92;
        // size of the map data
        private const int MAP_DATA_SIZE = 0x180;
        // offset of the level map data
        private const int MAP_OFFSET = 0x11;
        // offset of the level map data for level 9
        private const int MAP9_OFFSET = 0x13;
        private const int MISC_OFFSET = 0x512;
        private const int MISC_SIZE = 0x4;
        private const int NAME_OFFSET = 0x2;
        private const int NAME_SIZE = 0x8;
        private const int NOTE_OFFSET = 0xF;
        private const int QUEST_OFFSET = 0x9;
        private const int PLAYCOUNT_OFFSET = 0x6;
        private const int POTION_OFFSET = 0x7;
        private const int RING_OFFSET = 0xB;
        private const int RUPEES_OFFSET = 0x16;
        private const int SRAM_SIZE = 0x2000;
        private const int SWORD_OFFSET = 0x0;
        private const int TRIFORCE_OFFSET = 0x1A;

        //private byte[] sram;
        //private bool modified { get; set; }
        //private bool valid { get; set; }

        //public LoZSaveProfile(byte[] sram, int profileSlot)
        //{
        //    this.sram = new byte[SRAM_SIZE];
        //    Array.Copy(sram, this.sram, SRAM_SIZE);
        //    valid = true;
        //    //for (int i = 0; i < 8; i++)
        //    //{
        //    //    if (nvram[NAME_OFFSET + i] != '\xF4')
        //    //    {
        //    //        valid = true;
        //    //        break;
        //    //    }
        //    //}
        //}

        /// <summary>
        /// Queries if this SaveSlot has been modified
        /// </summary>
        /// <returns>true if modified; false otherwise</returns>
        //public bool isModified() => modified;

        /// <summary>
        /// Queries if this SaveSlot is valid.
        /// </summary>
        /// <returns>true if valid; false otherwise</returns>
        //public bool isValid() => valid;

        private static int checksum(int profile)
        {
            int checksum = 0;



            return checksum;
        }

        private static int getChecksum(int profile)
        {
            return 0;
        }

        private static void setChecksum(int profile, int checksum)
        {

        }

        /// <summary>
        /// Gets the name of the character
        /// </summary>
        /// <returns>The name</returns>
        public static string getName(this LoZSRAM sram)
        {
            var name = "";

            var offset = NAME_OFFSET + (sram.currentProfile * NAME_SIZE);

            for (int i = 0; i < NAME_SIZE; i++)
            {
                char letter = fromNES(sram.data[offset + i]);
                name += letter;
            }

            return name;
        }

        public static Arrow getArrows(this LoZSRAM sram) => (Arrow)sram.data[INVENTORY_OFFSET + (sram.currentProfile * INVENTORY_SIZE) + ARROWS_OFFSET];

        public static int getBombCapacity(this LoZSRAM sram) => sram.data[INVENTORY_OFFSET + (sram.currentProfile * INVENTORY_SIZE) + BOMBCAPACITY_OFFSET];

        public static int getBombs(this LoZSRAM sram) => sram.data[INVENTORY_OFFSET + (sram.currentProfile * INVENTORY_SIZE) + BOMBS_OFFSET];

        //public static Candle getCandle(this LoZSRAM sram)
        //public static bool hasCompass(this LoZSRAM sram, int level)
        //public static int getHeartContainers(this LoZSRAM sram)
        //public static bool hasItem(this LoZSRAM sram, Items item)
        //public static int getKeys(this LoZSRAM sram)
        //public static bool hasMap(this LoZSRAM sram, int level)
        //public static Note getNote(this LoZSRAM sram)
        public static int getPlayCount(this LoZSRAM sram) => sram.data[MISC_OFFSET + PLAYCOUNT_OFFSET + sram.currentProfile];
        //public static Potion getPotion(this LoZSRAM sram)
        public static Quest getQuest(this LoZSRAM sram) => (Quest)sram.data[MISC_OFFSET + QUEST_OFFSET + sram.currentProfile];
        //public static Ring getRing(this LoZSRAM sram)
        //public static int getRupees(this LoZSRAM sram)
        public static Sword getSword(this LoZSRAM sram) => (Sword)sram.data[INVENTORY_OFFSET + (sram.currentProfile * INVENTORY_SIZE) + SWORD_OFFSET];
        //public static bool hasTriforce(this LoZSRAM sram, int piece)

        /// <summary>
        /// Translates a character from the Zelda alphabet to ASCII
        /// </summary>
        /// <param name="letter">The letter to translate.</param>
        /// <returns>The translated letter.</returns>
        private static char fromNES(byte letter)
        {
            if (letter >= 0 && letter <= 9)
            {
                return (char)('0' + letter);
            }
            else if (letter >= 0xA && letter <= 0x23)
            {
                return (char)('A' + (letter - 0xA));
            }
            else if (letter == 0x24)
            {
                return ' ';
            }
            else if (letter == 0x28)
            {
                return ',';
            }
            else if (letter == 0x29)
            {
                return '!';
            }
            else if (letter == 0x2A)
            {
                return '\'';
            }
            else if (letter == 0x2B)
            {
                return '&';
            }
            else if (letter == 0x2C)
            {
                return '.';
            }
            else if (letter == 0x2D)
            {
                return '"';
            }
            else if (letter == 0x2E)
            {
                return '?';
            }
            else if (letter == 0x2F)
            {
                return '_';
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
