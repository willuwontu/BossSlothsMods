﻿using UnboundLib.Cards;
using UnityEngine;

namespace BossSlothsCards.Cards
{
    public class Yeetus : CustomCard
    {
        public AssetBundle Asset;
        
        protected override string GetTitle()
        {
            return "Yeetus";
        }

        protected override string GetDescription()
        {
            return "Gives more bullet knockback";
        }
        
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }
        
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
            cardInfo.allowMultiple = true;
            gun.knockback = 2;
            //statModifiers.AddObjectToPlayer = Startup.EffectAsset.LoadAsset<GameObject>("A_Explode_Y");
        }

        protected override CardInfoStat[] GetStats()
        {
            return new[]
            {
                new CardInfoStat
                {
                    stat = "Knockback",
                    amount = "+200%",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override GameObject GetCardArt()
        {
            return BossSlothCards.ArtAsset.LoadAsset<GameObject>("C_Yeetus");
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }
        
        public override string GetModName()
        {
            return "BSC";
        }
        
        public override void OnRemoveCard()
        {
        }
    }
}