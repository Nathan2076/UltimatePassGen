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
            string glyph = "";
            int chosenBlock = RandomNumberGenerator.GetInt32(322);

            glyph += InsertGlyphFromArray(Charts.charts[chosenBlock]);
            
            return glyph;
        }
        
        private static string InsertUnicodeVariant()
        {
            string glyph = "";
            int chosenBlock = RandomNumberGenerator.GetInt32(10);
            
            switch (chosenBlock)
            {
                case 0:
                    glyph += InsertGlyphFromArray(Unicode.mathematical);
                    break;
                case 1:
                    glyph += InsertGlyphFromArray(Unicode.mathematicalAlphabetScriptVariants);
                    break;
                case 2:
                    glyph += InsertGlyphFromArray(Unicode.eastAsianPunctuationPositionalVariants);
                    break;
                case 3:
                    glyph += InsertGlyphFromArray(Unicode.myanmar);
                    break;
                case 4:
                    glyph += InsertGlyphFromArray(Unicode.phagsPa);
                    break;
                case 5:
                    glyph += InsertGlyphFromArray(Unicode.manichaean);
                    break;
                case 6:
                    glyph += InsertGlyphFromArray(Unicode.mongolian);
                    break;
                case 7:
                    glyph += InsertGlyphFromArray(Unicode.egyptianHieroglyphRotationalVariants);
                    break;
                case 8:
                    glyph += InsertGlyphFromArray(Unicode.egyptianHieroglyphExpandedVariants);
                    break;
                case 9:
                    glyph += InsertGlyphFromArray(Unicode.cjkCompatibilityIdeographs);
                    break;
            }
            
            return glyph;
        }
        
        private static string InsertEmoji()
        {
            string glyph = "";
            int chosenGroup = RandomNumberGenerator.GetInt32(102);
            
            switch (chosenGroup)
            {
                case 0:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceSmiling);
                    break;
                case 1:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceAffection);
                    break;
                case 2:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceTongue);
                    break;
                case 3:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceHand);
                    break;
                case 4:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceNeutralSkeptical);
                    break;
                case 5:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceSleepy);
                    break;
                case 6:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceUnwell);
                    break;
                case 7:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceHat);
                    break;
                case 8:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceGlasses);
                    break;
                case 9:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceConcerned);
                    break;
                case 10:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceNegative);
                    break;
                case 11:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.faceCostume);
                    break;
                case 12:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.catFace);
                    break;
                case 13:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.monkeyFace);
                    break;
                case 14:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.heart);
                    break;
                case 15:
                    glyph += InsertGlyphFromArray(Emoji.List.SmileysAndEmotion.emotion);
                    break;
                case 16:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersOpen);
                    break;
                case 17:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersPartial);
                    break;
                case 18:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handSingleFinger);
                    break;
                case 19:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handFingersClosed);
                    break;
                case 20:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.hands);
                    break;
                case 21:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.handProp);
                    break;
                case 22:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.bodyParts);
                    break;
                case 23:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.person);
                    break;
                case 24:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personGesture);
                    break;
                case 25:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personRole);
                    break;
                case 26:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personFantasy);
                    break;
                case 27:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personActivity);
                    break;
                case 28:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personSport);
                    break;
                case 29:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personResting);
                    break;
                case 30:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.family);
                    break;
                case 31:
                    glyph += InsertGlyphFromArray(Emoji.List.PeopleAndBody.personSymbol);
                    break;
                case 32:
                    glyph += InsertGlyphFromArray(Emoji.List.Component.skinTone);
                    break;
                case 33:
                    glyph += InsertGlyphFromArray(Emoji.List.Component.hairStyle);
                    break;
                case 34:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalMammal);
                    break;
                case 35:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalBird);
                    break;
                case 36:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalAmphibian);
                    break;
                case 37:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalReptile);
                    break;
                case 38:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalMarine);
                    break;
                case 39:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.animalBug);
                    break;
                case 40:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.plantFlower);
                    break;
                case 41:
                    glyph += InsertGlyphFromArray(Emoji.List.AnimalsAndNature.plantOther);
                    break;
                case 42:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodFruit);
                    break;
                case 43:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodVegetable);
                    break;
                case 44:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodPrepared);
                    break;
                case 45:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodAsian);
                    break;
                case 46:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodMarine);
                    break;
                case 47:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.foodSweet);
                    break;
                case 48:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.drink);
                    break;
                case 49:
                    glyph += InsertGlyphFromArray(Emoji.List.FoodAndDrink.dishware);
                    break;
                case 50:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeMap);
                    break;
                case 51:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeGeographic);
                    break;
                case 52:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeBuilding);
                    break;
                case 53:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeReligious);
                    break;
                case 54:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.placeOther);
                    break;
                case 55:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportGround);
                    break;
                case 56:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportWater);
                    break;
                case 57:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.transportAir);
                    break;
                case 58:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.hotel);
                    break;
                case 59:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.time);
                    break;
                case 60:
                    glyph += InsertGlyphFromArray(Emoji.List.TravelAndPlaces.skyAndWeather);
                    break;
                case 61:
                    glyph += InsertGlyphFromArray(Emoji.List.Activities.@event);
                    break;
                case 62:
                    glyph += InsertGlyphFromArray(Emoji.List.Activities.awardMedal);
                    break;
                case 63:
                    glyph += InsertGlyphFromArray(Emoji.List.Activities.sport);
                    break;
                case 64:
                    glyph += InsertGlyphFromArray(Emoji.List.Activities.game);
                    break;
                case 65:
                    glyph += InsertGlyphFromArray(Emoji.List.Activities.artsAndCrafts);
                    break;
                case 66:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.clothing);
                    break;
                case 67:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.sound);
                    break;
                case 68:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.music);
                    break;
                case 69:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.musicalInstrument);
                    break;
                case 70:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.phone);
                    break;
                case 71:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.computer);
                    break;
                case 72:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.lightAndVideo);
                    break;
                case 73:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.bookPaper);
                    break;
                case 74:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.money);
                    break;
                case 75:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.mail);
                    break;
                case 76:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.writing);
                    break;
                case 77:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.office);
                    break;
                case 78:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.@lock);
                    break;
                case 79:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.tool);
                    break;
                case 80:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.science);
                    break;
                case 81:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.medical);
                    break;
                case 82:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.household);
                    break;
                case 83:
                    glyph += InsertGlyphFromArray(Emoji.List.Objects.otherObject);
                    break;
                case 84:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.transportSign);
                    break;
                case 85:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.warning);
                    break;
                case 86:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.arrow);
                    break;
                case 87:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.religion);
                    break;
                case 88:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.zodiac);
                    break;
                case 89:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.avSymbol);
                    break;
                case 90:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.gender);
                    break;
                case 91:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.math);
                    break;
                case 92:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.punctuation);
                    break;
                case 93:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.currency);
                    break;
                case 94:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.otherSymbol);
                    break;
                case 95:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.keycap);
                    break;
                case 96:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.alphanum);
                    break;
                case 97:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.geometric);
                    break;
                case 98:
                    glyph += InsertGlyphFromArray(Emoji.List.Symbols.alphanumeric);
                    break;
                case 99:
                    glyph += InsertGlyphFromArray(Emoji.List.Flags.flag);
                    break;
                case 100:
                    glyph += InsertGlyphFromArray(Emoji.List.Flags.countryFlag);
                    break;
                case 101:
                    glyph += InsertGlyphFromArray(Emoji.List.Flags.subdivisionFlag);
                    break;
            }
            
            return glyph;
        }
        
        private static string InsertEmojiModifier()
        {
            string glyph = "";
            int chosenGroup = RandomNumberGenerator.GetInt32(16);
            
            switch (chosenGroup)
            {
                case 0:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersOpen);
                    break;
                case 1:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersPartial);
                    break;
                case 2:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handSingleFinger);
                    break;
                case 3:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handFingersClosed);
                    break;
                case 4:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.hands);
                    break;
                case 5:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.handProp);
                    break;
                case 6:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.bodyParts);
                    break;
                case 7:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.person);
                    break;
                case 8:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personGesture);
                    break;
                case 9:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personRole);
                    break;
                case 10:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personFantasy);
                    break;
                case 11:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personActivity);
                    break;
                case 12:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personSport);
                    break;
                case 13:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.personResting);
                    break;
                case 14:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.PeopleAndBody.family);
                    break;
                case 15:
                    glyph += InsertGlyphFromArray(Emoji.Modifiers.Component.skinTone);
                    break;
            }
            
            return glyph;
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
