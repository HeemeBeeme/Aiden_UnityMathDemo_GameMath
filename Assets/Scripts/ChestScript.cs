using System;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    static System.Random ChestTypeRnD = new System.Random();
    static System.Random ChestLootRnD = new System.Random();
    string currentChest;
    string currentRarity;
    public int ChestTypeInt;
    public int ChestLootInt;

    #region Chest Types
    [Header("Chest Type")]
    string WoodChest = "Wood Chest";
    public int WoodChestChance = 500;
    string BronzeChest = "Bronze Chest";
    public int BronzeChestChance = 300;
    string SilverChest = "Silver Chest";
    public int SilverChestChance = 150;
    string GoldChest = "Gold Chest";
    public int GoldChestChance = 50;
    string PlatinumChest = "Platinum Chest";
    public int PlatinumChestChance = 1;
    #endregion

    #region Chest Drops

    #region Wood Chest
    [Header("Wood Chest")]
    public int WoodCommon = 500;
    public int WoodUncommon = 300;
    public int WoodRare = 150;
    public int WoodEpic = 50;
    public int WoodLegendary = 1;
    #endregion

    #region Bronze Chest
    [Header("Bronze Chest")]
    public int BronzeCommon = 300;
    public int BronzeUncommon = 400;
    public int BronzeRare = 200;
    public int BronzeEpic = 100;
    public int BronzeLegendary = 1;
    #endregion

    #region Silver Chest
    [Header("Silver Chest")]
    public int SilverCommon = 200;
    public int SilverUncommon = 350;
    public int SilverRare = 300;
    public int SilverEpic = 150;
    public int SilverLegendary = 1;
    #endregion

    #region Gold Chest
    [Header("Gold Chest")]
    public int GoldCommon = 100;
    public int GoldUncommon = 247;
    public int GoldRare = 400;
    public int GoldEpic = 250;
    public int GoldLegendary = 4;
    #endregion

    #region Platinum Chest
    [Header("Platinum Chest")]
    public int PlatinumCommon = 50;
    public int PlatinumUncommon = 191;
    public int PlatinumRare = 450;
    public int PlatinumEpic = 300;
    public int PlatinumLegendary = 10;
    #endregion
    #endregion
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           ChestTypeInt = ChestTypeRnD.Next(1, 1002);
            ChestLootInt = ChestLootRnD.Next(1, 1002);

            if(ChestTypeInt <= WoodChestChance)
            {
                currentChest = WoodChest;

                if(ChestLootInt <= WoodCommon)
                {
                    currentRarity = "Wood Common";
                }

                else if (ChestLootInt > WoodCommon && ChestLootInt <= WoodCommon + WoodUncommon)
                {
                    currentRarity = "Wood Uncommon";
                }

                else if (ChestLootInt > WoodCommon + WoodUncommon && ChestLootInt <= WoodCommon + WoodUncommon + WoodRare)
                {
                    currentRarity = "Wood Rare";
                }

                else if (ChestLootInt > WoodCommon + WoodUncommon + WoodRare && ChestLootInt <= WoodCommon + WoodUncommon + WoodRare + WoodEpic)
                {
                    currentRarity = "Wood Epic";
                }

                else if (ChestLootInt > WoodCommon + WoodUncommon + WoodRare + WoodEpic && ChestLootInt <= WoodCommon + WoodUncommon + WoodRare + WoodEpic + WoodLegendary)
                {
                    currentRarity = "Wood Legendary";
                }
            }

            else if(ChestTypeInt > WoodChestChance && ChestTypeInt <= WoodChestChance + BronzeChestChance)
            {
                currentChest = BronzeChest;

                if (ChestLootInt <= BronzeCommon)
                {
                    currentRarity = "Bronze Common";
                }

                else if (ChestLootInt > BronzeCommon && ChestLootInt <= BronzeCommon + BronzeUncommon)
                {
                    currentRarity = "Bronze Uncommon";
                }

                else if (ChestLootInt > BronzeCommon + BronzeUncommon && ChestLootInt <= BronzeCommon + BronzeUncommon + BronzeRare)
                {
                    currentRarity = "Bronze Rare";
                }

                else if (ChestLootInt > BronzeCommon + BronzeUncommon + BronzeRare && ChestLootInt <= BronzeCommon + BronzeUncommon + BronzeRare + BronzeEpic)
                {
                    currentRarity = "Bronze Epic";
                }

                else if (ChestLootInt > BronzeCommon + BronzeUncommon + BronzeRare + BronzeEpic && ChestLootInt <= BronzeCommon + BronzeUncommon + BronzeRare + BronzeEpic + BronzeLegendary)
                {
                    currentRarity = "Bronze Legendary";
                }
            }

            else if (ChestTypeInt > WoodChestChance + BronzeChestChance && ChestTypeInt <= WoodChestChance + BronzeChestChance + SilverChestChance)
            {
                currentChest = SilverChest;

                if (ChestLootInt <= SilverCommon)
                {
                    currentRarity = "Silver Common";
                }

                else if (ChestLootInt > SilverCommon && ChestLootInt <= SilverCommon + SilverUncommon)
                {
                    currentRarity = "Silver Uncommon";
                }

                else if (ChestLootInt > SilverCommon + SilverUncommon && ChestLootInt <= SilverCommon + SilverUncommon + SilverRare)
                {
                    currentRarity = "Silver Rare";
                }

                else if (ChestLootInt > SilverCommon + SilverUncommon + SilverRare && ChestLootInt <= SilverCommon + SilverUncommon + SilverRare + SilverEpic)
                {
                    currentRarity = "Silver Epic";
                }

                else if (ChestLootInt > SilverCommon + SilverUncommon + SilverRare + SilverEpic && ChestLootInt <= SilverCommon + SilverUncommon + SilverRare + SilverEpic + SilverLegendary)
                {
                    currentRarity = "Silver Legendary";
                }
            }

            else if (ChestTypeInt > WoodChestChance + BronzeChestChance + SilverChestChance && ChestTypeInt <= WoodChestChance + BronzeChestChance + SilverChestChance + GoldChestChance)
            {
                currentChest = GoldChest;

                if (ChestLootInt <= GoldCommon)
                {
                    currentRarity = "Gold Common";
                }

                else if (ChestLootInt > GoldCommon && ChestLootInt <= GoldCommon + GoldUncommon)
                {
                    currentRarity = "Gold Uncommon";
                }

                else if (ChestLootInt > GoldCommon + GoldUncommon && ChestLootInt <= GoldCommon + GoldUncommon + GoldRare)
                {
                    currentRarity = "Gold Rare";
                }

                else if (ChestLootInt > GoldCommon + GoldUncommon + GoldRare && ChestLootInt <= GoldCommon + GoldUncommon + GoldRare + GoldEpic)
                {
                    currentRarity = "Gold Epic";
                }

                else if (ChestLootInt > GoldCommon + GoldUncommon + GoldRare + GoldEpic && ChestLootInt <= GoldCommon + GoldUncommon + GoldRare + GoldEpic + GoldLegendary)
                {
                    currentRarity = "Gold Legendary";
                }
            }

            else if (ChestTypeInt > WoodChestChance + BronzeChestChance + SilverChestChance + GoldChestChance && ChestTypeInt <= WoodChestChance + BronzeChestChance + SilverChestChance + GoldChestChance + PlatinumChestChance)
            {
                currentChest = PlatinumChest;

                if (ChestLootInt <= PlatinumCommon)
                {
                    currentRarity = "Platinum Common";
                }

                else if (ChestLootInt > PlatinumCommon && ChestLootInt <= PlatinumCommon + PlatinumUncommon)
                {
                    currentRarity = "Platinum Uncommon";
                }

                else if (ChestLootInt > PlatinumCommon + PlatinumUncommon && ChestLootInt <= PlatinumCommon + PlatinumUncommon + PlatinumRare)
                {
                    currentRarity = "Platinum Rare";
                }

                else if (ChestLootInt > PlatinumCommon + PlatinumUncommon + PlatinumRare && ChestLootInt <= PlatinumCommon + PlatinumUncommon + PlatinumRare + PlatinumEpic)
                {
                    currentRarity = "Platinum Epic";
                }

                else if (ChestLootInt > PlatinumCommon + PlatinumUncommon + PlatinumRare + PlatinumEpic && ChestLootInt <= PlatinumCommon + PlatinumUncommon + PlatinumRare + PlatinumEpic + PlatinumLegendary)
                {
                    currentRarity = "Platinum Legendary";
                }
            }

            Debug.Log($"Current Chest = {currentChest}      Current Rarity = {currentRarity}");
        }
    }
}
