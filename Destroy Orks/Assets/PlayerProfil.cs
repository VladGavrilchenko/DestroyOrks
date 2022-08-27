using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveData
{
    [System.Serializable]
    public class PlayerProfil
    {
        public int addHitPointEnemy;
        public int levelCount;


        public PlayerProfil()
        {
            addHitPointEnemy = 1;
            levelCount = 0;
        }

    }

    [System.Serializable]
    public class BankSave
    {
        public int countMoney;

        public BankSave()
        {
            countMoney = 0;
        }

    }

    [System.Serializable]
    public class BusstSave
    {
        public int playerDamage;

        public BusstSave()
        {
            playerDamage = 1;
        }

    }

    [System.Serializable]
    public class ShopSave
    {
        public  int costBusst;

        public ShopSave()
        {
            costBusst = 2;
        }

    }

}