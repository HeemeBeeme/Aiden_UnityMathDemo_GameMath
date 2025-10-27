using System;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    static System.Random ChestTypeRnD = new System.Random();
    static System.Random ChestLootRnD = new System.Random();

    static int ChestTypeInt;
    static string ChestTypeString;

    static int ChestLootRarityInt;
    static string ChestLootRarityString;


    #region Chest Types
    [Header("Chest Type")]
    [SerializeField]
    int WoodChest = 500;

    [SerializeField]
    int BronzeChest = 300;

    [SerializeField]
    int SilverChest = 150;

    [SerializeField]
    int GoldChest = 50;

    [SerializeField]
    int PlatinumChest = 1;
    #endregion

    #region Wood Chest
    [Header("Wood Chest")]
    [SerializeField]
    int WoodCommon = 500;

    [SerializeField]
    int WoodUncommon = 300;

    [SerializeField]
    int WoodRare = 150;

    [SerializeField]
    int WoodEpic = 50;

    [SerializeField]
    int WoodLegendary = 1;
    //1001
    #endregion

    #region Bronze Chest
    [Header("Bronze Chest")]
    [SerializeField]
    int BronzeCommon = 300;

    [SerializeField]
    int BronzeUncommon = 400;

    [SerializeField]
    int BronzeRare = 200;

    [SerializeField]
    int BronzeEpic = 100;

    [SerializeField]
    int BronzeLegendary = 1;
    //1001
    #endregion

    #region Silver Chest
    [Header("Silver Chest")]
    [SerializeField]
    int SilverCommon = 200;

    [SerializeField]
    int SilverUncommon = 350;

    [SerializeField]
    int SilverRare = 300;

    [SerializeField]
    int SilverEpic = 150;

    [SerializeField]
    int SilverLegendary = 1;
    //1001
    #endregion

    #region Gold Chest
    [Header("Gold Chest")]
    [SerializeField]
    int GoldCommon = 100;

    [SerializeField]
    int GoldUncommon = 247;

    [SerializeField]
    int GoldRare = 400;

    [SerializeField]
    int GoldEpic = 250;

    [SerializeField]
    int GoldLegendary = 4;
    //1001
    #endregion

    #region Platinum Chest
    [Header("Platinum Chest")]
    [SerializeField]
    int PlatinumCommon = 50;

    [SerializeField]
    int PlatinumUncommon = 191;

    [SerializeField]
    int PlatinumRare = 450;

    [SerializeField]
    int PlatinumEpic = 300;

    [SerializeField]
    int PlatinumLegendary = 10;
    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            #region Get Chest Type

            ChestTypeInt = ChestTypeRnD.Next(1, 1002);
            ChestLootRarityInt = ChestLootRnD.Next(1, 1002);


            if (ChestTypeInt < 501)
            {
                ChestTypeString = "Wood";

                if (ChestLootRarityInt < 501)
                {
                    ChestLootRarityString = "Common";
                }
                else if (ChestLootRarityInt > 499 && ChestLootRarityInt < 801)
                {
                    ChestLootRarityString = "Uncommon";
                }
                else if (ChestLootRarityInt > 799 && ChestLootRarityInt < 951)
                {
                    ChestLootRarityString = "Rare";
                }
                else if (ChestLootRarityInt > 949 && ChestLootRarityInt < 1001)
                {
                    ChestLootRarityString = "Epic";
                }
                else if (ChestLootRarityInt == 1001)
                {
                    ChestLootRarityString = "Legendary";
                }
            }
            else if (ChestTypeInt > 499 && ChestTypeInt < 801)
            {
                ChestTypeString = "Bronze";

                if (ChestLootRarityInt < 301)
                {
                    ChestLootRarityString = "Common";
                }
                else if (ChestLootRarityInt > 299 && ChestLootRarityInt < 701)
                {
                    ChestLootRarityString = "Uncommon";
                }
                else if (ChestLootRarityInt > 699 && ChestLootRarityInt < 901)
                {
                    ChestLootRarityString = "Rare";
                }
                else if (ChestLootRarityInt > 899 && ChestLootRarityInt < 1001)
                {
                    ChestLootRarityString = "Epic";
                }
                else if (ChestLootRarityInt == 1001)
                {
                    ChestLootRarityString = "Legendary";
                }
            }
            else if (ChestTypeInt > 799 && ChestTypeInt < 951)
            {
                ChestTypeString = "Silver";

                if (ChestLootRarityInt < 201)
                {
                    ChestLootRarityString = "Common";
                }
                else if (ChestLootRarityInt > 199 && ChestLootRarityInt < 551)
                {
                    ChestLootRarityString = "Uncommon";
                }
                else if (ChestLootRarityInt > 549 && ChestLootRarityInt < 851)
                {
                    ChestLootRarityString = "Rare";
                }
                else if (ChestLootRarityInt > 849 && ChestLootRarityInt < 1001)
                {
                    ChestLootRarityString = "Epic";
                }
                else if (ChestLootRarityInt == 1001)
                {
                    ChestLootRarityString = "Legendary";
                }
            }
            else if (ChestTypeInt > 949 && ChestTypeInt < 1001)
            {
                ChestTypeString = "Gold";

                if (ChestLootRarityInt < 101)
                {
                    ChestLootRarityString = "Common";
                }
                else if (ChestLootRarityInt > 99 && ChestLootRarityInt < 348)
                {
                    ChestLootRarityString = "Uncommon";
                }
                else if (ChestLootRarityInt > 346 && ChestLootRarityInt < 748)
                {
                    ChestLootRarityString = "Rare";
                }
                else if (ChestLootRarityInt > 746 && ChestLootRarityInt < 998)
                {
                    ChestLootRarityString = "Epic";
                }
                else if (ChestLootRarityInt > 997)
                {
                    ChestLootRarityString = "Legendary";
                }
            }
            else if (ChestTypeInt == 1001)
            {
                ChestTypeString = "Platinum";

                if (ChestLootRarityInt < 51)
                {
                    ChestLootRarityString = "Common";
                }
                else if (ChestLootRarityInt > 49 && ChestLootRarityInt < 242)
                {
                    ChestLootRarityString = "Uncommon";
                }
                else if (ChestLootRarityInt > 240 && ChestLootRarityInt < 692)
                {
                    ChestLootRarityString = "Rare";
                }
                else if (ChestLootRarityInt > 690 && ChestLootRarityInt < 991)
                {
                    ChestLootRarityString = "Epic";
                }
                else if (ChestLootRarityInt > 990)
                {
                    ChestLootRarityString = "Legendary";
                }
            }

            Debug.Log($"Chest Type Int: {ChestTypeInt}     Chest Loot Rarity Int: {ChestLootRarityInt}");
            Debug.Log($"Chest Type = {ChestTypeString}     Chest Loot Rarity = {ChestLootRarityString}");

            #endregion
        }
    }
}
