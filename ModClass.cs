using Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UObject = UnityEngine.Object;

namespace DisableAchievements
{
    public class DisableAchievements : Mod
    {
        internal static DisableAchievements Instance;

        //public override List<ValueTuple<string, string>> GetPreloadNames()
        //{
        //    return new List<ValueTuple<string, string>>
        //    {
        //        new ValueTuple<string, string>("White_Palace_18", "White Palace Fly")
        //    };
        //}

        public DisableAchievements() : base("DisableAchievements")
        {
            Instance = this;
        }

        public override string GetVersion()
        {
            return "v1.0.0.0";
        }

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Initializing");

            Instance = this;
            On.AchievementHandler.AwardAchievementToPlayer += hook_AwardAchievementToPlayer;

            Log("Initialized");
        }

        public void hook_AwardAchievementToPlayer(On.AchievementHandler.orig_AwardAchievementToPlayer orig, global::AchievementHandler self, string key)
        {
            return;
        }

    }
}