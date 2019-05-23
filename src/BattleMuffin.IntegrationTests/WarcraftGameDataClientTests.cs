using System;
using BattleMuffin.Clients;
using BattleMuffin.IntegrationTests.Attributes;
using Xunit;

namespace BattleMuffin.IntegrationTests
{
    public class WarcraftGameDataClientTests
    {
        private WarcraftGameDataClient? _client;

        private WarcraftGameDataClient Client
        {
            get
            {
                if (_client != null)
                {
                    return _client;
                }

                var clientId = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_ID");
                var clientSecret = Environment.GetEnvironmentVariable("BLIZZARD_CLIENT_SECRET");
                _client = new WarcraftGameDataClient(clientId, clientSecret);
                return _client;
            }
        }

        [Theory]
        [JsonData("GameData/achievement_category.json")]
        public async void GetAchievementCategoryAsyncTest(int achievementCategoryId)
        {
            var result = await Client.GetAchievementCategoryAsync(achievementCategoryId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/achievement.json")]
        public async void GetAchievementAsyncTest(int achievementId)
        {
            var result = await Client.GetAchievementAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/achievement_media.json")]
        public async void GetAchievementMediaAsyncTest(int achievementId)
        {
            var result = await Client.GetAchievementMediaAsync(achievementId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/connected_realm.json")]
        public async void GetConnectedRealmAsyncTest(int connectedRealmId)
        {
            var result = await Client.GetConnectedRealmAsync(connectedRealmId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_family.json")]
        public async void GetCreatureFamilyAsyncTest(int creatureFamilyId)
        {
            var result = await Client.GetCreatureFamilyAsync(creatureFamilyId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_type.json")]
        public async void GetCreatureTypeAsyncTest(int creatureTypeId)
        {
            var result = await Client.GetCreatureTypeAsync(creatureTypeId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature.json")]
        public async void GetCreatureAsyncTest(int creatureId)
        {
            var result = await Client.GetCreatureAsync(creatureId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_display_media.json")]
        public async void GetCreatureDisplayMediaAsyncTest(int creatureDisplayId)
        {
            var result = await Client.GetCreatureDisplayMediaAsync(creatureDisplayId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/creature_family_media.json")]
        public async void GetCreatureFamilyMediaAsyncTest(int creatureFamilyId)
        {
            var result = await Client.GetCreatureFamilyMediaAsync(creatureFamilyId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/guild.json")]
        public async void GetGuildAsyncTest(string realmSlug, string guildNameSlug)
        {
            var result = await Client.GetGuildAsync(realmSlug, guildNameSlug);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/guild_achievements.json")]
        public async void GetGuildAchievementsAsyncTest(string realmSlug, string guildNameSlug)
        {
            var result = await Client.GetGuildAchievementsAsync(realmSlug, guildNameSlug);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/guild_roster.json")]
        public async void GetGuildRosterAsyncTest(string realmSlug, string guildNameSlug)
        {
            var result = await Client.GetGuildRosterAsync(realmSlug, guildNameSlug);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/guild_crest_border_media.json")]
        public async void GetGuildCrestBorderMediaAsyncTest(int borderId)
        {
            var result = await Client.GetGuildCrestBorderMediaAsync(borderId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/guild_crest_emblem_media.json")]
        public async void GetGuildCrestEmblemMediaAsyncTest(int emblemId)
        {
            var result = await Client.GetGuildCrestEmblemMediaAsync(emblemId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_affix.json")]
        public async void GetMythicKeystoneAffixAsyncTest(int keystoneAffixId)
        {
            var result = await Client.GetMythicKeystoneAffixAsync(keystoneAffixId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_raid_leaderboard.json")]
        public async void GetMythicRaidLeaderboardAsyncTest(string raid, string faction)
        {
            var result = await Client.GetMythicRaidLeaderboardAsync(raid, faction);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mount.json")]
        public async void GetMountAsyncTest(int mountId)
        {
            var result = await Client.GetMountAsync(mountId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_dungeon.json")]
        public async void GetMythicKeystoneDungeonAsyncTest(int dungeonId)
        {
            var result = await Client.GetMythicKeystoneDungeonAsync(dungeonId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_period.json")]
        public async void GetMythicKeystonePeriodAsyncTest(int periodId)
        {
            var result = await Client.GetMythicKeystonePeriodAsync(periodId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_season.json")]
        public async void GetMythicKeystoneSeasonAsyncTest(int seasonId)
        {
            var result = await Client.GetMythicKeystoneSeasonAsync(seasonId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_leaderboard_index.json")]
        public async void GetMythicKeystoneLeaderboardIndexAsyncTest(int connectedRealmId)
        {
            var result = await Client.GetMythicKeystoneLeaderboardIndexAsync(connectedRealmId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/mythic_keystone_leaderboard.json")]
        public async void GetMythicKeystoneLeaderboardAsyncTest(int connectedRealmId, int dungeonId, int periodId)
        {
            var result = await Client.GetMythicKeystoneLeaderboardAsync(connectedRealmId, dungeonId, periodId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/battle_pet.json")]
        public async void GetBattlePetAsyncTest(int petId)
        {
            var result = await Client.GetBattlePetAsync(petId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/playable_class.json")]
        public async void GetPlayableClassAsyncTest(int classId)
        {
            var result = await Client.GetPlayableClassAsync(classId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/playable_class.json")]
        public async void GetPlayableClassPvPTalentSlotsAsyncTest(int classId)
        {
            var result = await Client.GetPlayableClassPvPTalentSlotsAsync(classId);
            Assert.NotNull(result.Value);
        }

        [Theory]
        [JsonData("GameData/playable_specialization.json")]
        public async void GetPlayableSpecializationAsyncTest(int specId)
        {
            var result = await Client.GetPlayableSpecializationAsync(specId);
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementCategoryIndexAsyncTest()
        {
            var result = await Client.GetAchievementCategoryIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetAchievementIndexAsyncTest()
        {
            var result = await Client.GetAchievementIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetConnectedRealmIndexAsyncTest()
        {
            var result = await Client.GetConnectedRealmIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCreatureFamilyIndexAsyncTest()
        {
            var result = await Client.GetCreatureFamilyIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCreatureTypeIndexAsyncTest()
        {
            var result = await Client.GetCreatureTypeIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetGuildCrestComponentsIndexAsyncTest()
        {
            var result = await Client.GetGuildCrestComponentsIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMythicKeystoneAffixIndexAsyncTest()
        {
            var result = await Client.GetMythicKeystoneAffixIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMountIndexAsyncTest()
        {
            var result = await Client.GetMountIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMythicKeystoneDungeonIndexAsyncTest()
        {
            var result = await Client.GetMythicKeystoneDungeonIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMythicKeystoneIndexAsyncTest()
        {
            var result = await Client.GetMythicKeystoneIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMythicKeystonePeriodIndexAsyncTest()
        {
            var result = await Client.GetMythicKeystonePeriodIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetMythicKeystoneSeasonIndexAsyncTest()
        {
            var result = await Client.GetMythicKeystoneSeasonIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetBattlePetIndexAsyncTest()
        {
            var result = await Client.GetBattlePetIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableClassIndexAsyncTest()
        {
            var result = await Client.GetPlayableClassIndexAsync();
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetPlayableSpecializationIndexAsyncTest()
        {
            var result = await Client.GetPlayableSpecializationIndexAsync();
            Assert.NotNull(result.Value);
        }
    }
}
