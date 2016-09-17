﻿namespace Jeopardy_Editor
{
    public static class Globals
    {
        /// <summary>
        /// Rom file start/end locations
        /// </summary>
        public const int ROMFILE_TEXT_BEGIN = 163840;
        public const int ROMFILE_TEXT_END = 379891;
        public const int ROMFILE_POINTER_BEGIN = 16117;
        public const int ROMFILE_POINTER_END = 17925;

        public const int ROMFILE_HEADER_TITLE_SIZE = 21;
        public const int ROMFILE_HEADER_TITLE_POS = 32704;
        public const string ROMFILE_HEADER_TITLE_STRING = "JEOPARDY!";

        /// <summary>
        /// Software version major.minor.sub
        /// </summary>
        public const int SOFTWARE_VERSION_MAJOR = 0;
        public const int SOFTWARE_VERSION_MINOR = 4;
        public const int SOFTWARE_VERSION_SUB = 1;
        public const string SOFTWARE_VERSION_STRING = "0.4.1";

        public const string SOFTWARE_TITLE = "Jepardy! Editor for Super Nintendo";

    }
}
