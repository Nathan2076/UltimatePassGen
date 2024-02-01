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
                glyphAdditionalLength = 0;
                string glyph = "";
                int chosenBlock = RandomNumberGenerator.GetInt32(450);
                
                switch (chosenBlock)
                {
                    /* Unicode Charts */
                    
                    // BMP - Basic Multilingual Plane
                    
                    case 0:
                        glyph += Unicode.Charts.u0000[RandomNumberGenerator.GetInt32(Unicode.Charts.u0000.Length)];
                        break;
                    case 1:
                        glyph += Unicode.Charts.u0080[RandomNumberGenerator.GetInt32(Unicode.Charts.u0080.Length)];
                        break;
                    case 2:
                        glyph += Unicode.Charts.u0100[RandomNumberGenerator.GetInt32(Unicode.Charts.u0100.Length)];
                        break;
                    case 3:
                        glyph += Unicode.Charts.u0180[RandomNumberGenerator.GetInt32(Unicode.Charts.u0180.Length)];
                        break;
                    case 4:
                        glyph += Unicode.Charts.u0250[RandomNumberGenerator.GetInt32(Unicode.Charts.u0250.Length)];
                        break;
                    case 5:
                        glyph += Unicode.Charts.u02B0[RandomNumberGenerator.GetInt32(Unicode.Charts.u02B0.Length)];
                        break;
                    case 6:
                        glyph += Unicode.Charts.u0300[RandomNumberGenerator.GetInt32(Unicode.Charts.u0300.Length)];
                        break;
                    case 7:
                        glyph += Unicode.Charts.u0370[RandomNumberGenerator.GetInt32(Unicode.Charts.u0370.Length)];
                        break;
                    case 8:
                        glyph += Unicode.Charts.u0400[RandomNumberGenerator.GetInt32(Unicode.Charts.u0400.Length)];
                        break;
                    case 9:
                        glyph += Unicode.Charts.u0500[RandomNumberGenerator.GetInt32(Unicode.Charts.u0500.Length)];
                        break;
                    case 10:
                        glyph += Unicode.Charts.u0530[RandomNumberGenerator.GetInt32(Unicode.Charts.u0530.Length)];
                        break;
                    case 11:
                        glyph += Unicode.Charts.u0590[RandomNumberGenerator.GetInt32(Unicode.Charts.u0590.Length)];
                        break;
                    case 12:
                        glyph += Unicode.Charts.u0600[RandomNumberGenerator.GetInt32(Unicode.Charts.u0600.Length)];
                        break;
                    case 13:
                        glyph += Unicode.Charts.u0700[RandomNumberGenerator.GetInt32(Unicode.Charts.u0700.Length)];
                        break;
                    case 14:
                        glyph += Unicode.Charts.u0750[RandomNumberGenerator.GetInt32(Unicode.Charts.u0750.Length)];
                        break;
                    case 15:
                        glyph += Unicode.Charts.u0780[RandomNumberGenerator.GetInt32(Unicode.Charts.u0780.Length)];
                        break;
                    case 16:
                        glyph += Unicode.Charts.u07C0[RandomNumberGenerator.GetInt32(Unicode.Charts.u07C0.Length)];
                        break;
                    case 17:
                        glyph += Unicode.Charts.u0800[RandomNumberGenerator.GetInt32(Unicode.Charts.u0800.Length)];
                        break;
                    case 18:
                        glyph += Unicode.Charts.u0840[RandomNumberGenerator.GetInt32(Unicode.Charts.u0840.Length)];
                        break;
                    case 19:
                        glyph += Unicode.Charts.u0860[RandomNumberGenerator.GetInt32(Unicode.Charts.u0860.Length)];
                        break;
                    case 20:
                        glyph += Unicode.Charts.u0870[RandomNumberGenerator.GetInt32(Unicode.Charts.u0870.Length)];
                        break;
                    case 21:
                        glyph += Unicode.Charts.u08A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u08A0.Length)];
                        break;
                    case 22:
                        glyph += Unicode.Charts.u0900[RandomNumberGenerator.GetInt32(Unicode.Charts.u0900.Length)];
                        break;
                    case 23:
                        glyph += Unicode.Charts.u0980[RandomNumberGenerator.GetInt32(Unicode.Charts.u0980.Length)];
                        break;
                    case 24:
                        glyph += Unicode.Charts.u0A00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0A00.Length)];
                        break;
                    case 25:
                        glyph += Unicode.Charts.u0A80[RandomNumberGenerator.GetInt32(Unicode.Charts.u0A80.Length)];
                        break;
                    case 26:
                        glyph += Unicode.Charts.u0B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0B00.Length)];
                        break;
                    case 27:
                        glyph += Unicode.Charts.u0B80[RandomNumberGenerator.GetInt32(Unicode.Charts.u0B80.Length)];
                        break;
                    case 28:
                        glyph += Unicode.Charts.u0C00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0C00.Length)];
                        break;
                    case 29:
                        glyph += Unicode.Charts.u0C80[RandomNumberGenerator.GetInt32(Unicode.Charts.u0C80.Length)];
                        break;
                    case 30:
                        glyph += Unicode.Charts.u0D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0D00.Length)];
                        break;
                    case 31:
                        glyph += Unicode.Charts.u0D80[RandomNumberGenerator.GetInt32(Unicode.Charts.u0D80.Length)];
                        break;
                    case 32:
                        glyph += Unicode.Charts.u0E00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0E00.Length)];
                        break;
                    case 33:
                        glyph += Unicode.Charts.u0E80[RandomNumberGenerator.GetInt32(Unicode.Charts.u0E80.Length)];
                        break;
                    case 34:
                        glyph += Unicode.Charts.u0F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u0F00.Length)];
                        break;
                    case 35:
                        glyph += Unicode.Charts.u1000[RandomNumberGenerator.GetInt32(Unicode.Charts.u1000.Length)];
                        break;
                    case 36:
                        glyph += Unicode.Charts.u10A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u10A0.Length)];
                        break;
                    case 37:
                        glyph += Unicode.Charts.u1100[RandomNumberGenerator.GetInt32(Unicode.Charts.u1100.Length)];
                        break;
                    case 38:
                        glyph += Unicode.Charts.u1200[RandomNumberGenerator.GetInt32(Unicode.Charts.u1200.Length)];
                        break;
                    case 39:
                        glyph += Unicode.Charts.u1380[RandomNumberGenerator.GetInt32(Unicode.Charts.u1380.Length)];
                        break;
                    case 40:
                        glyph += Unicode.Charts.u13A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u13A0.Length)];
                        break;
                    case 41:
                        glyph += Unicode.Charts.u1400[RandomNumberGenerator.GetInt32(Unicode.Charts.u1400.Length)];
                        break;
                    case 42:
                        glyph += Unicode.Charts.u1680[RandomNumberGenerator.GetInt32(Unicode.Charts.u1680.Length)];
                        break;
                    case 43:
                        glyph += Unicode.Charts.u16A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u16A0.Length)];
                        break;
                    case 44:
                        glyph += Unicode.Charts.u1700[RandomNumberGenerator.GetInt32(Unicode.Charts.u1700.Length)];
                        break;
                    case 45:
                        glyph += Unicode.Charts.u1720[RandomNumberGenerator.GetInt32(Unicode.Charts.u1720.Length)];
                        break;
                    case 46:
                        glyph += Unicode.Charts.u1740[RandomNumberGenerator.GetInt32(Unicode.Charts.u1740.Length)];
                        break;
                    case 47:
                        glyph += Unicode.Charts.u1760[RandomNumberGenerator.GetInt32(Unicode.Charts.u1760.Length)];
                        break;
                    case 48:
                        glyph += Unicode.Charts.u1780[RandomNumberGenerator.GetInt32(Unicode.Charts.u1780.Length)];
                        break;
                    case 49:
                        glyph += Unicode.Charts.u1800[RandomNumberGenerator.GetInt32(Unicode.Charts.u1800.Length)];
                        break;
                    case 50:
                        glyph += Unicode.Charts.u18B0[RandomNumberGenerator.GetInt32(Unicode.Charts.u18B0.Length)];
                        break;
                    case 51:
                        glyph += Unicode.Charts.u1900[RandomNumberGenerator.GetInt32(Unicode.Charts.u1900.Length)];
                        break;
                    case 52:
                        glyph += Unicode.Charts.u1950[RandomNumberGenerator.GetInt32(Unicode.Charts.u1950.Length)];
                        break;
                    case 53:
                        glyph += Unicode.Charts.u1980[RandomNumberGenerator.GetInt32(Unicode.Charts.u1980.Length)];
                        break;
                    case 54:
                        glyph += Unicode.Charts.u19E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u19E0.Length)];
                        break;
                    case 55:
                        glyph += Unicode.Charts.u1A00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1A00.Length)];
                        break;
                    case 56:
                        glyph += Unicode.Charts.u1A20[RandomNumberGenerator.GetInt32(Unicode.Charts.u1A20.Length)];
                        break;
                    case 57:
                        glyph += Unicode.Charts.u1AB0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1AB0.Length)];
                        break;
                    case 58:
                        glyph += Unicode.Charts.u1B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B00.Length)];
                        break;
                    case 59:
                        glyph += Unicode.Charts.u1B80[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B80.Length)];
                        break;
                    case 60:
                        glyph += Unicode.Charts.u1BC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1BC0.Length)];
                        break;
                    case 61:
                        glyph += Unicode.Charts.u1C00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1C00.Length)];
                        break;
                    case 62:
                        glyph += Unicode.Charts.u1C50[RandomNumberGenerator.GetInt32(Unicode.Charts.u1C50.Length)];
                        break;
                    case 63:
                        glyph += Unicode.Charts.u1C80[RandomNumberGenerator.GetInt32(Unicode.Charts.u1C80.Length)];
                        break;
                    case 64:
                        glyph += Unicode.Charts.u1C90[RandomNumberGenerator.GetInt32(Unicode.Charts.u1C90.Length)];
                        break;
                    case 65:
                        glyph += Unicode.Charts.u1CC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1CC0.Length)];
                        break;
                    case 66:
                        glyph += Unicode.Charts.u1CD0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1CD0.Length)];
                        break;
                    case 67:
                        glyph += Unicode.Charts.u1D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D00.Length)];
                        break;
                    case 68:
                        glyph += Unicode.Charts.u1D80[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D80.Length)];
                        break;
                    case 69:
                        glyph += Unicode.Charts.u1DC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1DC0.Length)];
                        break;
                    case 70:
                        glyph += Unicode.Charts.u1E00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E00.Length)];
                        break;
                    case 71:
                        glyph += Unicode.Charts.u1F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F00.Length)];
                        break;
                    case 72:
                        glyph += Unicode.Charts.u2000[RandomNumberGenerator.GetInt32(Unicode.Charts.u2000.Length)];
                        break;
                    case 73:
                        glyph += Unicode.Charts.u2070[RandomNumberGenerator.GetInt32(Unicode.Charts.u2070.Length)];
                        break;
                    case 74:
                        glyph += Unicode.Charts.u20A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u20A0.Length)];
                        break;
                    case 75:
                        glyph += Unicode.Charts.u20D0[RandomNumberGenerator.GetInt32(Unicode.Charts.u20D0.Length)];
                        break;
                    case 76:
                        glyph += Unicode.Charts.u2100[RandomNumberGenerator.GetInt32(Unicode.Charts.u2100.Length)];
                        break;
                    case 77:
                        glyph += Unicode.Charts.u2150[RandomNumberGenerator.GetInt32(Unicode.Charts.u2150.Length)];
                        break;
                    case 78:
                        glyph += Unicode.Charts.u2190[RandomNumberGenerator.GetInt32(Unicode.Charts.u2190.Length)];
                        break;
                    case 79:
                        glyph += Unicode.Charts.u2200[RandomNumberGenerator.GetInt32(Unicode.Charts.u2200.Length)];
                        break;
                    case 80:
                        glyph += Unicode.Charts.u2300[RandomNumberGenerator.GetInt32(Unicode.Charts.u2300.Length)];
                        break;
                    case 81:
                        glyph += Unicode.Charts.u2400[RandomNumberGenerator.GetInt32(Unicode.Charts.u2400.Length)];
                        break;
                    case 82:
                        glyph += Unicode.Charts.u2440[RandomNumberGenerator.GetInt32(Unicode.Charts.u2440.Length)];
                        break;
                    case 83:
                        glyph += Unicode.Charts.u2460[RandomNumberGenerator.GetInt32(Unicode.Charts.u2460.Length)];
                        break;
                    case 84:
                        glyph += Unicode.Charts.u2500[RandomNumberGenerator.GetInt32(Unicode.Charts.u2500.Length)];
                        break;
                    case 85:
                        glyph += Unicode.Charts.u2580[RandomNumberGenerator.GetInt32(Unicode.Charts.u2580.Length)];
                        break;
                    case 86:
                        glyph += Unicode.Charts.u25A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u25A0.Length)];
                        break;
                    case 87:
                        glyph += Unicode.Charts.u2600[RandomNumberGenerator.GetInt32(Unicode.Charts.u2600.Length)];
                        break;
                    case 88:
                        glyph += Unicode.Charts.u2700[RandomNumberGenerator.GetInt32(Unicode.Charts.u2700.Length)];
                        break;
                    case 89:
                        glyph += Unicode.Charts.u27C0[RandomNumberGenerator.GetInt32(Unicode.Charts.u27C0.Length)];
                        break;
                    case 90:
                        glyph += Unicode.Charts.u27F0[RandomNumberGenerator.GetInt32(Unicode.Charts.u27F0.Length)];
                        break;
                    case 91:
                        glyph += Unicode.Charts.u2800[RandomNumberGenerator.GetInt32(Unicode.Charts.u2800.Length)];
                        break;
                    case 92:
                        glyph += Unicode.Charts.u2900[RandomNumberGenerator.GetInt32(Unicode.Charts.u2900.Length)];
                        break;
                    case 93:
                        glyph += Unicode.Charts.u2980[RandomNumberGenerator.GetInt32(Unicode.Charts.u2980.Length)];
                        break;
                    case 94:
                        glyph += Unicode.Charts.u2A00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2A00.Length)];
                        break;
                    case 95:
                        glyph += Unicode.Charts.u2B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2B00.Length)];
                        break;
                    case 96:
                        glyph += Unicode.Charts.u2C00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2C00.Length)];
                        break;
                    case 97:
                        glyph += Unicode.Charts.u2C60[RandomNumberGenerator.GetInt32(Unicode.Charts.u2C60.Length)];
                        break;
                    case 98:
                        glyph += Unicode.Charts.u2C80[RandomNumberGenerator.GetInt32(Unicode.Charts.u2C80.Length)];
                        break;
                    case 99:
                        glyph += Unicode.Charts.u2D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2D00.Length)];
                        break;
                    case 100:
                        glyph += Unicode.Charts.u2D30[RandomNumberGenerator.GetInt32(Unicode.Charts.u2D30.Length)];
                        break;
                    case 101:
                        glyph += Unicode.Charts.u2D80[RandomNumberGenerator.GetInt32(Unicode.Charts.u2D80.Length)];
                        break;
                    case 102:
                        glyph += Unicode.Charts.u2DE0[RandomNumberGenerator.GetInt32(Unicode.Charts.u2DE0.Length)];
                        break;
                    case 103:
                        glyph += Unicode.Charts.u2E00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2E00.Length)];
                        break;
                    case 104:
                        glyph += Unicode.Charts.u2E80[RandomNumberGenerator.GetInt32(Unicode.Charts.u2E80.Length)];
                        break;
                    case 105:
                        glyph += Unicode.Charts.u2F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u2F00.Length)];
                        break;
                    case 106:
                        glyph += Unicode.Charts.u2FF0[RandomNumberGenerator.GetInt32(Unicode.Charts.u2FF0.Length)];
                        break;
                    case 107:
                        glyph += Unicode.Charts.u3000[RandomNumberGenerator.GetInt32(Unicode.Charts.u3000.Length)];
                        break;
                    case 108:
                        glyph += Unicode.Charts.u3040[RandomNumberGenerator.GetInt32(Unicode.Charts.u3040.Length)];
                        break;
                    case 109:
                        glyph += Unicode.Charts.u30A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u30A0.Length)];
                        break;
                    case 110:
                        glyph += Unicode.Charts.u3100[RandomNumberGenerator.GetInt32(Unicode.Charts.u3100.Length)];
                        break;
                    case 111:
                        glyph += Unicode.Charts.u3130[RandomNumberGenerator.GetInt32(Unicode.Charts.u3130.Length)];
                        break;
                    case 112:
                        glyph += Unicode.Charts.u3190[RandomNumberGenerator.GetInt32(Unicode.Charts.u3190.Length)];
                        break;
                    case 113:
                        glyph += Unicode.Charts.u31A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u31A0.Length)];
                        break;
                    case 114:
                        glyph += Unicode.Charts.u31C0[RandomNumberGenerator.GetInt32(Unicode.Charts.u31C0.Length)];
                        break;
                    case 115:
                        glyph += Unicode.Charts.u31F0[RandomNumberGenerator.GetInt32(Unicode.Charts.u31F0.Length)];
                        break;
                    case 116:
                        glyph += Unicode.Charts.u3200[RandomNumberGenerator.GetInt32(Unicode.Charts.u3200.Length)];
                        break;
                    case 117:
                        glyph += Unicode.Charts.u3300[RandomNumberGenerator.GetInt32(Unicode.Charts.u3300.Length)];
                        break;
                    case 118:
                        glyph += Unicode.Charts.u3400[RandomNumberGenerator.GetInt32(Unicode.Charts.u3400.Length)];
                        break;
                    case 119:
                        glyph += Unicode.Charts.u4DC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u4DC0.Length)];
                        break;
                    case 120:
                        glyph += Unicode.Charts.u4E00[RandomNumberGenerator.GetInt32(Unicode.Charts.u4E00.Length)];
                        break;
                    case 121:
                        glyph += Unicode.Charts.uA000[RandomNumberGenerator.GetInt32(Unicode.Charts.uA000.Length)];
                        break;
                    case 122:
                        glyph += Unicode.Charts.uA490[RandomNumberGenerator.GetInt32(Unicode.Charts.uA490.Length)];
                        break;
                    case 123:
                        glyph += Unicode.Charts.uA4D0[RandomNumberGenerator.GetInt32(Unicode.Charts.uA4D0.Length)];
                        break;
                    case 124:
                        glyph += Unicode.Charts.uA500[RandomNumberGenerator.GetInt32(Unicode.Charts.uA500.Length)];
                        break;
                    case 125:
                        glyph += Unicode.Charts.uA640[RandomNumberGenerator.GetInt32(Unicode.Charts.uA640.Length)];
                        break;
                    case 126:
                        glyph += Unicode.Charts.uA6A0[RandomNumberGenerator.GetInt32(Unicode.Charts.uA6A0.Length)];
                        break;
                    case 127:
                        glyph += Unicode.Charts.uA700[RandomNumberGenerator.GetInt32(Unicode.Charts.uA700.Length)];
                        break;
                    case 128:
                        glyph += Unicode.Charts.uA720[RandomNumberGenerator.GetInt32(Unicode.Charts.uA720.Length)];
                        break;
                    case 129:
                        glyph += Unicode.Charts.uA800[RandomNumberGenerator.GetInt32(Unicode.Charts.uA800.Length)];
                        break;
                    case 130:
                        glyph += Unicode.Charts.uA830[RandomNumberGenerator.GetInt32(Unicode.Charts.uA830.Length)];
                        break;
                    case 131:
                        glyph += Unicode.Charts.uA840[RandomNumberGenerator.GetInt32(Unicode.Charts.uA840.Length)];
                        break;
                    case 132:
                        glyph += Unicode.Charts.uA880[RandomNumberGenerator.GetInt32(Unicode.Charts.uA880.Length)];
                        break;
                    case 133:
                        glyph += Unicode.Charts.uA8E0[RandomNumberGenerator.GetInt32(Unicode.Charts.uA8E0.Length)];
                        break;
                    case 134:
                        glyph += Unicode.Charts.uA900[RandomNumberGenerator.GetInt32(Unicode.Charts.uA900.Length)];
                        break;
                    case 135:
                        glyph += Unicode.Charts.uA930[RandomNumberGenerator.GetInt32(Unicode.Charts.uA930.Length)];
                        break;
                    case 136:
                        glyph += Unicode.Charts.uA960[RandomNumberGenerator.GetInt32(Unicode.Charts.uA960.Length)];
                        break;
                    case 137:
                        glyph += Unicode.Charts.uA980[RandomNumberGenerator.GetInt32(Unicode.Charts.uA980.Length)];
                        break;
                    case 138:
                        glyph += Unicode.Charts.uA9E0[RandomNumberGenerator.GetInt32(Unicode.Charts.uA9E0.Length)];
                        break;
                    case 139:
                        glyph += Unicode.Charts.uAA00[RandomNumberGenerator.GetInt32(Unicode.Charts.uAA00.Length)];
                        break;
                    case 140:
                        glyph += Unicode.Charts.uAA60[RandomNumberGenerator.GetInt32(Unicode.Charts.uAA60.Length)];
                        break;
                    case 141:
                        glyph += Unicode.Charts.uAA80[RandomNumberGenerator.GetInt32(Unicode.Charts.uAA80.Length)];
                        break;
                    case 142:
                        glyph += Unicode.Charts.uAAE0[RandomNumberGenerator.GetInt32(Unicode.Charts.uAAE0.Length)];
                        break;
                    case 143:
                        glyph += Unicode.Charts.uAB00[RandomNumberGenerator.GetInt32(Unicode.Charts.uAB00.Length)];
                        break;
                    case 144:
                        glyph += Unicode.Charts.uAB30[RandomNumberGenerator.GetInt32(Unicode.Charts.uAB30.Length)];
                        break;
                    case 145:
                        glyph += Unicode.Charts.uAB70[RandomNumberGenerator.GetInt32(Unicode.Charts.uAB70.Length)];
                        break;
                    case 146:
                        glyph += Unicode.Charts.uABC0[RandomNumberGenerator.GetInt32(Unicode.Charts.uABC0.Length)];
                        break;
                    case 147:
                        glyph += Unicode.Charts.uAC00[RandomNumberGenerator.GetInt32(Unicode.Charts.uAC00.Length)];
                        break;
                    case 148:
                        glyph += Unicode.Charts.uD7B0[RandomNumberGenerator.GetInt32(Unicode.Charts.uD7B0.Length)];
                        break;
                    case 149:
                        glyph += Unicode.Charts.uF900[RandomNumberGenerator.GetInt32(Unicode.Charts.uF900.Length)];
                        break;
                    case 150:
                        glyph += Unicode.Charts.uFB00[RandomNumberGenerator.GetInt32(Unicode.Charts.uFB00.Length)];
                        break;
                    case 151:
                        glyph += Unicode.Charts.uFB50[RandomNumberGenerator.GetInt32(Unicode.Charts.uFB50.Length)];
                        break;
                    case 152:
                        glyph += Unicode.Charts.uFE00[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE00.Length)];
                        break;
                    case 153:
                        glyph += Unicode.Charts.uFE10[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE10.Length)];
                        break;
                    case 154:
                        glyph += Unicode.Charts.uFE20[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE20.Length)];
                        break;
                    case 155:
                        glyph += Unicode.Charts.uFE30[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE30.Length)];
                        break;
                    case 156:
                        glyph += Unicode.Charts.uFE50[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE50.Length)];
                        break;
                    case 157:
                        glyph += Unicode.Charts.uFE70[RandomNumberGenerator.GetInt32(Unicode.Charts.uFE70.Length)];
                        break;
                    case 158:
                        glyph += Unicode.Charts.uFF00[RandomNumberGenerator.GetInt32(Unicode.Charts.uFF00.Length)];
                        break;
                    case 159:
                        glyph += Unicode.Charts.uFFF0[RandomNumberGenerator.GetInt32(Unicode.Charts.uFFF0.Length)];
                        break;
                    
                    // SMP - Supplementary Multilingual Plane
                    
                    case 160:
                        glyph += Unicode.Charts.u10000[RandomNumberGenerator.GetInt32(Unicode.Charts.u10000.Length)];
                        break;
                    case 161:
                        glyph += Unicode.Charts.u10080[RandomNumberGenerator.GetInt32(Unicode.Charts.u10080.Length)];
                        break;
                    case 162:
                        glyph += Unicode.Charts.u10100[RandomNumberGenerator.GetInt32(Unicode.Charts.u10100.Length)];
                        break;
                    case 163:
                        glyph += Unicode.Charts.u10140[RandomNumberGenerator.GetInt32(Unicode.Charts.u10140.Length)];
                        break;
                    case 164:
                        glyph += Unicode.Charts.u10190[RandomNumberGenerator.GetInt32(Unicode.Charts.u10190.Length)];
                        break;
                    case 165:
                        glyph += Unicode.Charts.u101D0[RandomNumberGenerator.GetInt32(Unicode.Charts.u101D0.Length)];
                        break;
                    case 166:
                        glyph += Unicode.Charts.u10280[RandomNumberGenerator.GetInt32(Unicode.Charts.u10280.Length)];
                        break;
                    case 167:
                        glyph += Unicode.Charts.u102A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u102A0.Length)];
                        break;
                    case 168:
                        glyph += Unicode.Charts.u102E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u102E0.Length)];
                        break;
                    case 169:
                        glyph += Unicode.Charts.u10300[RandomNumberGenerator.GetInt32(Unicode.Charts.u10300.Length)];
                        break;
                    case 170:
                        glyph += Unicode.Charts.u10330[RandomNumberGenerator.GetInt32(Unicode.Charts.u10330.Length)];
                        break;
                    case 171:
                        glyph += Unicode.Charts.u10350[RandomNumberGenerator.GetInt32(Unicode.Charts.u10350.Length)];
                        break;
                    case 172:
                        glyph += Unicode.Charts.u10380[RandomNumberGenerator.GetInt32(Unicode.Charts.u10380.Length)];
                        break;
                    case 173:
                        glyph += Unicode.Charts.u103A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u103A0.Length)];
                        break;
                    case 174:
                        glyph += Unicode.Charts.u10400[RandomNumberGenerator.GetInt32(Unicode.Charts.u10400.Length)];
                        break;
                    case 175:
                        glyph += Unicode.Charts.u10450[RandomNumberGenerator.GetInt32(Unicode.Charts.u10450.Length)];
                        break;
                    case 176:
                        glyph += Unicode.Charts.u10480[RandomNumberGenerator.GetInt32(Unicode.Charts.u10480.Length)];
                        break;
                    case 177:
                        glyph += Unicode.Charts.u104B0[RandomNumberGenerator.GetInt32(Unicode.Charts.u104B0.Length)];
                        break;
                    case 178:
                        glyph += Unicode.Charts.u10500[RandomNumberGenerator.GetInt32(Unicode.Charts.u10500.Length)];
                        break;
                    case 179:
                        glyph += Unicode.Charts.u10530[RandomNumberGenerator.GetInt32(Unicode.Charts.u10530.Length)];
                        break;
                    case 180:
                        glyph += Unicode.Charts.u10570[RandomNumberGenerator.GetInt32(Unicode.Charts.u10570.Length)];
                        break;
                    case 181:
                        glyph += Unicode.Charts.u10600[RandomNumberGenerator.GetInt32(Unicode.Charts.u10600.Length)];
                        break;
                    case 182:
                        glyph += Unicode.Charts.u10780[RandomNumberGenerator.GetInt32(Unicode.Charts.u10780.Length)];
                        break;
                    case 183:
                        glyph += Unicode.Charts.u10800[RandomNumberGenerator.GetInt32(Unicode.Charts.u10800.Length)];
                        break;
                    case 184:
                        glyph += Unicode.Charts.u10840[RandomNumberGenerator.GetInt32(Unicode.Charts.u10840.Length)];
                        break;
                    case 185:
                        glyph += Unicode.Charts.u10860[RandomNumberGenerator.GetInt32(Unicode.Charts.u10860.Length)];
                        break;
                    case 186:
                        glyph += Unicode.Charts.u10880[RandomNumberGenerator.GetInt32(Unicode.Charts.u10880.Length)];
                        break;
                    case 187:
                        glyph += Unicode.Charts.u108E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u108E0.Length)];
                        break;
                    case 188:
                        glyph += Unicode.Charts.u10900[RandomNumberGenerator.GetInt32(Unicode.Charts.u10900.Length)];
                        break;
                    case 189:
                        glyph += Unicode.Charts.u10920[RandomNumberGenerator.GetInt32(Unicode.Charts.u10920.Length)];
                        break;
                    case 190:
                        glyph += Unicode.Charts.u10980[RandomNumberGenerator.GetInt32(Unicode.Charts.u10980.Length)];
                        break;
                    case 191:
                        glyph += Unicode.Charts.u109A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u109A0.Length)];
                        break;
                    case 192:
                        glyph += Unicode.Charts.u10A00[RandomNumberGenerator.GetInt32(Unicode.Charts.u10A00.Length)];
                        break;
                    case 193:
                        glyph += Unicode.Charts.u10A60[RandomNumberGenerator.GetInt32(Unicode.Charts.u10A60.Length)];
                        break;
                    case 194:
                        glyph += Unicode.Charts.u10A80[RandomNumberGenerator.GetInt32(Unicode.Charts.u10A80.Length)];
                        break;
                    case 195:
                        glyph += Unicode.Charts.u10AC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u10AC0.Length)];
                        break;
                    case 196:
                        glyph += Unicode.Charts.u10B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u10B00.Length)];
                        break;
                    case 197:
                        glyph += Unicode.Charts.u10B40[RandomNumberGenerator.GetInt32(Unicode.Charts.u10B40.Length)];
                        break;
                    case 198:
                        glyph += Unicode.Charts.u10B60[RandomNumberGenerator.GetInt32(Unicode.Charts.u10B60.Length)];
                        break;
                    case 199:
                        glyph += Unicode.Charts.u10B80[RandomNumberGenerator.GetInt32(Unicode.Charts.u10B80.Length)];
                        break;
                    case 200:
                        glyph += Unicode.Charts.u10C00[RandomNumberGenerator.GetInt32(Unicode.Charts.u10C00.Length)];
                        break;
                    case 201:
                        glyph += Unicode.Charts.u10C80[RandomNumberGenerator.GetInt32(Unicode.Charts.u10C80.Length)];
                        break;
                    case 202:
                        glyph += Unicode.Charts.u10D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u10D00.Length)];
                        break;
                    case 203:
                        glyph += Unicode.Charts.u10E60[RandomNumberGenerator.GetInt32(Unicode.Charts.u10E60.Length)];
                        break;
                    case 204:
                        glyph += Unicode.Charts.u10E80[RandomNumberGenerator.GetInt32(Unicode.Charts.u10E80.Length)];
                        break;
                    case 205:
                        glyph += Unicode.Charts.u10EC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u10EC0.Length)];
                        break;
                    case 206:
                        glyph += Unicode.Charts.u10F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u10F00.Length)];
                        break;
                    case 207:
                        glyph += Unicode.Charts.u10F30[RandomNumberGenerator.GetInt32(Unicode.Charts.u10F30.Length)];
                        break;
                    case 208:
                        glyph += Unicode.Charts.u10F70[RandomNumberGenerator.GetInt32(Unicode.Charts.u10F70.Length)];
                        break;
                    case 209:
                        glyph += Unicode.Charts.u10FB0[RandomNumberGenerator.GetInt32(Unicode.Charts.u10FB0.Length)];
                        break;
                    case 210:
                        glyph += Unicode.Charts.u10FE0[RandomNumberGenerator.GetInt32(Unicode.Charts.u10FE0.Length)];
                        break;
                    case 211:
                        glyph += Unicode.Charts.u11000[RandomNumberGenerator.GetInt32(Unicode.Charts.u11000.Length)];
                        break;
                    case 212:
                        glyph += Unicode.Charts.u11080[RandomNumberGenerator.GetInt32(Unicode.Charts.u11080.Length)];
                        break;
                    case 213:
                        glyph += Unicode.Charts.u110D0[RandomNumberGenerator.GetInt32(Unicode.Charts.u110D0.Length)];
                        break;
                    case 214:
                        glyph += Unicode.Charts.u11100[RandomNumberGenerator.GetInt32(Unicode.Charts.u11100.Length)];
                        break;
                    case 215:
                        glyph += Unicode.Charts.u11150[RandomNumberGenerator.GetInt32(Unicode.Charts.u11150.Length)];
                        break;
                    case 216:
                        glyph += Unicode.Charts.u11180[RandomNumberGenerator.GetInt32(Unicode.Charts.u11180.Length)];
                        break;
                    case 217:
                        glyph += Unicode.Charts.u111E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u111E0.Length)];
                        break;
                    case 218:
                        glyph += Unicode.Charts.u11200[RandomNumberGenerator.GetInt32(Unicode.Charts.u11200.Length)];
                        break;
                    case 219:
                        glyph += Unicode.Charts.u11280[RandomNumberGenerator.GetInt32(Unicode.Charts.u11280.Length)];
                        break;
                    case 220:
                        glyph += Unicode.Charts.u112B0[RandomNumberGenerator.GetInt32(Unicode.Charts.u112B0.Length)];
                        break;
                    case 221:
                        glyph += Unicode.Charts.u11300[RandomNumberGenerator.GetInt32(Unicode.Charts.u11300.Length)];
                        break;
                    case 222:
                        glyph += Unicode.Charts.u11400[RandomNumberGenerator.GetInt32(Unicode.Charts.u11400.Length)];
                        break;
                    case 223:
                        glyph += Unicode.Charts.u11480[RandomNumberGenerator.GetInt32(Unicode.Charts.u11480.Length)];
                        break;
                    case 224:
                        glyph += Unicode.Charts.u11580[RandomNumberGenerator.GetInt32(Unicode.Charts.u11580.Length)];
                        break;
                    case 225:
                        glyph += Unicode.Charts.u11600[RandomNumberGenerator.GetInt32(Unicode.Charts.u11600.Length)];
                        break;
                    case 226:
                        glyph += Unicode.Charts.u11660[RandomNumberGenerator.GetInt32(Unicode.Charts.u11660.Length)];
                        break;
                    case 227:
                        glyph += Unicode.Charts.u11680[RandomNumberGenerator.GetInt32(Unicode.Charts.u11680.Length)];
                        break;
                    case 228:
                        glyph += Unicode.Charts.u11700[RandomNumberGenerator.GetInt32(Unicode.Charts.u11700.Length)];
                        break;
                    case 229:
                        glyph += Unicode.Charts.u11800[RandomNumberGenerator.GetInt32(Unicode.Charts.u11800.Length)];
                        break;
                    case 230:
                        glyph += Unicode.Charts.u118A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u118A0.Length)];
                        break;
                    case 231:
                        glyph += Unicode.Charts.u11900[RandomNumberGenerator.GetInt32(Unicode.Charts.u11900.Length)];
                        break;
                    case 232:
                        glyph += Unicode.Charts.u119A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u119A0.Length)];
                        break;
                    case 233:
                        glyph += Unicode.Charts.u11A00[RandomNumberGenerator.GetInt32(Unicode.Charts.u11A00.Length)];
                        break;
                    case 234:
                        glyph += Unicode.Charts.u11A50[RandomNumberGenerator.GetInt32(Unicode.Charts.u11A50.Length)];
                        break;
                    case 235:
                        glyph += Unicode.Charts.u11AB0[RandomNumberGenerator.GetInt32(Unicode.Charts.u11AB0.Length)];
                        break;
                    case 236:
                        glyph += Unicode.Charts.u11AC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u11AC0.Length)];
                        break;
                    case 237:
                        glyph += Unicode.Charts.u11B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u11B00.Length)];
                        break;
                    case 238:
                        glyph += Unicode.Charts.u11C00[RandomNumberGenerator.GetInt32(Unicode.Charts.u11C00.Length)];
                        break;
                    case 239:
                        glyph += Unicode.Charts.u11C70[RandomNumberGenerator.GetInt32(Unicode.Charts.u11C70.Length)];
                        break;
                    case 240:
                        glyph += Unicode.Charts.u11D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u11D00.Length)];
                        break;
                    case 241:
                        glyph += Unicode.Charts.u11D60[RandomNumberGenerator.GetInt32(Unicode.Charts.u11D60.Length)];
                        break;
                    case 242:
                        glyph += Unicode.Charts.u11EE0[RandomNumberGenerator.GetInt32(Unicode.Charts.u11EE0.Length)];
                        break;
                    case 243:
                        glyph += Unicode.Charts.u11F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u11F00.Length)];
                        break;
                    case 244:
                        glyph += Unicode.Charts.u11FB0[RandomNumberGenerator.GetInt32(Unicode.Charts.u11FB0.Length)];
                        break;
                    case 245:
                        glyph += Unicode.Charts.u11FC0[RandomNumberGenerator.GetInt32(Unicode.Charts.u11FC0.Length)];
                        break;
                    case 246:
                        glyph += Unicode.Charts.u12000[RandomNumberGenerator.GetInt32(Unicode.Charts.u12000.Length)];
                        break;
                    case 247:
                        glyph += Unicode.Charts.u12400[RandomNumberGenerator.GetInt32(Unicode.Charts.u12400.Length)];
                        break;
                    case 248:
                        glyph += Unicode.Charts.u12480[RandomNumberGenerator.GetInt32(Unicode.Charts.u12480.Length)];
                        break;
                    case 249:
                        glyph += Unicode.Charts.u12F90[RandomNumberGenerator.GetInt32(Unicode.Charts.u12F90.Length)];
                        break;
                    case 250:
                        glyph += Unicode.Charts.u13000[RandomNumberGenerator.GetInt32(Unicode.Charts.u13000.Length)];
                        break;
                    case 251:
                        glyph += Unicode.Charts.u13430[RandomNumberGenerator.GetInt32(Unicode.Charts.u13430.Length)];
                        break;
                    case 252:
                        glyph += Unicode.Charts.u14400[RandomNumberGenerator.GetInt32(Unicode.Charts.u14400.Length)];
                        break;
                    case 253:
                        glyph += Unicode.Charts.u16800[RandomNumberGenerator.GetInt32(Unicode.Charts.u16800.Length)];
                        break;
                    case 254:
                        glyph += Unicode.Charts.u16A40[RandomNumberGenerator.GetInt32(Unicode.Charts.u16A40.Length)];
                        break;
                    case 255:
                        glyph += Unicode.Charts.u16A70[RandomNumberGenerator.GetInt32(Unicode.Charts.u16A70.Length)];
                        break;
                    case 256:
                        glyph += Unicode.Charts.u16AD0[RandomNumberGenerator.GetInt32(Unicode.Charts.u16AD0.Length)];
                        break;
                    case 257:
                        glyph += Unicode.Charts.u16B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u16B00.Length)];
                        break;
                    case 258:
                        glyph += Unicode.Charts.u16E40[RandomNumberGenerator.GetInt32(Unicode.Charts.u16E40.Length)];
                        break;
                    case 259:
                        glyph += Unicode.Charts.u16F00[RandomNumberGenerator.GetInt32(Unicode.Charts.u16F00.Length)];
                        break;
                    case 260:
                        glyph += Unicode.Charts.u16FE0[RandomNumberGenerator.GetInt32(Unicode.Charts.u16FE0.Length)];
                        break;
                    case 261:
                        glyph += Unicode.Charts.u17000[RandomNumberGenerator.GetInt32(Unicode.Charts.u17000.Length)];
                        break;
                    case 262:
                        glyph += Unicode.Charts.u18800[RandomNumberGenerator.GetInt32(Unicode.Charts.u18800.Length)];
                        break;
                    case 263:
                        glyph += Unicode.Charts.u18B00[RandomNumberGenerator.GetInt32(Unicode.Charts.u18B00.Length)];
                        break;
                    case 264:
                        glyph += Unicode.Charts.u18D00[RandomNumberGenerator.GetInt32(Unicode.Charts.u18D00.Length)];
                        break;
                    case 265:
                        glyph += Unicode.Charts.u1AFF0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1AFF0.Length)];
                        break;
                    case 266:
                        glyph += Unicode.Charts.u1B000[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B000.Length)];
                        break;
                    case 267:
                        glyph += Unicode.Charts.u1B100[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B100.Length)];
                        break;
                    case 268:
                        glyph += Unicode.Charts.u1B130[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B130.Length)];
                        break;
                    case 269:
                        glyph += Unicode.Charts.u1B170[RandomNumberGenerator.GetInt32(Unicode.Charts.u1B170.Length)];
                        break;
                    case 270:
                        glyph += Unicode.Charts.u1BC00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1BC00.Length)];
                        break;
                    case 271:
                        glyph += Unicode.Charts.u1BCA0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1BCA0.Length)];
                        break;
                    case 272:
                        glyph += Unicode.Charts.u1CF00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1CF00.Length)];
                        break;
                    case 273:
                        glyph += Unicode.Charts.u1D000[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D000.Length)];
                        break;
                    case 274:
                        glyph += Unicode.Charts.u1D100[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D100.Length)];
                        break;
                    case 275:
                        glyph += Unicode.Charts.u1D200[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D200.Length)];
                        break;
                    case 276:
                        glyph += Unicode.Charts.u1D2C0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D2C0.Length)];
                        break;
                    case 277:
                        glyph += Unicode.Charts.u1D2E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D2E0.Length)];
                        break;
                    case 278:
                        glyph += Unicode.Charts.u1D300[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D300.Length)];
                        break;
                    case 279:
                        glyph += Unicode.Charts.u1D360[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D360.Length)];
                        break;
                    case 280:
                        glyph += Unicode.Charts.u1D400[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D400.Length)];
                        break;
                    case 281:
                        glyph += Unicode.Charts.u1D800[RandomNumberGenerator.GetInt32(Unicode.Charts.u1D800.Length)];
                        break;
                    case 282:
                        glyph += Unicode.Charts.u1DF00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1DF00.Length)];
                        break;
                    case 283:
                        glyph += Unicode.Charts.u1E000[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E000.Length)];
                        break;
                    case 284:
                        glyph += Unicode.Charts.u1E030[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E030.Length)];
                        break;
                    case 285:
                        glyph += Unicode.Charts.u1E100[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E100.Length)];
                        break;
                    case 286:
                        glyph += Unicode.Charts.u1E290[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E290.Length)];
                        break;
                    case 287:
                        glyph += Unicode.Charts.u1E2C0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E2C0.Length)];
                        break;
                    case 288:
                        glyph += Unicode.Charts.u1E4D0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E4D0.Length)];
                        break;
                    case 289:
                        glyph += Unicode.Charts.u1E7E0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E7E0.Length)];
                        break;
                    case 290:
                        glyph += Unicode.Charts.u1E800[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E800.Length)];
                        break;
                    case 291:
                        glyph += Unicode.Charts.u1E900[RandomNumberGenerator.GetInt32(Unicode.Charts.u1E900.Length)];
                        break;
                    case 292:
                        glyph += Unicode.Charts.u1EC70[RandomNumberGenerator.GetInt32(Unicode.Charts.u1EC70.Length)];
                        break;
                    case 293:
                        glyph += Unicode.Charts.u1ED00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1ED00.Length)];
                        break;
                    case 294:
                        glyph += Unicode.Charts.u1EE00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1EE00.Length)];
                        break;
                    case 295:
                        glyph += Unicode.Charts.u1F000[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F000.Length)];
                        break;
                    case 296:
                        glyph += Unicode.Charts.u1F030[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F030.Length)];
                        break;
                    case 297:
                        glyph += Unicode.Charts.u1F0A0[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F0A0.Length)];
                        break;
                    case 298:
                        glyph += Unicode.Charts.u1F100[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F100.Length)];
                        break;
                    case 299:
                        glyph += Unicode.Charts.u1F200[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F200.Length)];
                        break;
                    case 300:
                        glyph += Unicode.Charts.u1F300[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F300.Length)];
                        break;
                    case 301:
                        glyph += Unicode.Charts.u1F600[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F600.Length)];
                        break;
                    case 302:
                        glyph += Unicode.Charts.u1F650[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F650.Length)];
                        break;
                    case 303:
                        glyph += Unicode.Charts.u1F680[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F680.Length)];
                        break;
                    case 304:
                        glyph += Unicode.Charts.u1F700[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F700.Length)];
                        break;
                    case 305:
                        glyph += Unicode.Charts.u1F780[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F780.Length)];
                        break;
                    case 306:
                        glyph += Unicode.Charts.u1F800[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F800.Length)];
                        break;
                    case 307:
                        glyph += Unicode.Charts.u1F900[RandomNumberGenerator.GetInt32(Unicode.Charts.u1F900.Length)];
                        break;
                    case 308:
                        glyph += Unicode.Charts.u1FA00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1FA00.Length)];
                        break;
                    case 309:
                        glyph += Unicode.Charts.u1FA70[RandomNumberGenerator.GetInt32(Unicode.Charts.u1FA70.Length)];
                        break;
                    case 310:
                        glyph += Unicode.Charts.u1FB00[RandomNumberGenerator.GetInt32(Unicode.Charts.u1FB00.Length)];
                        break;
                    
                    // SIP - Supplementary Ideographic Plane
                    
                    case 311:
                        glyph += Unicode.Charts.u20000[RandomNumberGenerator.GetInt32(Unicode.Charts.u20000.Length)];
                        break;
                    case 312:
                        glyph += Unicode.Charts.u2A700[RandomNumberGenerator.GetInt32(Unicode.Charts.u2A700.Length)];
                        break;
                    case 313:
                        glyph += Unicode.Charts.u2B740[RandomNumberGenerator.GetInt32(Unicode.Charts.u2B740.Length)];
                        break;
                    case 314:
                        glyph += Unicode.Charts.u2B820[RandomNumberGenerator.GetInt32(Unicode.Charts.u2B820.Length)];
                        break;
                    case 315:
                        glyph += Unicode.Charts.u2CEB0[RandomNumberGenerator.GetInt32(Unicode.Charts.u2CEB0.Length)];
                        break;
                    case 316:
                        glyph += Unicode.Charts.u2EBF0[RandomNumberGenerator.GetInt32(Unicode.Charts.u2EBF0.Length)];
                        break;
                    case 317:
                        glyph += Unicode.Charts.u2F800[RandomNumberGenerator.GetInt32(Unicode.Charts.u2F800.Length)];
                        break;
                    
                    // TIP - Tertiary Ideographic Plane
                    
                    case 318:
                        glyph += Unicode.Charts.u30000[RandomNumberGenerator.GetInt32(Unicode.Charts.u30000.Length)];
                        break;
                    case 319:
                        glyph += Unicode.Charts.u31350[RandomNumberGenerator.GetInt32(Unicode.Charts.u31350.Length)];
                        break;
                    
                    // SSP - Supplementary Special-purpose Plane
                    
                    case 320:
                        glyph += Unicode.Charts.uE0000[RandomNumberGenerator.GetInt32(Unicode.Charts.uE0000.Length)];
                        break;
                    case 321:
                        glyph += Unicode.Charts.uE0100[RandomNumberGenerator.GetInt32(Unicode.Charts.uE0100.Length)];
                        break;
                    
                    /* Unicode Variants */
                    
                    case 322:
                        glyph += InsertGlyphFromArray(Unicode.Variants.mathematical);
                        break;
                    case 323:
                        glyph += InsertGlyphFromArray(Unicode.Variants.mathematicalAlphabetScriptVariants);
                        break;
                    case 324:
                        glyph += InsertGlyphFromArray(Unicode.Variants.eastAsianPunctuationPositionalVariants);
                        break;
                    case 325:
                        glyph += InsertGlyphFromArray(Unicode.Variants.myanmar);
                        break;
                    case 326:
                        glyph += InsertGlyphFromArray(Unicode.Variants.phagsPa);
                        break;
                    case 327:
                        glyph += InsertGlyphFromArray(Unicode.Variants.manichaean);
                        break;
                    case 328:
                        glyph += InsertGlyphFromArray(Unicode.Variants.mongolian);
                        break;
                    case 329:
                        glyph += InsertGlyphFromArray(Unicode.Variants.egyptianHieroglyphRotationalVariants);
                        break;
                    case 330:
                        glyph += InsertGlyphFromArray(Unicode.Variants.egyptianHieroglyphExpandedVariants);
                        break;
                    case 331:
                        glyph += InsertGlyphFromArray(Unicode.Variants.cjkCompatibilityIdeographs);
                        break;
                    
                    /* Emoji List */

                    case 332:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceSmiling);
                        break;
                    case 333:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceAffection);
                        break;
                    case 334:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceTongue);
                        break;
                    case 335:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceHand);
                        break;
                    case 336:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceNeutralSkeptical);
                        break;
                    case 337:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceSleepy);
                        break;
                    case 338:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceUnwell);
                        break;
                    case 339:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceHat);
                        break;
                    case 340:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceGlasses);
                        break;
                    case 341:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceConcerned);
                        break;
                    case 342:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceNegative);
                        break;
                    case 343:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceCostume);
                        break;
                    case 344:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.catFace);
                        break;
                    case 345:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.monkeyFace);
                        break;
                    case 346:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.heart);
                        break;
                    case 347:
                        glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.emotion);
                        break;
                    case 348:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersOpen);
                        break;
                    case 349:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersPartial);
                        break;
                    case 350:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handSingleFinger);
                        break;
                    case 351:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersClosed);
                        break;
                    case 352:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.hands);
                        break;
                    case 353:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handProp);
                        break;
                    case 354:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.bodyParts);
                        break;
                    case 355:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.person);
                        break;
                    case 356:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personGesture);
                        break;
                    case 357:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personRole);
                        break;
                    case 358:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personFantasy);
                        break;
                    case 359:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personActivity);
                        break;
                    case 360:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personSport);
                        break;
                    case 361:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personResting);
                        break;
                    case 362:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.family);
                        break;
                    case 363:
                        glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personSymbol);
                        break;
                    case 364:
                        glyph += InsertGlyphFromArray(Emoji.List.Component.skinTone);
                        break;
                    case 365:
                        glyph += InsertGlyphFromArray(Emoji.List.Component.hairStyle);
                        break;
                    case 366:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalMammal);
                        break;
                    case 367:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalBird);
                        break;
                    case 368:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalAmphibian);
                        break;
                    case 369:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalReptile);
                        break;
                    case 370:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalMarine);
                        break;
                    case 371:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalBug);
                        break;
                    case 372:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.plantFlower);
                        break;
                    case 373:
                        glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.plantOther);
                        break;
                    case 374:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodFruit);
                        break;
                    case 375:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodVegetable);
                        break;
                    case 376:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodPrepared);
                        break;
                    case 377:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodAsian);
                        break;
                    case 378:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodMarine);
                        break;
                    case 379:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodSweet);
                        break;
                    case 380:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.drink);
                        break;
                    case 381:
                        glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.dishware);
                        break;
                    case 382:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeMap);
                        break;
                    case 383:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeGeographic);
                        break;
                    case 384:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeBuilding);
                        break;
                    case 385:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeReligious);
                        break;
                    case 386:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeOther);
                        break;
                    case 387:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportGround);
                        break;
                    case 388:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportWater);
                        break;
                    case 389:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportAir);
                        break;
                    case 390:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.hotel);
                        break;
                    case 391:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.time);
                        break;
                    case 392:
                        glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.skyAndWeather);
                        break;
                    case 393:
                        glyph += InsertGlyphFromArray(Emoji.List.Activities.@event);
                        break;
                    case 394:
                        glyph += InsertGlyphFromArray(Emoji.List.Activities.awardMedal);
                        break;
                    case 395:
                        glyph += InsertGlyphFromArray(Emoji.List.Activities.sport);
                        break;
                    case 396:
                        glyph += InsertGlyphFromArray(Emoji.List.Activities.game);
                        break;
                    case 397:
                        glyph += InsertGlyphFromArray(Emoji.List.Activities.artsAndCrafts);
                        break;
                    case 398:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.clothing);
                        break;
                    case 399:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.sound);
                        break;
                    case 400:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.music);
                        break;
                    case 401:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.musicalInstrument);
                        break;
                    case 402:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.phone);
                        break;
                    case 403:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.computer);
                        break;
                    case 404:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.lightAndVideo);
                        break;
                    case 405:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.bookPaper);
                        break;
                    case 406:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.money);
                        break;
                    case 407:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.mail);
                        break;
                    case 408:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.writing);
                        break;
                    case 409:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.office);
                        break;
                    case 410:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.@lock);
                        break;
                    case 411:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.tool);
                        break;
                    case 412:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.science);
                        break;
                    case 413:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.medical);
                        break;
                    case 414:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.household);
                        break;
                    case 415:
                        glyph += InsertGlyphFromArray(Emoji.List.Objects.otherObject);
                        break;
                    case 416:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.transportSign);
                        break;
                    case 417:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.warning);
                        break;
                    case 418:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.arrow);
                        break;
                    case 419:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.religion);
                        break;
                    case 420:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.zodiac);
                        break;
                    case 421:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.avSymbol);
                        break;
                    case 422:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.gender);
                        break;
                    case 423:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.math);
                        break;
                    case 424:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.punctuation);
                        break;
                    case 425:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.currency);
                        break;
                    case 426:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.otherSymbol);
                        break;
                    case 427:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.keycap);
                        break;
                    case 428:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.alphanum);
                        break;
                    case 429:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.geometric);
                        break;
                    case 430:
                        glyph += InsertGlyphFromArray(Emoji.List.Symbols.alphanumeric);
                        break;
                    case 431:
                        glyph += InsertGlyphFromArray(Emoji.List.Flags.flag);
                        break;
                    case 432:
                        glyph += InsertGlyphFromArray(Emoji.List.Flags.countryFlag);
                        break;
                    case 433:
                        glyph += InsertGlyphFromArray(Emoji.List.Flags.subdivisionFlag);
                        break;
                    
                    /* Emoji Modifiers */

                    case 434:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersOpen);
                        break;
                    case 435:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersPartial);
                        break;
                    case 436:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handSingleFinger);
                        break;
                    case 437:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersClosed);
                        break;
                    case 438:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.hands);
                        break;
                    case 439:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handProp);
                        break;
                    case 440:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.bodyParts);
                        break;
                    case 441:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.person);
                        break;
                    case 442:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personGesture);
                        break;
                    case 443:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personRole);
                        break;
                    case 444:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personFantasy);
                        break;
                    case 445:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personActivity);
                        break;
                    case 446:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personSport);
                        break;
                    case 447:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personResting);
                        break;
                    case 448:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.family);
                        break;
                    case 449:
                        glyph += InsertGlyphFromArray(Emoji.Modifiers.Component.skinTone);
                        break;
                }

                if (chosenBlock >= 160 && chosenBlock <= 321)
                    glyphAdditionalLength = 1;
                
                if (i < passwordLength && i + glyph.Length > passwordLength)
                {
                    i--;
                    continue;
                }
                
                i += glyphAdditionalLength;
                
                password += glyph;
            }
            
            return password;
        }

        static string InsertGlyphFromArray(string[] array)
        {
            int glyphIndex = RandomNumberGenerator.GetInt32(array.Length);
            string glyph = array[glyphIndex];

            if (glyph.Length > 1)
                glyphAdditionalLength = glyph.Length - 1;
            
            return glyph;
        }
    }
}
