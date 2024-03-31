using System.Text.Json;

namespace UltimatePassGen
{
    class Config
    {
        public static Options options = null!;

        public static void Load()
        {
            try
            {
                var jsonText = File.ReadAllText("config.json");
                options = (Options?)JsonSerializer.Deserialize(jsonText, typeof(Options))!;
            }
            catch
            {
                Options preferences = new()
                {
                    AutoGeneratePassword = false,
                    PasswordLength = 16
                };

                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                var jsonText = JsonSerializer.Serialize(preferences, jsonOptions);

                File.WriteAllText("config.json", jsonText);
            }

            var jsonString = File.ReadAllText("config.json");
            options = (Options?)JsonSerializer.Deserialize(jsonString, typeof(Options))!;
        }
    }

    class Options
    {
        public bool AutoGeneratePassword { get; set; }
        public int PasswordLength { get; set; }
    }
}
