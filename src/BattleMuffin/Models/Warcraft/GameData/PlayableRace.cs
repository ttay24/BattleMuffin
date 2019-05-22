using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableRace
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}