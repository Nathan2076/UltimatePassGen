using System.Security.Cryptography;

namespace UltimatePassGen
{
    static class Password
    {
        private static int glyphAdditionalLength;
        
        public static string Generate(int passwordLength)
        {
            string password = "";
            
            for (var i = 0; i < passwordLength; i++)
            {
                string glyph = "";
                glyphAdditionalLength = 0;
                int chosenPool = RandomNumberGenerator.GetInt32(8);
                
                switch (chosenPool)
                {
                    case 0:
                        glyph += InsertLowercaseLetter();
                        break;
                    case 1:
                        glyph += InsertUppercaseLetter();
                        break;
                    case 2:
                        glyph += InsertNumber();
                        break;
                    case 3:
                        glyph += InsertSymbol();
                        break;
                    case 4:
                        glyph += InsertUnicodeGlyph();
                        break;
                    case 5:
                        glyph += InsertUnicodeVariant();
                        break;
                    case 6:
                        glyph += InsertEmoji();
                        break;
                    case 7:
                        glyph += InsertEmojiModifier();
                        break;
                }
                
                if (i + glyph.Length > passwordLength)
                {
                    i--;
                    continue;
                }
                
                i += glyphAdditionalLength;
                
                password += glyph;
            }
            
            return password;
        }
        
        private static char InsertLowercaseLetter()
        {
            int charIndex = RandomNumberGenerator.GetInt32(26);
            
            return Chars.lowercaseLetters[charIndex];
        }
        
        private static char InsertUppercaseLetter()
        {
            int charIndex = RandomNumberGenerator.GetInt32(26);
            
            return Chars.uppercaseLetters[charIndex];
        }
        
        private static char InsertNumber()
        {
            int charIndex = RandomNumberGenerator.GetInt32(10);
            
            return Chars.numbers[charIndex];
        }
        
        private static char InsertSymbol()
        {
            int charIndex = RandomNumberGenerator.GetInt32(32);
            
            return Chars.symbols[charIndex];
        }
        
        private static string InsertUnicodeGlyph()
        {
            int chosenBlock = RandomNumberGenerator.GetInt32(322);
            
            return InsertGlyphFromArray(Charts.charts[chosenBlock]);
        }
        
        private static string InsertUnicodeVariant()
        {
            int chosenBlock = RandomNumberGenerator.GetInt32(10);
            
            return InsertGlyphFromArray(Unicode.variants[chosenBlock]);
        }
        
        private static string InsertEmoji()
        {
            int chosenGroup = RandomNumberGenerator.GetInt32(102);
            
            return InsertGlyphFromArray(Emoji.list[chosenGroup]);
        }
        
        private static string InsertEmojiModifier()
        {
            int chosenGroup = RandomNumberGenerator.GetInt32(16);
            
            return InsertGlyphFromArray(Modifiers.modifiers[chosenGroup]);
        }
        
        static string InsertGlyphFromArray(string[] array)
        {
            string glyph = array[RandomNumberGenerator.GetInt32(array.Length)];
            
            if (glyph.Length > 1)
                glyphAdditionalLength = glyph.Length - 1;
            
            return glyph;
        }
    }
}
