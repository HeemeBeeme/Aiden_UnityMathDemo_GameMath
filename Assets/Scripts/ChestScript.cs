using System;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    static System.Random ChestType = new System.Random();

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
            
        }
    }
}
